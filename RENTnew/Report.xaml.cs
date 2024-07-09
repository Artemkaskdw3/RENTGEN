
using RENTnew.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Diagnostics;
using ClosedXML.Report;
using System.Xaml;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Math;
using Microsoft.Data.SqlClient;
using Microsoft.Win32;


namespace RENTnew
{
    /// <summary>
    /// Логика взаимодействия для Report.xaml
    /// </summary>
    public partial class Report : Window
    {
        public Report()
        {
            InitializeComponent();
         
        }
   


        public static XLWorkbook GenerateReport(List<Reserch> researchData, List<ReserchsName> researchDataName, DateOnly dateStart, DateOnly dateEnd)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Report");

            worksheet.Range(1, 1, 1, 6).Merge().Value = "Рентгенологическая работа";
            worksheet.Cell(1, 1).Style.Font.Bold = true;
            worksheet.Cell(1, 1).Style.Font.FontSize = 14;
            worksheet.Cell(2, 1).Value = $"{dateStart.ToShortDateString()} по {dateEnd.ToShortDateString()}";
            worksheet.Cell(3, 1).Value = "Вид исследования";
            worksheet.Cell(4, 2).Value = "иссл-й";
            worksheet.Cell(4, 3).Value = "Амбул.";
            worksheet.Cell(4, 4).Value = "Стац-р";
            worksheet.Cell(4, 5).Value = "Экстр.";
            worksheet.Cell(4, 6).Value = "сним-в";
            worksheet.Cell(3, 2).Value = "Всего";
            worksheet.Cell(3, 6).Value = "Кол-во";
            worksheet.Range(3, 3, 3, 5).Merge().Value = "Из них";
            worksheet.Range(3, 3, 2, 5).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);


            // Стобцы
            worksheet.Range(3, 1, 4, 6).Style.Font.Bold = true;

            worksheet.Column(1).Width = 40;
            worksheet.Column(2).Width = 8;
            worksheet.Column(3).Width = 8;
            worksheet.Column(4).Width = 8;
            worksheet.Column(5).Width = 8;
            worksheet.Column(6).Width = 8;

            // Запись данных
            int row = 5;
            foreach (var research in researchDataName)
            {
                Console.WriteLine("DATE START   " + dateStart);
                Console.WriteLine("DATE END   " + dateEnd);

                string researchName = research.NameReserch; // Extract NameReserch

                // Filter data based on date range and research type
                int researchCount = researchData.Count(r =>
                    r.NameRerserchId == research.Id &&
                    DateOnly.FromDateTime(r.DateReserch) >= dateStart &&
                    DateOnly.FromDateTime(r.DateReserch) <= dateEnd
                );

                int ambylatornCount = researchData.Count(r =>
                    r.InpatientOutpatient == true &&
                    r.NameRerserchId == research.Id &&
                    DateOnly.FromDateTime(r.DateReserch) >= dateStart &&
                    DateOnly.FromDateTime(r.DateReserch) <= dateEnd
                );

                int stacionarCount = researchData.Count(r =>
                    r.InpatientOutpatient == false &&
                    r.NameRerserchId == research.Id &&
                    DateOnly.FromDateTime(r.DateReserch) >= dateStart &&
                    DateOnly.FromDateTime(r.DateReserch) <= dateEnd
                );

                int emerjencyCount = researchData.Count(r =>
                    r.PlanOrEmerg == true &&
                    r.NameRerserchId == research.Id &&
                    DateOnly.FromDateTime(r.DateReserch) >= dateStart &&
                    DateOnly.FromDateTime(r.DateReserch) <= dateEnd
                );

                int pictureCount = researchData.Where(r => r.NameRerserchId == research.Id && DateOnly.FromDateTime(r.DateReserch) > dateStart && DateOnly.FromDateTime(r.DateReserch) <= dateEnd)
.Select(r => new { Id = r.Id, PictureCount = r.NumOfPicture })
.Sum(r => r.PictureCount);

                if (researchCount <= 0 && ambylatornCount <= 0 && stacionarCount <= 0 && emerjencyCount <= 0 && pictureCount <= 0)
                {
                    continue;
                }
                worksheet.Cell(row, 1).Value = researchName; // Запишите NameReserch
                worksheet.Cell(row, 2).Value = researchCount;
                worksheet.Cell(row, 3).Value = ambylatornCount; // Запишите количество
                worksheet.Cell(row, 4).Value = stacionarCount; // Запишите количество
                worksheet.Cell(row, 5).Value = emerjencyCount; // Запишите количество
                worksheet.Cell(row, 6).Value = pictureCount;

                row++;
            }

            worksheet.Range(3, 1, 3, 6).Style.Border.SetTopBorder(XLBorderStyleValues.Thin);
            worksheet.Cell(row, 1).Style.Border.SetTopBorder(XLBorderStyleValues.Thin); // ИТОГ
            worksheet.Cell(row, 2).Style.Border.SetTopBorder(XLBorderStyleValues.Thin); // ИТОГ
            worksheet.Cell(row, 3).Style.Border.SetTopBorder(XLBorderStyleValues.Thin); // ИТОГ
            worksheet.Cell(row, 4).Style.Border.SetTopBorder(XLBorderStyleValues.Thin); // ИТОГ
            worksheet.Cell(row, 5).Style.Border.SetTopBorder(XLBorderStyleValues.Thin); // ИТОГ
            worksheet.Cell(row, 6).Style.Border.SetTopBorder(XLBorderStyleValues.Thin); // ИТОГ
            worksheet.Range(4, 1, 4, 6).Style.Border.SetBottomBorder(XLBorderStyleValues.Thin);
            worksheet.Range(3, 1, row, 6).Style.Border.SetLeftBorder(XLBorderStyleValues.Thin);
            worksheet.Range(3, 1, row, 6).Style.Border.SetRightBorder(XLBorderStyleValues.Thin);

            int resultReserch = researchData.Count(r => r.NameRerserchId > 0 && DateOnly.FromDateTime(r.DateReserch) >= dateStart && DateOnly.FromDateTime(r.DateReserch) <= dateEnd);
            int ambylatornResult = researchData.Count(r => r.InpatientOutpatient == true && DateOnly.FromDateTime(r.DateReserch) >= dateStart && DateOnly.FromDateTime(r.DateReserch) <= dateEnd);
            int stacionarResult = researchData.Count(r => r.InpatientOutpatient == false && DateOnly.FromDateTime(r.DateReserch) >= dateStart && DateOnly.FromDateTime(r.DateReserch) <= dateEnd);
            int emerjencyResult = researchData.Count(r => r.PlanOrEmerg == true && DateOnly.FromDateTime(r.DateReserch) >= dateStart && DateOnly.FromDateTime(r.DateReserch) <= dateEnd);
            int pictureResult = researchData.Where(r => r.NumOfPicture > 0 && DateOnly.FromDateTime(r.DateReserch) > dateStart && DateOnly.FromDateTime(r.DateReserch) <= dateEnd)
.Select(r => new { Id = r.Id, PictureCount = r.NumOfPicture })
.Sum(r => r.PictureCount);

            worksheet.Cell(row, 1).Value = "Всего рентгенологических исследований";
            worksheet.Cell(row, 2).Value = resultReserch;
            worksheet.Cell(row, 3).Value = ambylatornResult;
            worksheet.Cell(row, 4).Value = stacionarResult;
            worksheet.Cell(row, 5).Value = emerjencyResult;
            worksheet.Cell(row, 6).Value = pictureResult;

            return workbook;
        }

        private void createReportBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateOnly dateStart = new DateOnly();
                DateOnly.TryParse(_maskedTextBox.Text, out dateStart);
                DateOnly dateEnd = new DateOnly();
                DateOnly.TryParse(_maskedTextBox1.Text, out dateEnd);
                var workbook = GenerateReport(Helper.db.Reserchs.Include(x =>x.NameRerserch).ToList(), Helper.db.ReserchsNames.ToList(), dateStart, dateEnd);
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Файлы Excel (*.xlsx)|*.xlsx";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                var result = saveFileDialog.ShowDialog();
               
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Отчет успешно сохранен!");
                
                

            }
            catch (Exception)
            {
                Exception a = new Exception();
                MessageBox.Show(a.ToString());
                throw;
            }
        }


    
    }
}
