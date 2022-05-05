using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaladeurMultiFormats
{
    /// <summary>
    /// Instancie une chanson utilisant un codage au format MP3.
    /// </summary>
    public class ChansonMP3:Chanson
    {
        #region PROPRIÉTÉ
        public override string Format { get { return "mp3"; } }
        #endregion

        #region CONSTRUCTEURS
        /// <summary>
        /// Initialise une chanson au format MP3 avec les données passées en paramètres en appelant le constructeur de la classe de base.
        /// </summary>
        /// <param name="pNomFichier">Le nom de fichier.</param>
        public ChansonMP3(string pNomFichier) : base(pNomFichier)
        { }
        /// <summary>
        /// Initialise une chanson au format MP3 avec les données passées en paramètres en appelant le constructeur de la classe de base.
        /// </summary>
        /// <param name="pRepertoire">Le répertoire de la chanson.</param>
        /// <param name="pArtiste">L'artiste de la chanson.</param>
        /// <param name="pTitre">Le titre de la chanson.</param>
        /// <param name="pAnnée">La date de création de la chanson.</param>
        public ChansonMP3(string pRepertoire, string pArtiste, string pTitre, int pAnnée) : base(pRepertoire, pArtiste, pTitre, pAnnée)
        { }
        #endregion

        #region MÉTHODES
        public override void EcrireEntete(StreamWriter pobjFichier)
        {
            pobjFichier.WriteLine(m_artiste + " | " + m_annee + " | " + m_titre );
        }

        public override void EcrireParoles(StreamWriter pobjFichier, string pParoles)
        {
            pobjFichier.WriteLine(OutilsFormats.EncoderMP3(pParoles));
        }

        public override void LireEntete()
        {
            StreamReader sr = new StreamReader(m_nomFichier);
            string[] info = sr.ReadLine().Split('|');
            m_titre = info[2].Trim();
            m_artiste = info[0].Trim();
            m_annee = int.Parse(info[1].Trim());
            sr.Close();
        }

        public override string LireParoles(StreamReader pobjFichier)
        {
            return OutilsFormats.DecoderMP3(pobjFichier.ReadToEnd());
        }
        #endregion

    }
}
