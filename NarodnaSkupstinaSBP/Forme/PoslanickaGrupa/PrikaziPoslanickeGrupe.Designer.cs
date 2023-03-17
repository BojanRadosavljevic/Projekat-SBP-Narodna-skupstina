
namespace NarodnaSkupstinaSBP.Forme.PoslanickaGrupa
{
    partial class PrikaziPoslanickeGrupe
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
            this.listaPoslanickihGrupa = new System.Windows.Forms.ListView();
            this.ImePoslanickeGrupe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDPredsednika = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDZamenika = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listaPoslanickihGrupa
            // 
            this.listaPoslanickihGrupa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ImePoslanickeGrupe,
            this.IDPredsednika,
            this.IDZamenika});
            this.listaPoslanickihGrupa.HideSelection = false;
            this.listaPoslanickihGrupa.Location = new System.Drawing.Point(0, 0);
            this.listaPoslanickihGrupa.Name = "listaPoslanickihGrupa";
            this.listaPoslanickihGrupa.Size = new System.Drawing.Size(307, 230);
            this.listaPoslanickihGrupa.TabIndex = 0;
            this.listaPoslanickihGrupa.UseCompatibleStateImageBehavior = false;
            this.listaPoslanickihGrupa.View = System.Windows.Forms.View.Details;
            this.listaPoslanickihGrupa.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ImePoslanickeGrupe
            // 
            this.ImePoslanickeGrupe.Text = "Ime poslanicke grupe";
            this.ImePoslanickeGrupe.Width = 126;
            // 
            // IDPredsednika
            // 
            this.IDPredsednika.Text = "ID predsednika";
            this.IDPredsednika.Width = 94;
            // 
            // IDZamenika
            // 
            this.IDZamenika.Text = "IDZamenika";
            this.IDZamenika.Width = 79;
            // 
            // PrikaziPoslanickeGrupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaPoslanickihGrupa);
            this.Name = "PrikaziPoslanickeGrupe";
            this.Text = "PrikaziPoslanickeGrupe";
            this.Load += new System.EventHandler(this.PrikaziPoslanickeGrupe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaPoslanickihGrupa;
        private System.Windows.Forms.ColumnHeader ImePoslanickeGrupe;
        private System.Windows.Forms.ColumnHeader IDPredsednika;
        private System.Windows.Forms.ColumnHeader IDZamenika;
    }
}