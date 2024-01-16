using Janitor_V1.Models;
using netDxf;
using netDxf.Entities;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Janitor_V1.Utils
{
    public class ExportDXFandPDF
    {

        public enum SheetMetalOptions_e
        {
            ExportFlatPatternGeometry = 1,
            IncludeHiddenEdges = 2,
            ExportBendLines = 4,
            IncludeSketches = 8,
            MergeCoplanarFaces = 16,
            ExportLibraryFeatures = 32,
            ExportFormingTools = 64,
            ExportBoundingBox = 2048
        }

        const bool SKIP_EXISTING_FILES = false;

        const string OUT_NAME_TEMPLATE_LANKSTOMOS = "DXF ir PDF\\Lankstomos\\<$PRP:Skardos storis_mm>\\<_FileName_>_<_ConfName_>_sk<$PRP:Skardos storis_mm>mm_<_QUANTITY_>vnt";
        const string OUT_NAME_TEMPLATE_NELANKSTOMOS = "DXF ir PDF\\NElankstomos\\<$PRP:Skardos storis_mm>\\<_FileName_>_<_ConfName_>_sk<$PRP:Skardos storis_mm>mm_<_QUANTITY_>vnt";

        const int FLAT_PATTERN_OPTIONS = (int)SheetMetalOptions_e.ExportBendLines + (int)SheetMetalOptions_e.ExportFlatPatternGeometry;

        private string partName = "";
        private string partConfiguration = "";

        private ISldWorks swApp;
        private string EksportuojamoBrezinioFailoPavadinimas;
        private int duplicateQuantity = 0;

        public bool ProcessComponent(ISldWorks swApp, ModelDoc2 swModel, string configuration, int numberOfComponents, Part part)
        {
            this.swApp = swApp;
            this.duplicateQuantity = numberOfComponents;
            this.partName = part.ComponentName;
            this.partConfiguration = part.ReferencedConfiguration;
            try
            {
                if (swModel == null)
                {
                    throw new Exception("Please open assembly or part document");
                }

                if (swModel.GetType() == (int)swDocumentTypes_e.swDocASSEMBLY)
                {
                    // Process assembly
                }
                else if (swModel.GetType() == (int)swDocumentTypes_e.swDocPART)
                {
                    ProcessSheetMetalModel(swModel, swModel, configuration);
                }
                else
                {
                    throw new Exception("Only assembly and part documents are supported");
                }

                //swApp.SendMsgToUser2("Operation completed", (int)swMessageBoxIcon_e.swMbInformation, (int)swMessageBoxBtn_e.swMbOk);
                return true;
            }
            catch (Exception ex)
            {
                swApp.SendMsgToUser2(ex.Message, (int)swMessageBoxIcon_e.swMbStop, (int)swMessageBoxBtn_e.swMbOk);
                return false;
            }
        }

        public static object GetDistinctSheetMetalComponents(AssemblyDoc assy)
        {
            object[] vComps = (object[])assy.GetComponents(false);

            List<Component2> swSheetMetalComps = new List<Component2>();

            foreach (object compObj in vComps)
            {
                Component2 swComp = (Component2)compObj;

                if (!swComp.IsSuppressed())
                {
                    if (!ContainsComponent(swSheetMetalComps.ToArray(), swComp))
                    {
                        if (IsSheetMetalComponent(swComp))
                        {
                            swSheetMetalComps.Add(swComp);
                        }
                    }
                }
            }

            if (swSheetMetalComps.Count == 0)
            {
                return System.Type.Missing;
            }

            return swSheetMetalComps.ToArray();
        }

        public static bool IsSheetMetalComponent(Component2 comp)
        {
            object bodiesInfo;
            object[] vBodies = (object[])comp.GetBodies3((int)swBodyType_e.swSolidBody, out bodiesInfo);

            if (vBodies != null && vBodies.Length > 0)
            {
                foreach (object bodyObj in vBodies)
                {
                    Body2 swBody = (Body2)bodyObj;

                    if (swBody.IsSheetMetal() != false)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool ContainsComponent(Component2[] comps, Component2 swComp)
        {
            foreach (Component2 swThisComp in comps)
            {
                if (swThisComp.GetPathName() == swComp.GetPathName() &&
                    swThisComp.ReferencedConfiguration == swComp.ReferencedConfiguration)
                {
                    return true;
                }
            }

            return false;
        }

        public string ComposeOutFileName(string template, ModelDoc2 rootModel, ModelDoc2 sheetMetalModel, string conf, Feature flatPatternFeat, Feature cutListFeat)
        {
            System.Text.RegularExpressions.Regex regEx = new System.Text.RegularExpressions.Regex("<[^>]*>");
            System.Text.RegularExpressions.MatchCollection regExMatches = regEx.Matches(template);

            string outFileName = template;

            for (int i = regExMatches.Count - 1; i >= 0; i--)
            {
                System.Text.RegularExpressions.Match regExMatch = regExMatches[i];
                string tokenName = regExMatch.Value.Substring(1, regExMatch.Value.Length - 2);

                var temp = ResolveToken(tokenName, rootModel, sheetMetalModel, conf, flatPatternFeat, cutListFeat, duplicateQuantity);
                outFileName = outFileName.Substring(0, regExMatch.Index) + temp + outFileName.Substring(regExMatch.Index + regExMatch.Length);
            }

            return ReplaceInvalidPathSymbols(GetFullPath(rootModel, outFileName));
        }

        public static string ReplaceInvalidPathSymbols(string path)
        {
            const char REPLACE_SYMB = '_';
            string res = path.Substring("X:\\".Length);
            string drive = path.Substring(0, "X:\\".Length);

            char[] invalidSymbols = { '/', ':', '*', '?', '"', '<', '>', '|' };

            foreach (char invalidSymb in invalidSymbols)
            {
                res = res.Replace(invalidSymb, REPLACE_SYMB);
            }

            return drive + res;
        }

        public static string ResolveToken(string token, ModelDoc2 rootModel, ModelDoc2 sheetMetalModel, string conf, Feature flatPatternFeat, Feature cutListFeat, int quantity)
        {
            const string FILE_NAME_TOKEN = "_filename_";
            const string ASSM_FILE_NAME_TOKEN = "_assmfilename_";
            const string FEAT_NAME_TOKEN = "_featurename_";
            const string CONF_NAME_TOKEN = "_confname_";
            const string QUANTITY_TOKEN = "_quantity_";
            const string PRP_TOKEN = "$PRP:";
            const string CUT_LIST_PRP_TOKEN = "$CLPRP:";
            const string ASM_PRP_TOKEN = "$ASSMPRP:";

            switch (token.ToLower())
            {
                case FILE_NAME_TOKEN:
                    return GetFileNameWithoutExtension(sheetMetalModel.GetPathName());
                case FEAT_NAME_TOKEN:
                    return flatPatternFeat.Name;
                case CONF_NAME_TOKEN:
                    return conf;
                case QUANTITY_TOKEN:
                    return quantity.ToString();
                case ASSM_FILE_NAME_TOKEN:
                    if (rootModel.GetPathName() == "")
                    {
                        throw new System.Exception("Assembly must be saved to use " + ASSM_FILE_NAME_TOKEN);
                    }
                    return GetFileNameWithoutExtension(rootModel.GetPathName());
                default:
                    string prpName;
                    if (token.StartsWith(PRP_TOKEN))
                    {
                        prpName = token.Substring(PRP_TOKEN.Length);
                        return GetModelPropertyValue(sheetMetalModel, conf, prpName);
                    }
                    else if (token.StartsWith(ASM_PRP_TOKEN))
                    {
                        prpName = token.Substring(ASM_PRP_TOKEN.Length);
                        return GetModelPropertyValue(rootModel, rootModel.ConfigurationManager.ActiveConfiguration.Name, prpName);
                    }
                    else if (token.StartsWith(CUT_LIST_PRP_TOKEN))
                    {
                        prpName = token.Substring(CUT_LIST_PRP_TOKEN.Length);
                        return GetPropertyValue(cutListFeat.CustomPropertyManager, prpName);
                    }
                    else
                    {
                        throw new System.Exception("Unrecognized token: " + token);
                    }
            }
        }


        public static string GetModelPropertyValue(ModelDoc2 model, string confName, string prpName)
        {
            string prpVal;
            CustomPropertyManager swCustPrpMgr = model.Extension.CustomPropertyManager[confName];
            prpVal = GetPropertyValue(swCustPrpMgr, prpName);

            if (string.IsNullOrEmpty(prpVal))
            {
                swCustPrpMgr = model.Extension.CustomPropertyManager[""];
                prpVal = GetPropertyValue(swCustPrpMgr, prpName);
            }

            return prpVal;
        }

        public static string GetPropertyValue(CustomPropertyManager custPrpMgr, string prpName)
        {
            string resVal;
            string valOut;
            custPrpMgr.Get2(prpName, out valOut, out resVal);
            return resVal;
        }

        public static string GetFileNameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        public object GetCutListFeatures(ModelDoc2 model)
        {
            return GetFeaturesByType(model, "CutListFolder");
        }

        public object GetFlatPatternFeatures(ModelDoc2 model)
        {
            return GetFeaturesByType(model, "FlatPattern");
        }

        public void ProcessSheetMetalModel(ModelDoc2 rootModel, ModelDoc2 sheetMetalModel, string conf)
        {
            object[] vCutListFeats = (object[])GetCutListFeatures(sheetMetalModel);

            if (vCutListFeats != null && vCutListFeats.Length > 0)
            {
                object[] vFlatPatternFeats = (object[])GetFlatPatternFeatures(sheetMetalModel);

                if (vFlatPatternFeats != null && vFlatPatternFeats.Length > 0)
                {
                    List<Feature> swProcessedCutListsFeats = new List<Feature>();

                    foreach (object featObj in vFlatPatternFeats)
                    {
                        Feature swFlatPatternFeat = (Feature)featObj;
                        FlatPatternFeatureData swFlatPattern = (FlatPatternFeatureData)swFlatPatternFeat.GetDefinition();

                        Entity swFixedEnt = (Entity)swFlatPattern.FixedFace2;
                        Body2 swBody;

                        if (swFixedEnt is Face2 swFixedFace)
                            swBody = (Body2)swFixedFace.GetBody();
                        else if (swFixedEnt is Edge swFixedEdge)
                            swBody = swFixedEdge.GetBody();
                        else if (swFixedEnt is Vertex swFixedVert)
                            swBody = new Body2();
                        //KAZKAS NEGERAI
                        //swBody = (Body2)swFixedVert.GetBody();
                        else
                            throw new Exception("Unexpected entity type");

                        Feature swCutListFeat = FindCutListFeature(vCutListFeats, swBody);

                        if (swCutListFeat != null)
                        {
                            bool isUnique = swProcessedCutListsFeats.Count == 0 || !ContainsSwObject(swProcessedCutListsFeats.ToArray(), swCutListFeat);

                            if (isUnique)
                            {
                                swProcessedCutListsFeats.Add(swCutListFeat);

                                string outFileName;
                                string LenkimuSkaicius = GetModelPropertyValue(sheetMetalModel, sheetMetalModel.ConfigurationManager.ActiveConfiguration.Name, "Lenkimu skaicius");

                                if (LenkimuSkaicius == "0")
                                    outFileName = ComposeOutFileName(OUT_NAME_TEMPLATE_NELANKSTOMOS, rootModel, sheetMetalModel, conf, swFlatPatternFeat, swCutListFeat);
                                else
                                    outFileName = ComposeOutFileName(OUT_NAME_TEMPLATE_LANKSTOMOS, rootModel, sheetMetalModel, conf, swFlatPatternFeat, swCutListFeat);

                                EksportuojamoBrezinioFailoPavadinimas = outFileName;

                                if (!SKIP_EXISTING_FILES || !FileExists(outFileName))
                                    ExportFlatPattern((PartDoc)sheetMetalModel, swFlatPatternFeat, outFileName, FLAT_PATTERN_OPTIONS, conf);
                            }
                        }
                        else
                        {
                            throw new Exception("Failed to find cut-list for flat pattern " + swFlatPatternFeat.Name);
                        }
                    }
                }
                else
                {
                    throw new Exception("No flat pattern features found");
                }
            }
            else
            {
                throw new Exception("No cut-list items found");
            }
        }

        public bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public Feature FindCutListFeature(object[] vCutListFeats, Body2 body)
        {
            foreach (object featObj in vCutListFeats)
            {
                Feature swCutListFeat = (Feature)featObj;
                BodyFolder swBodyFolder = swCutListFeat.GetSpecificFeature2() as BodyFolder;

                if (swBodyFolder != null)
                {
                    object[] vBodies = swBodyFolder.GetBodies() as object[];

                    if (ContainsSwObject(vBodies, body))
                    {
                        return swCutListFeat;
                    }
                }
            }

            return null;
        }

        public bool ContainsSwObject(object[] vArr, object obj)
        {
            if (vArr != null)
            {
                foreach (object swObj in vArr)
                {
                    if (swApp.IsSame(swObj, obj) == (int)swObjectEquality.swObjectSame)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public object GetFeaturesByType(ModelDoc2 model, string typeName)
        {
            Feature[] swFeats = null;
            Feature swFeat = (Feature)model.FirstFeature();

            while (swFeat != null)
            {
                if (typeName == "CutListFolder" && swFeat.GetTypeName2() == "SolidBodyFolder")
                {
                    BodyFolder swBodyFolder = swFeat.GetSpecificFeature2() as BodyFolder;
                    swBodyFolder?.UpdateCutList();
                }

                ProcessFeature(swFeat, ref swFeats, typeName);
                swFeat = (Feature)swFeat.GetNextFeature();
            }

            if (swFeats.Length == 0)
            {
                return System.Type.Missing;
            }
            else
            {
                return swFeats;
            }
        }

        public void ProcessFeature(Feature thisFeat, ref Feature[] featsArr, string typeName)
        {
            if (thisFeat.GetTypeName2() == typeName)
            {
                if (featsArr == null)
                {
                    featsArr = new Feature[1];
                    featsArr[0] = thisFeat;
                }
                else
                {
                    for (int i = 0; i <= featsArr.GetUpperBound(0); i++)
                    {
                        if (swApp.IsSame(featsArr[i], thisFeat) == (int)swObjectEquality.swObjectSame)
                        {
                            return;
                        }
                    }
                    Array.Resize(ref featsArr, featsArr.Length + 1);
                    featsArr[featsArr.GetUpperBound(0)] = thisFeat;
                }
            }

            Feature swSubFeat = (Feature)thisFeat.GetFirstSubFeature();

            while (swSubFeat != null)
            {
                ProcessFeature(swSubFeat, ref featsArr, typeName);
                swSubFeat = (Feature)swSubFeat.GetNextSubFeature();
            }
        }

        public void ExportFlatPattern(PartDoc part, Feature flatPattern, string outFilePath, int opts, string conf)
        {
            ModelDoc2 swModel = (ModelDoc2)part;

            bool hide = false;

            try
            {
                if (!swModel.Visible)
                {
                    hide = true;
                    swModel.Visible = true;
                }

                swApp.ActivateDoc3(swModel.GetPathName(), false, (int)swRebuildOnActivation_e.swDontRebuildActiveDoc, 0);

                swModel.FeatureManager.EnableFeatureTree = false;
                swModel.FeatureManager.EnableFeatureTreeWindow = false;
                swModel.IActiveView.EnableGraphicsUpdate = false;

                string curConf = swModel.ConfigurationManager.ActiveConfiguration.Name;

                if (curConf != conf)
                {
                    if (!swModel.ShowConfiguration2(conf))
                    {
                        throw new Exception("Failed to activate configuration");
                    }
                }

                string outDir = outFilePath.Substring(0, outFilePath.LastIndexOf("\\"));
                CreateDirectories(outDir);

                string modelPath = swModel.GetPathName();

                if (modelPath == "")
                {
                    throw new Exception("Part document must be saved");
                }

                if (flatPattern.Select2(false, -1))
                {
                    if (!part.ExportToDWG2(outFilePath + ".dxf", modelPath, (int)swExportToDWG_e.swExportToDWG_ExportSheetMetal, true, null, false, false, opts, null))
                    {
                        throw new Exception("Failed to export flat pattern");
                    }

                    //dxf failo papildymas

                    DxfDocument dxfDocument = DxfDocument.Load(outFilePath + ".dxf");
                    MText partText = new MText(partName, new Vector3(-10, 10, 45), 3);
                    //partText.Rotation = 90;
                    dxfDocument.Entities.Add(partText);
                    var lines = dxfDocument.Entities.All.ToList();

                    CheckForOverlapping(partText, lines);

                    //foreach (EntityObject entity in dxfDocument.Entities.All)
                    //{
                    //    int a = 0;
                    //}
                    dxfDocument.Save(outFilePath + ".dxf");

                }
                else
                {
                    throw new Exception("Failed to select flat-pattern");
                }

                swModel.ShowConfiguration2(curConf);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                swModel.FeatureManager.EnableFeatureTree = true;
                swModel.FeatureManager.EnableFeatureTreeWindow = true;
                swModel.IActiveView.EnableGraphicsUpdate = true;

                if (hide)
                {
                    swApp.CloseDoc(swModel.GetTitle());
                }
            }
        }

        private void CheckForOverlapping(MText text, List<EntityObject> entities)
        {
            foreach (EntityObject entity in entities)
            {
                
                if(entity is Line line)
                {
                    int a = 0;
                }
            }
        }


        public void CreateDirectories(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                CreateDirectories(di.Parent.FullName);
                di.Create();
            }
        }


        public string GetFullPath(ModelDoc2 model, string path)
        {
            string fullPath = path;

            if (IsPathRelative(path))
            {
                if (path[0] != '\\')
                    path = '\\' + path;

                string modelPath = model.GetPathName();
                string modelDir = modelPath.Substring(0, modelPath.LastIndexOf('\\'));

                fullPath = modelDir + path;
            }

            return fullPath;
        }

        public bool IsPathRelative(string path)
        {
            return path[1] != ':' && !IsPathUnc(path);
        }

        public bool IsPathUnc(string path)
        {
            return path.StartsWith("\\");
        }

        public bool GeneratePDF(ModelDoc2 sheetMetalModel, string conf)
        {
            string PathName = sheetMetalModel.GetPathName();
            string FileNameWithoutExtension = Path.GetFileNameWithoutExtension(PathName);
            string FolderOfTheFile = Path.GetDirectoryName(PathName);
            string PDFFileName = EksportuojamoBrezinioFailoPavadinimas + ".pdf";
            string DrawingFileName = Path.Combine(FolderOfTheFile, FileNameWithoutExtension + ".slddrw");

            if (!File.Exists(DrawingFileName))
            {
                MessageBox.Show("Drawing file missing!");
                return false;
            }
            else
            {
                ModelDoc2 doc = swApp.OpenDoc6(DrawingFileName, (int)swDocumentTypes_e.swDocDRAWING, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", 0, 0);
                IDrawingDoc swDraw = (IDrawingDoc)doc;

                var vSheetNames = (Array)swDraw.GetSheetNames();
                bool generated = false;
                for (int i = 0; i <= vSheetNames.GetUpperBound(0); i++)
                {
                    string name = vSheetNames.GetValue(i).ToString();
                    if(name != conf)
                    {
                        continue;
                    }
                    string[] strSheetName = new string[] { name };
                    Array varSheetName = strSheetName;

                    ExportPdfData swExportPDFData =
                        (ExportPdfData)swApp.GetExportFileData((int)swExportDataFileType_e.swExportPdfData);

                    swExportPDFData.SetSheets((int)swExportDataSheetsToExport_e.swExportData_ExportSpecifiedSheets, varSheetName);

                    doc.Extension.SaveAs(PDFFileName, (int)swSaveAsVersion_e.swSaveAsCurrentVersion, (int)swSaveAsOptions_e.swSaveAsOptions_Silent, swExportPDFData, 0, 0);
                    generated = true;
                }

                swApp.CloseDoc(DrawingFileName);

                if(!generated)
                {
                    MessageBox.Show("Error generating PDF!\nConfiguration not fount!");
                }
                return generated;
            }
        }
    }
}



