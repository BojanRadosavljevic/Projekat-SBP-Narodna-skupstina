
namespace NarodnaSkupstinaSBP.Forme.Poslanik
{
    partial class PrikaziPoslanike
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.listaPoslanika = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImeRoditelja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JMBG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MestoStanovanja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MestoRodjenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumRodjenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IzbornaLista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUkupanBrojPoslanika = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listaPoslanika
            // 
            this.listaPoslanika.AllowColumnReorder = true;
            this.listaPoslanika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Ime,
            this.ImeRoditelja,
            this.Prezime,
            this.JMBG,
            this.MestoStanovanja,
            this.Adresa,
            this.MestoRodjenja,
            this.DatumRodjenja,
            this.IzbornaLista});
            this.listaPoslanika.HideSelection = false;
            this.listaPoslanika.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listaPoslanika.Location = new System.Drawing.Point(0, -3);
            this.listaPoslanika.Name = "listaPoslanika";
            this.listaPoslanika.Size = new System.Drawing.Size(734, 376);
            this.listaPoslanika.TabIndex = 0;
            this.listaPoslanika.UseCompatibleStateImageBehavior = false;
            this.listaPoslanika.View = System.Windows.Forms.View.Details;
            this.listaPoslanika.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 41;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            // 
            // ImeRoditelja
            // 
            this.ImeRoditelja.Text = "Ime roditelja";
            this.ImeRoditelja.Width = 77;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            // 
            // JMBG
            // 
            this.JMBG.Text = "JMBG";
            // 
            // MestoStanovanja
            // 
            this.MestoStanovanja.Text = "Mesto stanovanja";
            this.MestoStanovanja.Width = 104;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            // 
            // MestoRodjenja
            // 
            this.MestoRodjenja.Text = "Mesto rodjenja";
            this.MestoRodjenja.Width = 90;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.Text = "Datum rodjenja";
            this.DatumRodjenja.Width = 91;
            // 
            // IzbornaLista
            // 
            this.IzbornaLista.Text = "Izborna lista";
            this.IzbornaLista.Width = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ukupan broj poslanika:";
            // 
            // txtUkupanBrojPoslanika
            // 
            this.txtUkupanBrojPoslanika.Location = new System.Drawing.Point(119, 390);
            this.txtUkupanBrojPoslanika.Name = "txtUkupanBrojPoslanika";
            this.txtUkupanBrojPoslanika.Size = new System.Drawing.Size(100, 20);
            this.txtUkupanBrojPoslanika.TabIndex = 8;
            // 
            // PrikaziPoslanike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUkupanBrojPoslanika);
            this.Controls.Add(this.listaPoslanika);
            this.Name = "PrikaziPoslanike";
            this.Text = "PrikaziPoslanike";
            this.Load += new System.EventHandler(this.PrikaziPoslanike_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaPoslanika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUkupanBrojPoslanika;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader ImeRoditelja;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader JMBG;
        private System.Windows.Forms.ColumnHeader MestoStanovanja;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader MestoRodjenja;
        private System.Windows.Forms.ColumnHeader DatumRodjenja;
        private System.Windows.Forms.ColumnHeader IzbornaLista;
    }
}