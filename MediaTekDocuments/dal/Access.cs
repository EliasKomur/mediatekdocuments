using System;
using System.Collections.Generic;
using System.Linq;
using MediaTekDocuments.manager;
using MediaTekDocuments.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace MediaTekDocuments.dal
{
    /// <summary>
    /// Classe d'accès aux données
    /// </summary>
    public class Access
    {
        private static Access instance = null;
        private readonly ApiRest api = null;
        private const string GET = "GET";
        private const string POST = "POST";
        private const string PUT = "PUT";
        private const string DELETE = "DELETE";
        private static readonly string cheminLog = AppDomain.CurrentDomain.BaseDirectory + "logs\\mediatekdocuments.log";

        private static void EcrireLog(string message)
        {
            try
            {
                string ligne = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + message;
                Console.WriteLine(ligne);
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "logs");
                System.IO.File.AppendAllText(cheminLog, ligne + Environment.NewLine);
            }
            catch { }
        }

        private Access()
        {
            try
            {
                string authenticationString = System.Configuration.ConfigurationManager.AppSettings["ApiAuthentification"];
                string uriApiLocal = System.Configuration.ConfigurationManager.AppSettings["ApiUrl"];
                api = ApiRest.GetInstance(uriApiLocal, authenticationString);
            }
            catch (Exception e)
            {
                EcrireLog("Erreur de connexion à l'API : " + e.Message);
                Environment.Exit(0);
            }
        }

        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }

        public List<Categorie> GetAllGenres()
        {
            IEnumerable<Genre> lesGenres = TraitementRecup<Genre>(GET, "genre", null);
            return new List<Categorie>(lesGenres);
        }

        public List<Categorie> GetAllRayons()
        {
            IEnumerable<Rayon> lesRayons = TraitementRecup<Rayon>(GET, "rayon", null);
            return new List<Categorie>(lesRayons);
        }

        public List<Categorie> GetAllPublics()
        {
            IEnumerable<Public> lesPublics = TraitementRecup<Public>(GET, "public", null);
            return new List<Categorie>(lesPublics);
        }

        public List<Livre> GetAllLivres()
        {
            List<Livre> lesLivres = TraitementRecup<Livre>(GET, "livre", null);
            return lesLivres;
        }

        public List<Dvd> GetAllDvd()
        {
            List<Dvd> lesDvd = TraitementRecup<Dvd>(GET, "dvd", null);
            return lesDvd;
        }

        public List<Revue> GetAllRevues()
        {
            List<Revue> lesRevues = TraitementRecup<Revue>(GET, "revue", null);
            return lesRevues;
        }

        public List<Exemplaire> GetExemplairesRevue(string idDocument)
        {
            String jsonIdDocument = convertToJson("id", idDocument);
            List<Exemplaire> lesExemplaires = TraitementRecup<Exemplaire>(GET, "exemplaire/" + jsonIdDocument, null);
            return lesExemplaires;
        }

        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            String jsonExemplaire = JsonConvert.SerializeObject(exemplaire, new CustomDateTimeConverter());
            try
            {
                List<Exemplaire> liste = TraitementRecup<Exemplaire>(POST, "exemplaire", "champs=" + jsonExemplaire);
                return (liste != null);
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur CreerExemplaire : " + ex.Message);
            }
            return false;
        }

        public bool CreerLivre(Livre livre)
        {
            try
            {
                Dictionary<string, object> champDocument = new Dictionary<string, object>
                {
                    { "id", livre.Id },
                    { "titre", livre.Titre },
                    { "image", livre.Image },
                    { "idGenre", livre.IdGenre },
                    { "idPublic", livre.IdPublic },
                    { "idRayon", livre.IdRayon }
                };
                String jsonDocument = JsonConvert.SerializeObject(champDocument);
                List<Object> listeDoc = TraitementRecup<Object>(POST, "document", "champs=" + jsonDocument);
                if (listeDoc == null) return false;

                Dictionary<string, object> champLivreDvd = new Dictionary<string, object>
                {
                    { "id", livre.Id }
                };
                String jsonLivreDvd = JsonConvert.SerializeObject(champLivreDvd);
                List<Object> listeLivreDvd = TraitementRecup<Object>(POST, "livres_dvd", "champs=" + jsonLivreDvd);
                if (listeLivreDvd == null)
                {
                    String jsonId = convertToJson("id", livre.Id);
                    TraitementRecup<Object>(DELETE, "document/" + jsonId, null);
                    return false;
                }

                Dictionary<string, object> champLivre = new Dictionary<string, object>
                {
                    { "id", livre.Id },
                    { "ISBN", livre.Isbn },
                    { "auteur", livre.Auteur },
                    { "collection", livre.Collection }
                };
                String jsonLivre = JsonConvert.SerializeObject(champLivre);
                List<Object> listeLivre = TraitementRecup<Object>(POST, "livre", "champs=" + jsonLivre);
                if (listeLivre == null)
                {
                    String jsonId = convertToJson("id", livre.Id);
                    TraitementRecup<Object>(DELETE, "livres_dvd/" + jsonId, null);
                    TraitementRecup<Object>(DELETE, "document/" + jsonId, null);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur CreerLivre : " + ex.Message);
            }
            return false;
        }

        public bool ModifierLivre(Livre livre)
        {
            try
            {
                Dictionary<string, object> champDocument = new Dictionary<string, object>
                {
                    { "titre", livre.Titre },
                    { "image", livre.Image },
                    { "idGenre", livre.IdGenre },
                    { "idPublic", livre.IdPublic },
                    { "idRayon", livre.IdRayon }
                };
                String jsonDocument = JsonConvert.SerializeObject(champDocument);
                List<Object> listeDoc = TraitementRecup<Object>(PUT, "document/" + livre.Id, "champs=" + jsonDocument);
                if (listeDoc == null) return false;

                Dictionary<string, object> champLivre = new Dictionary<string, object>
                {
                    { "ISBN", livre.Isbn },
                    { "auteur", livre.Auteur },
                    { "collection", livre.Collection }
                };
                String jsonLivre = JsonConvert.SerializeObject(champLivre);
                List<Object> listeLivre = TraitementRecup<Object>(PUT, "livre/" + livre.Id, "champs=" + jsonLivre);
                return (listeLivre != null);
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur ModifierLivre : " + ex.Message);
            }
            return false;
        }

        public bool SupprimerLivre(Livre livre)
        {
            try
            {
                String jsonId = convertToJson("id", livre.Id);
                List<Object> listeLivre = TraitementRecup<Object>(DELETE, "livre/" + jsonId, null);
                if (listeLivre == null) return false;
                List<Object> listeLivreDvd = TraitementRecup<Object>(DELETE, "livres_dvd/" + jsonId, null);
                if (listeLivreDvd == null) return false;
                List<Object> listeDoc = TraitementRecup<Object>(DELETE, "document/" + jsonId, null);
                return (listeDoc != null);
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur SupprimerLivre : " + ex.Message);
            }
            return false;
        }

        public bool CreerDvd(Dvd dvd)
        {
            try
            {
                Dictionary<string, object> champDocument = new Dictionary<string, object>
                {
                    { "id", dvd.Id },
                    { "titre", dvd.Titre },
                    { "image", dvd.Image },
                    { "idGenre", dvd.IdGenre },
                    { "idPublic", dvd.IdPublic },
                    { "idRayon", dvd.IdRayon }
                };
                String jsonDocument = JsonConvert.SerializeObject(champDocument);
                List<Object> listeDoc = TraitementRecup<Object>(POST, "document", "champs=" + jsonDocument);
                if (listeDoc == null) return false;

                Dictionary<string, object> champLivreDvd = new Dictionary<string, object>
                {
                    { "id", dvd.Id }
                };
                String jsonLivreDvd = JsonConvert.SerializeObject(champLivreDvd);
                List<Object> listeLivreDvd = TraitementRecup<Object>(POST, "livres_dvd", "champs=" + jsonLivreDvd);
                if (listeLivreDvd == null)
                {
                    String jsonId = convertToJson("id", dvd.Id);
                    TraitementRecup<Object>(DELETE, "document/" + jsonId, null);
                    return false;
                }

                Dictionary<string, object> champDvd = new Dictionary<string, object>
                {
                    { "id", dvd.Id },
                    { "duree", dvd.Duree },
                    { "realisateur", dvd.Realisateur },
                    { "synopsis", dvd.Synopsis }
                };
                String jsonDvd = JsonConvert.SerializeObject(champDvd);
                List<Object> listeDvd = TraitementRecup<Object>(POST, "dvd", "champs=" + jsonDvd);
                if (listeDvd == null)
                {
                    String jsonId = convertToJson("id", dvd.Id);
                    TraitementRecup<Object>(DELETE, "livres_dvd/" + jsonId, null);
                    TraitementRecup<Object>(DELETE, "document/" + jsonId, null);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur CreerDvd : " + ex.Message);
            }
            return false;
        }

        public bool ModifierDvd(Dvd dvd)
        {
            try
            {
                Dictionary<string, object> champDocument = new Dictionary<string, object>
                {
                    { "titre", dvd.Titre },
                    { "image", dvd.Image },
                    { "idGenre", dvd.IdGenre },
                    { "idPublic", dvd.IdPublic },
                    { "idRayon", dvd.IdRayon }
                };
                String jsonDocument = JsonConvert.SerializeObject(champDocument);
                List<Object> listeDoc = TraitementRecup<Object>(PUT, "document/" + dvd.Id, "champs=" + jsonDocument);
                if (listeDoc == null) return false;

                Dictionary<string, object> champDvd = new Dictionary<string, object>
                {
                    { "duree", dvd.Duree },
                    { "realisateur", dvd.Realisateur },
                    { "synopsis", dvd.Synopsis }
                };
                String jsonDvd = JsonConvert.SerializeObject(champDvd);
                List<Object> listeDvd = TraitementRecup<Object>(PUT, "dvd/" + dvd.Id, "champs=" + jsonDvd);
                return (listeDvd != null);
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur ModifierDvd : " + ex.Message);
            }
            return false;
        }

        public bool SupprimerDvd(Dvd dvd)
        {
            try
            {
                String jsonId = convertToJson("id", dvd.Id);
                List<Object> listeDvd = TraitementRecup<Object>(DELETE, "dvd/" + jsonId, null);
                if (listeDvd == null) return false;
                List<Object> listeLivreDvd = TraitementRecup<Object>(DELETE, "livres_dvd/" + jsonId, null);
                if (listeLivreDvd == null) return false;
                List<Object> listeDoc = TraitementRecup<Object>(DELETE, "document/" + jsonId, null);
                return (listeDoc != null);
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur SupprimerDvd : " + ex.Message);
            }
            return false;
        }

        public bool CreerRevue(Revue revue)
        {
            try
            {
                Dictionary<string, object> champDocument = new Dictionary<string, object>
                {
                    { "id", revue.Id },
                    { "titre", revue.Titre },
                    { "image", revue.Image },
                    { "idGenre", revue.IdGenre },
                    { "idPublic", revue.IdPublic },
                    { "idRayon", revue.IdRayon }
                };
                String jsonDocument = JsonConvert.SerializeObject(champDocument);
                List<Object> listeDoc = TraitementRecup<Object>(POST, "document", "champs=" + jsonDocument);
                if (listeDoc == null) return false;

                Dictionary<string, object> champRevue = new Dictionary<string, object>
                {
                    { "id", revue.Id },
                    { "periodicite", revue.Periodicite },
                    { "delaiMiseADispo", revue.DelaiMiseADispo }
                };
                String jsonRevue = JsonConvert.SerializeObject(champRevue);
                List<Object> listeRevue = TraitementRecup<Object>(POST, "revue", "champs=" + jsonRevue);
                if (listeRevue == null)
                {
                    String jsonId = convertToJson("id", revue.Id);
                    TraitementRecup<Object>(DELETE, "document/" + jsonId, null);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur CreerRevue : " + ex.Message);
            }
            return false;
        }

        public bool ModifierRevue(Revue revue)
        {
            try
            {
                Dictionary<string, object> champDocument = new Dictionary<string, object>
                {
                    { "titre", revue.Titre },
                    { "image", revue.Image },
                    { "idGenre", revue.IdGenre },
                    { "idPublic", revue.IdPublic },
                    { "idRayon", revue.IdRayon }
                };
                String jsonDocument = JsonConvert.SerializeObject(champDocument);
                List<Object> listeDoc = TraitementRecup<Object>(PUT, "document/" + revue.Id, "champs=" + jsonDocument);
                if (listeDoc == null) return false;

                Dictionary<string, object> champRevue = new Dictionary<string, object>
                {
                    { "periodicite", revue.Periodicite },
                    { "delaiMiseADispo", revue.DelaiMiseADispo }
                };
                String jsonRevue = JsonConvert.SerializeObject(champRevue);
                List<Object> listeRevue = TraitementRecup<Object>(PUT, "revue/" + revue.Id, "champs=" + jsonRevue);
                return (listeRevue != null);
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur ModifierRevue : " + ex.Message);
            }
            return false;
        }

        public bool SupprimerRevue(Revue revue)
        {
            try
            {
                String jsonId = convertToJson("id", revue.Id);
                List<Object> listeRevue = TraitementRecup<Object>(DELETE, "revue/" + jsonId, null);
                if (listeRevue == null) return false;
                List<Object> listeDoc = TraitementRecup<Object>(DELETE, "document/" + jsonId, null);
                return (listeDoc != null);
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur SupprimerRevue : " + ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Retourne l'utilisateur correspondant au login/pwd, ou null si non trouvé
        /// </summary>
        public Utilisateur GetUtilisateur(string login, string pwd)
        {
            Dictionary<string, object> champs = new Dictionary<string, object>
            {
                { "login", login },
                { "pwd", pwd }
            };
            String json = JsonConvert.SerializeObject(champs);
            List<Utilisateur> liste = TraitementRecup<Utilisateur>(GET, "utilisateur/" + json, null);
            if (liste != null && liste.Count > 0)
                return liste[0];
            return null;
        }

        /// <summary>
        /// Retourne les commandes d'un livre
        /// </summary>
        public List<CommandeDocument> GetCommandesLivreDvd(string idLivreDvd)
        {
            String jsonIdLivreDvd = convertToJson("idLivreDvd", idLivreDvd);
            List<CommandeDocument> lesCommandes = TraitementRecup<CommandeDocument>(GET, "commandeslivre/" + jsonIdLivreDvd, null);
            return lesCommandes;
        }

        /// <summary>
        /// Retourne les commandes d'un DVD
        /// </summary>
        public List<CommandeDocument> GetCommandesDvd(string idLivreDvd)
        {
            String jsonIdLivreDvd = convertToJson("idLivreDvd", idLivreDvd);
            List<CommandeDocument> lesCommandes = TraitementRecup<CommandeDocument>(GET, "commandesdvd/" + jsonIdLivreDvd, null);
            return lesCommandes;
        }

        /// <summary>
        /// Retourne les étapes de suivi
        /// </summary>
        public List<Categorie> GetAllSuivi()
        {
            List<Categorie> lesSuivi = TraitementRecup<Categorie>(GET, "suivi", null);
            return lesSuivi;
        }

        /// <summary>
        /// Crée une commande dans la BDD
        /// </summary>
        public bool CreerCommandeDocument(CommandeDocument commande)
        {
            try
            {
                Dictionary<string, object> champCommande = new Dictionary<string, object>
                {
                    { "id", commande.Id },
                    { "dateCommande", commande.DateCommande.ToString("yyyy-MM-dd") },
                    { "montant", commande.Montant }
                };
                String jsonCommande = JsonConvert.SerializeObject(champCommande);
                List<Object> listeCommande = TraitementRecup<Object>(POST, "commande", "champs=" + jsonCommande);
                if (listeCommande == null) return false;

                Dictionary<string, object> champCommandeDoc = new Dictionary<string, object>
                {
                    { "id", commande.Id },
                    { "nbExemplaire", commande.NbExemplaire },
                    { "idLivreDvd", commande.IdLivreDvd },
                    { "idSuivi", "00001" }
                };
                String jsonCommandeDoc = JsonConvert.SerializeObject(champCommandeDoc);
                List<Object> listeCommandeDoc = TraitementRecup<Object>(POST, "commandedocument", "champs=" + jsonCommandeDoc);
                if (listeCommandeDoc == null)
                {
                    String jsonId = convertToJson("id", commande.Id);
                    TraitementRecup<Object>(DELETE, "commande/" + jsonId, null);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur CreerCommandeDocument : " + ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Modifie le suivi d'une commande document
        /// </summary>
        public bool ModifierSuiviCommande(CommandeDocument commande)
        {
            try
            {
                Dictionary<string, object> champ = new Dictionary<string, object>
                {
                    { "idSuivi", commande.IdSuivi }
                };
                String json = JsonConvert.SerializeObject(champ);
                List<Object> liste = TraitementRecup<Object>(PUT, "commandedocument/" + commande.Id, "champs=" + json);
                return (liste != null);
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur ModifierSuiviCommande : " + ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Supprime une commande
        /// </summary>
        public bool SupprimerCommandeDocument(CommandeDocument commande)
        {
            try
            {
                String jsonId = convertToJson("id", commande.Id);
                List<Object> liste = TraitementRecup<Object>(DELETE, "commande/" + jsonId, null);
                return (liste != null);
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur SupprimerCommandeDocument : " + ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Retourne les commandes (abonnements) d'une revue
        /// </summary>
        public List<CommandeAbonnement> GetCommandesRevue(string idRevue)
        {
            String jsonIdRevue = convertToJson("idRevue", idRevue);
            List<CommandeAbonnement> lesCommandes = TraitementRecup<CommandeAbonnement>(GET, "commandesrevue/" + jsonIdRevue, null);
            return lesCommandes;
        }

        /// <summary>
        /// Crée un abonnement dans la BDD
        /// </summary>
        public bool CreerAbonnement(CommandeAbonnement commande)
        {
            try
            {
                Dictionary<string, object> champCommande = new Dictionary<string, object>
                {
                    { "id", commande.Id },
                    { "dateCommande", commande.DateCommande.ToString("yyyy-MM-dd") },
                    { "montant", commande.Montant }
                };
                String jsonCommande = JsonConvert.SerializeObject(champCommande);
                List<Object> listeCommande = TraitementRecup<Object>(POST, "commande", "champs=" + jsonCommande);
                if (listeCommande == null) return false;

                Dictionary<string, object> champAbonnement = new Dictionary<string, object>
                {
                    { "id", commande.Id },
                    { "dateFinAbonnement", commande.DateFinAbonnement.ToString("yyyy-MM-dd") },
                    { "idRevue", commande.IdRevue }
                };
                String jsonAbonnement = JsonConvert.SerializeObject(champAbonnement);
                List<Object> listeAbonnement = TraitementRecup<Object>(POST, "abonnement", "champs=" + jsonAbonnement);
                if (listeAbonnement == null)
                {
                    String jsonId = convertToJson("id", commande.Id);
                    TraitementRecup<Object>(DELETE, "commande/" + jsonId, null);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur CreerAbonnement : " + ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Supprime un abonnement
        /// </summary>
        public bool SupprimerAbonnement(CommandeAbonnement commande)
        {
            try
            {
                String jsonId = convertToJson("id", commande.Id);
                List<Object> liste = TraitementRecup<Object>(DELETE, "commande/" + jsonId, null);
                return (liste != null);
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur SupprimerAbonnement : " + ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Retourne les revues dont l'abonnement se termine dans moins de 30 jours
        /// </summary>
        public List<CommandeAbonnement> GetAbonnementsExpires()
        {
            List<Revue> toutesRevues = GetAllRevues();
            List<CommandeAbonnement> tousAbonnements = new List<CommandeAbonnement>();
            foreach (Revue revue in toutesRevues)
            {
                List<CommandeAbonnement> abonnementsRevue = GetCommandesRevue(revue.Id);
                if (abonnementsRevue != null)
                    tousAbonnements.AddRange(abonnementsRevue);
            }
            if (tousAbonnements.Count == 0) return new List<CommandeAbonnement>();
            DateTime dans30Jours = DateTime.Now.AddDays(30);
            return tousAbonnements
                .FindAll(x => x.DateFinAbonnement <= dans30Jours && x.DateFinAbonnement >= DateTime.Now)
                .OrderBy(x => x.DateFinAbonnement)
                .ToList();
        }

        private List<T> TraitementRecup<T>(String methode, String message, String parametres)
        {
            List<T> liste = new List<T>();
            try
            {
                JObject retour = api.RecupDistant(methode, message, parametres);
                String code = (String)retour["code"];
                if (code.Equals("200"))
                {
                    if (methode.Equals(GET))
                    {
                        String resultString = JsonConvert.SerializeObject(retour["result"]);
                        liste = JsonConvert.DeserializeObject<List<T>>(resultString, new CustomBooleanJsonConverter());
                    }
                }
                else
                {
                    EcrireLog("code erreur = " + code + " message = " + (String)retour["message"]);
                }
            }
            catch (Exception e)
            {
                EcrireLog("Erreur lors de l'accès à l'API : " + e.Message);
                Environment.Exit(0);
            }
            return liste;
        }

        /// <summary>
        /// Modifie l'état d'un exemplaire
        /// </summary>
        public bool ModifierEtatExemplaire(Exemplaire exemplaire)
        {
            try
            {
                Dictionary<string, object> champ = new Dictionary<string, object>
                {
                    { "idEtat", exemplaire.IdEtat }
                };
                String json = JsonConvert.SerializeObject(champ);
                List<Object> liste = TraitementRecup<Object>(PUT, "exemplaire/" + exemplaire.Id + "_" + exemplaire.Numero, "champs=" + json);
                return (liste != null);
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur ModifierEtatExemplaire : " + ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Supprime un exemplaire
        /// </summary>
        public bool SupprimerExemplaire(Exemplaire exemplaire)
        {
            try
            {
                Dictionary<string, object> champs = new Dictionary<string, object>
                {
                    { "id", exemplaire.Id },
                    { "numero", exemplaire.Numero }
                };
                String json = JsonConvert.SerializeObject(champs);
                List<Object> liste = TraitementRecup<Object>(DELETE, "exemplaire/" + json, null);
                return (liste != null);
            }
            catch (Exception ex)
            {
                EcrireLog("Erreur SupprimerExemplaire : " + ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Récupère les exemplaires d'un livre ou DVD
        /// </summary>
        public List<Exemplaire> GetExemplairesLivreDvd(string idDocument)
        {
            String jsonIdDocument = convertToJson("id", idDocument);
            List<Exemplaire> lesExemplaires = TraitementRecup<Exemplaire>(GET, "exemplaire/" + jsonIdDocument, null);
            return lesExemplaires;
        }

        /// <summary>
        /// Retourne les états des exemplaires
        /// </summary>
        public List<Categorie> GetAllEtats()
        {
            List<Categorie> lesEtats = TraitementRecup<Categorie>(GET, "etat", null);
            return lesEtats;
        }

        private String convertToJson(Object nom, Object valeur)
        {
            Dictionary<Object, Object> dictionary = new Dictionary<Object, Object>();
            dictionary.Add(nom, valeur);
            return JsonConvert.SerializeObject(dictionary);
        }

        private sealed class CustomDateTimeConverter : IsoDateTimeConverter
        {
            public CustomDateTimeConverter()
            {
                base.DateTimeFormat = "yyyy-MM-dd";
            }
        }

        private sealed class CustomBooleanJsonConverter : JsonConverter<bool>
        {
            public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                return Convert.ToBoolean(reader.ValueType == typeof(string) ? Convert.ToByte(reader.Value) : reader.Value);
            }

            public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }
        }
    }
}