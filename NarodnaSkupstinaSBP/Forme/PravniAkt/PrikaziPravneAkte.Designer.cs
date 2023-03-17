
namespace NarodnaSkupstinaSBP.Forme.PravniAkt
{
    partial class PrikaziPravneAkte
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
            this.btnZakon = new System.Windows.Forms.Button();
            this.btnDeklaracija = new System.Windows.Forms.Button();
            this.btnPreporuka = new System.Windows.Forms.Button();
            this.btnOdluka = new System.Windows.Forms.Button();
            this.btnTumacenje = new System.Windows.Forms.Button();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.cmdPredlagaci = new System.Windows.Forms.ComboBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblPredlozili = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZakon
            // 
            this.btnZakon.Location = new System.Drawing.Point(522, 12);
            this.btnZakon.Name = "btnZakon";
            this.btnZakon.Size = new System.Drawing.Size(237, 52);
            this.btnZakon.TabIndex = 2;
            this.btnZakon.Text = "Zakon";
            this.btnZakon.UseVisualStyleBackColor = true;
            this.btnZakon.Click += new System.EventHandler(this.btnZakon_Click);
            // 
            // btnDeklaracija
            // 
            this.btnDeklaracija.Location = new System.Drawing.Point(522, 70);
            this.btnDeklaracija.Name = "btnDeklaracija";
            this.btnDeklaracija.Size = new System.Drawing.Size(237, 52);
            this.btnDeklaracija.TabIndex = 3;
            this.btnDeklaracija.Text = "Deklaracija";
            this.btnDeklaracija.UseVisualStyleBackColor = true;
            this.btnDeklaracija.Click += new System.EventHandler(this.btnDeklaracija_Click);
            // 
            // btnPreporuka
            // 
            this.btnPreporuka.Location = new System.Drawing.Point(522, 128);
            this.btnPreporuka.Name = "btnPreporuka";
            this.btnPreporuka.Size = new System.Drawing.Size(237, 52);
            this.btnPreporuka.TabIndex = 4;
            this.btnPreporuka.Text = "Preporuka";
            this.btnPreporuka.UseVisualStyleBackColor = true;
            this.btnPreporuka.Click += new System.EventHandler(this.btnPreporuka_Click);
            // 
            // btnOdluka
            // 
            this.btnOdluka.Location = new System.Drawing.Point(522, 186);
            this.btnOdluka.Name = "btnOdluka";
            this.btnOdluka.Size = new System.Drawing.Size(237, 52);
            this.btnOdluka.TabIndex = 5;
            this.btnOdluka.Text = "Odluka";
            this.btnOdluka.UseVisualStyleBackColor = true;
            this.btnOdluka.Click += new System.EventHandler(this.btnOdluka_Click);
            // 
            // btnTumacenje
            // 
            this.btnTumacenje.Location = new System.Drawing.Point(522, 244);
            this.btnTumacenje.Name = "btnTumacenje";
            this.btnTumacenje.Size = new System.Drawing.Size(237, 52);
            this.btnTumacenje.TabIndex = 6;
            this.btnTumacenje.Text = "Tumacenje";
            this.btnTumacenje.UseVisualStyleBackColor = true;
            this.btnTumacenje.Click += new System.EventHandler(this.btnTumacenje_Click);
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Items.AddRange(new object[] {
            "Zakon",
            "Deklaracija",
            "Preporuka",
            "Odluka",
            "Tumacenje"});
            this.cmbTip.Location = new System.Drawing.Point(148, 12);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(121, 21);
            this.cmbTip.TabIndex = 7;
            // 
            // cmdPredlagaci
            // 
            this.cmdPredlagaci.FormattingEnabled = true;
            this.cmdPredlagaci.Location = new System.Drawing.Point(148, 43);
            this.cmdPredlagaci.Name = "cmdPredlagaci";
            this.cmdPredlagaci.Size = new System.Drawing.Size(121, 21);
            this.cmdPredlagaci.TabIndex = 8;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(23, 20);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(60, 13);
            this.lblTip.TabIndex = 9;
            this.lblTip.Text = "Tip zakona";
            // 
            // lblPredlozili
            // 
            this.lblPredlozili.AutoSize = true;
            this.lblPredlozili.Location = new System.Drawing.Point(23, 51);
            this.lblPredlozili.Name = "lblPredlozili";
            this.lblPredlozili.Size = new System.Drawing.Size(57, 13);
            this.lblPredlozili.TabIndex = 10;
            this.lblPredlozili.Text = "Predlagaci";
            // 
            // PrikaziPravneAkte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPredlozili);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.cmdPredlagaci);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.btnTumacenje);
            this.Controls.Add(this.btnOdluka);
            this.Controls.Add(this.btnPreporuka);
            this.Controls.Add(this.btnDeklaracija);
            this.Controls.Add(this.btnZakon);
            this.Name = "PrikaziPravneAkte";
            this.Text = "PrikaziPravneAkte";
            this.Load += new System.EventHandler(this.PrikaziPravneAkte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnZakon;
        private System.Windows.Forms.Button btnDeklaracija;
        private System.Windows.Forms.Button btnPreporuka;
        private System.Windows.Forms.Button btnOdluka;
        private System.Windows.Forms.Button btnTumacenje;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.ComboBox cmdPredlagaci;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblPredlozili;
    }
}