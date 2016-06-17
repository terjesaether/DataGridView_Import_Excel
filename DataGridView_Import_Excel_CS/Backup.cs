using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NordubbCheckRoles
{
    class Backup
    {
    }

    // FJERNES?
    //private void calculateResultByRole(DataTable dt, string queryActor)
    //{
    //    // Finn første rad med rolle
    //    string currActor = "";
    //    string currEpsLines = "";

    //    string linesTotal;
    //    string linesDone;
    //    string[] linesArray;

    //    var rolesList = new List<RoleNameAndListOfEpisodes>(); // Dette er en liste med karakterer, karakterer har navn og de eps den mangler i

    //    lblChosenDubber.Font = new Font("Arial", 20);
    //    lblChosenDubber.Text = queryActor.ToString().ToUpper();

    //    // Går gjennom alle radene:
    //    for (int i = 5; i < dt.Rows.Count; i++) // i er raden
    //    {
    //        currActor = dt.Rows[i][3].ToString().ToLower(); // Skp i aktuell rad

    //        if (currActor.Contains(queryActor)) // Vi finner en match
    //        {

    //            RoleNameAndListOfEpisodes characters = new RoleNameAndListOfEpisodes(); // Oppretter et ny karakterobjekt
    //            characters.roleName = dt.Rows[i][1].ToString(); // Legger til rollenavnet
    //            characters.episodes = new List<string>();
    //            rolesList.Add(characters);
    //            string epNumber;

    //            for (int j = 4; j < 17; j++) // j er kolonnen, kompansert for 
    //            {
    //                currEpsLines = dt.Rows[i][j].ToString().ToLower();
    //                linesArray = currEpsLines.Split(new char[] { '/' }, StringSplitOptions.None);

    //                if (linesArray.Length == 2)
    //                {
    //                    linesDone = linesArray[0];
    //                    linesTotal = linesArray[1];

    //                    if (Convert.ToInt32(linesTotal) - Convert.ToInt32(linesDone) > 0)
    //                    {
    //                        // Må finne episodenummer i kolonne:
    //                        epNumber = dt.Rows[2][j].ToString();
    //                        characters.episodes.Add(epNumber);

    //                    }
    //                }
    //            }
    //        }
    //    }

    //    PrintResult.printResultByRoles(rolesList, flowLayoutPanel1); // Skriver ut pr rolle          
    //}

    // Lister opp alt -- fjernes?
    //public void calculateRoles(DataTable dt, string searchString)
    //{
    //    int counter = 0;
    //    string currRole = "";
    //    var listRoles = new List<string>();
    //    listRoles.Add("");

    //    for (int i = 0; i < dt.Rows.Count; i++)
    //    {
    //        currRole = dt.Rows[i][3].ToString().ToLower();

    //        if (currRole.Contains(searchString))
    //        {
    //            counter++;
    //        }
    //    }
    //    calculateSearchResultsByEpisode(dt, searchString);
    //}

    // Skal evt fjernes, lister opp etter rollenavn
    internal class RoleNameAndListOfEpisodes
    {
        // Liste over episoder hvor den rollen hører til
        public List<string> episodes { get; set; }
        public string roleName { get; set; }
    }
}
