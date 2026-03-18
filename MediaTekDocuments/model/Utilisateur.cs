namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Utilisateur : représente un employé de la médiathèque
    /// </summary>
    public class Utilisateur
    {
        /// <summary>
        /// Identifiant de l'utilisateur
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        public string Nom { get; }
        /// <summary>
        /// Prénom de l'utilisateur
        /// </summary>
        public string Prenom { get; }
        /// <summary>
        /// Login de l'utilisateur
        /// </summary>
        public string Login { get; }
        /// <summary>
        /// Mot de passe de l'utilisateur
        /// </summary>
        public string Pwd { get; }
        /// <summary>
        /// Identifiant du service de l'utilisateur
        /// </summary>
        public string IdService { get; }
        /// <summary>
        /// Libellé du service de l'utilisateur
        /// </summary>
        public string Service { get; }

        /// <summary>
        /// Constructeur de la classe Utilisateur
        /// </summary>
        public Utilisateur(string id, string nom, string prenom, string login, string pwd, string idService, string service)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Login = login;
            Pwd = pwd;
            IdService = idService;
            Service = service;
        }
    }
}