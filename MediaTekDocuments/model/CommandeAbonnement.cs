using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier CommandeAbonnement (commande de revue)
    /// </summary>
    public class CommandeAbonnement : Commande
    {
        public DateTime DateFinAbonnement { get; set; }
        public string IdRevue { get; }

        public CommandeAbonnement(string id, DateTime dateCommande, double montant,
            DateTime dateFinAbonnement, string idRevue)
            : base(id, dateCommande, montant)
        {
            DateFinAbonnement = dateFinAbonnement;
            IdRevue = idRevue;
        }
    }
}