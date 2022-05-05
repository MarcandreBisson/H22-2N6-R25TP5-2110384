using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaladeurMultiFormats
{
    /// <summary>
    /// Classe abstraite pour une chanson.
    /// </summary>
    public abstract class Chanson : IChanson
    {
        #region CHAMPS ET PROPRIÉTÉS
        /// <summary>
        /// Année de création de la chanson.
        /// </summary>
        protected int m_annee;
        public int Annee { get { return m_annee; } }
        /// <summary>
        /// Nom de l'artiste de la chanson.
        /// </summary>
        protected string m_artiste;
        public string Artiste { get { return m_artiste; } }

        public abstract string Format { get; }
        /// <summary>
        /// Nom du fichier de la chanson.
        /// </summary>
        protected string m_nomFichier;
        public string NomFichier { get { return m_nomFichier; } }

        public string Paroles => throw new NotImplementedException();
        /// <summary>
        /// Titre de la chanson.
        /// </summary>
        protected string m_titre;
        public string Titre { get { return m_titre; } }

        #endregion

        #region CONSTRUCTEURS
        /// <summary>
        /// Initialise une instance avec le nom du fichier.
        /// </summary>
        /// <param name="pNomFichier">Le nom du fichier.</param>
        public Chanson(string pNomFichier)
        {
            m_nomFichier = pNomFichier;
            LireEntete();
        }
        /// <summary>
        /// Initialise une instance avec le répertoire, l'artiste, le titre et la date de création de la chanson.
        /// </summary>
        /// <param name="pRepertoire">Le répertoire de la chanson.</param>
        /// <param name="pArtiste">L'artiste de la chanson.</param>
        /// <param name="pTitre">Le titre de la chanson.</param>
        /// <param name="pAnnée">La date de création de la chanson.</param>
        public Chanson(string pRepertoire, string pArtiste, string pTitre, int pAnnée)
        {
            m_nomFichier = pRepertoire + "\\" + pTitre + "." + Format;
            m_artiste = pArtiste;
            m_titre = pTitre;
            m_annee = pAnnée;
        }
        #endregion

        #region MÉTHODES
        public void Ecrire(string pParoles)
        {
            StreamWriter sw = new StreamWriter(m_nomFichier);

            EcrireEntete(sw);
            EcrireParoles(sw, pParoles);

            sw.Close();
        }

        public abstract void EcrireEntete(StreamWriter pobjFichier);

        public abstract void EcrireParoles(StreamWriter pobjFichier, string pParoles);

        public abstract void LireEntete();

        public abstract string LireParoles(StreamReader pobjFichier);

        public void SauterEntete(StreamReader pobjFichier)
        {
            pobjFichier.ReadLine();
        }
        #endregion
    }
}
