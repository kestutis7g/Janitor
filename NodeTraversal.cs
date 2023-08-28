using Janitor_V1.Models;
using Microsoft.Office.Interop.Excel;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Lifetime;
using System.Windows.Forms;
using static BrightIdeasSoftware.TreeListView;

namespace Janitor_V1
{
    public class NodeTraversal
    {
        public SldWorks swApp;
        public List<Node> AssemblingoNariai;
        public List<Node> PartsOnly;

        public NodeTraversal()
        {
            AssemblingoNariai = new List<Node>();
            PartsOnly = new List<Node>();
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
            Debug.WriteLine($"Number of members in the array: {numberOfMembers}");
            

            for (int i = 0; i < vChildComp.Length; i++)
            {
                var childComp = vChildComp[i];
                Component2 swChildComp = childComp as Component2;
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
            
            //CustPropMgr = swModel.Extension.CustomPropertyManager[""];
          
            CustomPropertyManager CustPropMgr = swModel.Extension.get_CustomPropertyManager(swChildComp.ReferencedConfiguration);



            if (swModel.GetType() == (int)swDocumentTypes_e.swDocPART)
            {
                node.ComponentType = NodeType.Part;
                node.Part.ItemNumber = itemNumber;
                node.Part.ComponentName = swChildComp.Name2;
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

                string temp = (string)swModel.CustomInfo2[swChildComp.ReferencedConfiguration, "Skardos storis_mm"];

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

                if (Solidworks_control_tools.Solidworks_control_tools.CheckToolboxComponents(swModel) != 0)
                {
                    node.Part.PartType = PartType.Toolbox;
                    node.Part.Weight = Solidworks_control_tools.Solidworks_control_tools.WeightOfComponent(swApp, swChildComp.GetPathName(), swChildComp.ReferencedConfiguration);
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



                }

                //MessageBox.Show("Komponento " + node.GetComponentName().ToString() + "Toolbox tipas:" + IsToolboxComponent.ToString());

                return node;
            }
            else if (swModel.GetType() == (int)swDocumentTypes_e.swDocASSEMBLY)
            {
                node.ComponentType = NodeType.Assembly;

                node.Assembly.ItemNumber = itemNumber;
                node.Assembly.ComponentName = swChildComp.Name2;
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

                return node;
            }
            else if (swModelType == (int)swDocumentTypes_e.swDocDRAWING)
            {
                MessageBox.Show("Breziniu sita programa neapdoroja");
            }
            return null;
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














        
    







    

