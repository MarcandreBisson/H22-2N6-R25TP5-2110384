using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaladeurMultiFormats
{
    /// <summary>
    /// Définit tous les éléments requis pour une chanson.
    /// </summary>
    interface IChanson
    {
        #region PROPRIÉTÉS 
        /// <summary>
        /// Obtient l'année de création de la chanson.
        /// </summary>
        int Annee { get; }
        /// <summary>
        /// Obtient le nom de l’artiste ou du groupe ayant créé la chanson.
        /// </summary>
        string Artiste { get; }
        /// <summary>
        /// Obtient le format audio de la chanson par exemple AAC, MP3 ou WMA.
        /// </summary>
        string Format { get; }
        /// <summary>
        /// Obtient le nom de fichier de la chanson.
        /// </summary>
        string NomFichier { get; }
        /// <summary>
        /// Cette propriété calculée va obtenir les paroles de la chanson à partir d’un fichier texte.
        /// </summary>
        string Paroles { get; }
        /// <summary>
        /// Obtient le titre de la chanson.
        /// </summary>
        string Titre { get; }
        #endregion

        #region MÉTHODES
        /// <summary>
        /// Méthode servant à écrire les paroles passées en paramètre dans le fichier de la chanson. 
        /// </summary>
        /// <param name="pParoles">Les paroles à écrire.</param>
        void Ecrire(string pParoles);
        /// <summary>
        /// Méthode servant à écrire uniquement l'entête de la chanson.
        /// </summary>
        /// <param name="pobjFichier">Le fichier ou il faut écrire l'entête de la chanson.</param>
        void EcrireEntete(StreamWriter pobjFichier);
        /// <summary>
        /// Méthode servant à écrire uniquement les paroles de la chanson.
        /// </summary>
        /// <param name="pobjFichier">Le fichier ou il faut écrire les paroles de la chanson.</param>
        /// <param name="pParoles">Les paroles à écrire.</param>
        void EcrireParoles(StreamWriter pobjFichier, string pParoles);
        /// <summary>
        /// Méthode servant à lire l’en-tête du fichier soit uniquement la première ligne et d'initialiser les champs de la chanson (titre, artiste et années de création de la chanson).
        /// </summary>
        void LireEntete();
        /// <summary>
        /// Méthode servant à obtenir les paroles à partir d'un fichier binaire déjà ouvert.
        /// </summary>
        /// <param name="pobjFichier">Le fichier à lire.</param>
        /// <returns></returns>
        string LireParoles(StreamReader pobjFichier);
        /// <summary>
        /// Méthode servant à lire une ligne à partir du fichier passé en paramètre.
        /// </summary>
        /// <param name="pobjFichier">Le fichier à lire.</param>
        void SauterEntete(StreamReader pobjFichier);
        #endregion
    }
}
