using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;


namespace BaladeurMultiFormats
{
    // Étapes de  réalisation :
    // Étape #1 : Définir les classes Chanson et ChasonAAC

    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(2110384)";
        Baladeur objBaladeur = new Baladeur();
        #region Propriété : MonHistorique
        public Historique MonHistorique { get; }
        #endregion
        //---------------------------------------------------------------------------------
        #region FrmPrincipal
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            MonHistorique = new Historique();
            // À COMPLÉTER...
            lsvChansons.Items.Clear();
            objBaladeur.ConstruireLaListeDesChansons();
            objBaladeur.AfficherLesChansons(lsvChansons);
            MettreAJourSelonContexte();
            lblNbChansons.Text = objBaladeur.NbChansons.ToString();
        }
        #endregion
        //---------------------------------------------------------------------------------
        #region Méthode : MettreAJourSelonContexte
        private void MettreAJourSelonContexte()
        {
            // À COMPLÉTER...
            MnuFormatConvertirVersAAC.Enabled = lsvChansons.SelectedItems.Count != 0 && objBaladeur.ChansonAt(lsvChansons.SelectedIndices[0]).Format != "aac";
            MnuFormatConvertirVersMP3.Enabled = lsvChansons.SelectedItems.Count != 0 && objBaladeur.ChansonAt(lsvChansons.SelectedIndices[0]).Format != "mp3";
            MnuFormatConvertirVersWMA.Enabled = lsvChansons.SelectedItems.Count != 0 && objBaladeur.ChansonAt(lsvChansons.SelectedIndices[0]).Format != "wma";
        }
        #endregion
        //---------------------------------------------------------------------------------
        #region Événement : LsvChansons_SelectedIndexChanged
        private void LsvChansons_SelectedIndexChanged(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            MettreAJourSelonContexte();
            if(lsvChansons.SelectedItems.Count != 0)
            {
                txtParoles.Text = objBaladeur.ChansonAt(lsvChansons.SelectedIndices[0]).Paroles;
                MonHistorique.Add(new Consultation(DateTime.Now, objBaladeur.ChansonAt(lsvChansons.SelectedIndices[0])));
            }
        }
        #endregion

        //---------------------------------------------------------------------------------
        #region Méthodes : Convertir vers les formats AAC, MP3 ou WMA
        private void MnuFormatConvertirVersAAC_Click(object sender, EventArgs e)
        {
            // Vider l'historique car les références ne sont plus bonnes
            MonHistorique.Clear();
            // À COMPLÉTER...
            int indexchanson = lsvChansons.SelectedIndices[0];
            objBaladeur.ConvertirVersAAC(indexchanson);
            Chanson objChanson = objBaladeur.ChansonAt(indexchanson);
            ListViewItem objItem = new ListViewItem(objChanson.Format.ToUpper());

            lsvChansons.Items[indexchanson].SubItems[3] = objItem.SubItems[0];
            MettreAJourSelonContexte();
        }
        private void MnuFormatConvertirVersMP3_Click(object sender, EventArgs e)
        {
            // Vider l'historique car les références ne sont plus bonnes
            MonHistorique.Clear();
            // À COMPLÉTER...
            int indexchanson = lsvChansons.SelectedIndices[0];
            objBaladeur.ConvertirVersMP3(indexchanson);
            Chanson objChanson = objBaladeur.ChansonAt(indexchanson);
            ListViewItem objItem = new ListViewItem(objChanson.Format.ToUpper());

            lsvChansons.Items[indexchanson].SubItems[3] = objItem.SubItems[0];
            MettreAJourSelonContexte();
        }
        private void MnuFormatConvertirVersWMA_Click(object sender, EventArgs e)
        {
            // Vider l'historique car les références ne sont plus bonnes
            MonHistorique.Clear();
            // À COMPLÉTER...
            int indexchanson = lsvChansons.SelectedIndices[0];
            objBaladeur.ConvertirVersWMA(indexchanson);
            Chanson objChanson = objBaladeur.ChansonAt(indexchanson);
            ListViewItem objItem = new ListViewItem(objChanson.Format.ToUpper());

            lsvChansons.Items[indexchanson].SubItems[3] = objItem.SubItems[0];
            MettreAJourSelonContexte();
        }
        #endregion
        //---------------------------------------------------------------------------------
        #region Historique
        private void MnuSpécialHistorique_Click(object sender, EventArgs e)
        {
            FrmHistorique objFormulaire = new FrmHistorique(MonHistorique);            
            objFormulaire.ShowDialog();
        }
        #endregion
         //---------------------------------------------------------------------------------
        #region Méthodes : MnuFichierQuitter_Click
        //---------------------------------------------------------------------------------
        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
