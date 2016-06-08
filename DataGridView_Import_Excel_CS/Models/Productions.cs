using System.Collections.Generic;
using System.Data;

namespace DataGridView_Import_Excel
{
    // Liste over alle produksjonene, hver DataTable er en forside
    public class NordubbProductions
    {
        public List<DataTable> productions { get; set; }
        
    }

    // En serie består av et navn og en liste med Produksjoner
    public class Series
    {
        public string seriesName { get; set; }
        public int numEpisodes { get; set; }
        public List<NordubbProductions> rolesList { get; set; }
    }

    internal class RoleNameAndListOfEpisodes
    {
        // Liste over episoder hvor den rolle hører til
        public List<string> episodes { get; set; }
        public string roleName { get; set; }
    }

    internal class Episode
    {
        public string episodeNumber { get; set; }
        //public List<Dictionary<string, string>> roleNamesDic { get; set; }
        public List<RoleNameAndNumOfLines> roleNames { get; set; }
    }
    
    public class RoleNameAndNumOfLines
    {
        public string roleName { get; set; }
        public string numOfLines { get; set; }
    }
    
}