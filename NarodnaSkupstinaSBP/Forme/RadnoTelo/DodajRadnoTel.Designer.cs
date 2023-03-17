
namespace NarodnaSkupstinaSBP.Forme.RadnoTelo
{
    partial class DodajRadnoTel
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
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblSprat = new System.Windows.Forms.Label();
            this.lblID_Predsednika = new System.Windows.Forms.Label();
            this.lblID_Zamenika = new System.Windows.Forms.Label();
            this.lblTipRadnogTela = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.txtSprat = new System.Windows.Forms.TextBox();
            this.txtIDPredsednika = new System.Windows.Forms.TextBox();
            this.txtIDZamenika = new System.Windows.Forms.TextBox();
            this.cmbTipRadnogTela = new System.Windows.Forms.ComboBox();
            this.btnDodajRadnoTelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(201, 50);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(25, 13);
            this.lblBroj.TabIndex = 0;
            this.lblBroj.Text = "Broj";
            // 
            // lblSprat
            // 
            this.lblSprat.AutoSize = true;
            this.lblSprat.Location = new System.Drawing.Point(194, 88);
            this.lblSprat.Name = "lblSprat";
            this.lblSprat.Size = new System.Drawing.Size(32, 13);
            this.lblSprat.TabIndex = 1;
            this.lblSprat.Text = "Sprat";
            // 
            // lblID_Predsednika
            // 
            this.lblID_Predsednika.AutoSize = true;
            this.lblID_Predsednika.Location = new System.Drawing.Point(148, 129);
            this.lblID_Predsednika.Name = "lblID_Predsednika";
            this.lblID_Predsednika.Size = new System.Drawing.Size(78, 13);
            this.lblID_Predsednika.TabIndex = 2;
            this.lblID_Predsednika.Text = "ID Predsednka";
            // 
            // lblID_Zamenika
            // 
            this.lblID_Zamenika.AutoSize = true;
            this.lblID_Zamenika.Location = new System.Drawing.Point(158, 168);
            this.lblID_Zamenika.Name = "lblID_Zamenika";
            this.lblID_Zamenika.Size = new System.Drawing.Size(68, 13);
            this.lblID_Zamenika.TabIndex = 3;
            this.lblID_Zamenika.Text = "ID Zamenika";
            // 
            // lblTipRadnogTela
            // 
            this.lblTipRadnogTela.AutoSize = true;
            this.lblTipRadnogTela.Location = new System.Drawing.Point(148, 203);
            this.lblTipRadnogTela.Name = "lblTipRadnogTela";
            this.lblTipRadnogTela.Size = new System.Drawing.Size(78, 13);
            this.lblTipRadnogTela.TabIndex = 4;
            this.lblTipRadnogTela.Text = "Tip radnog tela";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(260, 43);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(121, 20);
            this.txtBroj.TabIndex = 5;
            // 
            // txtSprat
            // 
            this.txtSprat.Location = new System.Drawing.Point(260, 81);
            this.txtSprat.Name = "txtSprat";
            this.txtSprat.Size = new System.Drawing.Size(121, 20);
            this.txtSprat.TabIndex = 6;
            // 
            // txtIDPredsednika
            // 
            this.txtIDPredsednika.Location = new System.Drawing.Point(260, 122);
            this.txtIDPredsednika.Name = "txtIDPredsednika";
            this.txtIDPredsednika.Size = new System.Drawing.Size(121, 20);
            this.txtIDPredsednika.TabIndex = 7;
            // 
            // txtIDZamenika
            // 
            this.txtIDZamenika.Location = new System.Drawing.Point(260, 161);
            this.txtIDZamenika.Name = "txtIDZamenika";
            this.txtIDZamenika.Size = new System.Drawing.Size(121, 20);
            this.txtIDZamenika.TabIndex = 8;
            // 
            // cmbTipRadnogTela
            // 
            this.cmbTipRadnogTela.FormattingEnabled = true;
            this.cmbTipRadnogTela.Location = new System.Drawing.Point(260, 195);
            this.cmbTipRadnogTela.Name = "cmbTipRadnogTela";
            this.cmbTipRadnogTela.Size = new System.Drawing.Size(121, 21);
            this.cmbTipRadnogTela.TabIndex = 9;
            // 
            // btnDodajRadnoTelo
            // 
            this.btnDodajRadnoTelo.Location = new System.Drawing.Point(465, 114);
            this.btnDodajRadnoTelo.Name = "btnDodajRadnoTelo";
            this.btnDodajRadnoTelo.Size = new System.Drawing.Size(123, 28);
            this.btnDodajRadnoTelo.TabIndex = 10;
            this.btnDodajRadnoTelo.Text = "Dodaj radno telo";
            this.btnDodajRadnoTelo.UseVisualStyleBackColor = true;
            this.btnDodajRadnoTelo.Click += new System.EventHandler(this.btnDodajRadnoTelo_Click);
            // 
            // DodajRadnoTel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajRadnoTelo);
            this.Controls.Add(this.cmbTipRadnogTela);
            this.Controls.Add(this.txtIDZamenika);
            this.Controls.Add(this.txtIDPredsednika);
            this.Controls.Add(this.txtSprat);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.lblTipRadnogTela);
            this.Controls.Add(this.lblID_Zamenika);
            this.Controls.Add(this.lblID_Predsednika);
            this.Controls.Add(this.lblSprat);
            this.Controls.Add(this.lblBroj);
            this.Name = "DodajRadnoTel";
            this.Text = "DodajRadnoTel";
            this.Load += new System.EventHandler(this.DodajRadnoTel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label lblSprat;
        private System.Windows.Forms.Label lblID_Predsednika;
        private System.Windows.Forms.Label lblID_Zamenika;
        private System.Windows.Forms.Label lblTipRadnogTela;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.TextBox txtSprat;
        private System.Windows.Forms.TextBox txtIDPredsednika;
        private System.Windows.Forms.TextBox txtIDZamenika;
        private System.Windows.Forms.ComboBox cmbTipRadnogTela;
        private System.Windows.Forms.Button btnDodajRadnoTelo;
    }
}