namespace MinesweeperForm
{
    partial class FormKonfiguracija
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
            this.lblRedovi = new System.Windows.Forms.Label();
            this.lblKolone = new System.Windows.Forms.Label();
            this.numRed = new System.Windows.Forms.NumericUpDown();
            this.numKolone = new System.Windows.Forms.NumericUpDown();
            this.lblBrMina = new System.Windows.Forms.Label();
            this.numBrMina = new System.Windows.Forms.NumericUpDown();
            this.btnNovaIgra = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrMina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRedovi
            // 
            this.lblRedovi.AutoSize = true;
            this.lblRedovi.Location = new System.Drawing.Point(12, 32);
            this.lblRedovi.Name = "lblRedovi";
            this.lblRedovi.Size = new System.Drawing.Size(44, 13);
            this.lblRedovi.TabIndex = 0;
            this.lblRedovi.Text = "Redovi:";
            // 
            // lblKolone
            // 
            this.lblKolone.AutoSize = true;
            this.lblKolone.Location = new System.Drawing.Point(13, 73);
            this.lblKolone.Name = "lblKolone";
            this.lblKolone.Size = new System.Drawing.Size(43, 13);
            this.lblKolone.TabIndex = 1;
            this.lblKolone.Text = "Kolone:";
            // 
            // numRed
            // 
            this.numRed.Location = new System.Drawing.Point(68, 30);
            this.numRed.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numRed.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numRed.Name = "numRed";
            this.numRed.Size = new System.Drawing.Size(120, 20);
            this.numRed.TabIndex = 2;
            this.numRed.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // numKolone
            // 
            this.numKolone.Location = new System.Drawing.Point(68, 71);
            this.numKolone.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numKolone.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numKolone.Name = "numKolone";
            this.numKolone.Size = new System.Drawing.Size(120, 20);
            this.numKolone.TabIndex = 3;
            this.numKolone.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // lblBrMina
            // 
            this.lblBrMina.AutoSize = true;
            this.lblBrMina.Location = new System.Drawing.Point(3, 114);
            this.lblBrMina.Name = "lblBrMina";
            this.lblBrMina.Size = new System.Drawing.Size(53, 13);
            this.lblBrMina.TabIndex = 4;
            this.lblBrMina.Text = "Broj mina:";
            // 
            // numBrMina
            // 
            this.numBrMina.Location = new System.Drawing.Point(68, 112);
            this.numBrMina.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numBrMina.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBrMina.Name = "numBrMina";
            this.numBrMina.Size = new System.Drawing.Size(120, 20);
            this.numBrMina.TabIndex = 5;
            this.numBrMina.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnNovaIgra
            // 
            this.btnNovaIgra.Location = new System.Drawing.Point(12, 166);
            this.btnNovaIgra.Name = "btnNovaIgra";
            this.btnNovaIgra.Size = new System.Drawing.Size(75, 23);
            this.btnNovaIgra.TabIndex = 6;
            this.btnNovaIgra.Text = "Nova igra";
            this.btnNovaIgra.UseVisualStyleBackColor = true;
            this.btnNovaIgra.Click += new System.EventHandler(this.btnNovaIgra_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(114, 166);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 7;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // FormKonfiguracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 201);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnNovaIgra);
            this.Controls.Add(this.numBrMina);
            this.Controls.Add(this.lblBrMina);
            this.Controls.Add(this.numKolone);
            this.Controls.Add(this.numRed);
            this.Controls.Add(this.lblKolone);
            this.Controls.Add(this.lblRedovi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKonfiguracija";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova igra";
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrMina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRedovi;
        private System.Windows.Forms.Label lblKolone;
        private System.Windows.Forms.NumericUpDown numRed;
        private System.Windows.Forms.NumericUpDown numKolone;
        private System.Windows.Forms.Label lblBrMina;
        private System.Windows.Forms.NumericUpDown numBrMina;
        private System.Windows.Forms.Button btnNovaIgra;
        private System.Windows.Forms.Button btnOtkazi;
    }
}