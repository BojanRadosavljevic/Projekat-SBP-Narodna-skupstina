
namespace NarodnaSkupstinaSBP.Forme.Sednica
{
    partial class DodajSednicu
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrZasedanja = new System.Windows.Forms.TextBox();
            this.txtBrSaziva = new System.Windows.Forms.TextBox();
            this.dtDatumZavrsetka = new System.Windows.Forms.DateTimePicker();
            this.dtDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.btnDodajSednicu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Broj zasedanja";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Broj saziva";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Datum zavrsetka";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Datum pocetka";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBrZasedanja
            // 
            this.txtBrZasedanja.Location = new System.Drawing.Point(350, 144);
            this.txtBrZasedanja.Name = "txtBrZasedanja";
            this.txtBrZasedanja.Size = new System.Drawing.Size(177, 20);
            this.txtBrZasedanja.TabIndex = 22;
            this.txtBrZasedanja.TextChanged += new System.EventHandler(this.txtBrZasedanja_TextChanged);
            // 
            // txtBrSaziva
            // 
            this.txtBrSaziva.Location = new System.Drawing.Point(350, 118);
            this.txtBrSaziva.Name = "txtBrSaziva";
            this.txtBrSaziva.Size = new System.Drawing.Size(177, 20);
            this.txtBrSaziva.TabIndex = 21;
            this.txtBrSaziva.TextChanged += new System.EventHandler(this.txtBrSaziva_TextChanged);
            // 
            // dtDatumZavrsetka
            // 
            this.dtDatumZavrsetka.Location = new System.Drawing.Point(350, 92);
            this.dtDatumZavrsetka.Name = "dtDatumZavrsetka";
            this.dtDatumZavrsetka.Size = new System.Drawing.Size(177, 20);
            this.dtDatumZavrsetka.TabIndex = 20;
            this.dtDatumZavrsetka.ValueChanged += new System.EventHandler(this.dtDatumZavrsetka_ValueChanged);
            // 
            // dtDatumPocetka
            // 
            this.dtDatumPocetka.Location = new System.Drawing.Point(350, 66);
            this.dtDatumPocetka.Name = "dtDatumPocetka";
            this.dtDatumPocetka.Size = new System.Drawing.Size(177, 20);
            this.dtDatumPocetka.TabIndex = 19;
            this.dtDatumPocetka.ValueChanged += new System.EventHandler(this.dtDatumPocekta_ValueChanged);
            // 
            // btnDodajSednicu
            // 
            this.btnDodajSednicu.Location = new System.Drawing.Point(411, 189);
            this.btnDodajSednicu.Name = "btnDodajSednicu";
            this.btnDodajSednicu.Size = new System.Drawing.Size(116, 23);
            this.btnDodajSednicu.TabIndex = 18;
            this.btnDodajSednicu.Text = "Dodaj sednicu";
            this.btnDodajSednicu.UseVisualStyleBackColor = true;
            this.btnDodajSednicu.Click += new System.EventHandler(this.btnDodajSednicu_Click);
            // 
            // DodajSednicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrZasedanja);
            this.Controls.Add(this.txtBrSaziva);
            this.Controls.Add(this.dtDatumZavrsetka);
            this.Controls.Add(this.dtDatumPocetka);
            this.Controls.Add(this.btnDodajSednicu);
            this.Name = "DodajSednicu";
            this.Text = "DodajSednicu";
            this.Load += new System.EventHandler(this.DodajSednicu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrZasedanja;
        private System.Windows.Forms.TextBox txtBrSaziva;
        private System.Windows.Forms.DateTimePicker dtDatumZavrsetka;
        private System.Windows.Forms.DateTimePicker dtDatumPocetka;
        private System.Windows.Forms.Button btnDodajSednicu;
    }
}