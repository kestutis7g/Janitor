using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace Janitor_V1.Utils
{
    public static class Solidworks_control_tools
    {

        public static void OpenItem(ISldWorks swApp, string fileLocation, int DocumentType, string Configuration)
        {
            //aitemo atidarymas Solidworkse
            int errors = 0;
            int warnings = 0;

            //ISldWorks swApp;
            //swApp = (ISldWorks)Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application"));
        
        
            ModelDoc2 swModelDoc = default(ModelDoc2);
            //swModelDoc = (ModelDoc2)swApp.OpenDoc6(fileName, (int)swDocumentTypes_e.swDocPART, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", ref errors, ref warnings);
            swModelDoc = (ModelDoc2)swApp.OpenDoc6(fileLocation, DocumentType, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, Configuration, ref errors, ref warnings);
            if (swModelDoc.ConfigurationManager.ActiveConfiguration.Name != Configuration) 
            { 
                swModelDoc.ShowConfiguration2(Configuration); 
            }
            // Activate the loaded document and prompt for rebuild if the model changed
            swModelDoc = (ModelDoc2)swApp.ActivateDoc3(swModelDoc.GetTitle(), false, (int)swRebuildOnActivation_e.swUserDecision, ref errors);
            Debug.Print("Error code after document activation: " + errors.ToString());
        }

        public static int CheckToolboxComponents(ModelDoc2 swModel)
        {
            //patikrinama ar kompoentas yra Toolbox
            ModelDocExtension modelDocExt;

            // Tikrinama ar komponentas nera Toolbox

            modelDocExt = swModel.Extension;
            return modelDocExt.ToolboxPartType;
        }

        public static double WeightOfComponent(ISldWorks swApp,string componentPath, string Configuration)
        {
            //reik taisyti
            //return 0;
            ModelDoc2 swModel;
            int fileError = 0;
            int fileWarning = 0;
            swModel = (ModelDoc2)swApp.OpenDoc6(componentPath, (int)swDocumentTypes_e.swDocPART, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, Configuration, ref fileError, ref fileWarning);
            swModel.ForceRebuild3(true);

            double[] massprops;
            int status=0;
            double[] MassProperties = (double[])swModel.Extension.GetMassProperties(1, ref status);
            massprops = MassProperties;

            //double ToolboxKomponentoMase = (double)massprops[5];

            //float konvertuotaMase = (float)ToolboxKomponentoMase;

            //System.Diagnostics.Debug.Print("Toolbox komponento mase, kg: ", ToolboxKomponentoMase.ToString());

            swApp.CloseDoc(swModel.GetTitle());
            return Math.Round(massprops[5], 2);
        }

        public static string TakePictureOfItem(ISldWorks swApp, string fileLocation, int DocumentType, ModelDoc2 swModel, string configuration, string destinationFolder, string pictureName)
        {
            //padaro nuotrauką su Solidworks
            int errors = 0;
            int warnings = 0;
            bool boolstatus;

            //ISldWorks swApp;
            //swApp = (ISldWorks)Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application"));

            ModelDoc2 swModelDoc = default;
            swModelDoc = (ModelDoc2)swApp.OpenDoc6(fileLocation, DocumentType, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, configuration, ref errors, ref warnings);

            swModelDoc = (ModelDoc2)swApp.ActivateDoc3(swModelDoc.GetTitle(), false, (int)swRebuildOnActivation_e.swRebuildActiveDoc, ref errors);

            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            swModel.ShowNamedView2("*Isometric", 7);
            swModel.ViewZoomtofit2();
            boolstatus = swModel.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swViewDisplayHideAllTypes, true);
            if (swModel.GetType() == (int)swDocumentTypes_e.swDocPART)
            {
                swModel.ViewDisplayHiddenremoved();
                swModel.Extension.InsertScene(@"\scenes\01 basic scenes\11 white kitchen.p2s");
                swModel.ForceRebuild3(false);
            }

            var location = destinationFolder + pictureName + ".PNG";

            if (File.Exists(location))
            {
                //swModel.ForceReleaseLocks();
              //  File.Delete(location);
            }

            boolstatus = swModel.Extension.SaveAs2(location, 0, (int)swSaveAsOptions_e.swSaveAsOptions_Copy, null, "", false, errors, warnings);


            //atidaryti, uzdaryti



            // File.Delete(location);


            // Save As
            //Antrą kartą bandant išsaugoti nuotrauką Windows neleidžia to padaryti,
            //nes Solidworks yra atidarę nuotraukos failą
            if (swModel.GetType() == (int)swDocumentTypes_e.swDocPART)
            {
                ModelView activeModelView = swModel.ActiveView as ModelView;
                if (activeModelView != null)
                {
                    activeModelView.DisplayMode = (int)swViewDisplayMode_e.swViewDisplayMode_ShadedWithEdges;
                }
                swModel.Extension.InsertScene(@"\scenes\01 basic scenes\00 3 point faded.p2s");
            }

            swApp.CloseDoc(swModelDoc.GetTitle());
            return location;
        }


        public static double DetalesZaliavosKaina(ISldWorks swApp, string fileLocation, ModelDoc2 swModel)
        {
            //žaliavos kainos skaičiavimas
            int errors = 0;
            int warnings = 0;
            var swPart = (PartDoc)swApp.OpenDoc6(fileLocation, (int)swDocumentTypes_e.swDocPART, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", ref errors, ref warnings);

            if (swPart != null)
            {
                double[] vBBox;
                PartDoc swPartas;
                swPartas = (PartDoc)swModel;

                vBBox = GetPreciseBoundingBox(swPartas);

                DrawBox(swModel, System.Convert.ToDouble(vBBox[0]), System.Convert.ToDouble(vBBox[1]), System.Convert.ToDouble(vBBox[2]), System.Convert.ToDouble(vBBox[3]), System.Convert.ToDouble(vBBox[4]), System.Convert.ToDouble(vBBox[5]));
                double Width;
                double Length;
                double Height;
                double Turis;
                double Zaliavos_Svoris; // kg
                Width = System.Convert.ToDouble(vBBox[3]) - System.Convert.ToDouble(vBBox[0]);
                Length = System.Convert.ToDouble(vBBox[5]) - System.Convert.ToDouble(vBBox[2]);
                Height = System.Convert.ToDouble(vBBox[4]) - System.Convert.ToDouble(vBBox[1]);
                Turis = Width * Length * Height;
                Zaliavos_Svoris = Turis * 7800;


                Debug.Print("Width: " + Width);
                Debug.Print("Length: " + Length);
                Debug.Print("Height: " + Height);
                Debug.Print("Width: " + (System.Convert.ToDouble(vBBox[3]) - System.Convert.ToDouble(vBBox[0])));
                Debug.Print("Length: " + (System.Convert.ToDouble(vBBox[5]) - System.Convert.ToDouble(vBBox[2])));
                Debug.Print("Height: " + (System.Convert.ToDouble(vBBox[4]) - System.Convert.ToDouble(vBBox[1])));
                Debug.Print("Bounding box turis, m3: " + Turis);
                Debug.Print("Zaliavos svoris, kG: " + Zaliavos_Svoris);

                return Zaliavos_Svoris;
            }
            else
            {
                MessageBox.Show("Detale neatidaryta!");
                return 0;
            }
        }

        public static double[] GetPreciseBoundingBox(IPartDoc swPart)
        {
            double[] dBox = new double[6];

            //Variant vBodies;
            object[] vBodies = (object[])swPart.GetBodies2((int)swBodyType_e.swSolidBody, true);

            double minX = 0;
            double minY = 0;
            double minZ = 0;
            double maxX = 0;
            double maxY = 0;
            double maxZ = 0;

            if (vBodies != null)
            {
                int i;

                for (i = 0; i < vBodies.Length; i++)
                {
                    Body2 swBody = (Body2)vBodies[i];

                    double x;
                    double y;
                    double z;

                    swBody.GetExtremePoint(1, 0, 0, out x, out y, out z);
                    if (i == 0 || x > maxX)
                        maxX = x;

                    swBody.GetExtremePoint(-1, 0, 0, out x, out y, out z);
                    if (i == 0 || x < minX)
                        minX = x;

                    swBody.GetExtremePoint(0, 1, 0, out x, out y, out z);
                    if (i == 0 || y > maxY)
                        maxY = y;

                    swBody.GetExtremePoint(0, -1, 0, out x, out y, out z);
                    if (i == 0 || y < minY)
                        minY = y;

                    swBody.GetExtremePoint(0, 0, 1, out x, out y, out z);
                    if (i == 0 || z > maxZ)
                        maxZ = z;

                    swBody.GetExtremePoint(0, 0, -1, out x, out y, out z);
                    if (i == 0 || z < minZ)
                        minZ = z;
                }
            }

            dBox[0] = minX; dBox[1] = minY; dBox[2] = minZ;
            dBox[3] = maxX; dBox[4] = maxY; dBox[5] = maxZ;

            return dBox;
        }

        public static void DrawBox(ModelDoc2 model, double minX, double minY, double minZ, double maxX, double maxY, double maxZ)
        {
            model.ClearSelection2(true);
            model.SketchManager.Insert3DSketch(true);
            model.SketchManager.AddToDB = true;

            model.SketchManager.CreateLine(maxX, minY, minZ, maxX, minY, maxZ);
            model.SketchManager.CreateLine(maxX, minY, maxZ, minX, minY, maxZ);
            model.SketchManager.CreateLine(minX, minY, maxZ, minX, minY, minZ);
            model.SketchManager.CreateLine(minX, minY, minZ, maxX, minY, minZ);
            model.SketchManager.CreateLine(maxX, maxY, minZ, maxX, maxY, maxZ);
            model.SketchManager.CreateLine(maxX, maxY, maxZ, minX, maxY, maxZ);
            model.SketchManager.CreateLine(minX, maxY, maxZ, minX, maxY, minZ);
            model.SketchManager.CreateLine(minX, maxY, minZ, maxX, maxY, minZ);
            model.SketchManager.CreateLine(minX, minY, minZ, minX, maxY, minZ);
            model.SketchManager.CreateLine(minX, minY, maxZ, minX, maxY, maxZ);
            model.SketchManager.CreateLine(maxX, minY, minZ, maxX, maxY, minZ);
            model.SketchManager.CreateLine(maxX, minY, maxZ, maxX, maxY, maxZ);
            model.SketchManager.AddToDB = false;
            model.SketchManager.Insert3DSketch(true);
        }

    }
}

