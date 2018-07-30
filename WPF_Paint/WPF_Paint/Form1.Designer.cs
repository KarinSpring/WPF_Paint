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
            this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NormalMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.VulcanoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AquariumMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ForrestMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BlindMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.KittyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LblShape = new System.Windows.Forms.Label();
            this.DarculaMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenu,
            this.SaveAsMenu,
            this.OpenMenu,
            this.CloseMenu});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // SaveMenu
            // 
            this.SaveMenu.Name = "SaveMenu";
            this.SaveMenu.Size = new System.Drawing.Size(161, 22);
            this.SaveMenu.Text = "speichern [S]";
            this.SaveMenu.Click += new System.EventHandler(this.SaveMenu_Click);
            // 
            // SaveAsMenu
            // 
            this.SaveAsMenu.Name = "SaveAsMenu";
            this.SaveAsMenu.Size = new System.Drawing.Size(161, 22);
            this.SaveAsMenu.Text = "speichern als [A]";
            this.SaveAsMenu.Click += new System.EventHandler(this.SaveAsMenu_Click);
            // 
            // OpenMenu
            // 
            this.OpenMenu.Name = "OpenMenu";
            this.OpenMenu.Size = new System.Drawing.Size(161, 22);
            this.OpenMenu.Text = "öffnen [O]";
            this.OpenMenu.Click += new System.EventHandler(this.OpenMenu_Click);
            // 
            // CloseMenu
            // 
            this.CloseMenu.Name = "CloseMenu";
            this.CloseMenu.Size = new System.Drawing.Size(161, 22);
            this.CloseMenu.Text = "schliessen [X]";
            this.CloseMenu.Click += new System.EventHandler(this.CloseMenu_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NormalMenu,
            this.DarculaMenu,
            this.VulcanoMenu,
            this.AquariumMenu,
            this.ForrestMenu,
            this.BlindMenu,
            this.KittyMenu});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // NormalMenu
            // 
            this.NormalMenu.Name = "NormalMenu";
            this.NormalMenu.Size = new System.Drawing.Size(152, 22);
            this.NormalMenu.Text = "Normal";
            this.NormalMenu.Click += new System.EventHandler(this.NormalMenu_Click);
            // 
            // VulcanoMenu
            // 
            this.VulcanoMenu.Name = "VulcanoMenu";
            this.VulcanoMenu.Size = new System.Drawing.Size(152, 22);
            this.VulcanoMenu.Text = "Vulcano";
            // 
            // AquariumMenu
            // 
            this.AquariumMenu.Name = "AquariumMenu";
            this.AquariumMenu.Size = new System.Drawing.Size(152, 22);
            this.AquariumMenu.Text = "Aquarium";
            // 
            // ForrestMenu
            // 
            this.ForrestMenu.Name = "ForrestMenu";
            this.ForrestMenu.Size = new System.Drawing.Size(152, 22);
            this.ForrestMenu.Text = "Forrest";
            // 
            // BlindMenu
            // 
            this.BlindMenu.Name = "BlindMenu";
            this.BlindMenu.Size = new System.Drawing.Size(152, 22);
            this.BlindMenu.Text = "Blind Panda";
            // 
            // KittyMenu
            // 
            this.KittyMenu.Name = "KittyMenu";
            this.KittyMenu.Size = new System.Drawing.Size(152, 22);
            this.KittyMenu.Text = "Hello Kitty";
            // 
            // HelpMenu
            // 
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "Hilfe";
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
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(50, 95);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 35);
            this.button8.TabIndex = 12;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 11;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(92, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 10;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(50, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
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
            this.PnlDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDraw.Location = new System.Drawing.Point(181, 34);
            this.PnlDraw.Name = "PnlDraw";
            this.PnlDraw.Size = new System.Drawing.Size(617, 394);
            this.PnlDraw.TabIndex = 3;
            // 
            // PnlShape
            // 
            this.PnlShape.Controls.Add(this.button10);
            this.PnlShape.Controls.Add(this.comboBox1);
            this.PnlShape.Controls.Add(this.LblShape);
            this.PnlShape.Location = new System.Drawing.Point(12, 254);
            this.PnlShape.Name = "PnlShape";
            this.PnlShape.Size = new System.Drawing.Size(142, 126);
            this.PnlShape.TabIndex = 2;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.Image = global::WPF_Paint.Properties.Resources.radiergummi2;
            this.button10.Location = new System.Drawing.Point(6, 71);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 52);
            this.button10.TabIndex = 14;
            this.button10.UseVisualStyleBackColor = false;
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
            // DarculaMenu
            // 
            this.DarculaMenu.Name = "DarculaMenu";
            this.DarculaMenu.Size = new System.Drawing.Size(152, 22);
            this.DarculaMenu.Text = "Darcula";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 438);
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
        private System.Windows.Forms.ToolStripMenuItem SaveMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseMenu;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VulcanoMenu;
        private System.Windows.Forms.ToolStripMenuItem AquariumMenu;
        private System.Windows.Forms.ToolStripMenuItem ForrestMenu;
        private System.Windows.Forms.ToolStripMenuItem NormalMenu;
        private System.Windows.Forms.ToolStripMenuItem BlindMenu;
        private System.Windows.Forms.ToolStripMenuItem KittyMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
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
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ToolStripMenuItem DarculaMenu;
    }
}

