using System;
using System.Windows.Forms;
using System.IO;


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
            
            objBaladeur.ConstruireLaListeDesChansons();
            objBaladeur.AfficherLesChansons(lsvChansons);
        }
        #endregion
        //---------------------------------------------------------------------------------
        #region Méthode : MettreAJourSelonContexte
        private void MettreAJourSelonContexte()
        {
            // À COMPLÉTER...
        }
        #endregion
        //---------------------------------------------------------------------------------
        #region Événement : LsvChansons_SelectedIndexChanged
        private void LsvChansons_SelectedIndexChanged(object sender, EventArgs e)
        {
            // À COMPLÉTER...
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
        }
        private void MnuFormatConvertirVersWMA_Click(object sender, EventArgs e)
        {
            // Vider l'historique car les références ne sont plus bonnes
            // À COMPLÉTER...
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
