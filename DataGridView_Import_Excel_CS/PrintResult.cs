using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DataGridView_Import_Excel
{
    class PrintResult
    {
        public static void printResultByRoles(List<RoleNameAndListOfEpisodes> rolesList, FlowLayoutPanel resultPanel)
        {
            // skrive ut rolesList, som består av rollenavn med tilhørende episoder:
            foreach (var item in rolesList)
            {
                
                if (item.episodes.Count > 0)
                {
                    Label lbl = new Label();
                    lbl.Text = item.roleName.ToString() + " er med i disse eps : ";
                    //lbl.ForeColor = Color.Red;
                    lbl.AutoSize = true;


                    for (int eps = 0; eps < item.episodes.Count; eps++)
                    {
                        lbl.Text += item.episodes[eps].ToString() + ", ";
                    }

                    //lbl.Text += " ";

                    resultPanel.Controls.Add(lbl);
                    //panel1.Controls.Add(lbl);
                    
                }
            }
        }

         public static int printResultByEpisode(List<Episode> episodeList, FlowLayoutPanel resultPanel)
        {
            int totNumLines = 0;
            foreach (var item in episodeList)
            {
                if (item.roleNames.Count > 0)
                {
                    int totNumLinesPrEpisode = 0;
                    Label lbl = new Label();
                    lbl.Font = new Font("Arial", 14);
                    lbl.AutoSize = true;

                    Label lblHeading = new Label();
                    lblHeading.BackColor = Color.Red;
                    lblHeading.ForeColor = Color.Wheat;
                    lblHeading.AutoSize = true;
                    
                    lblHeading.Text = item.seriesName.ToString().ToUpper() + " - " + "Episode " + item.episodeNumber.ToString() + ": ";
                    
                    resultPanel.Controls.Add(lblHeading);

                    string resultTemp = "";
                    //string result = seriesName + "\r\n" + "Episode " + item.episodeNumber.ToString() + ": "; 
                                         
                    resultTemp += Environment.NewLine;
                    

                    for (int role = 0; role < item.roleNames.Count; role += 1)
                    {                        
                        resultTemp += item.roleNames[role].roleName.ToString() + ": " + item.roleNames[role].numOfLines.ToString() + ", ";

                        totNumLinesPrEpisode += Convert.ToInt32(item.roleNames[role].numOfLines);
                        totNumLines += totNumLinesPrEpisode;
                    }
                    // Tar bort komma:
                    string result = resultTemp.Substring(0, resultTemp.Length - 2);
                    result += " || Totalt " + totNumLinesPrEpisode.ToString() + " replikker.";

                    if (totNumLinesPrEpisode < 3)
                    {
                        result += " ..kanskje vi har en pickup her?";
                    }

                    //result += Environment.NewLine;
                    result += "\r\n\r\n";
                   
                    lbl.Text = result;
                    resultPanel.Controls.Add(lbl);
                }
            }
            return totNumLines;
        }

        

        public static void CalculateAllEpisodes(NordubbProductions productions, FlowLayoutPanel resultPanel)
        {
            foreach (var item in productions.productions)
            {
                //printResultByEpisode(item.frontPageDataTable, panel);
            }
        }
       
    }
}
