namespace MinesweeperForm
{
    partial class FormGlavna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novaIgraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaIgraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm9x9 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm10x10 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm15x15 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOdrediDim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSnimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUcitaj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIzadji = new System.Windows.Forms.ToolStripMenuItem();
            this.krajIgreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tajmer = new System.Windows.Forms.Timer(this.components);
            this.lblBrojMinaValue = new System.Windows.Forms.Label();
            this.lblBrojMina = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblDveTacke = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaIgraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novaIgraToolStripMenuItem
            // 
            this.novaIgraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaIgraToolStripMenuItem1,
            this.tsmSnimi,
            this.tsmUcitaj,
            this.tsmIzadji,
            this.krajIgreToolStripMenuItem});
            this.novaIgraToolStripMenuItem.Name = "novaIgraToolStripMenuItem";
            this.novaIgraToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.novaIgraToolStripMenuItem.Text = "Fajl";
            // 
            // novaIgraToolStripMenuItem1
            // 
            this.novaIgraToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm9x9,
            this.tsm10x10,
            this.tsm15x15,
            this.tsmOdrediDim});
            this.novaIgraToolStripMenuItem1.Name = "novaIgraToolStripMenuItem1";
            this.novaIgraToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.novaIgraToolStripMenuItem1.Text = "Nova igra";
            // 
            // tsm9x9
            // 
            this.tsm9x9.Name = "tsm9x9";
            this.tsm9x9.Size = new System.Drawing.Size(164, 22);
            this.tsm9x9.Text = "9x9";
            this.tsm9x9.Click += new System.EventHandler(this.tsm9x9_Click_1);
            // 
            // tsm10x10
            // 
            this.tsm10x10.Name = "tsm10x10";
            this.tsm10x10.Size = new System.Drawing.Size(164, 22);
            this.tsm10x10.Text = "10x10";
            this.tsm10x10.Click += new System.EventHandler(this.tsm10x10_Click);
            // 
            // tsm15x15
            // 
            this.tsm15x15.Name = "tsm15x15";
            this.tsm15x15.Size = new System.Drawing.Size(164, 22);
            this.tsm15x15.Text = "15x15";
            this.tsm15x15.Click += new System.EventHandler(this.tsm15x15_Click);
            // 
            // tsmOdrediDim
            // 
            this.tsmOdrediDim.Name = "tsmOdrediDim";
            this.tsmOdrediDim.Size = new System.Drawing.Size(164, 22);
            this.tsmOdrediDim.Text = "Odredi dimenzije";
            this.tsmOdrediDim.Click += new System.EventHandler(this.tsmOdrediDim_Click);
            // 
            // tsmSnimi
            // 
            this.tsmSnimi.Name = "tsmSnimi";
            this.tsmSnimi.Size = new System.Drawing.Size(125, 22);
            this.tsmSnimi.Text = "Snimi";
            this.tsmSnimi.Click += new System.EventHandler(this.tsmSnimi_Click);
            // 
            // tsmUcitaj
            // 
            this.tsmUcitaj.Name = "tsmUcitaj";
            this.tsmUcitaj.Size = new System.Drawing.Size(125, 22);
            this.tsmUcitaj.Text = "Ucitaj";
            this.tsmUcitaj.Click += new System.EventHandler(this.tsmUcitaj_Click);
            // 
            // tsmIzadji
            // 
            this.tsmIzadji.Name = "tsmIzadji";
            this.tsmIzadji.Size = new System.Drawing.Size(125, 22);
            this.tsmIzadji.Text = "Izadji";
            this.tsmIzadji.Click += new System.EventHandler(this.izadjiToolStripMenuItem_Click);
            // 
            // krajIgreToolStripMenuItem
            // 
            this.krajIgreToolStripMenuItem.Name = "krajIgreToolStripMenuItem";
            this.krajIgreToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.krajIgreToolStripMenuItem.Text = "Kraj igre";
            this.krajIgreToolStripMenuItem.Click += new System.EventHandler(this.krajIgreToolStripMenuItem_Click);
            // 
            // Tajmer
            // 
            this.Tajmer.Interval = 1000;
            this.Tajmer.Tick += new System.EventHandler(this.Tajmer_Tick);
            // 
            // lblBrojMinaValue
            // 
            this.lblBrojMinaValue.AutoSize = true;
            this.lblBrojMinaValue.Location = new System.Drawing.Point(71, 24);
            this.lblBrojMinaValue.Name = "lblBrojMinaValue";
            this.lblBrojMinaValue.Size = new System.Drawing.Size(48, 13);
            this.lblBrojMinaValue.TabIndex = 2;
            this.lblBrojMinaValue.Text = "BrojMina";
            // 
            // lblBrojMina
            // 
            this.lblBrojMina.AutoSize = true;
            this.lblBrojMina.Location = new System.Drawing.Point(12, 24);
            this.lblBrojMina.Name = "lblBrojMina";
            this.lblBrojMina.Size = new System.Drawing.Size(53, 13);
            this.lblBrojMina.TabIndex = 3;
            this.lblBrojMina.Text = "Broj mina:";
            // 
            // lblMin
            // 
            this.lblMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(196, 24);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Min";
            // 
            // lblSec
            // 
            this.lblSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(226, 24);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(26, 13);
            this.lblSec.TabIndex = 5;
            this.lblSec.Text = "Sec";
            // 
            // lblDveTacke
            // 
            this.lblDveTacke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDveTacke.AutoSize = true;
            this.lblDveTacke.Location = new System.Drawing.Point(215, 24);
            this.lblDveTacke.Name = "lblDveTacke";
            this.lblDveTacke.Size = new System.Drawing.Size(10, 13);
            this.lblDveTacke.TabIndex = 6;
            this.lblDveTacke.Text = ":";
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 310);
            this.Controls.Add(this.lblDveTacke);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblBrojMina);
            this.Controls.Add(this.lblBrojMinaValue);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ",";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGlavna_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaIgraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaIgraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsm9x9;
        private System.Windows.Forms.ToolStripMenuItem tsm10x10;
        private System.Windows.Forms.ToolStripMenuItem tsm15x15;
        private System.Windows.Forms.ToolStripMenuItem tsmSnimi;
        private System.Windows.Forms.ToolStripMenuItem tsmUcitaj;
        private System.Windows.Forms.ToolStripMenuItem tsmIzadji;
        private System.Windows.Forms.Timer Tajmer;
        private System.Windows.Forms.Label lblBrojMinaValue;
        private System.Windows.Forms.Label lblBrojMina;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblDveTacke;
        private System.Windows.Forms.ToolStripMenuItem tsmOdrediDim;
        private System.Windows.Forms.ToolStripMenuItem krajIgreToolStripMenuItem;





    }
}

