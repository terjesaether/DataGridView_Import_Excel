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

        NordubbProductions allProductions = new NordubbProductions();
        DataTable chosenExcelFileDataTable = new DataTable();
        //Utils utils = new Utils();

        public Form1()
        {
            InitializeComponent();         
            //Utils.listFiles(lboxShowFiles, comboListFiles); // slett
            scanDubtoolFolder();
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
            filePath = @"C:\dubtool\"; // this is the path that you are checking.
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
        // Scanner folder og henter inn alle manusene i minnet
        public void scanDubtoolFolder()
        {                      
            string conStr;
            conStr = string.Empty;
            string sheetName;
            string searchString = txtActorName.Text.ToString().ToLower();

            List<string> dtc = new List<string>();
            dtc = getDubtoolFolderContent();
            Utils.listFilesFromMemoryList(dtc, lboxShowFiles, comboListFiles);  // Fyller opp listboksene          

            //switch (extension)
            //{
            //    case ".xls": //Excel 97-03
            //        conStr = string.Format(Excel03ConString, filePath);

            //        break;

            //    case ".xlsx": //Excel 07
            //        conStr = string.Format(Excel07ConString, filePath);
            //        break;
            //}

            //List<DataTable> productionsList = new List<DataTable>();
            //List<excelFrontPage> excelFrontpageList = new List<excelFrontPage>();

            int counter = 0;
            foreach (var excelFile in dtc) // Fylle opp en liste med DataTables
            {            
                conStr = string.Format(Excel03ConString, excelFile);

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
                            //productionsList.Add(dt);
                            var excelFrontPage = new excelFrontPage();
                            excelFrontPage.frontPageDataTable = dt;
                            excelFrontPage.seriesName = dt.Rows[0][0].ToString();
                            excelFrontPage.excelFileName = dtc[counter];
                            counter++;
                            
                            
                            for (int i = 4; i < 16; i++)
                            {                                                             
                                excelFrontPage.numEpisodesList.Add(dt.Rows[2][i].ToString());
                            }
                            allProductions.productions.Add(excelFrontPage);                        
                            con.Close();
                            
                            //dataGridView1.DataSource = dt;
                            
                            
                        }
                    }
                }
            }
            //Populate DataGridView
            //Variables.theTable = dt;
            txtActorName.Visible = true;
            btnCheckActor.Enabled = true;
            //calculateRoles(dt, searchString);
            //calculateResultsByEpisode(dt, searchString);
            
        }
        // Laster inn dir-innhold i en liste i minnet
        public List<string> getDubtoolFolderContent()
        {
            List<string> dtc = new List<string>();
            //DirectoryInfo dinfo = new DirectoryInfo(@"C:\dubtool\");
            DirectoryInfo dinfo = new DirectoryInfo(Utils.dubToolDir);
            
            if (dinfo.Exists)
            {
                FileInfo[] Files = dinfo.GetFiles("*.xls");
                
                foreach (FileInfo file in Files)
                {
                    dtc.Add(dinfo.ToString() + file.Name.ToString());
                    //dtc[c].Replace(@"\\", @"\");
                }
            }
            return dtc;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
{
    string filePath = openFileDialog1.FileName; // Her henter vi filnavnet, kan hentes fra listen
    string extension = Path.GetExtension(filePath);
    string conStr; 
    string sheetName;
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
            //ScanFolder sc = new ScanFolder();
            //sc.GetNameFromFirstSheet(conStr);


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
                        dataGridView1.DataSource = dt;
                        Variables.theTable = dt;
                        txtActorName.Visible = true;
                        btnCheckActor.Enabled = true;

                        //calculateRoles(dt, searchString);
                        calculateSearchResultsByEpisode(dt, searchString);
                    }
                }
            }
        }
        // Lister opp alt -- fjernes?
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
            calculateSearchResultsByEpisode(dt, searchString);
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
            calculateByOneEpisode(chosenExcelFileDataTable, searchString);
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

        public void calculateByOneEpisode(DataTable dt, string searchString)
        {
            List<Episode> episodeList = calculateSearchResultsByEpisode(dt, searchString);
            PrintResult.printResultByEpisode(episodeList, flowLayoutPanel1, "");
        }

        public void calculateAllEpisodes(NordubbProductions productions, string searchString)
        {
            foreach (var item in productions.productions)
            {
                string seriesName = "";                
                
                List<Episode> episodeList = calculateSearchResultsByEpisode(item.frontPageDataTable, searchString);
                if (episodeList.Count > 0)
                {
                    seriesName = item.seriesName.ToString();
                    PrintResult.printResultByEpisode(episodeList, flowLayoutPanel1, seriesName);
                }
                
                // Må gi Utskriften en mulighet til å skrive ut navn på eps
                
            }
            //calculateAllEpisodes
            // Kjøre print for hver episode?
        }

        // Episode består av Episodenummer og Role med antall linjer
        public List<Episode> calculateSearchResultsByEpisode(DataTable dt, string searchString)
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
                                                                       
                                }
                            }
                        }                      
                    }                  
                }
            }

            //PrintResult.printResultByEpisode(episodeList, flowLayoutPanel1);
            return episodeList;
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
            //Utils.listFiles(lboxShowFiles, comboListFiles);
            List<string> dtc = new List<string>();
            dtc = getDubtoolFolderContent();
            Utils.listFilesFromMemoryList(dtc, lboxShowFiles, comboListFiles);
        }

        // == Velger fila som er valgt i dropdown-boks ==
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            //if (comboListFiles.SelectedItem != null)
            if (lboxShowFiles.SelectedItem != null)
            {
                //string selectedFile = comboListFiles.SelectedItem.ToString();
                string selectedFile = lboxShowFiles.SelectedItem.ToString();
                lblFileChosen.Text = "Du har valgt: " + selectedFile;
                lblChosenEpisodeFrontpage.Text = "Du har valgt: " + selectedFile;

                findFileFromSelection(selectedFile);
            }
            else
            {
                lblFileChosen.Text = "Du må velge en fil...";
            }         
        }

        private void findFileFromSelection(string selectedFile)
        {
            foreach (var episode in allProductions.productions)
            {
                if (selectedFile.Contains(episode.trimFilename(episode.excelFileName)))
                {
                    dataGridView1.DataSource = episode.frontPageDataTable;
                    chosenExcelFileDataTable = episode.frontPageDataTable;
                    //calculateAllEpisodes(chosenExcelFileDataTable, txtActorName.Text.ToString());
                    calculateByOneEpisode(chosenExcelFileDataTable, txtActorName.Text.ToString());
                }
            }
        }

        

        private void comboListFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // Åpner for å søke (skrur på knapp osv)
        public void enableActorSearch(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            txtActorName.Visible = true;
            btnCheckActor.Enabled = true;
            string searchString = txtActorName.Text.ToString().ToLower();
            //calculateRoles(dt, searchString);
            calculateSearchResultsByEpisode(dt, searchString);
            
        }

        
    }
}
