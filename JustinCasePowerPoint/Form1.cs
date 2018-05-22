using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustinCasePowerPoint
{
    public partial class Form1 : Form
    {
        public string browse {
            get { return _browse; }
            set
            {
                if(browse != _browse)
                {
                    browse = _browse;
                    label_file_path.Text = browse;
                }
            }
        }
        public string _browse;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            string test = "";
            int size = -1;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                DirectoryInfo d = new DirectoryInfo(folderBrowserDialog1.ToString());

                try
                {
                    foreach(var file in d.GetFiles("*.pptx"))
                    {
                        test = test + file.Name;
                    }
                }
                catch
                {

                }
            }
            label_file_path.Text = test;
        }
    }
}
