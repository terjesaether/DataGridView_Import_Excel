using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DataGridView_Import_Excel
{

    class Utils
    {

        public const string dubToolDir = @"C:\dubtool\";

        public static void listFiles(ListBox listbox, ComboBox combobox)
        {
            listbox.Items.Clear();
            combobox.Items.Clear();

            DirectoryInfo dinfo = new DirectoryInfo(dubToolDir);
            if (dinfo.Exists)
            {
                FileInfo[] Files = dinfo.GetFiles("*.xls");
                foreach (FileInfo file in Files)
                {
                    listbox.Items.Add(file.Name);
                    combobox.Items.Add(file.Name);
                }
            }

        }
        // Fyller ut listboks og combobox
        public static void listFilesFromMemoryList(List<string> folderContent, ListBox listbox)
        {
            listbox.Items.Clear();

            string onlyFileName;

            foreach (var file in folderContent)
            {

                onlyFileName = file.Substring(dubToolDir.Length, file.Length - dubToolDir.Length - 4);
                listbox.Items.Add(onlyFileName);
                //combobox.Items.Add(onlyFileName);
            }
        }






    }

}