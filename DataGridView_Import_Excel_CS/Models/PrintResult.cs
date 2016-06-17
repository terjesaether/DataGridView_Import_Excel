using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using NordubbCheckRolesLibrary;

namespace DataGridView_Import_Excel
{
    class PrintResult
    {
        //public static void printResultByRoles(List<RoleNameAndListOfEpisodes> rolesList, FlowLayoutPanel resultPanel)
        //{
        //    // skrive ut rolesList, som består av rollenavn med tilhørende episoder:
        //    foreach (var item in rolesList)
        //    {
                
        //        if (item.episodes.Count > 0)
        //        {
        //            Label lbl = new Label();
        //            lbl.Text = item.roleName.ToString() + " er med i disse eps : ";
        //            //lbl.ForeColor = Color.Red;
        //            lbl.AutoSize = true;

        //            for (int eps = 0; eps < item.episodes.Count; eps++)
        //            {
        //                lbl.Text += item.episodes[eps].ToString() + ", ";
        //            }

        //            //lbl.Text += " ";

        //            resultPanel.Controls.Add(lbl);
        //            //panel1.Controls.Add(lbl);                  
        //        }
        //    }
        //}

         public static int printResultByEpisode(List<Episode> episodeList, FlowLayoutPanel resultPanel, CheckBox checkBoxNoIntro)
        {
            int totNumLines = 0;
            int counter = 0;
            
            foreach (var item in episodeList)
            {
                if (item.roleNames.Count > 0)
                {
                    int totNumLinesPrEpisode = 0;
                    Label lbl = new Label();
                    lbl.Font = new Font("Arial", 14);
                    lbl.AutoSize = true;
                    TimeSpan span = new TimeSpan();
                    string warningText = "";
                    string daysText = " dager.";
                    string deliveryText = "";

                    if (item.deliveryDate.ToString() != "")
                    {
                        try
                        {
                            DateTime deliveryDate = Convert.ToDateTime(item.deliveryDate.ToString());
                            span = deliveryDate.Subtract(DateTime.Now);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Åh heisann! Virker som det er et Excelark som ikke er i orden. Kan det være " + item.seriesName.ToString() + ", ep " + item.episodeNumber.ToString() + " ?");
                            break;
                        }
                        
                        if (span.Days < 5)
                        {
                            warningText = " På tide å KLIPPE!!";
                        }
                        deliveryText = ". Skal leveres om " + span.Days.ToString() + daysText + warningText;
                    }
                                   
                    Label lblHeading = new Label();
                    lblHeading.BackColor = Color.DarkBlue;
                    lblHeading.ForeColor = Color.WhiteSmoke;
                    lblHeading.AutoSize = true;

                    Label lblEpNumber = new Label();
                    lblEpNumber.BackColor = Color.Green;
                    lblEpNumber.ForeColor = Color.WhiteSmoke;
                    lblEpNumber.Font = new Font("Arial", 16);
                    lblEpNumber.AutoSize = true;


                    if (span.Days == 1)
                    {
                        daysText = " dag.";
                    }

                    lblHeading.Text = item.seriesName.ToString().ToUpper() + " - " + "Episode " + item.episodeNumber.ToString() + deliveryText;

                    lblEpNumber.Text = "Ep: " + item.episodeNumber.ToString();
                                                          
                    string resultTemp = "";
                                          
                    resultTemp += Environment.NewLine;
                    
                    for (int role = 0; role < item.roleNames.Count; role += 1)
                    {
                        if (!(checkBoxNoIntro.Checked && (item.roleNames[role].roleName.ToString().ToLower() == "intro" || item.roleNames[role].roleName.ToString().ToLower() == "outro" || item.roleNames[role].roleName.ToString().ToLower() == "plakat")))
                        {
                            resultTemp += item.roleNames[role].roleName.ToString() + ": " + item.roleNames[role].numOfLines.ToString() + ", ";

                            // Regner ut antall replikker
                            totNumLinesPrEpisode += Convert.ToInt32(item.roleNames[role].numOfLines);
                            totNumLines += totNumLinesPrEpisode;
                        }                      
                    }
                    // Tar bort komma:
                    string result = resultTemp.Substring(0, resultTemp.Length - 2);
                    result += " || Totalt " + totNumLinesPrEpisode.ToString() + " rep.";

                    if (totNumLinesPrEpisode > 0)
                    {
                        // Sjekker om få replikker
                        if (totNumLinesPrEpisode < 3)
                        {
                            result += " ..kanskje vi har en pickup her?";
                        }

                        //result += Environment.NewLine;
                        result += "\r\n\r\n";

                        lbl.Text = result;
                        resultPanel.Controls.Add(lblHeading);
                        resultPanel.Controls.Add(lblEpNumber);
                        resultPanel.Controls.Add(lbl);
                    }
                    
                }
                counter++;
            }
            return totNumLines;
        }

        

        //public static void CalculateAllEpisodes(NordubbProductions productions, FlowLayoutPanel resultPanel)
        //{
        //    foreach (var item in productions.productions)
        //    {
        //        //printResultByEpisode(item.frontPageDataTable, panel);
        //    }
        //}
       
    }
}
