
namespace NarodnaSkupstinaSBP.Forme.PravniAkt
{
    partial class PrikaziZakon
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
            this.listaZakona = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteZakon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaZakona
            // 
            this.listaZakona.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID});
            this.listaZakona.HideSelection = false;
            this.listaZakona.Location = new System.Drawing.Point(12, 12);
            this.listaZakona.Name = "listaZakona";
            this.listaZakona.Size = new System.Drawing.Size(109, 97);
            this.listaZakona.TabIndex = 0;
            this.listaZakona.UseCompatibleStateImageBehavior = false;
            this.listaZakona.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID zakona";
            this.ID.Width = 102;
            // 
            // btnDeleteZakon
            // 
            this.btnDeleteZakon.Location = new System.Drawing.Point(198, 12);
            this.btnDeleteZakon.Name = "btnDeleteZakon";
            this.btnDeleteZakon.Size = new System.Drawing.Size(95, 30);
            this.btnDeleteZakon.TabIndex = 2;
            this.btnDeleteZakon.Text = "Obrisi zakon";
            this.btnDeleteZakon.UseVisualStyleBackColor = true;
            // 
            // PrikaziZakon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteZakon);
            this.Controls.Add(this.listaZakona);
            this.Name = "PrikaziZakon";
            this.Text = "PrikaziZakon";
            this.Load += new System.EventHandler(this.PrikaziZakon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaZakona;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button btnDeleteZakon;
    }
}