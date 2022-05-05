using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void AfficherLesChansons(ListView pListeView)
        {
            throw new NotImplementedException();
        }

        public Chanson ChansonAt(int pIndex)
        {
            throw new NotImplementedException();
        }

        public void ConstruireLaListeDesChansons()
        {
            throw new NotImplementedException();
        }

        public void ConvertirVersAAC(int pIndex)
        {
            throw new NotImplementedException();
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
