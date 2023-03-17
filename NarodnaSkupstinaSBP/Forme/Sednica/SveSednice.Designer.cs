
namespace NarodnaSkupstinaSBP.Forme.Sednica
{
    partial class SveSednice
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
            this.listaSednica = new System.Windows.Forms.ListView();
            this.IDSednice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrSaziva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrZasedanja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumPocetka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumZavrsetka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajSednicu = new System.Windows.Forms.Button();
            this.btnDodajRadniDan = new System.Windows.Forms.Button();
            this.cmdVanredna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaSednica
            // 
            this.listaSednica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDSednice,
            this.BrSaziva,
            this.BrZasedanja,
            this.DatumPocetka,
            this.DatumZavrsetka});
            this.listaSednica.HideSelection = false;
            this.listaSednica.Location = new System.Drawing.Point(12, 12);
            this.listaSednica.Name = "listaSednica";
            this.listaSednica.Size = new System.Drawing.Size(486, 97);
            this.listaSednica.TabIndex = 0;
            this.listaSednica.UseCompatibleStateImageBehavior = false;
            this.listaSednica.View = System.Windows.Forms.View.Details;
            // 
            // IDSednice
            // 
            this.IDSednice.Text = "ID sednice";
            this.IDSednice.Width = 78;
            // 
            // BrSaziva
            // 
            this.BrSaziva.Text = "Broj saziva";
            this.BrSaziva.Width = 76;
            // 
            // BrZasedanja
            // 
            this.BrZasedanja.Text = "Broj zasedanja";
            this.BrZasedanja.Width = 86;
            // 
            // DatumPocetka
            // 
            this.DatumPocetka.Text = "Datum pocetka";
            this.DatumPocetka.Width = 121;
            // 
            // DatumZavrsetka
            // 
            this.DatumZavrsetka.Text = "Datum zavrsetka";
            this.DatumZavrsetka.Width = 121;
            // 
            // btnDodajSednicu
            // 
            this.btnDodajSednicu.Location = new System.Drawing.Point(607, 12);
            this.btnDodajSednicu.Name = "btnDodajSednicu";
            this.btnDodajSednicu.Size = new System.Drawing.Size(153, 33);
            this.btnDodajSednicu.TabIndex = 1;
            this.btnDodajSednicu.Text = "Dodaj sednicu";
            this.btnDodajSednicu.UseVisualStyleBackColor = true;
            this.btnDodajSednicu.Click += new System.EventHandler(this.btnDodajSednicu_Click);
            // 
            // btnDodajRadniDan
            // 
            this.btnDodajRadniDan.Location = new System.Drawing.Point(607, 90);
            this.btnDodajRadniDan.Name = "btnDodajRadniDan";
            this.btnDodajRadniDan.Size = new System.Drawing.Size(153, 33);
            this.btnDodajRadniDan.TabIndex = 2;
            this.btnDodajRadniDan.Text = "Dodaj radni dan";
            this.btnDodajRadniDan.UseVisualStyleBackColor = true;
            this.btnDodajRadniDan.Click += new System.EventHandler(this.btnDodajRadniDan_Click);
            // 
            // cmdVanredna
            // 
            this.cmdVanredna.Location = new System.Drawing.Point(607, 51);
            this.cmdVanredna.Name = "cmdVanredna";
            this.cmdVanredna.Size = new System.Drawing.Size(153, 33);
            this.cmdVanredna.TabIndex = 3;
            this.cmdVanredna.Text = "Dodaj vanrednu sednicu";
            this.cmdVanredna.UseVisualStyleBackColor = true;
            this.cmdVanredna.Click += new System.EventHandler(this.cmdVanredna_Click);
            // 
            // SveSednice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdVanredna);
            this.Controls.Add(this.btnDodajRadniDan);
            this.Controls.Add(this.btnDodajSednicu);
            this.Controls.Add(this.listaSednica);
            this.Name = "SveSednice";
            this.Text = "SveSednice";
            this.Load += new System.EventHandler(this.SveSednice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaSednica;
        private System.Windows.Forms.ColumnHeader IDSednice;
        private System.Windows.Forms.ColumnHeader BrSaziva;
        private System.Windows.Forms.ColumnHeader BrZasedanja;
        private System.Windows.Forms.ColumnHeader DatumPocetka;
        private System.Windows.Forms.ColumnHeader DatumZavrsetka;
        private System.Windows.Forms.Button btnDodajSednicu;
        private System.Windows.Forms.Button btnDodajRadniDan;
        private System.Windows.Forms.Button cmdVanredna;
    }
}