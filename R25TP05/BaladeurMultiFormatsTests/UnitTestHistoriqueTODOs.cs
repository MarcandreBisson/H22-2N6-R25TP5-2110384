using BaladeurMultiFormats;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BaladeurMultiFormatsTests
{
    [TestClass]
    public class UnitTestHistoriqueTODOs
    {
        
        #region Tests de la méthode NbConsultationDepuisXSecondes
        // TODO Test E : HistoriqueTestNbConsultationDepuisXSecondesParamNegatifTest
        // Compléter la méthode pour tester le cas où la valeur du délai passé en paramètre est négative
        [TestMethod()]
        #region MÉTHODE 1 : (DÉBUT)
        //[ExpectedException(typeof(IndexOutOfRangeException))]
        #endregion
        public void HistoriqueTestNbConsultationDepuisXSecondesParamNegatifTest()
        {
            // Arrange : Instancier un objet Historique
            // À compléter...
            Historique objHistorique = new Historique();
            // Act : Appeler la méthode NbConsultationsDepuisXSecondes
            // À compléter...
            #region MÉTHODE 1 : (SUITE)
            //objHistorique.NbConsultationsDepuisXSecondes(-1);
            #endregion
            #region MÉTHODE 2 :
            try
            {
                objHistorique.NbConsultationsDepuisXSecondes(-1);
            }
            // Assert : Vérifier si la méthode lève une exception IndexOutOfRangeException
            // À compléter...
            catch (IndexOutOfRangeException)
            {
                //Résultat attendu
            }
            catch(Exception)
            {
                Assert.Fail("IndexOutOfRangeException attendu");
            }
            #endregion
        }


        // TODO Test F : HistoriqueTestNbConsultationDepuisXSecondesValideTest
        // Compléter la méthode pour tester le cas valide
        [TestMethod()]
        public void HistoriqueTestNbConsultationDepuisXSecondesValideTest()
        {
            // Arrange : Instancier un objet Historique et y ajouter trois consultations d'une même chansonAAC
            // La première consultation depuis 100 secondes (DateTime.AddSeconds(-100))
            // La deuxième consultation depuis 150 secondes (DateTime.AddSeconds(-150))
            // La troisième consultation depuis 300 secondes (DateTime.AddSeconds(-300))
            // À compléter...
            Historique objHistorique = new Historique();
            ChansonAAC objChanson = new ChansonAAC("Chansons\\Happy.aac");
            Consultation objConsultation1 = new Consultation((DateTime.Now.AddSeconds(-100)), objChanson);
            Consultation objConsultation2 = new Consultation((DateTime.Now.AddSeconds(-150)), objChanson);
            Consultation objConsultation3 = new Consultation((DateTime.Now.AddSeconds(-300)), objChanson);
            objHistorique.Add(objConsultation1);
            objHistorique.Add(objConsultation2);
            objHistorique.Add(objConsultation3);

            // Act : Appeler la méthode NbConsultationsDepuisXSecondes pour calculer le nombre 
            // de chansons consultées depuis 200 secondes.
            // À compléter...
            int NbRetourne = objHistorique.NbConsultationsDepuisXSecondes(200);
            // Assert : Vérifier si la méthode retourne le bon nombre de consultations qui est 2 !
            // À compléter...
            Assert.AreEqual(2, NbRetourne);


        }
        #endregion
 
        #region Tests de la méthode NbConsultationsPourUneChanson
        // TODO Test G : HistoriqueTestNbConsultationsPourUneChansonParamNullTest
        // Compléter la méthode pour tester le cas où la chanson passée en paramètre est à null
        [TestMethod()]
        #region MÉTHODE 1 : (DÉBUT)
        //[ExpectedException(typeof(ArgumentNullException))]
        #endregion
        public void HistoriqueTestNbConsultationsPourUneChansonParamNullTest()
        {
            // Arrange : Instancier un objet Historique
            // À compléter...
            Historique objHistorique = new Historique();

            // Act : Appeler la méthode NbConsultationsDepuisXSecondes en lui passant la valeur null
            // À compléter...
            #region MÉTHODE 1 : (SUITE)
            //objHistorique.NbConsultationsPourUneChanson(null);
            #endregion
            #region MÉTHODE 2 :
            try
            {
                objHistorique.NbConsultationsPourUneChanson(null);
            }
            // Assert : Vérifier si la méthode lève une exception IndexOutOfRangeException
            // À compléter...
            catch (ArgumentNullException)
            {
                //Résultat attendu
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentNullException attendu");
            }
            #endregion
        }

        // TODO Test H : HistoriqueTestNbConsultationsPourUneChansonValideTest
        // Compléter la méthode pour tester le cas valide
        [TestMethod()]
        public void HistoriqueTestNbConsultationsPourUneChansonValideTest()
        {
            // Arrange : Instancier un objet Historique et un objet ChansonAAC
            // Ajouter quatre consultations de cette même chansonAAC dans l'objet Historique
            // La première consultation depuis 100 secondes (DateTime.AddSeconds(-100))
            // La deuxième consultation depuis 150 secondes (DateTime.AddSeconds(-150))
            // La troisième consultation depuis 300 secondes (DateTime.AddSeconds(-300))
            // La quatrième consultation depuis 350 secondes (DateTime.AddSeconds(-350))
            // À compléter...
            Historique objHistorique = new Historique();
            ChansonAAC objChanson = new ChansonAAC("Chansons\\Happy.aac");
            Consultation objConsultation1 = new Consultation((DateTime.Now.AddSeconds(-100)), objChanson);
            Consultation objConsultation2 = new Consultation((DateTime.Now.AddSeconds(-150)), objChanson);
            Consultation objConsultation3 = new Consultation((DateTime.Now.AddSeconds(-300)), objChanson);
            Consultation objConsultation4 = new Consultation((DateTime.Now.AddSeconds(-350)), objChanson);
            objHistorique.Add(objConsultation1);
            objHistorique.Add(objConsultation2);
            objHistorique.Add(objConsultation3);
            objHistorique.Add(objConsultation4);
            // Act : Appeler la méthode NbConsultationsDepuisXSecondes pour calculer le nombre 
            // de fois que la chansonAAC a été consultée.
            // À compléter...
            int NbRetourne = objHistorique.NbConsultationsPourUneChanson(objChanson);

            // Assert : Vérifier si la méthode retourne la bon nombre de consultations qui est 4
            // À compléter...
            Assert.AreEqual(4, NbRetourne);



        }
        

        #endregion
    }
}
