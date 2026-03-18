using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;
using MediaTekDocuments.util;
using System;

namespace MediaTekDocuments.Tests
{
    [TestClass]
    public class ModelTests
    {
        #region Tests Categorie
        [TestMethod]
        public void Categorie_Id_RetourneBienLId()
        {
            Categorie categorie = new Genre("G001", "Roman");
            Assert.AreEqual("G001", categorie.Id);
        }

        [TestMethod]
        public void Categorie_Libelle_RetourneBienLeLibelle()
        {
            Categorie categorie = new Genre("G001", "Roman");
            Assert.AreEqual("Roman", categorie.Libelle);
        }

        [TestMethod]
        public void Categorie_ToString_RetourneLeLibelle()
        {
            Categorie categorie = new Genre("G001", "Roman");
            Assert.AreEqual("Roman", categorie.ToString());
        }
        #endregion

        #region Tests Genre
        [TestMethod]
        public void Genre_Creation_IdCorrect()
        {
            Genre genre = new Genre("G001", "Roman");
            Assert.AreEqual("G001", genre.Id);
        }

        [TestMethod]
        public void Genre_Creation_LibelleCorrect()
        {
            Genre genre = new Genre("G001", "Roman");
            Assert.AreEqual("Roman", genre.Libelle);
        }
        #endregion

        #region Tests Public
        [TestMethod]
        public void Public_Creation_IdCorrect()
        {
            Public lePublic = new Public("P001", "Adulte");
            Assert.AreEqual("P001", lePublic.Id);
        }

        [TestMethod]
        public void Public_Creation_LibelleCorrect()
        {
            Public lePublic = new Public("P001", "Adulte");
            Assert.AreEqual("Adulte", lePublic.Libelle);
        }
        #endregion

        #region Tests Rayon
        [TestMethod]
        public void Rayon_Creation_IdCorrect()
        {
            Rayon rayon = new Rayon("R001", "Littérature");
            Assert.AreEqual("R001", rayon.Id);
        }

        [TestMethod]
        public void Rayon_Creation_LibelleCorrect()
        {
            Rayon rayon = new Rayon("R001", "Littérature");
            Assert.AreEqual("Littérature", rayon.Libelle);
        }
        #endregion

        #region Tests Livre
        [TestMethod]
        public void Livre_Creation_IdCorrect()
        {
            Livre livre = new Livre("L001", "Le Petit Prince", "", "978-2-07-040850-4",
                "Saint-Exupéry", "Folio", "G001", "Roman", "P001", "Adulte", "R001", "Littérature");
            Assert.AreEqual("L001", livre.Id);
        }

        [TestMethod]
        public void Livre_Creation_TitreCorrect()
        {
            Livre livre = new Livre("L001", "Le Petit Prince", "", "978-2-07-040850-4",
                "Saint-Exupéry", "Folio", "G001", "Roman", "P001", "Adulte", "R001", "Littérature");
            Assert.AreEqual("Le Petit Prince", livre.Titre);
        }

        [TestMethod]
        public void Livre_Creation_IsbnCorrect()
        {
            Livre livre = new Livre("L001", "Le Petit Prince", "", "978-2-07-040850-4",
                "Saint-Exupéry", "Folio", "G001", "Roman", "P001", "Adulte", "R001", "Littérature");
            Assert.AreEqual("978-2-07-040850-4", livre.Isbn);
        }

        [TestMethod]
        public void Livre_Creation_AuteurCorrect()
        {
            Livre livre = new Livre("L001", "Le Petit Prince", "", "978-2-07-040850-4",
                "Saint-Exupéry", "Folio", "G001", "Roman", "P001", "Adulte", "R001", "Littérature");
            Assert.AreEqual("Saint-Exupéry", livre.Auteur);
        }

        [TestMethod]
        public void Livre_Creation_CollectionCorrecte()
        {
            Livre livre = new Livre("L001", "Le Petit Prince", "", "978-2-07-040850-4",
                "Saint-Exupéry", "Folio", "G001", "Roman", "P001", "Adulte", "R001", "Littérature");
            Assert.AreEqual("Folio", livre.Collection);
        }

        [TestMethod]
        public void Livre_Creation_GenreCorrect()
        {
            Livre livre = new Livre("L001", "Le Petit Prince", "", "978-2-07-040850-4",
                "Saint-Exupéry", "Folio", "G001", "Roman", "P001", "Adulte", "R001", "Littérature");
            Assert.AreEqual("Roman", livre.Genre);
        }
        #endregion

        #region Tests Dvd
        [TestMethod]
        public void Dvd_Creation_IdCorrect()
        {
            Dvd dvd = new Dvd("D001", "Titanic", "", 194, "James Cameron", "Film épique",
                "G001", "Drame", "P001", "Adulte", "R001", "Cinéma");
            Assert.AreEqual("D001", dvd.Id);
        }

        [TestMethod]
        public void Dvd_Creation_TitreCorrect()
        {
            Dvd dvd = new Dvd("D001", "Titanic", "", 194, "James Cameron", "Film épique",
                "G001", "Drame", "P001", "Adulte", "R001", "Cinéma");
            Assert.AreEqual("Titanic", dvd.Titre);
        }

        [TestMethod]
        public void Dvd_Creation_DureeCorrecte()
        {
            Dvd dvd = new Dvd("D001", "Titanic", "", 194, "James Cameron", "Film épique",
                "G001", "Drame", "P001", "Adulte", "R001", "Cinéma");
            Assert.AreEqual(194, dvd.Duree);
        }

        [TestMethod]
        public void Dvd_Creation_RealisateurCorrect()
        {
            Dvd dvd = new Dvd("D001", "Titanic", "", 194, "James Cameron", "Film épique",
                "G001", "Drame", "P001", "Adulte", "R001", "Cinéma");
            Assert.AreEqual("James Cameron", dvd.Realisateur);
        }

        [TestMethod]
        public void Dvd_Creation_SynopsisCorrect()
        {
            Dvd dvd = new Dvd("D001", "Titanic", "", 194, "James Cameron", "Film épique",
                "G001", "Drame", "P001", "Adulte", "R001", "Cinéma");
            Assert.AreEqual("Film épique", dvd.Synopsis);
        }
        #endregion

        #region Tests Revue
        [TestMethod]
        public void Revue_Creation_IdCorrect()
        {
            Revue revue = new Revue("R001", "Le Monde", "", "G001", "Presse", "P001",
                "Adulte", "R001", "Presse", "Quotidien", 2);
            Assert.AreEqual("R001", revue.Id);
        }

        [TestMethod]
        public void Revue_Creation_TitreCorrect()
        {
            Revue revue = new Revue("R001", "Le Monde", "", "G001", "Presse", "P001",
                "Adulte", "R001", "Presse", "Quotidien", 2);
            Assert.AreEqual("Le Monde", revue.Titre);
        }

        [TestMethod]
        public void Revue_Creation_PeriodiciteCorrecte()
        {
            Revue revue = new Revue("R001", "Le Monde", "", "G001", "Presse", "P001",
                "Adulte", "R001", "Presse", "Quotidien", 2);
            Assert.AreEqual("Quotidien", revue.Periodicite);
        }

        [TestMethod]
        public void Revue_Creation_DelaiMiseADispoCorrect()
        {
            Revue revue = new Revue("R001", "Le Monde", "", "G001", "Presse", "P001",
                "Adulte", "R001", "Presse", "Quotidien", 2);
            Assert.AreEqual(2, revue.DelaiMiseADispo);
        }
        #endregion

        #region Tests Exemplaire
        [TestMethod]
        public void Exemplaire_Creation_NumeroCorrect()
        {
            Exemplaire exemplaire = new Exemplaire(1, new DateTime(2024, 1, 1), "", "00001", "L001");
            Assert.AreEqual(1, exemplaire.Numero);
        }

        [TestMethod]
        public void Exemplaire_Creation_DateAchatCorrecte()
        {
            DateTime dateAchat = new DateTime(2024, 1, 1);
            Exemplaire exemplaire = new Exemplaire(1, dateAchat, "", "00001", "L001");
            Assert.AreEqual(dateAchat, exemplaire.DateAchat);
        }

        [TestMethod]
        public void Exemplaire_Creation_IdEtatCorrect()
        {
            Exemplaire exemplaire = new Exemplaire(1, new DateTime(2024, 1, 1), "", "00001", "L001");
            Assert.AreEqual("00001", exemplaire.IdEtat);
        }

        [TestMethod]
        public void Exemplaire_Creation_IdDocumentCorrect()
        {
            Exemplaire exemplaire = new Exemplaire(1, new DateTime(2024, 1, 1), "", "00001", "L001");
            Assert.AreEqual("L001", exemplaire.Id);
        }
        #endregion

        #region Tests Commande
        [TestMethod]
        public void Commande_Creation_IdCorrect()
        {
            CommandeDocument commande = new CommandeDocument("C001", new DateTime(2024, 1, 1),
                50.0, 3, "L001", "00001", "En cours");
            Assert.AreEqual("C001", commande.Id);
        }

        [TestMethod]
        public void Commande_Creation_MontantCorrect()
        {
            CommandeDocument commande = new CommandeDocument("C001", new DateTime(2024, 1, 1),
                50.0, 3, "L001", "00001", "En cours");
            Assert.AreEqual(50.0, commande.Montant);
        }

        [TestMethod]
        public void CommandeDocument_Creation_NbExemplaireCorrect()
        {
            CommandeDocument commande = new CommandeDocument("C001", new DateTime(2024, 1, 1),
                50.0, 3, "L001", "00001", "En cours");
            Assert.AreEqual(3, commande.NbExemplaire);
        }

        [TestMethod]
        public void CommandeDocument_Creation_IdLivreDvdCorrect()
        {
            CommandeDocument commande = new CommandeDocument("C001", new DateTime(2024, 1, 1),
                50.0, 3, "L001", "00001", "En cours");
            Assert.AreEqual("L001", commande.IdLivreDvd);
        }

        [TestMethod]
        public void CommandeDocument_Creation_IdSuiviCorrect()
        {
            CommandeDocument commande = new CommandeDocument("C001", new DateTime(2024, 1, 1),
                50.0, 3, "L001", "00001", "En cours");
            Assert.AreEqual("00001", commande.IdSuivi);
        }

        [TestMethod]
        public void CommandeDocument_Creation_SuiviCorrect()
        {
            CommandeDocument commande = new CommandeDocument("C001", new DateTime(2024, 1, 1),
                50.0, 3, "L001", "00001", "En cours");
            Assert.AreEqual("En cours", commande.Suivi);
        }
        #endregion

        #region Tests CommandeAbonnement
        [TestMethod]
        public void CommandeAbonnement_Creation_IdCorrect()
        {
            CommandeAbonnement abonnement = new CommandeAbonnement("A001", new DateTime(2024, 1, 1),
                100.0, new DateTime(2024, 12, 31), "R001");
            Assert.AreEqual("A001", abonnement.Id);
        }

        [TestMethod]
        public void CommandeAbonnement_Creation_DateFinAbonnementCorrecte()
        {
            DateTime dateFin = new DateTime(2024, 12, 31);
            CommandeAbonnement abonnement = new CommandeAbonnement("A001", new DateTime(2024, 1, 1),
                100.0, dateFin, "R001");
            Assert.AreEqual(dateFin, abonnement.DateFinAbonnement);
        }

        [TestMethod]
        public void CommandeAbonnement_Creation_IdRevueCorrect()
        {
            CommandeAbonnement abonnement = new CommandeAbonnement("A001", new DateTime(2024, 1, 1),
                100.0, new DateTime(2024, 12, 31), "R001");
            Assert.AreEqual("R001", abonnement.IdRevue);
        }

        [TestMethod]
        public void CommandeAbonnement_Creation_MontantCorrect()
        {
            CommandeAbonnement abonnement = new CommandeAbonnement("A001", new DateTime(2024, 1, 1),
                100.0, new DateTime(2024, 12, 31), "R001");
            Assert.AreEqual(100.0, abonnement.Montant);
        }
        #endregion

        #region Tests Utilisateur
        [TestMethod]
        public void Utilisateur_Creation_IdCorrect()
        {
            Utilisateur utilisateur = new Utilisateur("U001", "Dupont", "Jean", "jdupont", "mdp123", "admin", "Administratif");
            Assert.AreEqual("U001", utilisateur.Id);
        }

        [TestMethod]
        public void Utilisateur_Creation_NomCorrect()
        {
            Utilisateur utilisateur = new Utilisateur("U001", "Dupont", "Jean", "jdupont", "mdp123", "admin", "Administratif");
            Assert.AreEqual("Dupont", utilisateur.Nom);
        }

        [TestMethod]
        public void Utilisateur_Creation_PrenomCorrect()
        {
            Utilisateur utilisateur = new Utilisateur("U001", "Dupont", "Jean", "jdupont", "mdp123", "admin", "Administratif");
            Assert.AreEqual("Jean", utilisateur.Prenom);
        }

        [TestMethod]
        public void Utilisateur_Creation_LoginCorrect()
        {
            Utilisateur utilisateur = new Utilisateur("U001", "Dupont", "Jean", "jdupont", "mdp123", "admin", "Administratif");
            Assert.AreEqual("jdupont", utilisateur.Login);
        }

        [TestMethod]
        public void Utilisateur_Creation_IdServiceCorrect()
        {
            Utilisateur utilisateur = new Utilisateur("U001", "Dupont", "Jean", "jdupont", "mdp123", "admin", "Administratif");
            Assert.AreEqual("admin", utilisateur.IdService);
        }

        [TestMethod]
        public void Utilisateur_Creation_ServiceCorrect()
        {
            Utilisateur utilisateur = new Utilisateur("U001", "Dupont", "Jean", "jdupont", "mdp123", "admin", "Administratif");
            Assert.AreEqual("Administratif", utilisateur.Service);
        }
        #endregion

        #region Tests UtilitaireDates
        [TestMethod]
        public void ParutionDansAbonnement_DateDedans_RetourneVrai()
        {
            DateTime dateCmd = new DateTime(2024, 1, 1);
            DateTime dateFin = new DateTime(2024, 12, 31);
            DateTime dateParution = new DateTime(2024, 6, 15);
            Assert.IsTrue(UtilitaireDates.ParutionDansAbonnement(dateCmd, dateFin, dateParution));
        }

        [TestMethod]
        public void ParutionDansAbonnement_DateAvant_RetourneFaux()
        {
            DateTime dateCmd = new DateTime(2024, 1, 1);
            DateTime dateFin = new DateTime(2024, 12, 31);
            DateTime dateParution = new DateTime(2023, 12, 31);
            Assert.IsFalse(UtilitaireDates.ParutionDansAbonnement(dateCmd, dateFin, dateParution));
        }

        [TestMethod]
        public void ParutionDansAbonnement_DateApres_RetourneFaux()
        {
            DateTime dateCmd = new DateTime(2024, 1, 1);
            DateTime dateFin = new DateTime(2024, 12, 31);
            DateTime dateParution = new DateTime(2025, 1, 1);
            Assert.IsFalse(UtilitaireDates.ParutionDansAbonnement(dateCmd, dateFin, dateParution));
        }

        [TestMethod]
        public void ParutionDansAbonnement_DateEgaleDebut_RetourneVrai()
        {
            DateTime dateCmd = new DateTime(2024, 1, 1);
            DateTime dateFin = new DateTime(2024, 12, 31);
            Assert.IsTrue(UtilitaireDates.ParutionDansAbonnement(dateCmd, dateFin, dateCmd));
        }

        [TestMethod]
        public void ParutionDansAbonnement_DateEgaleFin_RetourneVrai()
        {
            DateTime dateCmd = new DateTime(2024, 1, 1);
            DateTime dateFin = new DateTime(2024, 12, 31);
            Assert.IsTrue(UtilitaireDates.ParutionDansAbonnement(dateCmd, dateFin, dateFin));
        }
        #endregion
    }
}