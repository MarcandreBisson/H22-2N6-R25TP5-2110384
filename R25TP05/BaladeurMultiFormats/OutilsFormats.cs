using System.Text;

namespace BaladeurMultiFormats
{
    /// <summary>
    /// Contient des méthodes pour traiter les paroles selon les formats AAC, MP3 ou WMA
    /// </summary>
    public static class OutilsFormats
    {
        #region Méthode pour le format AAC
        public static string EncoderAAC(string pParoles)
        {
            StringBuilder objChaine = new StringBuilder(pParoles);
            for (int index = 0; index < objChaine.Length; index++)
            {
                if (objChaine[index] >= 'A' && objChaine[index] <= 'Z')
                    objChaine[index] = (char)('Z' - objChaine[index] + 'A');
                else
                    if (objChaine[index] >= 'a' && objChaine[index] <= 'z')
                    objChaine[index] = (char)('z' - objChaine[index] + 'a');
            }
            return objChaine.ToString();
        }
        public static string DecoderAAC(string pParoles)
        {
            return EncoderAAC(pParoles);
        }
        #endregion

        #region Méthodes pour le format MP3
        public static string EncoderMP3(string pParoles)
        {
           StringBuilder objChaine = new StringBuilder(pParoles);
            for (int index = 0; index < objChaine.Length; index++)
            {
                if (objChaine[index] >= 64)
                    objChaine[index] = (char)(objChaine[index] ^ (index % 32));
            }
            return objChaine.ToString();
        }
        public static string DecoderMP3(string pParoles)
        {
            return EncoderMP3(pParoles);
        }
        #endregion

        #region Méthodes pour le format WMA
        public static string EncoderWMA(string pParoles, int pCode)
        {
            StringBuilder objChaine = new StringBuilder(pParoles);
            for (int index = 0; index < objChaine.Length; index++)
                if (objChaine[index] >= 64)
                    objChaine[index] = (char)(objChaine[index] ^ (pCode + index % 16));
            return objChaine.ToString();
        }
        public static string DecoderWMA(string pParoles,int pCode)
        {
            return EncoderWMA(pParoles, pCode);
        }
        #endregion
    }
}
