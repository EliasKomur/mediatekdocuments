using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier CommandeDocument
    /// </summary>
    public class CommandeDocument : Commande
    {
        public int NbExemplaire { get; }
        public string IdLivreDvd { get; }
        public string IdSuivi { get; set; }
        public string Suivi { get; set; }

        public CommandeDocument(string id, DateTime dateCommande, double montant,
            int nbExemplaire, string idLivreDvd, string idSuivi, string suivi)
            : base(id, dateCommande, montant)
        {
            NbExemplaire = nbExemplaire;
            IdLivreDvd = idLivreDvd;
            IdSuivi = idSuivi;
            Suivi = suivi;
        }
    }
}