﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGrPidView_Import_Excel
{
    class ScanFolder
    {
        public static void GetNameFromFirstSheet(string conStr, DataGridView dataGrid)
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
            //ReadDataFromFirstSheet(conStr, sheetName, dataGrid);                   
        }

        public void ReadDataFromFirstSheet(string conStr, string sheetName, DataGridView dataGrid)
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
                        dataGrid.DataSource = dt;

                        Form1.Variables.theTable = dt;

                        //txtActorName.Visible = true;
                       //btnCheckActor.Enabled = true;
                        //string searchString = txtActorName.Text.ToString().ToLower();

                        //Form1.calculateRoles(dt, searchString);
                    }
                }
            }
        }
    }
}
