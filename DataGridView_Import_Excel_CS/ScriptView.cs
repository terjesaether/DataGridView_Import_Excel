using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGrPidView_Import_Excel
{
    public partial class ScriptView : Form
    {
        
        public ScriptView()
        {
            InitializeComponent();
        }
       
        public string myLabelText // Test, viser navn til skuespiller
        {
             set { label1.Text = "Valgt døbber er: " + value.ToUpper(); }
        }

        public DataTable scriptViewDataSource // Setter datasourcen fra form1
        {
            set { gwViewScript.DataSource = value; }
           
        }

    }
    
}
