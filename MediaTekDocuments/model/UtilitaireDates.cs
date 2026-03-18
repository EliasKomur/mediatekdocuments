using System;

namespace MediaTekDocuments.util
{
    public class UtilitaireDates
    {
        /// <summary>
        /// Retourne vrai si la date de parution est comprise entre dateCommande et dateFinAbonnement
        /// </summary>
        public static bool ParutionDansAbonnement(DateTime dateCommande, DateTime dateFinAbonnement, DateTime dateParution)
        {
            return dateParution >= dateCommande && dateParution <= dateFinAbonnement;
        }
    }
}