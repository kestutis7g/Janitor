using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Janitor_V1.Models;
using Janitor_V1.Utils;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace Janitor_V1
{
    public class NodeTraversal
    {
        public SldWorks swApp;
        public List<Node> AssemblingoNariai;
        public List<Node> PartsOnly;
        public Device Device;
        public string ProjectLocation = "C:\\bbb\\";

        public NodeTraversal()
        {
            AssemblingoNariai = new List<Node>();
            PartsOnly = new List<Node>();
            Device = new Device();
        }

        public void AssemblingoNariuSurinkimas()
        {
            ModelDoc2 swModel = swApp.ActiveDoc as ModelDoc2;
            ConfigurationManager swConfMgr = swModel.ConfigurationManager;
            Configuration swConf = swConfMgr.ActiveConfiguration;
            Component2 swRootComp = swConf.GetRootComponent3(true);
            AssemblyDoc swAssy;
            int errors = 0;
            //double StartTime = Timer(); // Start time (use Stopwatch for more precision)
            Debug.Print("File = " + swModel.GetPathName());

            this.Device.swModel = swModel;
            this.Device.FileLocation = swModel.GetPathName();
            this.Device.Configuration = swApp.GetActiveConfigurationName(swModel.GetPathName());
            this.ProjectLocation = Directory.GetParent(this.Device.FileLocation).ToString() + "\\";

            ReadDeviceProperties(swModel.Extension.get_CustomPropertyManager(
                this.Device.Configuration));

            if (swModel.GetType() == (int)swDocumentTypes_e.swDocASSEMBLY)
            {
                // Resolve all lightweight components
                swAssy = (AssemblyDoc)swModel;
                errors = swAssy.ResolveAllLightWeightComponents(true);
                var root = new Node();

                TraverseComponent(swRootComp, 1, "", root);
                this.AssemblingoNariai = root.Children;
            }

            // Calculate TotalTime and print it
            //double FinishTime = Timer(); // End time (use Stopwatch for more precision)
            //double TotalTime = FinishTime - StartTime; // Elapsed time
            //Debug.Print("Time = " + TotalTime.ToString() + " sec");

            //isjungia slolidworks
            //swApp.ExitApp();
            swApp = null;
        }

        public void TraverseComponent(Component2 swComp, long nLevel, string parentItemNumber, Node parent)
        {
            object[] vChildComp = (object[])swComp.GetChildren();
            int numberOfMembers = vChildComp.Length;
            //Debug.WriteLine($"Number of members in the array: {numberOfMembers}");
            
            for (int i = 0; i < vChildComp.Length; i++)
            {
                Component2 swChildComp = vChildComp[i] as Component2;
                if (swChildComp != null)
                {
                    if (swChildComp.GetSuppression() != (int)swComponentSuppressionState_e.swComponentSuppressed)
                    {
                        string itemNumber = GetItemNumber(parentItemNumber, i + 1);

                        ModelDoc2 swModel = (ModelDoc2)swChildComp.GetModelDoc2();
                        var node = ReadProperties(swModel, swChildComp, itemNumber);
                        if (node != null)
                        {
                            if(node.ComponentType == NodeType.Part)
                            {
                                PartsOnly.Add(node);
                            }
                            parent.Children.Add(node);
                            TraverseComponent(swChildComp, nLevel + 1, itemNumber, node);
                        }
                    }
                }
            }
        }

        public Node ReadProperties(ModelDoc2 swModel, Component2 swChildComp, string itemNumber)
        {
            Node node = new Node();
            if(swModel == null)
            {
                return null;
            }
            int swModelType = swModel.GetType();
            node.swModel = swModel;
            node.swComp = swChildComp;
          
            CustomPropertyManager CustPropMgr = swModel.Extension.get_CustomPropertyManager(swChildComp.ReferencedConfiguration);

            if (swModel.GetType() == (int)swDocumentTypes_e.swDocPART)
            {
                node.ComponentType = NodeType.Part;
                node.Part.ItemNumber = itemNumber;
                var name = swChildComp.Name2.Split('/');
                node.Part.ComponentName = new string(' ', (name.Length - 1) * 4) + name.Last();
                node.Part.ReferencedConfiguration = swChildComp.ReferencedConfiguration;
                node.Part.FileLocation = swChildComp.GetPathName();

                node.Part.SurfaceArea = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Pavirsiaus plotas_m2", CustPropMgr);

                node.Part.Weight = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Detales mase_kg", CustPropMgr);

                node.Part.Welded = ReadPropertiesFromSolidworks_boolOut(
                    swModel, swChildComp.ReferencedConfiguration, "Virinimas");

                node.Part.Material = ReadPropertiesFromSolidworks_stringOut(
                    swModel, swChildComp.ReferencedConfiguration, "Medziaga");

                node.Part.Coverage = ReadPropertiesFromSolidworks_stringOut(
                    swModel, swChildComp.ReferencedConfiguration, "Padengimas");

                node.Part.PurchasePrice = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Pirkimo kaina", CustPropMgr);

                node.Part.Markup = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Musu dedamas antkainis", CustPropMgr);

                node.Part.Price = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "KAINA_EUR", CustPropMgr);

                node.Part.SheetThickness = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Skardos storis_mm", CustPropMgr);

                node.Part.Bent = ReadPropertiesFromSolidworks_boolOut(
                    swModel, swChildComp.ReferencedConfiguration, "Lankstymas");

                node.Part.NumberOfBends = ReadPropertiesFromSolidworks_intOut(
                    swModel, swChildComp.ReferencedConfiguration, "Lenkimu skaicius");

                node.Part.CutLength = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Pjuvio ilgis_m", CustPropMgr);

                node.Part.NumberOfPunches = ReadPropertiesFromSolidworks_intOut(
                    swModel, swChildComp.ReferencedConfiguration, "Pramusimu skaicius");

                node.Part.MetalPrice = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Metalo kaina_EUR uz kg", CustPropMgr);

                node.Part.PaintingCost = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Dazymo Miltel Budu Kaina_EUR uz m2", CustPropMgr);

                node.Part.CuttingCost = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Pjovimo kaina_Eur uz 1m", CustPropMgr);

                node.Part.PunchingCost = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Skardos pramusimo kaina_Eur", CustPropMgr);

                node.Part.BendingCost = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Skardos sulenkimo kaina_Eur uz vnt", CustPropMgr);

                if (Solidworks_control_tools.CheckToolboxComponents(swModel) != 0)
                {
                    node.Part.PartType = PartType.Toolbox;
                    //isjungta del ilgo veikimo laiko
                    //node.Part.Weight = Solidworks_control_tools.WeightOfComponent(swApp, swChildComp.GetPathName(), swChildComp.ReferencedConfiguration);
                }
                else
                {
                    node.Part.PartType = PartType.Other;

                    node.Part.OtherPart.ProgrammingDuration = ReadPropertiesFromSolidworks_doubleOut(
                        swModel, swChildComp.ReferencedConfiguration, "Programavimo trukme_val", CustPropMgr);

                    node.Part.OtherPart.SinglePieceManufacturingDuration = ReadPropertiesFromSolidworks_doubleOut(
                        swModel, swChildComp.ReferencedConfiguration, "Pagaminimo trukme_min", CustPropMgr);

                    node.Part.OtherPart.MaterialCost = ReadPropertiesFromSolidworks_doubleOut(
                        swModel, swChildComp.ReferencedConfiguration, "Zaliavos kaina", CustPropMgr);

                    node.Part.OtherPart.AmountOfThisPart = ReadPropertiesFromSolidworks_intOut(
                        swModel, swChildComp.ReferencedConfiguration, "Detaliu skaicius");

                    node.Part.OtherPart.ManufacturingCost = ReadPropertiesFromSolidworks_doubleOut(
                        swModel, swChildComp.ReferencedConfiguration, "Gamybos valandos kaina_EUR", CustPropMgr);

                    node.Part.OtherPart.Description = ReadPropertiesFromSolidworks_stringOut(
                        swModel, swChildComp.ReferencedConfiguration, "Description");

                    node.Part.OtherPart.Supplier = ReadPropertiesFromSolidworks_doubleOut(
                        swModel, swChildComp.ReferencedConfiguration, "Tiekejas", CustPropMgr);

                    node.Part.OtherPart.ComponentArticle = ReadPropertiesFromSolidworks_doubleOut(
                        swModel, swChildComp.ReferencedConfiguration, "Komponento artikulas", CustPropMgr);

                    node.Part.OtherPart.TechnicalParameters = ReadPropertiesFromSolidworks_doubleOut(
                        swModel, swChildComp.ReferencedConfiguration, "Techniniai parametrai", CustPropMgr);

                    node.Part.OtherPart.PurchaseCost = ReadPropertiesFromSolidworks_doubleOut(
                        swModel, swChildComp.ReferencedConfiguration, "Pirkimo kaina", CustPropMgr);
                        
                    node.Part.OtherPart.MarkupCostPurchase = ReadPropertiesFromSolidworks_doubleOut(
                        swModel, swChildComp.ReferencedConfiguration, "Antkainis", CustPropMgr);
                    
                    node.Part.OtherPart.StripMaterialCost = ReadPropertiesFromSolidworks_doubleOut(
                        swModel, swChildComp.ReferencedConfiguration, "Juostos medziagos 1m2 kaina", CustPropMgr);

                    node.Part.OtherPart.MaterialWeight = Math.Round(Solidworks_control_tools.DetalesZaliavosKaina(swApp, node.GetFileLocation(), swModel), 2);
                }

                return node;
            }
            else if (swModel.GetType() == (int)swDocumentTypes_e.swDocASSEMBLY)
            {
                node.ComponentType = NodeType.Assembly;

                node.Assembly.ItemNumber = itemNumber;
                var name = swChildComp.Name2.Split('/');
                node.Assembly.ComponentName = new string(' ', (name.Length-1)*4) + name.Last();
                node.Assembly.ReferencedConfiguration = swChildComp.ReferencedConfiguration;
                node.Assembly.FileLocation = swChildComp.GetPathName();

                node.Assembly.ChildNodeAssemblyDuration = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Pomazgiu sumontavimo trukme_val", CustPropMgr);

                node.Assembly.IndividualComponentAssemblyDuration = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Palaidu komponentu sumontavimo trukme_val", CustPropMgr);

                node.Assembly.AssemblyToParentNodeDuration = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Sumontavimo i kita mazga trukme_val", CustPropMgr);

                node.Assembly.CombinedAssemblyTime = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Sumine planuojama mazgo montavimo trukme_val", CustPropMgr);
                
                node.Assembly.WeldingDuration = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "Planuojama suvirinimo trukme_val", CustPropMgr);
                
                node.Assembly.OtherCosts = ReadPropertiesFromSolidworks_doubleOut(
                    swModel, swChildComp.ReferencedConfiguration, "KITI kastai_EUR", CustPropMgr);
                    
                node.Assembly.OtherCostsDescription = ReadPropertiesFromSolidworks_stringOut(
                    swModel, swChildComp.ReferencedConfiguration, "Kitu kastu aprasas");
                
                node.Assembly.ImageLocation = ReadPropertiesFromSolidworks_stringOut(
                    swModel, swChildComp.ReferencedConfiguration, "Paveikslelio failas");

                return node;
            }
            else if (swModelType == (int)swDocumentTypes_e.swDocDRAWING)
            {
                MessageBox.Show("Breziniu sita programa neapdoroja");
            }
            return null;
        }

        private void ReadDeviceProperties(CustomPropertyManager CustPropMgr)
        {
            //designing
            this.Device.PlannedDesigningDuration = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Planuojama projektavimo trukme_val", CustPropMgr);

            this.Device.DesigningCostWithoutVAT = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Projektavimo valandos kaina", CustPropMgr);

            this.Device.DesigningTotalPrice = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "PROJEKTAVIMO kaina vienam irenginiui", CustPropMgr);

            //welding tab
            this.Device.PlannedWeldingDuration = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Planuojama suvirinimo trukme_val", CustPropMgr);

            this.Device.WeldingCostWithoutVAT = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Virinimo valandos kaina", CustPropMgr);

            this.Device.WeldingTotalPrice = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "SUVIRINIMO kaina", CustPropMgr);

            //assembly and packaging
            this.Device.TotalWorkManagementDuration = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Darbu organiz trukme visiems ireng_val", CustPropMgr);

            this.Device.WorkManagementCost = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Darbu organizavimo valandos kaina", CustPropMgr);

            this.Device.WorkManagementTotalCost = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Darbu organizavimo irenginiui kaina", CustPropMgr);
            //-------------------------
            this.Device.TotalSupplyDuration = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Tiekimo trukme visiems ireng_val", CustPropMgr);

            this.Device.SupplyCost = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Tiekimo valandos kaina", CustPropMgr);

            this.Device.SupplyTotalCost = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Tiekimo irenginiam kaina", CustPropMgr);
            //-------------------------
            this.Device.ChildNodeAssemblyDuration = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Pomazgiu sumontavimo trukme_val", CustPropMgr);

            this.Device.IndividualComponentsAssembly = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Palaidu komponentu sumontavimo trukme_val", CustPropMgr);

            this.Device.AssemblyToParentDuration = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Sumontavimo i kita mazga trukme_val", CustPropMgr);

            this.Device.TotalAssemblyDuration = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Sumine mazgo planuojama montavimo trukme_val", CustPropMgr);

            this.Device.AssemblyCost = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Montavimo valandos kaina", CustPropMgr);

            this.Device.AssemblyTotalCost = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Irenginio sumontavimo kaina", CustPropMgr);
            //-------------------------
            this.Device.TotalPackagingDuration = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Pakavimo trukme_val", CustPropMgr);

            this.Device.PackingCost = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Pakavimo valandos kaina", CustPropMgr);

            this.Device.PackagingMaterialCost = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Pakavimo medziagu kaina", CustPropMgr);

            this.Device.PackagingTotalCost = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "Irenginio supakavimo kaina", CustPropMgr);            

            //parts tab
            this.Device.NumberOfParts = ReadPropertiesFromSolidworks_intOut(
                    this.Device.swModel, this.Device.Configuration, "VISU DETALIU skaicius");

            this.Device.TotalPartsCost = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "VISU DETALIU sumine kaina", CustPropMgr);

            this.Device.TotalToolboxWeight = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "TOOLBOX svoris", CustPropMgr);

            this.Device.TotalToolboxCost = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "TOOLBOX sumine kaina", CustPropMgr);

            this.Device.TotalPartsAndToolboxCost = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "VISU DETALIU sumine kaina su Antkainiu", CustPropMgr);

            //other costs
            this.Device.OtherCosts = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "KITI kastai_EUR", CustPropMgr);

            this.Device.OtherCostsDescription = ReadPropertiesFromSolidworks_stringOut(
                    this.Device.swModel, this.Device.Configuration, "Kitu kastu aprasas");

            //footer
            this.Device.AmountOfDevices = ReadPropertiesFromSolidworks_intOut(
                    this.Device.swModel, this.Device.Configuration, "Uzsakomu irenginiu skaicius");

            this.Device.TotalPrice = ReadPropertiesFromSolidworks_doubleOut(
                    this.Device.swModel, this.Device.Configuration, "IRENGINIO SUMINE KAINA_EUR", CustPropMgr);

        }

        public string GetItemNumber(string parentItemNumber, int childIndex)
        {
            if (string.IsNullOrEmpty(parentItemNumber))
            {
                return childIndex.ToString();
            }
            return $"{parentItemNumber}.{childIndex}";
        }

        public double Timer()
        {
            // Use System.Diagnostics.Stopwatch for more precision in C#
            return (double)Stopwatch.GetTimestamp() / Stopwatch.Frequency;
        }

        public string ReadPropertiesFromSolidworks_stringOut(ModelDoc2 swModel, string Configuration, string PropertyName)
        {
            string PropertyRed = (string)swModel.CustomInfo2[Configuration, PropertyName];
            if (string.IsNullOrEmpty(PropertyRed))
            {
                return "";
            }
            return PropertyRed.ToString();
        }
        public int ReadPropertiesFromSolidworks_intOut(ModelDoc2 swModel, string Configuration, string PropertyName)
        {
            string PropertyRed = (string)swModel.CustomInfo2[Configuration, PropertyName];
            int value = 0;
            int.TryParse(PropertyRed, out value);
            return value;
        }

        public bool ReadPropertiesFromSolidworks_boolOut(ModelDoc2 swModel, string Configuration, string PropertyName)
        {
            string PropertyRed = (string)swModel.CustomInfo2[Configuration, PropertyName];

            if (string.IsNullOrEmpty(PropertyRed) || PropertyRed.ToLower() == "ne")
            {
                return false;
            }
            return true;
        }

        public double ReadPropertiesFromSolidworks_doubleOut(ModelDoc2 swModel, string Configuration, string PropertyName, CustomPropertyManager CustPropMgr)
        {
            string ValOut;
            string ResValue;
            bool WasResolved;
            bool LinkedToProperty;
            //string temp = (string)swModel.CustomInfo2[Configuration, PropertyName];
            int retVal;

            retVal = CustPropMgr.Get6(PropertyName,false,out ValOut,out ResValue,out WasResolved, out LinkedToProperty);
            ResValue = ResValue.Replace(',', '.');
            double value = 0;
            double.TryParse(ResValue, out value);
            //MessageBox.Show("Komponento " + swModel.GetPathName() + " properčio " + PropertyName + " reikšmė: "+ResValue ).ToString();

            return value;
        }   
    }
}














        
    







    

