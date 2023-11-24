using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using Janitor_V1.Models;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace Janitor_V1.Utils
{
    public class PartUtils
    {
        public void BaziniuProperciuSurasymasVIENAI_Konfiguracijai(Part part)
        {
            string KonfiguracijosVardas;

            KonfiguracijosVardas = part.ReferencedConfiguration;
            if (part.PartType == PartType.Sheet)
            {
                SpecifinesKonfiguracijosProperciuSupildymas(part);
                SheetPart_PapildomuProperciuSupildymas(part);
                SkardinesDetalesKainosSuskaiciavimas(part, SkardinesDetalesParametrai(part));
            }
            else
            {
                SpecifinesKonfiguracijosProperciuSupildymas(part);
                //MultibodyPart_PapildomuProperciuSupildymas(KonfiguracijosVardas);
            }
        }

        public void SpecifinesKonfiguracijosProperciuSupildymas(Part part)
        {
            CustomPropertyManager swCustPropMgr = part.swModel.Extension.CustomPropertyManager[part.ReferencedConfiguration] as CustomPropertyManager;

            if (swCustPropMgr != null)
            {
                part.swModel.ShowConfiguration2(part.ReferencedConfiguration);

                part.swModel.AddCustomInfo3("", "Gamyba", (int)swCustomInfoType_e.swCustomInfoText, "Taip");

                part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Description", (int)swCustomInfoType_e.swCustomInfoText, "");
                part.swModel.CustomInfo2[part.ReferencedConfiguration, "Description"] = "";

                part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Pavirsiaus plotas_m2", (int)swCustomInfoType_e.swCustomInfoText, "");
                part.swModel.CustomInfo2[part.ReferencedConfiguration, "Pavirsiaus plotas_m2"] = string.Format("{0:Standard}", DetalesPavirsiausPlotoNustatymas(part));

                part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Detales mase_kg", (int)swCustomInfoType_e.swCustomInfoText, "");
                part.swModel.CustomInfo2[part.ReferencedConfiguration, "Detales mase_kg"] = string.Format("{0:Standard}", DetalesMasesNustatymas(part));

                part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Virinimas", (int)swCustomInfoType_e.swCustomInfoText, "");
                part.swModel.CustomInfo2[part.ReferencedConfiguration, "Virinimas"] = "";

                part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Medziaga", (int)swCustomInfoType_e.swCustomInfoText, "");
                part.swModel.CustomInfo2[part.ReferencedConfiguration, "Medziaga"] = DetalesMedziaga(part);

                part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Padengimas", (int)swCustomInfoType_e.swCustomInfoText, "");

                part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Pirkimo kaina", (int)swCustomInfoType_e.swCustomInfoText, "");

                System.IO.FileInfo fileInfo = new System.IO.FileInfo(part.swModel.GetPathName());
                string ExtensionName = fileInfo.Extension;

                string CostingoReiksmesIrasas = "\"" + "SW-Cost-TotalCost@@" + part.ReferencedConfiguration + "@" + part.swModel.GetTitle() + "." + ExtensionName + "\"";
                part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Musu dedamas antkainis", (int)swCustomInfoType_e.swCustomInfoText, "");
                part.swModel.CustomInfo2[part.ReferencedConfiguration, "Musu dedamas antkainis"] = "1";

                part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "KAINA_EUR", (int)swCustomInfoType_e.swCustomInfoText, ""); // Sumine kaina su musu antkainiu
                part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Properciu_Irasymo_Data", (int)swCustomInfoType_e.swCustomInfoText, "");
                part.swModel.CustomInfo2[part.ReferencedConfiguration, "Properciu_Irasymo_Data"] = DateTime.Now.ToString();

                part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Kiekis mazge", (int)swCustomInfoType_e.swCustomInfoText, "");

                part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Path name", (int)swCustomInfoType_e.swCustomInfoText, "");
                part.swModel.CustomInfo2[part.ReferencedConfiguration, "Path name"] = part.swModel.GetPathName();
            }
        }

        public void SheetPart_PapildomuProperciuSupildymas(Part part)
        {
            string ExtentsionName;


            System.IO.FileInfo fileInfo = new System.IO.FileInfo(part.swModel.GetPathName());
            ExtentsionName = fileInfo.Extension;

            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Skardos storis_mm", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Skardos storis_mm"] = "\"" + "Thickness@@" + part.ReferencedConfiguration + "@" + part.swModel.GetTitle() + "." + ExtentsionName + "\"";

            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Lankstymas", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Lenkimu skaicius", (int)swCustomInfoType_e.swCustomInfoText, "");

            if (part.Bent == true)
            {
                part.swModel.CustomInfo2[part.ReferencedConfiguration, "Lankstymas"] = "Taip";
                part.swModel.CustomInfo2[part.ReferencedConfiguration, "Lenkimu skaicius"] = "\"" + "SW-Bends@@@Cut-List-Item1" + "@" + part.swModel.GetTitle() + "." + ExtentsionName + "\"";
            }
            else
            {
                part.swModel.CustomInfo2[part.ReferencedConfiguration, "Lankstymas"] = "Ne";
                part.swModel.CustomInfo2[part.ReferencedConfiguration, "Lenkimu skaicius"] = "0";
            }
        }

        private string SkardosStoris_mm;
        private string Lenkimu_Skaicius;
        private string Pramusimu_Skaicius;
        private int Pramusimu_Skaicius_INT;
        private string Dazymo_Plotas_mm2;
        private string Vidiniu_Pjuviu_Ilgis_mm;
        private string Isoriniu_Pjuviu_ilgis_mm;
        private double Suminis_Pjuviu_Ilgis_mm;
        private string Mase_g;

        public Dictionary<string, object> SkardinesDetalesParametrai(Part part)
        {
            if (part.swModel != null)
            {
                if (part.swModel.GetType() == (int)swDocumentTypes_e.swDocPART)
                {
                    CutListoProperciuIrasymasIrNuskaitymas(part);

                    Dictionary<string, object> VisiParametrai = new Dictionary<string, object>();

                    VisiParametrai.Add("SkardosStoris_mm", Convert.ToSingle(SkardosStoris_mm.Replace(",", ".")));
                    VisiParametrai.Add("Lenkimu_Skaicius", Convert.ToInt32(Lenkimu_Skaicius));
                    VisiParametrai.Add("Pramusimu_Skaicius", Pramusimu_Skaicius_INT);
                    VisiParametrai.Add("Suminis_Pjuviu_Ilgis_mm", Suminis_Pjuviu_Ilgis_mm);
                    VisiParametrai.Add("Dazymo_Plotas_mm2", Convert.ToDouble(Dazymo_Plotas_mm2.Replace(",", ".")));
                    VisiParametrai.Add("Mase_g", Convert.ToDouble(Mase_g.Replace(",", ".")));

                    return VisiParametrai;
                }
                else
                {
                    Console.WriteLine("Active document is not a part");
                }
            }
            return null;
        }

        public void CutListoProperciuIrasymasIrNuskaitymas(Part part)
        {
            var cached = false; //??
            bool value;
            object vCutLists = GetCutLists(part.swModel);

            if (vCutLists != null && ((Array)vCutLists).Length > 0)
            {
                for (int I = 0; I <= ((Array)vCutLists).GetUpperBound(0); I++)
                {
                    Feature swCutListFeat = (Feature)((Array)vCutLists).GetValue(I);

                    IBodyFolder instance = (IBodyFolder)swCutListFeat.GetSpecificFeature2();
                    value = instance.UpdateCutList();
                    instance.SetAutomaticCutList(true);

                    CustomPropertyManager swCustPrpsMgr = swCutListFeat.CustomPropertyManager;

                    object vPrpNames;
                    object vPrpTypes;
                    object vPrpVals;
                    object vResVals;
                    object vPrpsLink;

                    int prpsCount;

                    string prpVal;
                    string prpResVal;
                    bool wasResolved;
                    bool isLinked;
                    long Res;

                    string ExtentsionName;
                    ExtentsionName = Path.GetExtension(part.swModel.GetPathName());

                    Res = swCustPrpsMgr.Get6("Sheet Metal Thickness", cached, out prpVal, out SkardosStoris_mm, out wasResolved, out isLinked);

                    Res = swCustPrpsMgr.Get6("Bends", cached, out prpVal, out Lenkimu_Skaicius, out wasResolved, out isLinked);

                    Res = swCustPrpsMgr.Get6("Cut Outs", cached, out prpVal, out Pramusimu_Skaicius, out wasResolved, out isLinked);
                    Pramusimu_Skaicius_INT = Convert.ToInt32(Pramusimu_Skaicius) + 1;

                    float SuminisPjuviuIlgis;
                    Res = swCustPrpsMgr.Get6("Cutting Length-Inner", cached, out prpVal, out Vidiniu_Pjuviu_Ilgis_mm, out wasResolved, out isLinked);
                    float VidPjuv = Convert.ToSingle(Vidiniu_Pjuviu_Ilgis_mm.Replace(",", "."));

                    Res = swCustPrpsMgr.Get6("Cutting Length-Outer", cached, out prpVal, out Isoriniu_Pjuviu_ilgis_mm, out wasResolved, out isLinked);
                    float IsorPjv = Convert.ToSingle(Isoriniu_Pjuviu_ilgis_mm.Replace(",", "."));

                    Suminis_Pjuviu_Ilgis_mm = (VidPjuv + IsorPjv);

                    CustomPropertyManager cutListFeatMgr = swCutListFeat.CustomPropertyManager;

                    part.swModel.CustomInfo2[part.ReferencedConfiguration, "Lenkimu skaicius"] = "\"" + "SW-Bends@@@Cut-List-Item1" + "@" + part.swModel.GetTitle() + "." + ExtentsionName + "\"";
                    Res = cutListFeatMgr.Add3("Dazymo plotas", (int)swCustomInfoType_e.swCustomInfoText, "\"" + "SW-SurfaceArea@@@Cut-List-Item1" + "@" + part.swModel.GetTitle() + "." + ExtentsionName + "\"", 1);

                    Res = swCustPrpsMgr.Get6("Dazymo plotas", cached, out prpVal, out Dazymo_Plotas_mm2, out wasResolved, out isLinked);

                    if (Res == 0)
                    {
                        //MessageBox.Show("Failed to add custom property.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    Res = cutListFeatMgr.Add3("Mase", (int)swCustomInfoType_e.swCustomInfoText, "\"" + "SW-Mass@@@Cut-List-Item1" + "@" + part.swModel.GetTitle() + "." + ExtentsionName + "\"", 1);

                    Res = swCustPrpsMgr.Get6("Mase", cached, out prpVal, out Mase_g, out wasResolved, out isLinked);
                }
            }
            else
            {
                Debug.Print("    -No Cut Lists-");
            }
        }

        public object GetCutLists(IModelDoc2 swModel)
        {
            Feature[] swCutListFeats = null;
            bool isInit = false;
            IPartDoc swPart = (IPartDoc)swModel;
            Feature swFeat = (Feature)swPart.FirstFeature();

            while (swFeat != null)
            {
                if (swFeat.GetTypeName2() == "CutListFolder")
                {
                    if (!isInit)
                    {
                        isInit = true;
                        swCutListFeats = new Feature[1] { swFeat };
                    }
                    else
                    {
                        Array.Resize(ref swCutListFeats, swCutListFeats.Length + 1);
                        swCutListFeats[swCutListFeats.Length - 1] = swFeat;
                    }
                }

                swFeat = (Feature)swFeat.GetNextFeature();
            }

            if (isInit)
            {
                return swCutListFeats;
            }
            else
            {
                return null;
            }
        }

        public struct PjovimoIrPramusimoKainos_Type
        {
            public double SkardosStoris;
            public double PjovimoKaina;
            public double PramusimoKaina;
        }

        public struct LankstymoKainos_Type
        {
            public double SkardosStoris;
            public double SulenkimoKaina;
        }

        public static PjovimoIrPramusimoKainos_Type[] oPjovimoIrPramusimoKainos = new PjovimoIrPramusimoKainos_Type[20];
        public static LankstymoKainos_Type[] oLankstymoKainos = new LankstymoKainos_Type[20];

        public static float Kaina_EUR;
        public static double Sumine_Detales_Kaina;
        public static float Musu_dedamas_antkainis;

        public static void PjovimoParametruUzpildymas()
        {
            oPjovimoIrPramusimoKainos[0].SkardosStoris = 1;
            oPjovimoIrPramusimoKainos[0].PjovimoKaina = 0.64;
            oPjovimoIrPramusimoKainos[0].PramusimoKaina = 0.04;

            oPjovimoIrPramusimoKainos[1].SkardosStoris = 2;
            oPjovimoIrPramusimoKainos[1].PjovimoKaina = 0.9;
            oPjovimoIrPramusimoKainos[1].PramusimoKaina = 0.06;
            oPjovimoIrPramusimoKainos[2].SkardosStoris = 2.5;
            oPjovimoIrPramusimoKainos[2].PjovimoKaina = 0.94;
            oPjovimoIrPramusimoKainos[2].PramusimoKaina = 0.07;
            oPjovimoIrPramusimoKainos[3].SkardosStoris = 3;
            oPjovimoIrPramusimoKainos[3].PjovimoKaina = 0.97;
            oPjovimoIrPramusimoKainos[3].PramusimoKaina = 0.08;
            oPjovimoIrPramusimoKainos[4].SkardosStoris = 4;
            oPjovimoIrPramusimoKainos[4].PjovimoKaina = 1.07;
            oPjovimoIrPramusimoKainos[4].PramusimoKaina = 0.1;
            oPjovimoIrPramusimoKainos[5].SkardosStoris = 5;
            oPjovimoIrPramusimoKainos[5].PjovimoKaina = 1.39;
            oPjovimoIrPramusimoKainos[5].PramusimoKaina = 0.12;
            oPjovimoIrPramusimoKainos[6].SkardosStoris = 6;
            oPjovimoIrPramusimoKainos[6].PjovimoKaina = 1.68;
            oPjovimoIrPramusimoKainos[6].PramusimoKaina = 0.16;
            oPjovimoIrPramusimoKainos[7].SkardosStoris = 8;
            oPjovimoIrPramusimoKainos[7].PjovimoKaina = 2.79;
            oPjovimoIrPramusimoKainos[7].PramusimoKaina = 0.18;
            oPjovimoIrPramusimoKainos[8].SkardosStoris = 10;
            oPjovimoIrPramusimoKainos[8].PjovimoKaina = 3.49;
            oPjovimoIrPramusimoKainos[8].PramusimoKaina = 0.2;
            oPjovimoIrPramusimoKainos[9].SkardosStoris = 12;
            oPjovimoIrPramusimoKainos[9].PjovimoKaina = 5.14;
            oPjovimoIrPramusimoKainos[9].PramusimoKaina = 0.25;
            oPjovimoIrPramusimoKainos[10].SkardosStoris = 15;
            oPjovimoIrPramusimoKainos[10].PjovimoKaina = 9.8;
            oPjovimoIrPramusimoKainos[10].PramusimoKaina = 0.3;
            oPjovimoIrPramusimoKainos[11].SkardosStoris = 20;
            oPjovimoIrPramusimoKainos[11].PjovimoKaina = 18.16;
            oPjovimoIrPramusimoKainos[11].PramusimoKaina = 0.4;
            oPjovimoIrPramusimoKainos[12].SkardosStoris = 1.5;
            oPjovimoIrPramusimoKainos[12].PjovimoKaina = 0.77;
            oPjovimoIrPramusimoKainos[12].PramusimoKaina = 0.05;

        }

        public static void SulenkimoKainuSupildymas()
        {
            oLankstymoKainos[0].SkardosStoris = 1;
            oLankstymoKainos[0].SulenkimoKaina = 1.5;

            oLankstymoKainos[1].SkardosStoris = 1.5;
            oLankstymoKainos[1].SulenkimoKaina = 1.5;
            oLankstymoKainos[2].SkardosStoris = 2;
            oLankstymoKainos[2].SulenkimoKaina = 1.5;
            oLankstymoKainos[3].SkardosStoris = 2.5;
            oLankstymoKainos[3].SulenkimoKaina = 1.5;
            oLankstymoKainos[4].SkardosStoris = 3;
            oLankstymoKainos[4].SulenkimoKaina = 1.5;
            oLankstymoKainos[5].SkardosStoris = 4;
            oLankstymoKainos[5].SulenkimoKaina = 1.5;
            oLankstymoKainos[6].SkardosStoris = 5;
            oLankstymoKainos[6].SulenkimoKaina = 1.5;
            oLankstymoKainos[7].SkardosStoris = 6;
            oLankstymoKainos[7].SulenkimoKaina = 1.5;
            oLankstymoKainos[8].SkardosStoris = 8;
            oLankstymoKainos[8].SulenkimoKaina = 1.5;
        }

        public static double PjovimoKainosParinkimas(float iSkardosStoris)
        {
            PjovimoParametruUzpildymas();
            for (int i = 0; i < oPjovimoIrPramusimoKainos.Length; i++)
            {
                if (oPjovimoIrPramusimoKainos[i].SkardosStoris == iSkardosStoris)
                {
                    return oPjovimoIrPramusimoKainos[i].PjovimoKaina;
                }
            }
            return 0;
        }

        public static double SulenkimoKainosParinkimas(float iSkardosStoris)
        {
            if (iSkardosStoris > 8)
            {
                return 0;
            }

            SulenkimoKainuSupildymas();
            for (int i = 0; i < oLankstymoKainos.Length; i++)
            {
                if (oLankstymoKainos[i].SkardosStoris == iSkardosStoris)
                {
                    return oLankstymoKainos[i].SulenkimoKaina;
                }
            }

            return 0;
        }

        public static double PramusimoKainosParinkimas(float iSkardosStoris)
        {
            PjovimoParametruUzpildymas();
            for (int i = 0; i < oPjovimoIrPramusimoKainos.Length; i++)
            {
                if (oPjovimoIrPramusimoKainos[i].SkardosStoris == iSkardosStoris)
                {
                    return oPjovimoIrPramusimoKainos[i].PramusimoKaina;
                }
            }

            return 0;
        }

        public static void SkardinesDetalesKainosSuskaiciavimas(Part part, Dictionary<string, object> SurinktiSkardinesDetalesParametrai)
        {
            float Skardos_Storis = Convert.ToSingle(SurinktiSkardinesDetalesParametrai["SkardosStoris_mm"]);
            int Lenkimu_Skaicius = Convert.ToInt32(SurinktiSkardinesDetalesParametrai["Lenkimu_Skaicius"]);
            int Pramusimu_Skaicius = Convert.ToInt32(SurinktiSkardinesDetalesParametrai["Pramusimu_Skaicius"]);
            double Detales_Suminis_Plotas_m2 = Convert.ToDouble(SurinktiSkardinesDetalesParametrai["Dazymo_Plotas_mm2"]) / 1000000;
            double Pjovimo_Ilgis_m = Convert.ToDouble(SurinktiSkardinesDetalesParametrai["Suminis_Pjuviu_Ilgis_mm"]) / 1000;
            double DetalesMase_kg = Convert.ToDouble(SurinktiSkardinesDetalesParametrai["Mase_g"]) / 1000;

            float MetaloKaina_Eur_uz_kg = 1.55f;

            double oDazymoMilteliniuBuduKaina = 14;
            double Pjovimo_Kaina_Uz_1m = PjovimoKainosParinkimas(Skardos_Storis);
            double Skardos_Pramusimo_Kaina = PramusimoKainosParinkimas(Skardos_Storis);
            double Skardos_Sulenkimo_Kaina = SulenkimoKainosParinkimas(Skardos_Storis);
            double Sumine_Detales_Kaina = (Pjovimo_Ilgis_m * Pjovimo_Kaina_Uz_1m + Pramusimu_Skaicius * Skardos_Pramusimo_Kaina + Lenkimu_Skaicius * Skardos_Sulenkimo_Kaina + oDazymoMilteliniuBuduKaina * Detales_Suminis_Plotas_m2 + (DetalesMase_kg * MetaloKaina_Eur_uz_kg * 1.2)); // 20proc eina i atraizas.

            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Pavirsiaus plotas_m2", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Pavirsiaus plotas_m2"] = Math.Round(Detales_Suminis_Plotas_m2, 3).ToString();
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Detales mase_kg", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Detales mase_kg"] = Math.Round(DetalesMase_kg, 3).ToString();
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Pjuvio ilgis_m", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Pjuvio ilgis_m"] = Math.Round(Pjovimo_Ilgis_m, 5).ToString();
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Lenkimu skaicius", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Lenkimu skaicius"] = Lenkimu_Skaicius.ToString();
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Pramusimu skaicius", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Pramusimu skaicius"] = Pramusimu_Skaicius.ToString();
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Medziaga", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Medziaga"] = DetalesMedziaga(part);
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Padengimas", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Metalo kaina_EUR uz kg", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Metalo kaina_EUR uz kg"] = MetaloKaina_Eur_uz_kg.ToString();
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Dazymo Miltel Budu Kaina_EUR uz m2", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Dazymo Miltel Budu Kaina_EUR uz m2"] = oDazymoMilteliniuBuduKaina.ToString();
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Pjovimo kaina_Eur uz 1m", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Pjovimo kaina_Eur uz 1m"] = Pjovimo_Kaina_Uz_1m.ToString();
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Skardos pramusimo kaina_Eur", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Skardos pramusimo kaina_Eur"] = Skardos_Pramusimo_Kaina.ToString();
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Skardos sulenkimo kaina_Eur uz vnt", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Skardos sulenkimo kaina_Eur uz vnt"] = Skardos_Sulenkimo_Kaina.ToString();
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Pirkimo kaina", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Pirkimo kaina"] = Math.Round(Sumine_Detales_Kaina, 2).ToString();

            double Musu_dedamas_antkainis = 1.2;
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "Musu dedamas antkainis", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "Musu dedamas antkainis"] = Musu_dedamas_antkainis.ToString();

            double Kaina_EUR = Sumine_Detales_Kaina * Musu_dedamas_antkainis;
            part.swModel.AddCustomInfo3(part.ReferencedConfiguration, "KAINA_EUR", (int)swCustomInfoType_e.swCustomInfoText, "");
            part.swModel.CustomInfo2[part.ReferencedConfiguration, "KAINA_EUR"] = Math.Round(Kaina_EUR, 2).ToString();
        }

        public static double DetalesMasesNustatymas(Part part)
        {
            double nuskaitytaDetalesMase = 0.0;

            if (part.swModel != null)
            {
                int status = 0;
                object[] massprops = part.swModel.Extension.GetMassProperties(1, ref status) as object[];

                if (massprops != null && massprops.Length >= 6)
                {
                    var NuskaitytaDetalesMase = (double)massprops[5];
                    MessageBox.Show("Detales mase yra: " + NuskaitytaDetalesMase);
                }
            }
            else
            {
                Console.WriteLine("No active document.");
            }

            return nuskaitytaDetalesMase;
        }

        public static double DetalesPavirsiausPlotoNustatymas(Part part)
        {
            double NuskaitytasDetalesPavirsiausPlotas = 0;

            if (part.swModel != null)
            {
                int status = 0;
                object[] massprops = part.swModel.Extension.GetMassProperties(1, ref status) as object[];

                if (massprops != null && massprops.Length >= 5)
                {
                    NuskaitytasDetalesPavirsiausPlotas = (double)massprops[4];
                }
            }

            return NuskaitytasDetalesPavirsiausPlotas;
        }

        public static string DetalesMedziaga(Part part)
        {
            IPartDoc swPart = part.swModel as IPartDoc;

            string MedziagosVardas = "";

            if (swPart != null)
            {
                string empty = "";
                MedziagosVardas = swPart.GetMaterialPropertyName2(part.ReferencedConfiguration, out empty);
            }

            return MedziagosVardas;
        }
    }
}
