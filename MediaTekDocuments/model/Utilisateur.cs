namespace MediaTekDocuments.model
{
    public class Utilisateur
    {
        public string Id { get; }
        public string Nom { get; }
        public string Prenom { get; }
        public string Login { get; }
        public string Pwd { get; }
        public string IdService { get; }
        public string Service { get; }

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