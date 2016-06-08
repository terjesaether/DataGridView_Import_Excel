using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Drawing;




namespace DataGridView_Import_Excel
{
    public partial class Form1 : Form
    {
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;IMEX=1;HDR=NO'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;IMEX=1;HDR=NO'";

        //ScriptView popUpForm = new ScriptView();
        
        

        public Form1()
        {
            InitializeComponent();
            Utils.listFiles(lboxShowFiles, comboListFiles);
            flowLayoutPanel1.BackColor = Color.LightBlue;
            lblChosenDubber.Font = new Font("Arial", 20, FontStyle.Bold);
            lblChosenDubber.ForeColor = Color.Red;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
            string filePath;
            filePath = @"C:\dubtool"; // this is the path that you are checking.
            if (Directory.Exists(filePath))
            {
                openFileDialog1.InitialDirectory = filePath;
            }
            else
            {
                openFileDialog1.InitialDirectory = @"C:\";
            }
            openFileDialog1.ShowDialog();
        }

private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
{
    string filePath = openFileDialog1.FileName; // Her henter vi filnavnet, kan hentes fra listen
    string extension = Path.GetExtension(filePath);
    string conStr; 
    //string sheetName;
    string searchString = txtActorName.Text.ToString().ToLower();

            conStr = string.Empty;
    switch (extension)
    {
        case ".xls": //Excel 97-03
            conStr = string.Format(Excel03ConString, filePath);
                    //conStr = string.Format(Excel03ConString, filePath, header);
            break;

        case ".xlsx": //Excel 07
            conStr = string.Format(Excel07ConString, filePath);
            break;
    }

            ScanFolder.GetNameFromFirstSheet(conStr, dataGridView1);
            
            

    //Get the name of the First Sheet.
    //        using (OleDbConnection con = new OleDbConnection(conStr))
    //{
    //    using (OleDbCommand cmd = new OleDbCommand())
    //    {
    //        cmd.Connection = con;
    //        con.Open();
    //        DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
    //        sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
    //        con.Close();
    //    }
    //}



    //Read Data from the First Sheet.
    using (OleDbConnection con = new OleDbConnection(conStr))
    {
        using (OleDbCommand cmd = new OleDbCommand())
        {
            using (OleDbDataAdapter oda = new OleDbDataAdapter())
            {
                DataTable dt = new DataTable();
                //cmd.CommandText = "SELECT * From [" + sheetName + "]";
                cmd.Connection = con;
                con.Open();
                oda.SelectCommand = cmd;
                oda.Fill(dt);
                con.Close();

                //Populate DataGridView.
                dataGridView1.DataSource = dt;
                Variables.theTable = dt;
                txtActorName.Visible = true;
                btnCheckActor.Enabled = true;
                        
                calculateRoles(dt, searchString);

                    }
                    
                }
    }
}
        // Lister opp alt
        public void calculateRoles(DataTable dt, string searchString)
        {
            int counter = 0;
            string currRole = "";
            var listRoles = new List<string>();
            listRoles.Add("");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                currRole = dt.Rows[i][3].ToString().ToLower();

                if (currRole.Contains(searchString))
                {
                    counter++;
                }              
            }
            
            calculateResultsByEpisode(dt, searchString);
        }
        
        private void calculateResultByRole(DataTable dt, string queryActor)
        {
            // Finn første rad med rolle
            string currActor = "";
            string currEpsLines = "";

            string linesTotal;
            string linesDone;
            string[] linesArray;

            var rolesList = new List<RoleNameAndListOfEpisodes>(); // Dette er en liste med karakterer, karakterer har navn og de eps den mangler i
            
            lblChosenDubber.Font = new Font("Arial", 20);
            lblChosenDubber.Text = queryActor.ToString().ToUpper();
            
            // Går gjennom alle radene:
            for (int i = 5; i < dt.Rows.Count; i++) // i er raden
            {
                currActor = dt.Rows[i][3].ToString().ToLower(); // Skp i aktuell rad
                
                if (currActor.Contains(queryActor)) // Vi finner en match
                {

                    RoleNameAndListOfEpisodes characters = new RoleNameAndListOfEpisodes(); // Oppretter et ny karakterobjekt
                    characters.roleName = dt.Rows[i][1].ToString(); // Legger til rollenavnet
                    characters.episodes = new List<string>();
                    rolesList.Add(characters);
                    string epNumber;

                    for (int j = 4; j < 17; j++) // j er kolonnen, kompansert for 
                    {
                        currEpsLines = dt.Rows[i][j].ToString().ToLower();
                        linesArray = currEpsLines.Split(new char[] { '/' }, StringSplitOptions.None);

                        if (linesArray.Length == 2)
                        {
                            linesDone = linesArray[0];
                            linesTotal = linesArray[1];

                            if (Convert.ToInt32(linesTotal) - Convert.ToInt32(linesDone) > 0)
                            {
                                // Må finne episodenummer i kolonne:
                                epNumber = dt.Rows[2][j].ToString();
                                characters.episodes.Add(epNumber);
                                
                            }
                        }
                    }
                }
            }

            PrintResult.printResultByRoles(rolesList, flowLayoutPanel1); // Skriver ut pr rolle          
        }

        private void btnCheckActor_Click(object sender, EventArgs e)
        {
            string searchString = txtActorName.Text.ToString().ToLower();
            flowLayoutPanel1.Controls.Clear();           
            calculateResultsByEpisode(Variables.theTable, searchString);
        }
        // Globale variabler
        public class Variables
        {
            public static DataTable theTable { get; set; }
        }
     
        private void btnViewScript_Click(object sender, EventArgs e)
        {
            
            if (!dataGridView1.Visible)
            {
                dataGridView1.Visible = true;               
            }
            else
            {
                dataGridView1.Visible = false;             
            }           
        }

        public void calculateResultsByEpisode(DataTable dt, string searchString)
        {
                        
            string currEpsLines = "";            
            string linesTotal;
            string linesDone;
            string[] linesArray;

            var episodeList = new List<Episode>(); // Dette er en liste med Episoder, Episoder med en liste over rollene i den episoden
          
            lblChosenDubber.Text = searchString.ToString().ToUpper();

            // Går gjennom alle kolonnene: [rad][kolonne]
            for (int epColumn = 4; epColumn <= 16; epColumn++)
            {
                Episode episode = new Episode(); // Oppretter et ny episodeobjekt
                episode.episodeNumber = dt.Rows[2][epColumn].ToString(); // Legger til epnr
                episode.roleNames = new List<RoleNameAndNumOfLines>(); // Liste med rollenavn
                episodeList.Add(episode);
                string currentRoleName;
                string currentRoleLineNumbers;
                
                // Nedover
                for (int row = 5; row < dt.Rows.Count; row++)
                {
                    if (dt.Rows[row][epColumn] != null) // Hvis kolonnen ikke er tom
                    {
                        
                        if (dt.Rows[row][3].ToString().ToLower().Contains(searchString))
                        {
                            currEpsLines = dt.Rows[row][epColumn].ToString().ToLower();
                            linesArray = currEpsLines.Split(new char[] { '/' }, StringSplitOptions.None);

                            if (linesArray.Length == 2)
                            {
                                linesDone = linesArray[0];
                                linesTotal = linesArray[1];

                                // Sjekker om det er mer enn 0 replikker igjen:
                                if (Convert.ToInt32(linesTotal) - Convert.ToInt32(linesDone) > 0)
                                {
                                    // Må finne episodenummer i kolonne:
                                    currentRoleName = dt.Rows[row][1].ToString().ToUpper();
                                    currentRoleLineNumbers = (Convert.ToInt32(linesTotal) - Convert.ToInt32(linesDone)).ToString();
                                    
                                    var r = new RoleNameAndNumOfLines
                                    {
                                       roleName = currentRoleName,
                                       numOfLines = currentRoleLineNumbers 
                                    };
                                     
                                    episode.roleNames.Add(r);
                                    //episode.roleNames.Add(currentRoleLineNumbers);                                   
                                }
                            }
                        }                      
                    }                  
                }
            }

            PrintResult.printResultByEpisode(episodeList, flowLayoutPanel1);

        }
            
        
        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtActorName_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnCheckActor;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnListFolder_Click(object sender, EventArgs e)
        {         
            Utils.listFiles(lboxShowFiles, comboListFiles);                    
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            string file = comboListFiles.SelectedItem.ToString();
        }
    }
}
