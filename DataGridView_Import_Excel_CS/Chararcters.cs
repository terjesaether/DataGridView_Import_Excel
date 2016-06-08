using System.Collections.Generic;

namespace DataGridView_Import_Excel
{
    internal class Chararcter
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