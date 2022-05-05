namespace BaladeurMultiFormats
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatTousLesFormats = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFormatConvertirVersAAC = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFormatConvertirVersMP3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFormatConvertirVersWMA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecial = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSpécialHistorique = new System.Windows.Forms.ToolStripMenuItem();
            this.picBaladeur = new System.Windows.Forms.PictureBox();
            this.txtParoles = new System.Windows.Forms.TextBox();
            this.lsvChansons = new System.Windows.Forms.ListView();
            this.clhArtiste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTitre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAnnée = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFormat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNbChansons = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaladeur)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuFormatTousLesFormats,
            this.mnuSpecial});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(458, 24);
            this.mnuPrincipal.TabIndex = 2;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.MnuFichierQuitter_Click);
            // 
            // mnuFormatTousLesFormats
            // 
            this.mnuFormatTousLesFormats.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFormatConvertirVersAAC,
            this.MnuFormatConvertirVersMP3,
            this.MnuFormatConvertirVersWMA});
            this.mnuFormatTousLesFormats.Name = "mnuFormatTousLesFormats";
            this.mnuFormatTousLesFormats.Size = new System.Drawing.Size(57, 20);
            this.mnuFormatTousLesFormats.Text = "For&mat";
            // 
            // MnuFormatConvertirVersAAC
            // 
            this.MnuFormatConvertirVersAAC.Name = "MnuFormatConvertirVersAAC";
            this.MnuFormatConvertirVersAAC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.MnuFormatConvertirVersAAC.Size = new System.Drawing.Size(222, 22);
            this.MnuFormatConvertirVersAAC.Text = "Convertir vers &AAC";
            this.MnuFormatConvertirVersAAC.Click += new System.EventHandler(this.MnuFormatConvertirVersAAC_Click);
            // 
            // MnuFormatConvertirVersMP3
            // 
            this.MnuFormatConvertirVersMP3.Name = "MnuFormatConvertirVersMP3";
            this.MnuFormatConvertirVersMP3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.MnuFormatConvertirVersMP3.Size = new System.Drawing.Size(222, 22);
            this.MnuFormatConvertirVersMP3.Text = "Convertir vers &MP3";
            this.MnuFormatConvertirVersMP3.Click += new System.EventHandler(this.MnuFormatConvertirVersMP3_Click);
            // 
            // MnuFormatConvertirVersWMA
            // 
            this.MnuFormatConvertirVersWMA.Name = "MnuFormatConvertirVersWMA";
            this.MnuFormatConvertirVersWMA.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.MnuFormatConvertirVersWMA.Size = new System.Drawing.Size(222, 22);
            this.MnuFormatConvertirVersWMA.Text = "Convertir vers &WMA";
            this.MnuFormatConvertirVersWMA.Click += new System.EventHandler(this.MnuFormatConvertirVersWMA_Click);
            // 
            // mnuSpecial
            // 
            this.mnuSpecial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSpécialHistorique});
            this.mnuSpecial.Name = "mnuSpecial";
            this.mnuSpecial.Size = new System.Drawing.Size(56, 20);
            this.mnuSpecial.Text = "&Spécial";
            // 
            // MnuSpécialHistorique
            // 
            this.MnuSpécialHistorique.Name = "MnuSpécialHistorique";
            this.MnuSpécialHistorique.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.MnuSpécialHistorique.Size = new System.Drawing.Size(266, 22);
            this.MnuSpécialHistorique.Text = "Historique de consultation...";
            this.MnuSpécialHistorique.Click += new System.EventHandler(this.MnuSpécialHistorique_Click);
            // 
            // picBaladeur
            // 
            this.picBaladeur.Image = ((System.Drawing.Image)(resources.GetObject("picBaladeur.Image")));
            this.picBaladeur.Location = new System.Drawing.Point(12, 33);
            this.picBaladeur.Name = "picBaladeur";
            this.picBaladeur.Size = new System.Drawing.Size(433, 805);
            this.picBaladeur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBaladeur.TabIndex = 3;
            this.picBaladeur.TabStop = false;
            // 
            // txtParoles
            // 
            this.txtParoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtParoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParoles.ForeColor = System.Drawing.Color.SkyBlue;
            this.txtParoles.Location = new System.Drawing.Point(41, 508);
            this.txtParoles.Multiline = true;
            this.txtParoles.Name = "txtParoles";
            this.txtParoles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParoles.Size = new System.Drawing.Size(376, 286);
            this.txtParoles.TabIndex = 92;
            // 
            // lsvChansons
            // 
            this.lsvChansons.BackColor = System.Drawing.Color.Silver;
            this.lsvChansons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvChansons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhArtiste,
            this.clhTitre,
            this.clhAnnée,
            this.clhFormat});
            this.lsvChansons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lsvChansons.FullRowSelect = true;
            this.lsvChansons.GridLines = true;
            this.lsvChansons.HideSelection = false;
            this.lsvChansons.Location = new System.Drawing.Point(41, 81);
            this.lsvChansons.MultiSelect = false;
            this.lsvChansons.Name = "lsvChansons";
            this.lsvChansons.Size = new System.Drawing.Size(376, 421);
            this.lsvChansons.TabIndex = 0;
            this.lsvChansons.UseCompatibleStateImageBehavior = false;
            this.lsvChansons.View = System.Windows.Forms.View.Details;
            this.lsvChansons.SelectedIndexChanged += new System.EventHandler(this.LsvChansons_SelectedIndexChanged);
            // 
            // clhArtiste
            // 
            this.clhArtiste.Text = "Artiste";
            this.clhArtiste.Width = 115;
            // 
            // clhTitre
            // 
            this.clhTitre.Text = "Titre";
            this.clhTitre.Width = 156;
            // 
            // clhAnnée
            // 
            this.clhAnnée.Text = "Année";
            this.clhAnnée.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhAnnée.Width = 43;
            // 
            // clhFormat
            // 
            this.clhFormat.Text = "Format";
            this.clhFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhFormat.Width = 44;
            // 
            // lblNbChansons
            // 
            this.lblNbChansons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNbChansons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbChansons.Location = new System.Drawing.Point(273, 85);
            this.lblNbChansons.Name = "lblNbChansons";
            this.lblNbChansons.Size = new System.Drawing.Size(32, 16);
            this.lblNbChansons.TabIndex = 94;
            this.lblNbChansons.Text = "0";
            this.lblNbChansons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(458, 852);
            this.Controls.Add(this.lblNbChansons);
            this.Controls.Add(this.lsvChansons);
            this.Controls.Add(this.txtParoles);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.picBaladeur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baladeur MultiFormat ";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaladeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.PictureBox picBaladeur;
        private System.Windows.Forms.TextBox txtParoles;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecial;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatTousLesFormats;
        private System.Windows.Forms.ListView lsvChansons;
        private System.Windows.Forms.ColumnHeader clhArtiste;
        private System.Windows.Forms.ColumnHeader clhTitre;
        private System.Windows.Forms.ColumnHeader clhAnnée;
        private System.Windows.Forms.Label lblNbChansons;
        private System.Windows.Forms.ColumnHeader clhFormat;
        private System.Windows.Forms.ToolStripMenuItem MnuFormatConvertirVersMP3;
        private System.Windows.Forms.ToolStripMenuItem MnuFormatConvertirVersWMA;
        private System.Windows.Forms.ToolStripMenuItem MnuFormatConvertirVersAAC;
        private System.Windows.Forms.ToolStripMenuItem MnuSpécialHistorique;
    }
}

