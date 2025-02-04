using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace TravDocGen
{
    partial class mainForm
    {
        //Create COM Objects.
        ExcelApp.Application excelApp = new ExcelApp.Application();
        private DataTable dtCountry;
        private DataTable dtDocType;
        private DataTable dtPrintSetup;

        DataTable myTable;
        DataRow myNewRow;

        private string tdPrefix;

        private void loadCountries()
        {
            try
            {
                var GetDirectory = AppContext.BaseDirectory;

                dtCountry = ReadExcel(GetDirectory + "\\Countries.xlsx"); //read excel file

                cmbIssuingState.DataSource = dtCountry;
                cmbIssuingState.DisplayMember = "Country";
                cmbIssuingState.ValueMember = "Country";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setCountry()
        {
            DataRow[] result = dtCountry.Select("cID = '" + cmbIssuingState.SelectedIndex + "'");

            txtDocument.Text = result[0]["Passport"] as string;
            txtStateCode.Text = result[0]["Alpha-3"] as string;
            txtNationality.Text = result[0]["Alpha-3"] as string;
            tdPrefix = result[0]["Alpha-2"] as string;
            txtIssuingAuthority.Text = result[0]["Country"] as string;

        }


        private void loadDocTypes()
        {
            try
            {
                var GetDirectory = AppContext.BaseDirectory;

                dtDocType = ReadExcel(GetDirectory + "\\DocType.xlsx"); //read excel file

                cmbDocType.DataSource = dtDocType;
                cmbDocType.DisplayMember = "DocumentType";
                cmbDocType.ValueMember = "DocumentType";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setDocType()
        {
            DataRow[] result = dtDocType.Select("dID = '" + cmbDocType.SelectedIndex + "'");

            txtType.Text = result[0]["DocumentCode"] as string;


        }

        private void loadPrintSetup()
        {
            try
            {
                var GetDirectory = AppContext.BaseDirectory;
                dtPrintSetup = ReadExcel(GetDirectory + "\\PrintSetup.xlsx"); //read excel file
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ReadExcel(string fileName)
        {
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(fileName);

            try
            {
                //Open Excel file
                ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
                ExcelApp.Range excelRange = excelSheet.UsedRange;

                int rows = excelRange.Rows.Count;
                int cols = excelRange.Columns.Count;

                //Set DataTable Name and Columns Name
                myTable = new DataTable(excelSheet.Name);

                //first row using for heading
                for (int i = 1; i <= cols; i++)
                {
                    myTable.Columns.Add(excelRange.Cells[1, i].Value2.ToString(), typeof(string));
                }

                if (rows > 1)
                {
                    //first row using for heading, start second row for data
                    for (int r = 2; r <= rows; r++)
                    {
                        myNewRow = myTable.NewRow();
                        for (int c = 1; c <= cols; c++)
                        {
                            string cellVal = "";

                            cellVal = Convert.ToString(excelRange.Cells[r, c].Value2); //Added on 2024-Dec-02

                            myNewRow[c - 1] = cellVal;


                        }
                        myTable.Rows.Add(myNewRow);
                    }
                }
                else
                {
                    DataRow newrow = myTable.NewRow();

                    for (int i = 0; i < cols; i++)
                    {
                        newrow[i] = "";
                    }

                    myTable.Rows.Add(newrow);
                }
                return myTable;
            }
            finally
            {
                if (excelBook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelBook);
                excelApp.Quit();
            }
        }


    }
}
