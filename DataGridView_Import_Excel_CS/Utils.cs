using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGridView_Import_Excel
{
    class Utils
    {
        public static void listFiles(ListBox listbox, ComboBox combobox)
        {
            listbox.Items.Clear();
            combobox.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\dubtool");

            FileInfo[] Files = dinfo.GetFiles("*.xls");

            foreach (FileInfo file in Files)
            {
                listbox.Items.Add(file.Name);
                combobox.Items.Add(file.Name);
            }
        }
    }
}
