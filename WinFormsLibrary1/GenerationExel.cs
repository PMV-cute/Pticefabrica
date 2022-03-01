using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;
using WinFormsLibrary1.Entity;

namespace WinFormsLibrary1
{
    public class GenerationExel
    {
        /**/
        public bool Generate(List<List<String>> report, string ways, string dir, string reportname )
        {
            ExcelPackage package = new ExcelPackage();


            var sheet = package.Workbook.Worksheets
                    .Add("Report");

            sheet.Cells["B2"].Value = "Company:";
            sheet.Cells[2, 3].Value = "Птицефабрика 1";
            sheet.Cells["B3"].Value = "Location:";
            sheet.Cells["C3"].Value = "пгт Зимний, ул.Снежная, д.1";
            sheet.Cells["B4"].Value = "Sector:";
            sheet.Cells["C4"].Value = "Производственный";
            sheet.Cells["B5"].Value = "Report type";
            sheet.Cells["C5"].Value = reportname;

            sheet.Cells[8, 2].Value = "Total Count:";
            sheet.Cells[9, 2, 9, 4].LoadFromArrays(new object[][] { new[] { "Capitalization", "SharePrice", "Date" } });
            var row = 10;
            var column = 2;
            var columns = 0;
            foreach (var item in report)
            {
                for(int i = 0; i < item.Count ;i++)
                {
                    sheet.Cells[row, column + i].Value = item[i];
                }
                row++;
                columns = item.Count;
            }
            //sheet.Cells[8, 3].Formula = $"=COUNT(B{10}:B{row})";
            sheet.Cells[8, 3].Value = report.Count;
            //sheet.Cells[1, 1, row, column + 2].AutoFitColumns();
            sheet.Column(2).Width = 20;
            sheet.Column(3).Width = 20;
            sheet.Column(4).Width = 20;
            sheet.Column(5).Width = 20;

            sheet.Cells[9, 4, 9 + report.Count, 4].Style.Numberformat.Format = "yyyy.mm.dd hh:mm:ss";
            sheet.Cells[9, 2, 9 + report.Count, 2].Style.Numberformat.Format = "### ### ### ##0";

            sheet.Column(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            sheet.Cells[9, 3, 9 + report.Count, 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Column(4).Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

            sheet.Cells[8, 2, 8, 4].Style.Font.Bold = true;
            sheet.Cells["B2:C4"].Style.Font.Bold = true;

            sheet.Cells[9, 2, 9 + report.Count, 5].Style.Border.BorderAround(ExcelBorderStyle.Double);
            sheet.Cells[9, 2, 9, 5].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

            var capitalizationChart = sheet.Drawings.AddChart("FindingsChart", OfficeOpenXml.Drawing.Chart.eChartType.Line);
            capitalizationChart.Title.Text = "Capitalization";
            capitalizationChart.SetPosition(7, 0, 5, 0);
            capitalizationChart.SetSize(800, 400);
            var capitalizationData = (ExcelChartSerie)(capitalizationChart.Series.Add(sheet.Cells[$"B10:B{row}"], sheet.Cells[$"D10:D{row}"]));
            capitalizationData.Header = "";

            sheet.Protection.IsProtected = true;

            string path = $@"Y:\{dir}";
            string way = $@"Y:\{dir}\{ways}.xlsx";

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo fi = new FileInfo(way);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            if (!fi.Exists)
            {
                package.SaveAs(fi);
                return true;
            }
            else
                return false;


        }
        
    }
}
