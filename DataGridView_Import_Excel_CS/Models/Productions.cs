using System.Collections.Generic;
using System.Data;

namespace DataGridView_Import_Excel
{

    // Liste over alle produksjonene, hver DataTable er en forside
    public class NordubbProductions
    {
        private List<excelFrontPage> _productions = new List<excelFrontPage>();

        public List<excelFrontPage> productions {
            get { return _productions; }
            set { _productions = value; }
        }
        
    }

    // En serie består av et navn og en liste med Produksjoner
    public class excelFrontPage
    {
        private List<string> _numEpisodes = new List<string>();

        public string seriesName { get; set; }
        public string excelFileName { get; set; }
        public DataTable frontPageDataTable { get; set; }

        public List<string> numEpisodesList
        {
            get { return _numEpisodes; }
            set { _numEpisodes = value; }
        }

        public string trimFilename (string filename)
        {           
            string t = filename.Substring(Utils.dubToolDir.Length);
            t = t.Substring(0, t.Length - 4);
            return t;
        }


    }
        internal class RoleNameAndListOfEpisodes
    {
        // Liste over episoder hvor den rolle hører til
        public List<string> episodes { get; set; }
        public string roleName { get; set; }
    }

    public class Episode
    {
        public string episodeNumber { get; set; }
        public string seriesName { get; set; }
        //public List<Dictionary<string, string>> roleNamesDic { get; set; }
        public List<RoleNameAndNumOfLines> roleNames { get; set; }
    }
    
    public class RoleNameAndNumOfLines
    {
        public string roleName { get; set; }
        public string numOfLines { get; set; }
    }

}