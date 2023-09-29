#pragma warning disable IDE0005 // Using directive is unnecessary.
using System;
using OfficeOpenXml;
using System.IO;

#pragma warning restore IDE0005 // Using directive is unnecessary.
namespace Attendance_System
{
	public class FileReader
	{
        private HashSet<Employee> employees = new HashSet<Employee>();
		public FileReader(string file)
		{
            // Specify the path to your Excel file
            string filePath = file;

            // Create a new Excel package
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                // Get the first worksheet in the Excel file
                var worksheet = package.Workbook.Worksheets[0];

                // Determine the number of rows and columns in the worksheet
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;
                
                // Loop through the rows and columns to read data
                for (int row = 1; row <= rowCount; row++)
                {
                    if(!employees.Contains(new Employee((int)worksheet.Cells[row, 1].Value)))
                    {
                        employees.Add(new Employee((int)worksheet.Cells[row, 1].Value));
                        employees.ElementAt(employees.Count() - 1).AddAtt((string)worksheet.Cells[row, 2].Value, (string)worksheet.Cells[row,3].Value, (string)worksheet.Cells[row, 4].Value);

                    }
                    else
                    {
                        foreach(Employee e in employees)
                        {
                            if(e.getID() == (int)worksheet.Cells[row, 1].Value)
                            {
                                e.AddAtt((string)worksheet.Cells[row, 2].Value, (string)worksheet.Cells[row, 3].Value, (string)worksheet.Cells[row, 4].Value);
                            }
                        }
                    }
                    Console.WriteLine(); // Move to the next row
                }
            }

        }
        public HashSet<Employee> GetEmployees()
        {
            return this.employees;
        }
    }
}

