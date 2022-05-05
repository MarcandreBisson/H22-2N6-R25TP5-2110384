using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
///using static System.Windows.Forms.ListViewItem;

namespace BaladeurMultiFormats
{
    /// <summary>
    /// Définit tous les éléments requis pour un baladeur.
    /// </summary>
    interface IBaladeur
    {
        #region PROPRIÉTÉ
        /// <summary>
        /// Obtient le nombre de chansons.
        /// </summary>
        int NbChansons { get; }
        #endregion

        #region MÉTHODES
        /// <summary>
        /// Méthode servant à afficher la liste des chansons dans la pListView passée en paramètre.
        /// </summary>
        /// <param name="pListeView">La ListView à afficher.</param>
        void AfficherLesChansons(ListView pListView);
        /// <summary>
        /// Méthode servant à obtenir la chanson à l’index pIndex passé en paramètre.
        /// </summary>
        /// <param name="pIndex">L'index de la chanson voulu.</param>
        /// <returns></returns>
        Chanson ChansonAt(int pIndex);
        /// <summary>
        /// Méthode servant à récupérer la liste des fichiers dans le dossier Chansons, instancie selon le cas des objets des classes dérivées de la classe Chanson.
        /// </summary>
        void ConstruireLaListeDesChansons();
        /// <summary>
        /// Méthode servant à convertir n'importe quelle chanson au format AAC. 
        /// </summary>
        /// <param name="pIndex">La chanson à convertir au format AAC.</param>
        void ConvertirVersAAC(int pIndex);
        /// <summary>
        /// Méthode servant à convertir n'importe quelle chanson au format MP3.
        /// </summary>
        /// <param name="pIndex">La chanson à convertir au format MP3.</param>
        void ConvertirVersMP3(int pIndex);
        /// <summary>
        /// Méthode servant à convertir n'importe quelle chanson au format WMA.
        /// </summary>
        /// <param name="pIndex">La chanson à convertir au format WMA.</param>
        void ConvertirVersWMA(int pIndex);
        #endregion
    }
}
