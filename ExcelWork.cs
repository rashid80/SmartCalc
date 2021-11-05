using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;

namespace SmartCalc
{
    static class ExcelWork
    {
        [DllImport("user32.dll")]
        static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessId);

        static Process GetExcelProcess(Excel.Application excelApp)
        {
            GetWindowThreadProcessId(excelApp.Hwnd, out int id);
            return Process.GetProcessById(id);
        }

        public static Tuple<bool, string> CreateExcelFile(string fileName)
        {

            bool err = false;
            string errText = "";

            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;

            Process appProcess = GetExcelProcess(excelApp);

            var workBook = excelApp.Workbooks.Add();

            try
            {
                workBook.SaveAs(fileName);
                workBook.Close(true);

                excelApp.Quit();
            }

            catch (Exception e)
            {
                err = true;
                errText = e.ToString();
            }

            workBook = null;
            excelApp = null;

            try
            {
                appProcess.Kill(); //Иначе Excel не закроется
            }
            catch
            {

            }

            return new Tuple<bool, string>(err, errText);

        }


        public static Tuple<bool, string> SaveStringArrayAsExcelFileRow(List<string> ar, string fileName, int firstRow = 0, int firstColumn = 1, bool needBorder=true)
        {

            bool err = false;
            string errText = "Записан файл: "+ fileName;

            Excel.Application excelApp = new Excel.Application(); //создаём приложение Excel
            excelApp.Visible = false;

            Process appProcess = GetExcelProcess(excelApp);

            var workBook = excelApp.Workbooks.Open(fileName);
            var sheet = workBook.Sheets[1];
            Excel.Range range2;

            try
            {
                int currRow = (firstRow == 0) ? sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row + 1 : firstRow;

                for (int col = firstColumn; col <= ar.Count; col++)
                {
                    sheet.Cells[currRow, col] = ar[col-1];

                    if (needBorder)
                    {
                        range2 = (sheet.Cells[currRow, col] as Excel.Range);
                        range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                        range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
                        range2.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
                        range2.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                        range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
                    }

                }


                //range2.Cells.Font.Name = "Times New Roman";
                //Задаем цвет этого диапазона. Необходимо подключить System.Drawing
                //range2.Cells.Font.Color = ColorTranslator.ToOle(Color.Green);
                ////Фоновый цвет
                //range2.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(0xFF, 0xFF, 0xCC));
                ////Расстановка рамок.
                ////Расставляем рамки со всех сторон:


                sheet.Columns.EntireColumn.AutoFit();

                workBook.Close(true);   

                excelApp.Quit();
           }

            catch (Exception e)
            {
                err = true;
                errText = e.ToString();
            }

            range2 = null;
            sheet = null;
            workBook = null;
            excelApp = null;

            try
            {
                appProcess.Kill(); //Иначе Excel не закроется
            }
            catch
            {

            }

            return new Tuple<bool, string>(err, errText);

        }



    }
}
