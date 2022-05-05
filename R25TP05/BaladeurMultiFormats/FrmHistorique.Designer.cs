namespace BaladeurMultiFormats
{
    partial class FrmHistorique
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorique));
            this.picBaladeur = new System.Windows.Forms.PictureBox();
            this.lsvChansons = new System.Windows.Forms.ListView();
            this.clhArtiste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTitre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAnnée = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDélai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNbConsultations = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNbChansons = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numSecondes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNbChansonsDepuis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrRaffraîchir = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBaladeur)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondes)).BeginInit();
            this.SuspendLayout();
            // 
            // picBaladeur
            // 
            this.picBaladeur.Image = ((System.Drawing.Image)(resources.GetObject("picBaladeur.Image")));
            this.picBaladeur.Location = new System.Drawing.Point(1, 3);
            this.picBaladeur.Name = "picBaladeur";
            this.picBaladeur.Size = new System.Drawing.Size(433, 805);
            this.picBaladeur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBaladeur.TabIndex = 4;
            this.picBaladeur.TabStop = false;
            // 
            // lsvChansons
            // 
            this.lsvChansons.BackColor = System.Drawing.Color.Silver;
            this.lsvChansons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvChansons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhArtiste,
            this.clhTitre,
            this.clhAnnée,
            this.clhDélai,
            this.clhNbConsultations});
            this.lsvChansons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lsvChansons.FullRowSelect = true;
            this.lsvChansons.GridLines = true;
            this.lsvChansons.Location = new System.Drawing.Point(30, 55);
            this.lsvChansons.MultiSelect = false;
            this.lsvChansons.Name = "lsvChansons";
            this.lsvChansons.Size = new System.Drawing.Size(376, 640);
            this.lsvChansons.TabIndex = 5;
            this.lsvChansons.UseCompatibleStateImageBehavior = false;
            this.lsvChansons.View = System.Windows.Forms.View.Details;
            // 
            // clhArtiste
            // 
            this.clhArtiste.Text = "Artiste";
            this.clhArtiste.Width = 100;
            // 
            // clhTitre
            // 
            this.clhTitre.Text = "Titre";
            this.clhTitre.Width = 125;
            // 
            // clhAnnée
            // 
            this.clhAnnée.Text = "Année";
            this.clhAnnée.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhAnnée.Width = 43;
            // 
            // clhDélai
            // 
            this.clhDélai.Text = "Délai";
            this.clhDélai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhDélai.Width = 45;
            // 
            // clhNbConsultations
            // 
            this.clhNbConsultations.Text = "NbC";
            this.clhNbConsultations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhNbConsultations.Width = 34;
            // 
            // lblNbChansons
            // 
            this.lblNbChansons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNbChansons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbChansons.Location = new System.Drawing.Point(213, 7);
            this.lblNbChansons.Name = "lblNbChansons";
            this.lblNbChansons.Size = new System.Drawing.Size(44, 20);
            this.lblNbChansons.TabIndex = 95;
            this.lblNbChansons.Text = "0";
            this.lblNbChansons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numSecondes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblNbChansonsDepuis);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNbChansons);
            this.panel1.Location = new System.Drawing.Point(30, 704);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 60);
            this.panel1.TabIndex = 96;
            // 
            // numSecondes
            // 
            this.numSecondes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSecondes.Location = new System.Drawing.Point(212, 33);
            this.numSecondes.Name = "numSecondes";
            this.numSecondes.Size = new System.Drawing.Size(45, 20);
            this.numSecondes.TabIndex = 98;
            this.numSecondes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSecondes.ValueChanged += new System.EventHandler(this.NumSecondes_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "secondes :";
            // 
            // lblNbChansonsDepuis
            // 
            this.lblNbChansonsDepuis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNbChansonsDepuis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbChansonsDepuis.Location = new System.Drawing.Point(328, 32);
            this.lblNbChansonsDepuis.Name = "lblNbChansonsDepuis";
            this.lblNbChansonsDepuis.Size = new System.Drawing.Size(36, 20);
            this.lblNbChansonsDepuis.TabIndex = 99;
            this.lblNbChansonsDepuis.Text = "0";
            this.lblNbChansonsDepuis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "Nombre de chansons consultées depuis :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Nombre de chansons dans l\'historique :";
            // 
            // tmrRaffraîchir
            // 
            this.tmrRaffraîchir.Interval = 1000;
            this.tmrRaffraîchir.Tick += new System.EventHandler(this.TmrRaffraîchir_Tick);
            // 
            // FrmHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 811);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvChansons);
            this.Controls.Add(this.picBaladeur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHistorique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historique de consultation des chansons";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHistorique_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picBaladeur)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBaladeur;
        private System.Windows.Forms.ListView lsvChansons;
        private System.Windows.Forms.ColumnHeader clhArtiste;
        private System.Windows.Forms.ColumnHeader clhTitre;
        private System.Windows.Forms.ColumnHeader clhAnnée;
        private System.Windows.Forms.ColumnHeader clhNbConsultations;
        private System.Windows.Forms.Label lblNbChansons;
        private System.Windows.Forms.ColumnHeader clhDélai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNbChansonsDepuis;
        private System.Windows.Forms.NumericUpDown numSecondes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrRaffraîchir;
    }
}