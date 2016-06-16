using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Drawing;
using DocumentFormat.OpenXml.CustomProperties;
using Microsoft.VisualBasic;
using System.Net.Sockets;
using System.Net;

namespace DataGridView_Import_Excel
{
    public partial class Form1 : Form
    {
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;IMEX=1;HDR=NO'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;IMEX=1;HDR=NO'";

        NordubbProductions allProductions = new NordubbProductions();
        DataTable chosenExcelFileDataTable = new DataTable();
        
        // Dato for å lage en uløpsdato. FInner dagens dato fra nettet
        DateTime expDate = new DateTime(2016, 8, 15);
        //DateTime systemTime = DateTime.Now;
        DateTime systemTime = GetNetworkTime();

        private void Form1_Load(object sender, EventArgs e)
        {
            if (DateTime.Compare(systemTime, expDate) > 0)
            {
                string promptValue = Prompt.ShowDialog("Enter password", "Log in...");
                if (promptValue != "drikk")
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                    Application.Exit();
                }
            }

            allProductions = scanDubtoolFolder();

            flowLayoutPanel1.BackColor = Color.LightBlue;
            //tabControl1.SelectedTab = tabPageSelect;

            lblTotalNumLines.Font = new Font("Arial", 16);
        }


        public Form1()
        {
            InitializeComponent();
                  
        }

        // Globale variabler
        public class Variables
        {
            public static DataTable theTable { get; set; }
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 400,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 300 };
                textBox.PasswordChar = '*';
                Button confirmation = new Button() { Text = "Ok", Left = 250, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Properties.Settings.Default.Save();
        }

       
        private void btnCheckActor_Click(object sender, EventArgs e)
        {
            if (chosenExcelFileDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Velg en serie din løk.");
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                string searchString = txtActorName.Text.ToString().ToLower();
                flowLayoutPanel1.Controls.Clear();
                calculateByOneEpisode(chosenExcelFileDataTable, searchString);
                //calculateAllSeriesAndEpisodes()
            }


        }

        // Velg-fil-knappen
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string filePath;
            //filePath = @"C:\dubtool\"; // this is the path that you are checking.
            filePath = Utils.dubToolDir;
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

        // Scanner folder og henter inn alle manusene i minnet og fyller opp listboks og comboboks
        public NordubbProductions scanDubtoolFolder()
        {   
            string conStr;                     
            conStr = string.Empty;
            string sheetName;
            string searchString = txtActorName.Text.ToString().ToLower();

            List<string> dtc = new List<string>();
            dtc = getDubtoolFolderContent();

            // Fyller opp listboksen og comboboksen:       
            Utils.listFilesFromMemoryList(dtc, lboxShowFiles);
            
            int counter = 0;
            foreach (var excelFile in dtc) // Fylle opp en liste med DataTables
            {
                conStr = string.Format(Excel03ConString, excelFile);

                //Get the name of the First Sheet.
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        try
                        {
                            cmd.Connection = con;
                            con.Open();
                            DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                            sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                            con.Close();
                        }
                        catch (OleDbException e)
                        {
                            MessageBox.Show("Får ikke åpnet en av Excel-filene. Virker som den er åpen et annet sted...", e.Message);
                            break;
                        }
                        
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
                            //sheetName = "Forside";
                            cmd.CommandText = "SELECT * From [" + sheetName + "]";
                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            
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
                            
                        }
                    }
                }
            }           
            return allProductions;
        }
        // Laster inn dir-innhold i en liste i minnet
        public List<string> getDubtoolFolderContent()
        {
            List<string> dtc = new List<string>();            
            DirectoryInfo dinfo = new DirectoryInfo(Utils.dubToolDir);

            if (dinfo.Exists)
            {
                FileInfo[] Files = dinfo.GetFiles("*.xls");

                foreach (FileInfo file in Files)
                {
                    if (file.Extension == ".xls")
                    {
                        dtc.Add(dinfo.ToString() + file.Name.ToString());                       
                    }
                    else
                    {
                        MessageBox.Show("Ser ut som det er noen uvedkommende filer i mappa...", "Fare!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Kan ikke finne Dubtool-mappe...", "Fare!");
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

            //ScanFolder.StartFileScanning(conStr);
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
            
        // Regner ut valgt serie
        public void calculateByOneEpisode(DataTable dt, string searchString)
        {
            List<Episode> episodeList = calculateSearchResultsByEpisode(dt, searchString);

            int totNumLines = PrintResult.printResultByEpisode(episodeList, flowLayoutPanel1, chckIntro);
            decimal t = decimal.Round((Convert.ToDecimal(totNumLines) / 90), 2);
            lblTotalNumLines.Text = "TOTALT antall replikker: " + Convert.ToString(totNumLines) + ". Det vil ta " + t + " timer å dubbe ferdig.";

        }

        // Regner ut alle seriene 
        public void calculateAllSeriesAndEpisodes(NordubbProductions productions, string searchString)
        {
            int totNumLines = 0;
            foreach (var item in productions.productions)
            {
                //string seriesName = "";

                List<Episode> episodeList = calculateSearchResultsByEpisode(item.frontPageDataTable, searchString);

                if (episodeList.Count > 0)
                {
                    //seriesName = item.seriesName.ToString();
                    totNumLines = totNumLines + PrintResult.printResultByEpisode(episodeList, flowLayoutPanel1, chckIntro);
                }

                // Må gi Utskriften en mulighet til å skrive ut navn på eps

            }
            ;
            decimal t = decimal.Round((Convert.ToDecimal(totNumLines) / 90), 2);
            lblTotalNumLines.Text = "TOTALT antall replikker: " + totNumLines.ToString() + ".  Det vil ta " + t + " timer å dubbe ferdig.";       
        }

        // En Episode-class består av Episodenummer og Role med antall linjer
        public List<Episode> calculateSearchResultsByEpisode(DataTable dt, string searchString)
        {
            string currEpsLines = "";
            string linesTotal;
            string linesDone;
            string[] linesArray;

            // Dette er en liste med Episoder, Episoder med en liste over rollene i den episoden
            var episodeList = new List<Episode>();

            lblChosenDubber.Text = searchString.ToString().ToUpper();
            

            // Går gjennom alle kolonnene: [rad][kolonne]
            for (int epColumn = 4; epColumn <= 16; epColumn++)
            {
                int rowCompensation = 0;

                Episode episode = new Episode(); // Oppretter et ny episodeobjekt
                
                episode.seriesName = dt.Rows[0][0].ToString();

                // Sjekker om manuset er i orden: sjekker hvor tittelen står:
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(episode.seriesName))
                    {
                        rowCompensation++;
                        episode.seriesName = dt.Rows[rowCompensation][0].ToString();
                        //break;                    
                    }
                    else
                    {
                        break;
                    }
                }
                episode.episodeNumber = dt.Rows[2+rowCompensation][epColumn].ToString(); // Legger til epnr

                //if (dt.Rows[0][0] == null)
                //{
                //    episode.seriesName = "";
                //}
                //else
                //{
                //    episode.seriesName = dt.Rows[0][0].ToString();                   
                //}

                episode.deliveryDate = dt.Rows[4+rowCompensation][epColumn].ToString();
                episode.roleNames = new List<RoleNameAndNumOfLines>(); // Liste med rollenavn
                episodeList.Add(episode);
                string currentRoleName;
                string currentRoleLineNumbersString;
                
                // Nedover
                for (int row = (5 + rowCompensation); row < dt.Rows.Count; row++)
                {
                    // Hvis kolonnen ikke er tom..
                    if (dt.Rows[row][epColumn] != null) 
                    {
                        // Hvis skuespillercellen inneholder søkestrengen..
                        if (dt.Rows[row][3].ToString().ToLower().Contains(searchString))
                        {
                            // Deler opp replikk-cellen
                            currEpsLines = dt.Rows[row][epColumn].ToString().ToLower();
                            linesArray = currEpsLines.Split(new char[] { '/' }, StringSplitOptions.None);

                            if (linesArray.Length == 2)
                            {
                                linesDone = linesArray[0];
                                linesTotal = linesArray[1];
                                
                                // Sjekker om det er mer enn 0 replikker igjen:
                                if (Convert.ToInt32(linesTotal) - Convert.ToInt32(linesDone) > 0)
                                {
                                    // Finner episodenummer i kolonne:
                                    currentRoleName = dt.Rows[row][1].ToString().ToUpper();
                                    currentRoleLineNumbersString = (Convert.ToInt32(linesTotal) - Convert.ToInt32(linesDone)).ToString();

                                    var r = new RoleNameAndNumOfLines
                                    {
                                        roleName = currentRoleName,
                                        numOfLines = currentRoleLineNumbersString                                        
                                    };

                                    // Legger til rollenavnet i episoden:
                                    episode.roleNames.Add(r);

                                }
                            }
                        }
                    }
                }
            }
           
            return episodeList;
        }


        // Setter enterbutton for søkefelt
        private void txtActorName_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnCheckActor;
        }

        private void btnListFolder_Click(object sender, EventArgs e)
        {
            scanDubtoolFolder();
        }

        
        //private void ScanFolderToMemory()
        //{
        //    List<string> dtc = new List<string>();
        //    dtc = getDubtoolFolderContent();
        //    Utils.listFilesFromMemoryList(dtc, lboxShowFiles, comboListFiles);
        //}

        

        // Laster inn valgte fil/episode i DataTable
        private void findFileFromSelectionAndPrintOut(string selectedFile)
        {
            foreach (var episode in allProductions.productions)
            {
                if (selectedFile.Contains(episode.trimFilename(episode.excelFileName)))
                {
                    dataGridView1.DataSource = episode.frontPageDataTable;
                    chosenExcelFileDataTable = episode.frontPageDataTable;                    
                    calculateByOneEpisode(chosenExcelFileDataTable, txtActorName.Text.ToString());
                    
                }
            }
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

        private void btnCheckAllEps_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string searchString = txtActorName.Text.ToString();
            calculateAllSeriesAndEpisodes(allProductions, searchString);
        }
        

        

        private void btnRescanFolder_Click_1(object sender, EventArgs e)
        {
            scanDubtoolFolder();
        }

        //private void comboListFiles_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string selectedFile = comboListFiles.SelectedItem.ToString();
        //    chooseEpisode(selectedFile);           
        //}
        
        private void lboxShowFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFile = lboxShowFiles.SelectedItem.ToString();
            chooseEpisode(selectedFile);          
        }

        // Finner valgte fil i liste eller combobox
        private void chooseEpisode(string selectedFile)
        {
            lblChosenEpisodeFrontpage.Text = "Du har valgt: " + selectedFile;
            flowLayoutPanel1.Controls.Clear();
            // Laster inn valgte fil inn i minnet og skriver ut
            findFileFromSelectionAndPrintOut(selectedFile);
        }

        public static DateTime GetNetworkTime()
        {
            //default Windows time server
            const string ntpServer = "time.windows.com";

            // NTP message size - 16 bytes of the digest (RFC 2030)
            var ntpData = new byte[48];

            //Setting the Leap Indicator, Version Number and Mode values
            ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

            try
            {
                var addresses = Dns.GetHostEntry(ntpServer).AddressList;

                //The UDP port number assigned to NTP is 123
                var ipEndPoint = new IPEndPoint(addresses[0], 123);
                //NTP uses UDP
                var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                socket.Connect(ipEndPoint);

                //Stops code hang if NTP is blocked
                socket.ReceiveTimeout = 3000;

                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();

                //Offset to get to the "Transmit Timestamp" field (time at which the reply
                //departed the server for the client, in 64-bit timestamp format."
                const byte serverReplyTime = 40;

                //Get the seconds part
                ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

                //Get the seconds fraction
                ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

                //Convert From big-endian to little-endian
                intPart = SwapEndianness(intPart);
                fractPart = SwapEndianness(fractPart);

                var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

                //**UTC** time
                var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

                return networkDateTime.ToLocalTime();
            }
            catch (Exception)
            {
                //MessageBox.Show(e.Message);
                return DateTime.Now;
            }            
        }

        // stackoverflow.com/a/3294698/162671
        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));

        }

        private void btnRescanFolder_Click(object sender, EventArgs e)
        {
            allProductions = scanDubtoolFolder();
        }
    }
}
