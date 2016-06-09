using DataGridView_Import_Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DataGridView_Import_Excel.Form1;

namespace DataGridView_Import_Excel
{
class ScanFolder
    {
        public static void GetNameFromFirstSheet(string conStr)
        {
            string sheetName;
            //Get the name of the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    con.Close();
                }
            }
            ReadDataFromFirstSheet(conStr, sheetName);                   
        }

        public static void ReadDataFromFirstSheet(string conStr, string sheetName)
        {
            //Read Data from the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        DataTable dt = new DataTable();
                        cmd.CommandText = "SELECT * From [" + sheetName + "]";
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        con.Close();

                        //Populate DataGridView.
                        //dataGrid.DataSource = dt;

                        Variables.theTable = dt;

                        Form1 form = new Form1();
                        form.enableActorSearch(dt);
                        
                    }
                }
            }
            
        }

    
}
}
