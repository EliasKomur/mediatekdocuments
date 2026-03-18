using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.util;
using System;

namespace MediaTekDocuments.Tests
{
    [TestClass]
    public class UtilitaireDatesTests
    {
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
    }
}