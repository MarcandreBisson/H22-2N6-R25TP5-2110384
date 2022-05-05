using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaladeurMultiFormats
{
    /// <summary>
    /// Instancie une chanson utilisant un codage au format AAC.
    /// </summary>
    public class ChansonAAC : Chanson
    {
        #region PROPRIÉTÉ
        public override string Format { get { return "aac"; } }
        #endregion

        #region CONSTRUCTEURS
        /// <summary>
        /// Initialise une chanson au format AAC avec les données passées en paramètres en appelant le constructeur de la classe de base.
        /// </summary>
        /// <param name="pNomFichier">Le nom de fichier.</param>
        public ChansonAAC(string pNomFichier):base(pNomFichier)
        { }
        /// <summary>
        /// Initialise une chanson au format AAC avec les données passées en paramètres en appelant le constructeur de la classe de base.
        /// </summary>
        /// <param name="pRepertoire">Le répertoire de la chanson.</param>
        /// <param name="pArtiste">L'artiste de la chanson.</param>
        /// <param name="pTitre">Le titre de la chanson.</param>
        /// <param name="pAnnée">La date de création de la chanson.</param>
        public ChansonAAC(string pRepertoire, string pArtiste, string pTitre, int pAnnée) : base(pRepertoire, pArtiste, pTitre, pAnnée)
        { }
        #endregion

        #region MÉTHODES
        public override void EcrireEntete(StreamWriter pobjFichier)
        {
            pobjFichier.WriteLine("TITRE = " + m_titre + " : ARTISTE = " + m_artiste + " : ANNÉE = " + m_annee);
        }

        public override void EcrireParoles(StreamWriter pobjFichier, string pParoles)
        {
            pobjFichier.WriteLine(OutilsFormats.EncoderAAC(pParoles));
        }

        public override void LireEntete()
        {
            StreamReader sr = new StreamReader(m_nomFichier);

            string[] entete = sr.ReadLine().Split(':');
            string[] info = new string[3];
            for (int i = 0; i < entete.Length; i++)
                info[i] = entete[i].Split('=')[1];

            m_titre = info[0].Trim();
            m_artiste = info[1].Trim();
            m_annee = int.Parse(info[2].Trim());
            sr.Close();
        }

        public override string LireParoles(StreamReader pobjFichier)
        {
            return  OutilsFormats.DecoderAAC(pobjFichier.ReadToEnd());
        }
        #endregion
    }
}
