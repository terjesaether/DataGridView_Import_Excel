using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                    // karakter -> eps nr, eps nr, eps nr....
                }
            }
        }

         public static void printResultByEpisode(List<Episode> episodeList, FlowLayoutPanel resultPanel, string seriesName)
        {
            foreach (var item in episodeList)
            {
                if (item.roleNames.Count > 0)
                {
                    Label lbl = new Label();
                    lbl.Font = new System.Drawing.Font("Arial", 14);
                    string result = seriesName + "\r\n" + "Episode " + item.episodeNumber.ToString() + ": "; ;
                                         
                    result += Environment.NewLine;
                    //lbl.ForeColor = Color.Red;
                    lbl.AutoSize = true;

                    for (int role = 0; role < item.roleNames.Count; role += 1)
                    {
                        //result += item.roleNames[role].ToString() + ": " + item.roleNames[role + 1].ToString() + ", ";
                        result += item.roleNames[role].roleName.ToString() + ": " + item.roleNames[role].numOfLines.ToString() + ", ";

                    }

                    
                    string result2 = result.Substring(0, result.Length - 2);

                    //result += Environment.NewLine;
                    result2 += "\r\n\r\n";
                   
                    lbl.Text = result2;
                    resultPanel.Controls.Add(lbl);
                }
            }
        }

        public static void CalculateAllEpisodes(NordubbProductions productions, FlowLayoutPanel panel)
        {
            foreach (var item in productions.productions)
            {
                //printResultByEpisode(item.frontPageDataTable, panel);
            }
        }
       
    }
}
