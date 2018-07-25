using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void speichernSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save File in a default folder (Show in MessageBox)
        }

        private void speichernAlsAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save File in a custom folder (Show in MessageBox)
        }

        private void öffnenOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open a existing project
        }

        private void schliessenXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close the current project with MessageBox warning for saving
        }
    }
}
