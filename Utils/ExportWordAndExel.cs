using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Janitor_V1.Models;
using Microsoft.Office.Interop.Word;
using OfficeOpenXml;
using SolidWorks.Interop.sldworks;

namespace Janitor_V1.Utils
{
    public class ExportWordAndExel
    {
        public bool ExportViewAsExel(List<Node> filteredObjects, List<OLVColumn> activeColumns, string path, string name)
        {
            try 
            {
                //activeColumns.Sort((x, y) =>  x.Text.CompareTo(y.Text));
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    //HEADER
                    worksheet.Cells[1, 1].Value = "Nr.";
                    for (int i = 1; i <= activeColumns.Count; i++)
                    {
                        worksheet.Cells[1, i+1].Value = activeColumns[i-1].Text;
                    }

                    int row = 1;
                    for (int i = 1; i <= filteredObjects.Count; i++)
                    {
                        Node node = filteredObjects[i-1];
                        row = AddExelRow(row+1, node, activeColumns, worksheet);
                    }

                    //CREATE FILE
                    var fileName = Path.Combine(path, name + ".xlsx");
                    if(!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }
                    File.WriteAllBytes(fileName, package.GetAsByteArray());                    
                }
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        private int AddExelRow(int row, Node node, List<OLVColumn> activeColumns, ExcelWorksheet worksheet)
        {
            int cell = 1;
            //WRITE ROW NUMBER
            worksheet.Cells[row, cell].Value = (row-1).ToString();
            cell++;

            foreach (var column in activeColumns)
            {
                switch (column.Text)
                {
                    case "ComponentName":
                        worksheet.Cells[row, cell].Value = node.GetComponentName();
                        cell++; break;
                    case "ReferencedConfiguration":
                        worksheet.Cells[row, cell].Value = node.GetReferencedConfiguration();
                        cell++; break;
                    case "ComponentID":
                        worksheet.Cells[row, cell].Value = node.GetComponentID();
                        cell++; break;
                    case "ComponentType":
                        worksheet.Cells[row, cell].Value = node.ComponentType.ToString();
                        cell++; break;
                    case "PartType":
                        worksheet.Cells[row, cell].Value = node.GetPartType();
                        cell++; break;
                    case "Combined assembling duration of sub-assemblies":
                        worksheet.Cells[row, cell].Value = node.GetChildNodeAssemblyDurationString();
                        cell++; break;
                    case "Assembling duration of separate components":
                        worksheet.Cells[row, cell].Value = node.GetIndividualComponentAssemblyDurationString();
                        cell++; break;
                    case "Integration to parent assembly duration":
                        worksheet.Cells[row, cell].Value = node.GetAssemblyToParentNodeDurationString();
                        cell++; break;
                    case "Combined assembling time":
                        worksheet.Cells[row, cell].Value = node.GetCombinedAssemblyTimeString();
                        cell++; break;
                    case "Welding duration":
                        worksheet.Cells[row, cell].Value = node.GetWeldingDurationString();
                        cell++; break;
                    case "FileLocation":
                        worksheet.Cells[row, cell].Value = node.GetFileLocation();
                        cell++; break;
                    case "Image":
                        worksheet.Cells[row, cell].Value = node.GetImageLocation();
                        cell++; break;
                    case "Description":
                        worksheet.Cells[row, cell].Value = node.GetDescription();
                        cell++; break;
                    case "SurfaceArea":
                        worksheet.Cells[row, cell].Value = node.GetSurfaceArea();
                        cell++; break;
                    case "Weight":
                        worksheet.Cells[row, cell].Value = node.GetWeight();
                        cell++; break;
                    case "Welded":
                        worksheet.Cells[row, cell].Value = node.GetWelded();
                        cell++; break;
                    case "Bent":
                        worksheet.Cells[row, cell].Value = node.GetBent();
                        cell++; break;
                    case "Material":
                        worksheet.Cells[row, cell].Value = node.GetMaterial();
                        cell++; break;
                    case "Coverage":
                        worksheet.Cells[row, cell].Value = node.GetCoverage();
                        cell++; break;
                    case "Price":
                        worksheet.Cells[row, cell].Value = node.GetPrice();
                        cell++; break;
                    case "PurchasePrice":
                        worksheet.Cells[row, cell].Value = node.GetPurchasePrice();
                        cell++; break;
                    case "Markup":
                        worksheet.Cells[row, cell].Value = node.GetMarkup();
                        cell++; break;
                    case "SheetThickness":
                        worksheet.Cells[row, cell].Value = node.GetSheetThickness();
                        cell++; break;
                    case "Amount":
                        worksheet.Cells[row, cell].Value = node.DuplicateAmount;
                        cell++; break;
                    case "Supplier":
                        worksheet.Cells[row, cell].Value = node.GetSupplier();
                        cell++; break;
                    case "VendorNo":
                        worksheet.Cells[row, cell].Value = node.GetVendorNo();
                        cell++; break;
                    default:
                        cell++; break;
                }
            }
            //if(node.Children.Count > 0)
            //{
            //    foreach (var child in node.Children)
            //    {
            //        row = AddExelRow(row+1, child, activeColumns, worksheet);
            //    }
            //}
            return row;
        }

        public void ExportSheetPartsToWord(List<Node> parts, string workingDirectory, string projectDirectory)
        {
            try
            {
                var templateLocation = Path.Combine(workingDirectory, "Assets\\Templates\\Sheet Components Template.docx");
                if(!File.Exists(templateLocation))
                {
                    MessageBox.Show("Word template missing!\n" + templateLocation);
                }
                var fileDirectory = Path.Combine(projectDirectory, "Word");
                if(!Directory.Exists(fileDirectory))
                {
                    Directory.CreateDirectory(fileDirectory);//Create missing directory
                }
                var fileLocation = Path.Combine(fileDirectory, "Sheet Components.docx");
                var pdfLocation = Path.Combine(fileDirectory, "Sheet Components.pdf");
                if(File.Exists(fileLocation))
                {
                    File.Delete(fileLocation); //Delete existing file
                }
                if (File.Exists(pdfLocation))
                {
                    File.Delete(pdfLocation); //Delete existing file
                }
                File.Copy(templateLocation, fileLocation);

                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Visible = true;
                Document doc = wordApp.Documents.Open(fileLocation);
                doc.Activate();

                Table table = null;
                //FIND LAST TABLE IN DOCUMENT
                foreach (Table table1 in doc.Tables)
                {
                    table = table1;
                }
                if (table == null)
                {
                    return;
                }

                double totalSurface = 0;
                int totalParts = 0;
                for (int i = parts.Count-1; i >= 0; i--)
                {
                    Row newRow = table.Rows.Add(table.Rows[2]);

                    var bent = "Nelanks.";
                    if (parts[i].GetBent() == true)
                    {
                        bent = "Lanks.";
                    }
                    newRow.Cells[1].Range.Text = (i+1).ToString();
                    newRow.Cells[2].Range.Text = parts[i].GetComponentName();
                    newRow.Cells[3].Range.Text = parts[i].GetReferencedConfiguration();
                    newRow.Cells[4].Range.Text = parts[i].GetDescription();
                    newRow.Cells[5].Range.Text = parts[i].GetSheetThickness().ToString();
                    newRow.Cells[6].Range.Text = bent;
                    newRow.Cells[7].Range.Text = parts[i].GetSurfaceArea().ToString();
                    newRow.Cells[8].Range.Text = parts[i].DuplicateAmount.ToString();

                    totalSurface += (double)(parts[i].GetSurfaceArea() ?? 0);
                    totalParts += parts[i].DuplicateAmount;
                }
                //DELETE TEMPLATE ROW
                table.Rows[parts.Count + 2].Delete();
                //WRITE TOTALS
                Row subtotalRow = table.Rows[table.Rows.Count];
                subtotalRow.Cells[subtotalRow.Cells.Count - 1].Range.Text = totalSurface.ToString();
                subtotalRow.Cells[subtotalRow.Cells.Count].Range.Text = totalParts.ToString();
                //ADD DATE
                FindAndReplaceTextInWord(doc, "{date}", DateTime.Now.ToString("yyyy-MM-dd"));

                doc.Save();
                doc.ExportAsFixedFormat(pdfLocation, WdExportFormat.wdExportFormatPDF);
                //doc.Close();
                //wordApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(table);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(doc);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ExportPurchasedPartsToWord(List<Node> parts, string workingDirectory, string projectDirectory)
        {
            try
            {
                var templateLocation = Path.Combine(workingDirectory, "Assets\\Templates\\Purchased Components Template.docx");
                if (!File.Exists(templateLocation))
                {
                    MessageBox.Show("Word template missing!\n" + templateLocation);
                }
                var fileDirectory = Path.Combine(projectDirectory, "Word");
                if (!Directory.Exists(fileDirectory))
                {
                    Directory.CreateDirectory(fileDirectory);//Create missing directory
                }
                var fileLocation = Path.Combine(fileDirectory, "Purchased Components.docx");
                var pdfLocation = Path.Combine(fileDirectory, "Purchased Components.pdf");
                if (File.Exists(fileLocation))
                {
                    File.Delete(fileLocation); //Delete existing file
                }
                if (File.Exists(pdfLocation))
                {
                    File.Delete(pdfLocation); //Delete existing file
                }
                File.Copy(templateLocation, fileLocation);

                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Visible = true;
                Document doc = wordApp.Documents.Open(fileLocation);
                doc.Activate();

                Table table = null;
                //FIND LAST TABLE IN DOCUMENT
                foreach (Table table1 in doc.Tables)
                {
                    table = table1;
                }
                if (table == null)
                {
                    return;
                }
                var totalParts = 0;
                for (int i = parts.Count - 1; i >= 0; i--)
                {
                    Row newRow = table.Rows.Add(table.Rows[2]);

                    newRow.Cells[1].Range.Text = (i + 1).ToString();
                    newRow.Cells[2].Range.Text = parts[i].GetComponentName();
                    newRow.Cells[3].Range.Text = parts[i].GetReferencedConfiguration();
                    newRow.Cells[4].Range.Text = parts[i].GetDescription();
                    newRow.Cells[5].Range.Text = parts[i].Part.OtherPart.Supplier;
                    newRow.Cells[6].Range.Text = parts[i].Part.OtherPart.VendorNo;
                    newRow.Cells[7].Range.Text = parts[i].DuplicateAmount.ToString();
                    newRow.Cells[8].Range.Text = parts[i].GetNotes();

                    totalParts += parts[i].DuplicateAmount;
                }
                //DELETE TEMPLATE ROW
                table.Rows[parts.Count + 2].Delete();
                //ADD DATE
                FindAndReplaceTextInWord(doc, "{date}", DateTime.Now.ToString("yyyy-MM-dd"));
                FindAndReplaceTextInWord(doc, "{component_count}", totalParts.ToString());

                doc.Save();
                doc.ExportAsFixedFormat(pdfLocation, WdExportFormat.wdExportFormatPDF);
                //doc.Close();
                //wordApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(table);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(doc);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        static void FindAndReplaceTextInWord(Document doc, string findText, string replaceText)
        {
            Range range = doc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: findText, ReplaceWith: replaceText, Replace: WdReplace.wdReplaceAll);
        }
    }
}
