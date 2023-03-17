
namespace NarodnaSkupstinaSBP.Forme.Sednica
{
    partial class DodajRadniDan
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
            this.lblBrojPoslanika = new System.Windows.Forms.Label();
            this.txtBrojPoslanika = new System.Windows.Forms.TextBox();
            this.lblPocetakRada = new System.Windows.Forms.Label();
            this.txtPocetakRada = new System.Windows.Forms.TextBox();
            this.lblKrajRada = new System.Windows.Forms.Label();
            this.txtKrajRada = new System.Windows.Forms.TextBox();
            this.btnDodajRadniDan = new System.Windows.Forms.Button();
            this.lblIDSednice = new System.Windows.Forms.Label();
            this.txtIDSednice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBrojPoslanika
            // 
            this.lblBrojPoslanika.AutoSize = true;
            this.lblBrojPoslanika.Location = new System.Drawing.Point(211, 78);
            this.lblBrojPoslanika.Name = "lblBrojPoslanika";
            this.lblBrojPoslanika.Size = new System.Drawing.Size(74, 13);
            this.lblBrojPoslanika.TabIndex = 0;
            this.lblBrojPoslanika.Text = "Broj Poslanika";
            this.lblBrojPoslanika.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBrojPoslanika
            // 
            this.txtBrojPoslanika.Location = new System.Drawing.Point(300, 71);
            this.txtBrojPoslanika.Name = "txtBrojPoslanika";
            this.txtBrojPoslanika.Size = new System.Drawing.Size(149, 20);
            this.txtBrojPoslanika.TabIndex = 1;
            // 
            // lblPocetakRada
            // 
            this.lblPocetakRada.AutoSize = true;
            this.lblPocetakRada.Location = new System.Drawing.Point(211, 126);
            this.lblPocetakRada.Name = "lblPocetakRada";
            this.lblPocetakRada.Size = new System.Drawing.Size(71, 13);
            this.lblPocetakRada.TabIndex = 2;
            this.lblPocetakRada.Text = "Pocetak rada";
            // 
            // txtPocetakRada
            // 
            this.txtPocetakRada.Location = new System.Drawing.Point(300, 119);
            this.txtPocetakRada.Name = "txtPocetakRada";
            this.txtPocetakRada.Size = new System.Drawing.Size(149, 20);
            this.txtPocetakRada.TabIndex = 3;
            // 
            // lblKrajRada
            // 
            this.lblKrajRada.AutoSize = true;
            this.lblKrajRada.Location = new System.Drawing.Point(211, 180);
            this.lblKrajRada.Name = "lblKrajRada";
            this.lblKrajRada.Size = new System.Drawing.Size(49, 13);
            this.lblKrajRada.TabIndex = 4;
            this.lblKrajRada.Text = "Kraj rada";
            // 
            // txtKrajRada
            // 
            this.txtKrajRada.Location = new System.Drawing.Point(300, 173);
            this.txtKrajRada.Name = "txtKrajRada";
            this.txtKrajRada.Size = new System.Drawing.Size(149, 20);
            this.txtKrajRada.TabIndex = 5;
            // 
            // btnDodajRadniDan
            // 
            this.btnDodajRadniDan.Location = new System.Drawing.Point(339, 265);
            this.btnDodajRadniDan.Name = "btnDodajRadniDan";
            this.btnDodajRadniDan.Size = new System.Drawing.Size(110, 23);
            this.btnDodajRadniDan.TabIndex = 6;
            this.btnDodajRadniDan.Text = "Dodaj radni dan";
            this.btnDodajRadniDan.UseVisualStyleBackColor = true;
            this.btnDodajRadniDan.Click += new System.EventHandler(this.btnDodajRadniDan_Click);
            // 
            // lblIDSednice
            // 
            this.lblIDSednice.AutoSize = true;
            this.lblIDSednice.Location = new System.Drawing.Point(211, 223);
            this.lblIDSednice.Name = "lblIDSednice";
            this.lblIDSednice.Size = new System.Drawing.Size(60, 13);
            this.lblIDSednice.TabIndex = 7;
            this.lblIDSednice.Text = "ID Sednice";
            // 
            // txtIDSednice
            // 
            this.txtIDSednice.Location = new System.Drawing.Point(300, 216);
            this.txtIDSednice.Name = "txtIDSednice";
            this.txtIDSednice.Size = new System.Drawing.Size(149, 20);
            this.txtIDSednice.TabIndex = 8;
            // 
            // DodajRadniDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDSednice);
            this.Controls.Add(this.lblIDSednice);
            this.Controls.Add(this.btnDodajRadniDan);
            this.Controls.Add(this.txtKrajRada);
            this.Controls.Add(this.lblKrajRada);
            this.Controls.Add(this.txtPocetakRada);
            this.Controls.Add(this.lblPocetakRada);
            this.Controls.Add(this.txtBrojPoslanika);
            this.Controls.Add(this.lblBrojPoslanika);
            this.Name = "DodajRadniDan";
            this.Text = "DodajRadniDan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrojPoslanika;
        private System.Windows.Forms.TextBox txtBrojPoslanika;
        private System.Windows.Forms.Label lblPocetakRada;
        private System.Windows.Forms.TextBox txtPocetakRada;
        private System.Windows.Forms.Label lblKrajRada;
        private System.Windows.Forms.TextBox txtKrajRada;
        private System.Windows.Forms.Button btnDodajRadniDan;
        private System.Windows.Forms.Label lblIDSednice;
        private System.Windows.Forms.TextBox txtIDSednice;
    }
}