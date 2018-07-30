using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WPF_Paint
{
    public partial class Form1 : Form
    {
        /*
         * Some code is used from source 
         * website: https://www.codeproject.com/Tips/811495/Simple-Paint-Application-in-Csharp
         */

        public Form1()
        {
            InitializeComponent();
            g = PnlDraw.CreateGraphics();
        }

        bool startPaint = false;
        Graphics g;
        int? initX = null;
        int? initY = null;
        bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false;

        /*
        * Ausgelagerte Methoden
        */

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



        /*
         * Menu "Datei"
         */

        private void SaveMenu_Click(object sender, EventArgs e)
        {
            //Save File in a default folder (Show in MessageBox)
            SavingMethod();
        }

        private void SaveAsMenu_Click(object sender, EventArgs e)
        {
            //Save File in a custom folder (Show in MessageBox)
        }

        private void OpenMenu_Click(object sender, EventArgs e)
        {
            //Open a existing project
        }

        private void CloseMenu_Click(object sender, EventArgs e)
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


        /*
         * Change Themes
         */

        //Theme "Normal" is activated
        private void NormalMenu_Click(object sender, EventArgs e)
        {
            //Chances Colors
            button1.BackColor = Color.Red;
            button2.BackColor = Color.DarkOrange;
            button3.BackColor = Color.Yellow;
            button4.BackColor = Color.Lime;
            button5.BackColor = Color.Aqua;
            button6.BackColor = Color.Blue;
            button7.BackColor = Color.DarkOrchid;
            button8.BackColor = Color.White;
            button9.BackColor = Color.Black;

            //Changes Activity of Theme add "(aktiv)* and to Bold 
            NormalMenu.Text = NormalMenu.Text + " (aktiv)";
            NormalMenu.Font = new Font(NormalMenu.Font, FontStyle.Bold);
        }





    }
}
