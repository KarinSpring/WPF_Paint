namespace WPF_Paint
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeichernMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeichernAlsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OeffnenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SchliessenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vulcanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aquariumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalwhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blindPandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloKittyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.PnlColor = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LblColor = new System.Windows.Forms.Label();
            this.PnlDraw = new System.Windows.Forms.Panel();
            this.PnlShape = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LblShape = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.PnlColor.SuspendLayout();
            this.PnlShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.themesToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpeichernMenu,
            this.SpeichernAlsMenu,
            this.OeffnenMenu,
            this.SchliessenMenu});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // SpeichernMenu
            // 
            this.SpeichernMenu.Name = "SpeichernMenu";
            this.SpeichernMenu.Size = new System.Drawing.Size(161, 22);
            this.SpeichernMenu.Text = "speichern [S]";
            this.SpeichernMenu.Click += new System.EventHandler(this.SpeichernSToolStripMenuItem_Click);
            // 
            // SpeichernAlsMenu
            // 
            this.SpeichernAlsMenu.Name = "SpeichernAlsMenu";
            this.SpeichernAlsMenu.Size = new System.Drawing.Size(161, 22);
            this.SpeichernAlsMenu.Text = "speichern als [A]";
            this.SpeichernAlsMenu.Click += new System.EventHandler(this.SpeichernAlsAToolStripMenuItem_Click);
            // 
            // OeffnenMenu
            // 
            this.OeffnenMenu.Name = "OeffnenMenu";
            this.OeffnenMenu.Size = new System.Drawing.Size(161, 22);
            this.OeffnenMenu.Text = "öffnen [O]";
            this.OeffnenMenu.Click += new System.EventHandler(this.OeffnenOToolStripMenuItem_Click);
            // 
            // SchliessenMenu
            // 
            this.SchliessenMenu.Name = "SchliessenMenu";
            this.SchliessenMenu.Size = new System.Drawing.Size(161, 22);
            this.SchliessenMenu.Text = "schliessen [X]";
            this.SchliessenMenu.Click += new System.EventHandler(this.SchliessenXToolStripMenuItem_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vulcanoToolStripMenuItem,
            this.aquariumToolStripMenuItem,
            this.forestToolStripMenuItem,
            this.normalwhiteToolStripMenuItem,
            this.blindPandaToolStripMenuItem,
            this.helloKittyToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // vulcanoToolStripMenuItem
            // 
            this.vulcanoToolStripMenuItem.Name = "vulcanoToolStripMenuItem";
            this.vulcanoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.vulcanoToolStripMenuItem.Text = "Vulcano";
            // 
            // aquariumToolStripMenuItem
            // 
            this.aquariumToolStripMenuItem.Name = "aquariumToolStripMenuItem";
            this.aquariumToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.aquariumToolStripMenuItem.Text = "Aquarium";
            // 
            // forestToolStripMenuItem
            // 
            this.forestToolStripMenuItem.Name = "forestToolStripMenuItem";
            this.forestToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.forestToolStripMenuItem.Text = "Forest";
            // 
            // normalwhiteToolStripMenuItem
            // 
            this.normalwhiteToolStripMenuItem.Name = "normalwhiteToolStripMenuItem";
            this.normalwhiteToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.normalwhiteToolStripMenuItem.Text = "Normal";
            // 
            // blindPandaToolStripMenuItem
            // 
            this.blindPandaToolStripMenuItem.Name = "blindPandaToolStripMenuItem";
            this.blindPandaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.blindPandaToolStripMenuItem.Text = "Blind Panda";
            // 
            // helloKittyToolStripMenuItem
            // 
            this.helloKittyToolStripMenuItem.Name = "helloKittyToolStripMenuItem";
            this.helloKittyToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.helloKittyToolStripMenuItem.Text = "Hello Kitty";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // PnlColor
            // 
            this.PnlColor.Controls.Add(this.button9);
            this.PnlColor.Controls.Add(this.button8);
            this.PnlColor.Controls.Add(this.button7);
            this.PnlColor.Controls.Add(this.button6);
            this.PnlColor.Controls.Add(this.button5);
            this.PnlColor.Controls.Add(this.button4);
            this.PnlColor.Controls.Add(this.button3);
            this.PnlColor.Controls.Add(this.button2);
            this.PnlColor.Controls.Add(this.button1);
            this.PnlColor.Controls.Add(this.LblColor);
            this.PnlColor.Location = new System.Drawing.Point(12, 69);
            this.PnlColor.Name = "PnlColor";
            this.PnlColor.Size = new System.Drawing.Size(142, 139);
            this.PnlColor.TabIndex = 1;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(92, 95);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 35);
            this.button9.TabIndex = 13;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(50, 95);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 35);
            this.button8.TabIndex = 12;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 11;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(92, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 10;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(50, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LblColor
            // 
            this.LblColor.AutoSize = true;
            this.LblColor.Location = new System.Drawing.Point(3, 0);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(62, 13);
            this.LblColor.TabIndex = 4;
            this.LblColor.Text = "Farbpallete:";
            // 
            // PnlDraw
            // 
            this.PnlDraw.Location = new System.Drawing.Point(162, 34);
            this.PnlDraw.Name = "PnlDraw";
            this.PnlDraw.Size = new System.Drawing.Size(636, 394);
            this.PnlDraw.TabIndex = 3;
            // 
            // PnlShape
            // 
            this.PnlShape.Controls.Add(this.comboBox1);
            this.PnlShape.Controls.Add(this.LblShape);
            this.PnlShape.Location = new System.Drawing.Point(12, 254);
            this.PnlShape.Name = "PnlShape";
            this.PnlShape.Size = new System.Drawing.Size(142, 126);
            this.PnlShape.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pinsel",
            "Dreieck",
            "Viereck",
            "Kreis"});
            this.comboBox1.Location = new System.Drawing.Point(6, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // LblShape
            // 
            this.LblShape.AutoSize = true;
            this.LblShape.Location = new System.Drawing.Point(3, 0);
            this.LblShape.Name = "LblShape";
            this.LblShape.Size = new System.Drawing.Size(82, 13);
            this.LblShape.TabIndex = 5;
            this.LblShape.Text = "Aktueller Pinsel:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 438);
            this.Controls.Add(this.PnlShape);
            this.Controls.Add(this.PnlDraw);
            this.Controls.Add(this.PnlColor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlColor.ResumeLayout(false);
            this.PnlColor.PerformLayout();
            this.PnlShape.ResumeLayout(false);
            this.PnlShape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpeichernMenu;
        private System.Windows.Forms.ToolStripMenuItem SpeichernAlsMenu;
        private System.Windows.Forms.ToolStripMenuItem OeffnenMenu;
        private System.Windows.Forms.ToolStripMenuItem SchliessenMenu;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vulcanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aquariumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalwhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blindPandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloKittyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel PnlColor;
        private System.Windows.Forms.Panel PnlDraw;
        private System.Windows.Forms.Panel PnlShape;
        private System.Windows.Forms.Label LblShape;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblColor;
    }
}

