using System;
using System.Collections.Generic;

namespace BaladeurMultiFormats
{
    /// <summary>
    /// Liste générique de consultations, elle ajoute quelques méthodes qui fournissent des statistiques.
    /// </summary>
    public class Historique : List<Consultation>
    {
        #region NbConsultationsDepuisXSecondes
        /// <summary>
        /// Parcourt les consultations afin de compter le nombre de chansons 
        /// qui ont étés consultées depuis un certains nombre de secondes.
        /// </summary>
        /// <param name="pDelai"></param>
        /// <returns>Nombre de chansons consultées depuis pDelai secondes</returns>
        public int NbConsultationsDepuisXSecondes(int pDelai)
        {

            if (pDelai < 0)
                throw new IndexOutOfRangeException();

            int cptChansons = 0;
            foreach (Consultation uneConsultation in this)
            {
                if (uneConsultation.Délai <= pDelai)
                {
                    cptChansons++;
                }
            }

            return cptChansons;
        }
        #endregion

        #region NbConsultationsPourUneChanson
        /// <summary>
        /// Parcourt les consultations afin de compter le nombre de fois qu'une certaine
        /// chanson a été consultée.
        /// </summary>
        /// <param name="pIndexChanson"></param>
        /// <returns>Nombre de consultations pour une certaine chanson</returns>
        public int NbConsultationsPourUneChanson(object pChanson)
        {

            if (pChanson == null)
                throw new ArgumentNullException();

            int cptOccurences = 0;
            foreach (Consultation uneConsultation in this)
            {
                if (uneConsultation.LaChanson == pChanson)
                {
                    cptOccurences++;
                }
            }
            return cptOccurences;
        }
        #endregion

    }
}
