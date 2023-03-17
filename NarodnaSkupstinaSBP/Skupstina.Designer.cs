
namespace NarodnaSkupstinaSBP
{
    partial class Skupstina
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdPoslanici = new System.Windows.Forms.Button();
            this.cmdPoslanickeGrupe = new System.Windows.Forms.Button();
            this.cmdPravniAkti = new System.Windows.Forms.Button();
            this.cmdRadnaTela = new System.Windows.Forms.Button();
            this.cmdSednice = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 163);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Narodna skupstina Republike Srbije";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::NarodnaSkupstinaSBP.Properties.Resources.Narodna_skupstina;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmdPoslanici
            // 
            this.cmdPoslanici.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPoslanici.Location = new System.Drawing.Point(12, 170);
            this.cmdPoslanici.Name = "cmdPoslanici";
            this.cmdPoslanici.Size = new System.Drawing.Size(148, 32);
            this.cmdPoslanici.TabIndex = 2;
            this.cmdPoslanici.Text = "Poslanici";
            this.cmdPoslanici.UseVisualStyleBackColor = true;
            this.cmdPoslanici.Click += new System.EventHandler(this.cmdPoslanici_Click);
            // 
            // cmdPoslanickeGrupe
            // 
            this.cmdPoslanickeGrupe.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdPoslanickeGrupe.Location = new System.Drawing.Point(166, 170);
            this.cmdPoslanickeGrupe.Name = "cmdPoslanickeGrupe";
            this.cmdPoslanickeGrupe.Size = new System.Drawing.Size(148, 32);
            this.cmdPoslanickeGrupe.TabIndex = 3;
            this.cmdPoslanickeGrupe.Text = "Poslanicke grupe";
            this.cmdPoslanickeGrupe.UseVisualStyleBackColor = true;
            this.cmdPoslanickeGrupe.Click += new System.EventHandler(this.cmdPoslanickeGrupe_Click);
            // 
            // cmdPravniAkti
            // 
            this.cmdPravniAkti.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdPravniAkti.Location = new System.Drawing.Point(320, 170);
            this.cmdPravniAkti.Name = "cmdPravniAkti";
            this.cmdPravniAkti.Size = new System.Drawing.Size(148, 32);
            this.cmdPravniAkti.TabIndex = 4;
            this.cmdPravniAkti.Text = "Pravni akti";
            this.cmdPravniAkti.UseVisualStyleBackColor = true;
            this.cmdPravniAkti.Click += new System.EventHandler(this.cmdPravniAkti_Click);
            // 
            // cmdRadnaTela
            // 
            this.cmdRadnaTela.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdRadnaTela.Location = new System.Drawing.Point(474, 170);
            this.cmdRadnaTela.Name = "cmdRadnaTela";
            this.cmdRadnaTela.Size = new System.Drawing.Size(148, 32);
            this.cmdRadnaTela.TabIndex = 5;
            this.cmdRadnaTela.Text = "Radna tela";
            this.cmdRadnaTela.UseVisualStyleBackColor = true;
            this.cmdRadnaTela.Click += new System.EventHandler(this.cmdRadnaTela_Click);
            // 
            // cmdSednice
            // 
            this.cmdSednice.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdSednice.Location = new System.Drawing.Point(628, 170);
            this.cmdSednice.Name = "cmdSednice";
            this.cmdSednice.Size = new System.Drawing.Size(148, 32);
            this.cmdSednice.TabIndex = 6;
            this.cmdSednice.Text = "Sednice";
            this.cmdSednice.UseVisualStyleBackColor = true;
            this.cmdSednice.Click += new System.EventHandler(this.cmdSednice_Click);
            // 
            // Skupstina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdSednice);
            this.Controls.Add(this.cmdRadnaTela);
            this.Controls.Add(this.cmdPravniAkti);
            this.Controls.Add(this.cmdPoslanickeGrupe);
            this.Controls.Add(this.cmdPoslanici);
            this.Controls.Add(this.panel1);
            this.Name = "Skupstina";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdPoslanici;
        private System.Windows.Forms.Button cmdPoslanickeGrupe;
        private System.Windows.Forms.Button cmdPravniAkti;
        private System.Windows.Forms.Button cmdRadnaTela;
        private System.Windows.Forms.Button cmdSednice;
    }
}