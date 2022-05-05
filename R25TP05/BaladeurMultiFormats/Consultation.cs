using System;

namespace BaladeurMultiFormats
{
    /// <summary>
    /// Modélise une consultation de chanson.
    /// </summary>
    public class Consultation
    {
        #region Propriétés
        /// <summary>
        /// Date de la consultation
        /// </summary>
        public DateTime Date { get; }
        /// <summary>
        /// Chanson consultée
        /// </summary>
        public object LaChanson { get; }
        /// <summary>
        /// Calcul le délai en la date actuelle et la date de consultation de la chanson
        /// </summary>
        public int Délai
        {
            get
            {
                return (int)((DateTime.Now - Date).TotalSeconds);
            }
        }
        #endregion

        #region Constructeur
        /// <summary>
        /// Initialise une consultation de chanson
        /// </summary>
        /// <param name="pDate">Date au moment de la consulation</param>
        /// <param name="pChanson">Chanson qui a été consultée</param>
        public Consultation(DateTime pDate, object pChanson)
        {
            if (pChanson == null) throw new ArgumentNullException();
            Date = pDate;
            LaChanson = pChanson;
        }
        #endregion
    }
}
