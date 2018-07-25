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
            this.components = new System.ComponentModel.Container();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 388);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Timer timer1;
    }
}

