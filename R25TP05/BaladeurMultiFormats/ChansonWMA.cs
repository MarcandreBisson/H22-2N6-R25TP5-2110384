using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaladeurMultiFormats
{
    public class ChansonWMA:Chanson
    {
        #region PROPRIÉTÉ ET CHAMPS
        /// <summary>
        /// Code pour décoder et coder les paroles au format WMA.
        /// </summary>
        private int m_codage;
        public override string Format { get { return "wma"; } }
        #endregion

        #region CONSTRUCTEURS
        /// <summary>
        /// Initialise une chanson au format WMA avec les données passées en paramètres en appelant le constructeur de la classe de base.
        /// </summary>
        /// <param name="pNomFichier">Le nom de fichier.</param>
        public ChansonWMA(string pNomFichier) : base(pNomFichier)
        { }
        /// <summary>
        /// Initialise une chanson au format WMA avec les données passées en paramètres en appelant le constructeur de la classe de base.
        /// </summary>
        /// <param name="pRepertoire">Le répertoire de la chanson.</param>
        /// <param name="pArtiste">L'artiste de la chanson.</param>
        /// <param name="pTitre">Le titre de la chanson.</param>
        /// <param name="pAnnée">La date de création de la chanson.</param>
        public ChansonWMA(string pRepertoire, string pArtiste, string pTitre, int pAnnée) : base(pRepertoire, pArtiste, pTitre, pAnnée)
        { }
        #endregion

        #region MÉTHODES
        public override void EcrireEntete(StreamWriter pobjFichier)
        {
            pobjFichier.WriteLine(m_codage + " / " + m_annee + " / " + m_artiste + " / " + m_titre);
        }

        public override void EcrireParoles(StreamWriter pobjFichier, string pParoles)
        {
            pobjFichier.WriteLine(OutilsFormats.EncoderWMA(pParoles, m_codage));
        }

        public override void LireEntete()
        {
            StreamReader sr = new StreamReader(m_nomFichier);
            string[] info = sr.ReadLine().Split('/');
            m_titre = info[2].Trim();
            m_artiste = info[3].Trim();
            m_annee = int.Parse(info[1].Trim());
            m_codage = int.Parse(info[0].Trim());
            sr.Close();
        }

        public override string LireParoles(StreamReader pobjFichier)
        {
            
            return OutilsFormats.DecoderWMA(pobjFichier.ReadToEnd(), m_codage);
        }
        #endregion

    }
}
