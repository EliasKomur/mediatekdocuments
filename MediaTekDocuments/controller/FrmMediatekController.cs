using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur lié à FrmMediatek
    /// </summary>
    class FrmMediatekController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmMediatekController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        public List<Categorie> GetAllGenres()
        {
            return access.GetAllGenres();
        }

        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        public List<Revue> GetAllRevues()
        {
            return access.GetAllRevues();
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        public List<Categorie> GetAllRayons()
        {
            return access.GetAllRayons();
        }

        /// <summary>
        /// getter sur les publics
        /// </summary>
        public List<Categorie> GetAllPublics()
        {
            return access.GetAllPublics();
        }

        /// <summary>
        /// Récupère les exemplaires d'une revue
        /// </summary>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }

        /// <summary>
        /// Crée un exemplaire d'une revue dans la BDD
        /// </summary>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return access.CreerExemplaire(exemplaire);
        }

        /// <summary>
        /// Crée un livre dans la BDD
        /// </summary>
        public bool CreerLivre(Livre livre)
        {
            return access.CreerLivre(livre);
        }

        /// <summary>
        /// Modifie un livre dans la BDD
        /// </summary>
        public bool ModifierLivre(Livre livre)
        {
            return access.ModifierLivre(livre);
        }

        /// <summary>
        /// Supprime un livre dans la BDD
        /// </summary>
        public bool SupprimerLivre(Livre livre)
        {
            return access.SupprimerLivre(livre);
        }

        /// <summary>
        /// Crée un dvd dans la BDD
        /// </summary>
        public bool CreerDvd(Dvd dvd)
        {
            return access.CreerDvd(dvd);
        }

        /// <summary>
        /// Modifie un dvd dans la BDD
        /// </summary>
        public bool ModifierDvd(Dvd dvd)
        {
            return access.ModifierDvd(dvd);
        }

        /// <summary>
        /// Supprime un dvd dans la BDD
        /// </summary>
        public bool SupprimerDvd(Dvd dvd)
        {
            return access.SupprimerDvd(dvd);
        }

        /// <summary>
        /// Crée une revue dans la BDD
        /// </summary>
        public bool CreerRevue(Revue revue)
        {
            return access.CreerRevue(revue);
        }

        /// <summary>
        /// Modifie une revue dans la BDD
        /// </summary>
        public bool ModifierRevue(Revue revue)
        {
            return access.ModifierRevue(revue);
        }

        /// <summary>
        /// Supprime une revue dans la BDD
        /// </summary>
        public bool SupprimerRevue(Revue revue)
        {
            return access.SupprimerRevue(revue);
        }

        /// <summary>
        /// Retourne les commandes d'un livre
        /// </summary>
        public List<CommandeDocument> GetCommandesLivreDvd(string idLivreDvd)
        {
            return access.GetCommandesLivreDvd(idLivreDvd);
        }

        /// <summary>
        /// Retourne les commandes d'un DVD
        /// </summary>
        public List<CommandeDocument> GetCommandesDvd(string idLivreDvd)
        {
            return access.GetCommandesDvd(idLivreDvd);
        }

        /// <summary>
        /// Retourne les étapes de suivi
        /// </summary>
        public List<Categorie> GetAllSuivi()
        {
            return access.GetAllSuivi();
        }

        /// <summary>
        /// Crée une commande de livre ou DVD dans la BDD
        /// </summary>
        public bool CreerCommandeDocument(CommandeDocument commande)
        {
            return access.CreerCommandeDocument(commande);
        }

        /// <summary>
        /// Modifie le suivi d'une commande de livre ou DVD
        /// </summary>
        public bool ModifierSuiviCommande(CommandeDocument commande)
        {
            return access.ModifierSuiviCommande(commande);
        }

        /// <summary>
        /// Supprime une commande de livre ou DVD
        /// </summary>
        public bool SupprimerCommandeDocument(CommandeDocument commande)
        {
            return access.SupprimerCommandeDocument(commande);
        }
    }
}