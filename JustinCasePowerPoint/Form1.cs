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
using JustinCasePowerPoint.Modules;


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
        public int files;


        public string _browse;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                browse = folderBrowserDialog1.SelectedPath;
                DirectoryInfo d = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                files = 0;
                try
                {
                    foreach (var file in d.GetFiles("*.pptx"))
                    {
                        files += 1;
                    }
                    foreach (var file in d.GetFiles("*ppt"))
                    {
                        files += 1;
                    }
                }
                catch
                {

                }
            }
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            progressBar_Working.Visible = true;
            

        }
    }
}
