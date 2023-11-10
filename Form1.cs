using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ersh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (location.Text == "") {}
            else {
                string path = location.Text;
                File.WriteAllText(path, source.Text);
            }
        }
    }
}
