using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BaladeurMultiFormats
{
    /// <summary>
    /// Instancie un baladeur.
    /// </summary>
    public class Baladeur : IBaladeur
    {
        #region CHAMPS ET PROPRIÉTÉ
        /// <summary>
        /// Nom du répertoire.
        /// </summary>
        private const string NOM_RÉPERTOIRE = "Chansons";
        /// <summary>
        /// Liste des chansons.
        /// </summary>
        private List<Chanson> m_colChansons;

        public int NbChansons { get { return m_colChansons.Count; } }
        #endregion

        #region CONSTRUCTEUR
        /// <summary>
        /// Initialise un baladeur.
        /// </summary>
        public Baladeur()
        {
            m_colChansons = new List<Chanson>();
        }

        #endregion

        #region MÉTHODES
        public void AfficherLesChansons(ListView pListView)
        {
            foreach (Chanson objChanson in m_colChansons)
            {
                ListViewItem objItem = new ListViewItem(objChanson.Artiste);
                objItem.SubItems.Add(objChanson.Titre);
                objItem.SubItems.Add(objChanson.Annee.ToString());
                objItem.SubItems.Add(objChanson.Format.ToUpper());
                pListView.Items.Add(objItem);
                pListView.Sort();
            }
        }

        public Chanson ChansonAt(int pIndex)
        {
            return m_colChansons[pIndex];
        }

        public void ConstruireLaListeDesChansons()
        {
            if(Directory.Exists(NOM_RÉPERTOIRE))
            {
                DirectoryInfo dir = new DirectoryInfo(NOM_RÉPERTOIRE);
                foreach(FileInfo objFichier in dir.GetFiles())
                {
                    string NomFichier = objFichier.Name;
                    string[] NomFichierSplit = NomFichier.Split('.');
                    if(NomFichierSplit[1] == "aac")
                    {
                        ChansonAAC objChanson = new ChansonAAC(NOM_RÉPERTOIRE + "\\" + NomFichier);
                        m_colChansons.Add(objChanson);
                    }
                    else if (NomFichierSplit[1] == "mp3")
                    {
                        ChansonMP3 objChanson = new ChansonMP3(NOM_RÉPERTOIRE + "\\" + NomFichier);
                        m_colChansons.Add(objChanson);
                    }
                    else if(NomFichierSplit[1] == "wma")
                    {
                        ChansonWMA objChanson = new ChansonWMA(NOM_RÉPERTOIRE + "\\" + NomFichier);
                        m_colChansons.Add(objChanson);
                    }
                }
                
            }
        }

        public void ConvertirVersAAC(int pIndex)
        {
            string paroleChanson = ChansonAt(pIndex).Paroles;
            ChansonAAC objChanson = new ChansonAAC(NOM_RÉPERTOIRE, m_colChansons[pIndex].Artiste, m_colChansons[pIndex].Titre, m_colChansons[pIndex].Annee);
            File.Delete(m_colChansons[pIndex].NomFichier);
            m_colChansons[pIndex] = objChanson;
            File.Create(objChanson.NomFichier).Close();
            objChanson.Ecrire(paroleChanson);


        }

        public void ConvertirVersMP3(int pIndex)
        {
            throw new NotImplementedException();
        }

        public void ConvertirVersWMA(int pIndex)
        {
            throw new NotImplementedException();
        }
        #endregion  

 

        
    }
}
