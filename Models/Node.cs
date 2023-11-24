using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using SolidWorks.Interop.sldworks;

namespace Janitor_V1.Models
{
    //enumeratorius. Komponentų tipai.
    public enum NodeType
    {
        Part,
        Assembly,
    }    

    public class Node
    {
        //Partas ir Assemblis turi skirtingus properčius
        public Part Part { get; set; }
        public Assembly Assembly { get; set; }

        //Bendri properčiai abiems tipams
        [Category("General"),
        Description("Component Type")]
        public NodeType ComponentType { get; set; } //enumeratoriaus tipo propertis, kuris gali turėti tik dvi reikšmes

        /*propertis priskiriamas kategorijai ir po to tverkingai atvaizduojamas
            komponento properčių tabe */
        [Category("General") ,
        Description("Full item number")]
        public string ItemNumber { get; set; }

        [Category("General"),
        Description("Amount of duplicate components")]
        public int DuplicateAmount { get; set; } //kiek įrenginyje yra tokių pačių assemblingų ir partų

        [Category("Other"),
        Description("All child nodes")]
        public List<Node> Children { get; set; } //vaikų sąrašas

        private StatusMessage StatusMessage { get; set;} = StatusMessage.None;

        public Node()
        {
            //naujo objekto aitemui sukūrimas
            this.Children = new List<Node>();
            this.Part = new Part();
            this.Assembly = new Assembly();
        }

        public void Update(Node data)
        {
            //priskiria identišką objektą kitam, tokiam pačiam jau buvusiam objektui
            this.Part = data.Part;
            this.Assembly = data.Assembly;
            this.ComponentType = data.ComponentType;
        }

        public string GetComponentName()
        {
            //šis metodas gražina vardą be tarpo priekyje
            if (this.ComponentType == NodeType.Part)
            {
                return Part.ComponentName.Trim();
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.ComponentName.Trim();
            }
            return "Unknown";
        }
        public string GetComponentNameWithSpaces()
        {
            //šis metodas gražina vardą su tarpu priekyje, jei jis yra kažkieno vaikas
            if (this.ComponentType == NodeType.Part)
            {
                return Part.ComponentName;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.ComponentName;
            }
            return "Unknown";
        }

        public string GetReferencedConfiguration()
        {
            //šis metodas gražina aitemo konfiguraciją
            if (this.ComponentType == NodeType.Part)
            {
                return Part.ReferencedConfiguration;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.ReferencedConfiguration;
            }
            return "Unknown"; //šis identifikatorius gražinamas, jei aitemas nėra nei partas nei assemblingas
        }

        public int GetComponentID()
        {
            //šis metodas gražina komponento ID. Kol kas su šituo ID beveik niekas nedaryta ir nenaudota. 
            if (this.ComponentType == NodeType.Part)
            {
                return Part.ComponentID;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.ComponentID;
            }
            return -999;
        }

        public string GetDescription()
        {
            //šis metodas gražina komponento aprašymą
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Description;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.Description;
            }
            return "Unknown";
        }
        public string GetNotes()
        {
            //šis metodas gražina komponento aprašymą
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Notes;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.Notes;
            }
            return "Unknown";
        }

        public string GetFileLocation()
        {

            //gražina komponento failo adresą
            if (this.ComponentType == NodeType.Part)
            {
                return Part.FileLocation;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.FileLocation;
            }
            return "Unknown";
        }
        public Image GetSmallImage(string workingDirectory)
        {
            //gražina mažą nuotrauką. Naudojama toje vietoje, kur dedama maža ikonėlė. 
            if (this.ComponentType == NodeType.Part && 
                !string.IsNullOrWhiteSpace(Part.ImageLocation) &&
                File.Exists(Part.ImageLocation))
            {
                return Image.FromFile(Part.ImageLocation);
            }
            else if (this.ComponentType == NodeType.Assembly && 
                !string.IsNullOrWhiteSpace(Assembly.ImageLocation) &&
                File.Exists(Assembly.ImageLocation))
            {
                return Image.FromFile(Assembly.ImageLocation);
            }
            return Image.FromFile(workingDirectory + "Assets\\placeholder-small.jpg");
        }
        public Image GetBigImage(string workingDirectory)
        {
            //paima didelę nuotrauką, kuri vaizduojama tabe.
            if (this.ComponentType == NodeType.Part && 
                !string.IsNullOrWhiteSpace(Part.ImageLocation) &&
                File.Exists(Part.ImageLocation))
            {
                return Image.FromFile(Part.ImageLocation);
            }
            else if (this.ComponentType == NodeType.Assembly && 
                !string.IsNullOrWhiteSpace(Assembly.ImageLocation) &&
                File.Exists(Assembly.ImageLocation))
            {
                return Image.FromFile(Assembly.ImageLocation);
            }
            return Image.FromFile(workingDirectory + "Assets\\placeholder-big.jpg");
        }
        public string GetImageLocation()
        {
            //pasiima nuotraukos failo vietą
            if (this.ComponentType == NodeType.Part)
            {
                return Part.ImageLocation;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.ImageLocation;
            }
            return "Unknown";
        }


        public double? GetChildNodeAssemblyDuration()
        {
            //pasiima vaikų bendrą surinkimo laiką (ne iš Solidworks, bet iš programos skaičiavimo rezultatų). 
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.ChildNodeAssemblyDuration;
            }
            return -999;
        }
        public string GetChildNodeAssemblyDurationString()
        {
            //gražina ankstesniame metode suskaičiuotą laiką, tik jį performatuoja į val ir min
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                var time = new Time((double)Assembly.ChildNodeAssemblyDuration);
                string result = "";
                if(time.Hour > 0)
                {
                    result += string.Format("{0}h ", time.Hour.ToString());
                }
                return result + string.Format("{0}min", time.Minute.ToString());
            }
            return "Unknown";
        }
        public double? GetIndividualComponentAssemblyDuration()
        {
            //gražina palaidų komponentų surinkimo laiką
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.IndividualComponentAssemblyDuration;
            }
            return -999;
        }
        public string GetIndividualComponentAssemblyDurationString()
        {
            //ankstesnio metodo suskaičiuotą laiką paverčia į stringą
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                var time = new Time((double)Assembly.IndividualComponentAssemblyDuration);
                string result = "";
                if (time.Hour > 0)
                {
                    result += string.Format("{0}h ", time.Hour.ToString());
                }
                return result + string.Format("{0}min", time.Minute.ToString());
            }
            return "Unknown";
        }
        public double? GetAssemblyToParentNodeDuration()
        {
            //gražina surinkimo į tėvinį assemblingą laiką
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.AssemblyToParentNodeDuration;
            }
            return -999;
        }
        public string GetAssemblyToParentNodeDurationString()
        {
            //ankstesnio metodo gautą laiką pavarčia į stringą
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                var time = new Time((double)Assembly.AssemblyToParentNodeDuration);
                string result = "";
                if (time.Hour > 0)
                {
                    result += string.Format("{0}h ", time.Hour.ToString());
                }
                return result + string.Format("{0}min", time.Minute.ToString());
            }
            return "Unknown";
        }
        public double? GetCombinedAssemblyTime()
        {
            //gražina bendrą assemblingo surinkimo laiką
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.CombinedAssemblyTime;
            }
            return -999;
        }
        public string GetCombinedAssemblyTimeString()
        {
            //ankstesnio metodo gautą laiką paverčia į stringą
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                var time = new Time((double)Assembly.CombinedAssemblyTime);
                string result = "";
                if (time.Hour > 0)
                {
                    result += string.Format("{0}h ", time.Hour.ToString());
                }
                return result + string.Format("{0}min", time.Minute.ToString());
            }
            return "Unknown";
        }

        public double? GetWeldingDuration()
        {
            //gražina suvirinimo laiką
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.WeldingDuration;
            }
            return -999;
        }
        public string GetWeldingDurationString()
        {
            //ankstesnio metodo gautą laiką paverčia į stringą
            if (this.ComponentType == NodeType.Part)
            {
                return null;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                var time = new Time((double)Assembly.WeldingDuration);
                string result = "";
                if (time.Hour > 0)
                {
                    result += string.Format("{0}h ", time.Hour.ToString());
                }
                return result + string.Format("{0}min", time.Minute.ToString());
            }
            return "Unknown";
        }

        public double? GetSurfaceArea()
        {
            //gražina detalės paviršiaus plotą
            if (this.ComponentType == NodeType.Part)
            {
                return Part.SurfaceArea;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return -999;
        }
        public double? GetWeight()
        {
            //gražina detalės svorį
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Weight;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return -999;
        }
        public bool? GetWelded()
        {
            //gražina ar detalė yra virinta
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Welded;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return false;
        }
        public bool? GetBent()
        {
            //gražina ar detalė yra lankstoma
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Bent;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return false;
        }
        public string GetMaterial()
        {
            //gražina detalės medžiagos pavadinimą
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Material;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return "";
            }
            return "Unknown";
        }
        public string GetCoverage()
        {
            //gražina padengimą (dažymas, cinkavimas)
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Coverage;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return "";
            }
            return "Unknown";
        }
        public double? GetPrice()
        {
            //gražina detalės kainą
            if (this.ComponentType == NodeType.Part)
            {
                return Part.Price;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return -999;
        }
        public double? GetSheetThickness()
        {
            //gražina detalės skardos storį
            if (this.ComponentType == NodeType.Part)
            {
                return Part.SheetThickness;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return -999;
        }
        public PartType? GetPartType()
        {
            //gražina detalės tipą, t.y. ar detalė yra Toolbox, Sheet ar Other
            if (this.ComponentType == NodeType.Part)
            {
                return Part.PartType;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return null;
            }
            return null;
        }
        public string GetSupplier()
        {
            //gražina perkamos detales tiekeja
            if (this.ComponentType == NodeType.Part && this.Part.PartType == PartType.Other)
            {
                return Part.OtherPart.Supplier;
            }

            return "";
        }
        public string GetVendorNo()
        {
            //gražina perkamos detales tiekejo numeri
            if (this.ComponentType == NodeType.Part && this.Part.PartType == PartType.Other)
            {
                return Part.OtherPart.VendorNo;
            }

            return "";
        }

        public ModelDoc2 GetSwModel()
        {
            //Pasiima komponento SW modelį.
            if (this.ComponentType == NodeType.Part)
            {
                return Part.swModel;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.swModel;
            }
            return null;
        }

        public Component2 GetSwComp()
        {
            //pasiima Component2 objektą
            if (this.ComponentType == NodeType.Part)
            {
                return Part.swComp;
            }
            else if (this.ComponentType == NodeType.Assembly)
            {
                return Assembly.swComp;
            }
            return null;
        }

        public void CheckIfComponentValuesEmpty()
        {
            if(this.ComponentType == NodeType.Assembly &&
                this.Assembly.ChildNodeAssemblyDuration == 0 &&
                this.Assembly.AssemblyToParentNodeDuration == 0 &&
                this.Assembly.IndividualComponentAssemblyDuration == 0 &&
                this.Assembly.CombinedAssemblyTime == 0 &&
                this.Assembly.WeldingDuration == 0)
            {
                this.SetStatusMessage(StatusMessage.Missing_Params);
            }
            else if (this.ComponentType == NodeType.Part &&
                this.Part.Price == 0)
            {
                //this.SetStatusMessage(StatusMessage.Missing_Params);
            }
            else
            {
                this.SetStatusMessage(StatusMessage.None);
            }
        }

        public void SetStatusMessage(StatusMessage statusMessage)
        {
            this.StatusMessage = statusMessage;
        }
        public StatusMessage GetStatusMessage()
        {
            return this.StatusMessage;
        }
        public Image GetStatusMessageIcon(string workingDirectory)
        {
            switch (this.StatusMessage)
            {
                case StatusMessage.None:
                    return Image.FromFile(workingDirectory + "Assets\\none.jpg");
                case StatusMessage.Success:
                    return Image.FromFile(workingDirectory + "Assets\\success.jpg");
                case StatusMessage.DXF_Error:
                    return Image.FromFile(workingDirectory + "Assets\\warning.jpg");
                case StatusMessage.PDF_Error:
                    return Image.FromFile(workingDirectory + "Assets\\error.jpg");
                case StatusMessage.Missing_Params:
                    return Image.FromFile(workingDirectory + "Assets\\error.jpg");
                default:
                    return Image.FromFile(workingDirectory + "Assets\\none.jpg");
            }            
        }

    }
}
