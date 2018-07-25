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

namespace WPF_Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SpeichernSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save File in a default folder (Show in MessageBox)
            SavingMethod();
        }

        private void SpeichernAlsAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save File in a custom folder (Show in MessageBox)
        }

        private void OeffnenOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open a existing project
        }

        private void SchliessenXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Messagebox for warning
            DialogResult dialogResult = MessageBox.Show("Ohne Speichern beenden?", "Achtung!", MessageBoxButtons.YesNo);
            //Close without saving
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }

            //Save file to default folder
            else if (dialogResult == DialogResult.No)
            {
                SavingMethod();
            }

        }

        //Ausgelagerte Methoden

        //used in Speichern (Default) and Schliessen (Default save)
        public void SavingMethod()
        {
            string fileName = string.Format("{0}.txt", DateTime.Now.ToString("yyyyMMddhhmm"));
            string Path = @"C:\Users\karin.spring\source\repos\WPF_Paint\testfiles\" + fileName;

            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.WriteLine("Testfile");
            }
            MessageBox.Show("Bild wurde in " + Path + " gespeichert.");
            this.Close();
        }
    }
}
