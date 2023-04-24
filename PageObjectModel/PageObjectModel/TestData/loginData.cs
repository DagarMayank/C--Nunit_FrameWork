using System;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace PageObjectModel.TestData
{
    class Program
    {
       public static void readData()
        {
            // Open the Excel file
            using (FileStream stream = new FileStream("C:\\Users\\Home\\Desktop\\C# learning\\PageObjectModel\\PageObjectModel\\TestData\\maqdoomAssigment.xlsx", FileMode.Open, FileAccess.Read))
            {
                // Create an instance of the Workbook class
                IWorkbook workbook = WorkbookFactory.Create(stream);

                // Get the worksheet you want to read
                ISheet sheet = workbook.GetSheet("Sheet1");

                // Iterate over the rows and cells in the worksheet
                for (int i = 0; i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);

                    if (row != null)
                    {
                        for (int j = 0; j < row.LastCellNum; j++)
                        {
                            ICell cell = row.GetCell(j);

                            if (cell != null)
                            {
                                Console.WriteLine("Cell ({0}, {1}): {2}", i, j, cell.ToString());
                            }
                        }
                    }
                }
            }
        }
    }
}