using System;
using System.Diagnostics;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace Janitor_V1.Solidworks_control_tools
{
    public static class Solidworks_control_tools
    {

        public static void OpenItem(string fileLocation, int DocumentType, string Configuration)
        {
            int errors = 0;
            int warnings = 0;

            ISldWorks swApp;
            swApp = (ISldWorks)Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application"));
            ModelDoc2 swModelDoc = default(ModelDoc2);
            //swModelDoc = (ModelDoc2)swApp.OpenDoc6(fileName, (int)swDocumentTypes_e.swDocPART, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", ref errors, ref warnings);
            swModelDoc = (ModelDoc2)swApp.OpenDoc6(fileLocation, DocumentType, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", ref errors, ref warnings);


            // Activate the loaded document and prompt for rebuild if the model changed
            swModelDoc = (ModelDoc2)swApp.ActivateDoc3(swModelDoc.GetTitle(), false, (int)swRebuildOnActivation_e.swUserDecision, ref errors);
            Debug.Print("Error code after document activation: " + errors.ToString());
        }

        public static int CheckToolboxComponents(ModelDoc2 swModel)
        {
            ModelDocExtension modelDocExt;

            // Tikrinama ar komponentas nera Toolbox

            modelDocExt = swModel.Extension;
            return modelDocExt.ToolboxPartType;
        }

        public static double WeightOfComponent(ISldWorks swApp,string componentPath, string Configuration)
        {
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

        public static string TakePictureOfItem(ModelDoc2 swModel, string pictureName)
        {
            swModel.ShowNamedView2("*Isometric", 7);
            swModel.ViewZoomtofit2();
            var location = "C:\\bbb\\" + pictureName + ".PNG";

            // Save As
            swModel.SaveAs3(location , 0, 0);
            return location;
        }
    }
}

