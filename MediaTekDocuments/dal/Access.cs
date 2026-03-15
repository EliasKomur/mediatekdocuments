using System;
using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.manager;
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
        /// <summary>
        /// adresse de l'API
        /// </summary>
        private static readonly string uriApi = "http://localhost/rest_mediatekdocuments/";
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// instance de ApiRest pour envoyer des demandes vers l'api et recevoir la réponse
        /// </summary>
        private readonly ApiRest api = null;
        /// <summary>
        /// méthode HTTP pour select
        /// </summary>
        private const string GET = "GET";
        /// <summary>
        /// méthode HTTP pour insert
        /// </summary>
        private const string POST = "POST";
        /// <summary>
        /// méthode HTTP pour update
        /// </summary>
        private const string PUT = "PUT";
        /// <summary>
        /// méthode HTTP pour delete
        /// </summary>
        private const string DELETE = "DELETE";

        /// <summary>
        /// Méthode privée pour créer un singleton
        /// initialise l'accès à l'API
        /// </summary>
        private Access()
        {
            String authenticationString;
            try
            {
                authenticationString = "admin:adminpwd";
                api = ApiRest.GetInstance(uriApi, authenticationString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Création et retour de l'instance unique de la classe
        /// </summary>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }

        /// <summary>
        /// Retourne tous les genres à partir de la BDD
        /// </summary>
        public List<Categorie> GetAllGenres()
        {
            IEnumerable<Genre> lesGenres = TraitementRecup<Genre>(GET, "genre", null);
            return new List<Categorie>(lesGenres);
        }

        /// <summary>
        /// Retourne tous les rayons à partir de la BDD
        /// </summary>
        public List<Categorie> GetAllRayons()
        {
            IEnumerable<Rayon> lesRayons = TraitementRecup<Rayon>(GET, "rayon", null);
            return new List<Categorie>(lesRayons);
        }

        /// <summary>
        /// Retourne toutes les catégories de public à partir de la BDD
        /// </summary>
        public List<Categorie> GetAllPublics()
        {
            IEnumerable<Public> lesPublics = TraitementRecup<Public>(GET, "public", null);
            return new List<Categorie>(lesPublics);
        }

        /// <summary>
        /// Retourne tous les livres à partir de la BDD
        /// </summary>
        public List<Livre> GetAllLivres()
        {
            List<Livre> lesLivres = TraitementRecup<Livre>(GET, "livre", null);
            return lesLivres;
        }

        /// <summary>
        /// Retourne tous les dvd à partir de la BDD
        /// </summary>
        public List<Dvd> GetAllDvd()
        {
            List<Dvd> lesDvd = TraitementRecup<Dvd>(GET, "dvd", null);
            return lesDvd;
        }

        /// <summary>
        /// Retourne toutes les revues à partir de la BDD
        /// </summary>
        public List<Revue> GetAllRevues()
        {
            List<Revue> lesRevues = TraitementRecup<Revue>(GET, "revue", null);
            return lesRevues;
        }

        /// <summary>
        /// Retourne les exemplaires d'une revue
        /// </summary>
        public List<Exemplaire> GetExemplairesRevue(string idDocument)
        {
            String jsonIdDocument = convertToJson("id", idDocument);
            List<Exemplaire> lesExemplaires = TraitementRecup<Exemplaire>(GET, "exemplaire/" + jsonIdDocument, null);
            return lesExemplaires;
        }

        /// <summary>
        /// Création d'un exemplaire de revue dans la BDD
        /// </summary>
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
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Création d'un livre dans la BDD
        /// insert dans document, livres_dvd puis livre
        /// si un insert échoue, annulation des inserts précédents
        /// </summary>
        public bool CreerLivre(Livre livre)
        {
            try
            {
                // 1. Insert dans document
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

                // 2. Insert dans livres_dvd
                Dictionary<string, object> champLivreDvd = new Dictionary<string, object>
                {
                    { "id", livre.Id }
                };
                String jsonLivreDvd = JsonConvert.SerializeObject(champLivreDvd);
                List<Object> listeLivreDvd = TraitementRecup<Object>(POST, "livres_dvd", "champs=" + jsonLivreDvd);
                if (listeLivreDvd == null)
                {
                    // Annulation : suppression dans document
                    String jsonId = convertToJson("id", livre.Id);
                    TraitementRecup<Object>(DELETE, "document/" + jsonId, null);
                    return false;
                }

                // 3. Insert dans livre
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
                    // Annulation : suppression dans livres_dvd et document
                    String jsonId = convertToJson("id", livre.Id);
                    TraitementRecup<Object>(DELETE, "livres_dvd/" + jsonId, null);
                    TraitementRecup<Object>(DELETE, "document/" + jsonId, null);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Modification d'un livre dans la BDD
        /// update dans document puis dans livre
        /// </summary>
        public bool ModifierLivre(Livre livre)
        {
            try
            {
                // 1. Update dans document
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

                // 2. Update dans livre
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
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Suppression d'un livre dans la BDD
        /// delete dans livre, livres_dvd puis document
        /// </summary>
        public bool SupprimerLivre(Livre livre)
        {
            try
            {
                String jsonId = convertToJson("id", livre.Id);
                // 1. Delete dans livre
                List<Object> listeLivre = TraitementRecup<Object>(DELETE, "livre/" + jsonId, null);
                if (listeLivre == null) return false;
                // 2. Delete dans livres_dvd
                List<Object> listeLivreDvd = TraitementRecup<Object>(DELETE, "livres_dvd/" + jsonId, null);
                if (listeLivreDvd == null) return false;
                // 3. Delete dans document
                List<Object> listeDoc = TraitementRecup<Object>(DELETE, "document/" + jsonId, null);
                return (listeDoc != null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Création d'un dvd dans la BDD
        /// insert dans document, livres_dvd puis dvd
        /// si un insert échoue, annulation des inserts précédents
        /// </summary>
        public bool CreerDvd(Dvd dvd)
        {
            try
            {
                // 1. Insert dans document
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

                // 2. Insert dans livres_dvd
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

                // 3. Insert dans dvd
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
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Modification d'un dvd dans la BDD
        /// update dans document puis dans dvd
        /// </summary>
        public bool ModifierDvd(Dvd dvd)
        {
            try
            {
                // 1. Update dans document
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

                // 2. Update dans dvd
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
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Suppression d'un dvd dans la BDD
        /// delete dans dvd, livres_dvd puis document
        /// </summary>
        public bool SupprimerDvd(Dvd dvd)
        {
            try
            {
                String jsonId = convertToJson("id", dvd.Id);
                // 1. Delete dans dvd
                List<Object> listeDvd = TraitementRecup<Object>(DELETE, "dvd/" + jsonId, null);
                if (listeDvd == null) return false;
                // 2. Delete dans livres_dvd
                List<Object> listeLivreDvd = TraitementRecup<Object>(DELETE, "livres_dvd/" + jsonId, null);
                if (listeLivreDvd == null) return false;
                // 3. Delete dans document
                List<Object> listeDoc = TraitementRecup<Object>(DELETE, "document/" + jsonId, null);
                return (listeDoc != null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Création d'une revue dans la BDD
        /// insert dans document puis dans revue
        /// si l'insert dans revue échoue, suppression dans document
        /// </summary>
        public bool CreerRevue(Revue revue)
        {
            try
            {
                // 1. Insert dans document
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

                // 2. Insert dans revue
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
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Modification d'une revue dans la BDD
        /// update dans document puis dans revue
        /// </summary>
        public bool ModifierRevue(Revue revue)
        {
            try
            {
                // 1. Update dans document
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

                // 2. Update dans revue
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
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Suppression d'une revue dans la BDD
        /// delete dans revue puis dans document
        /// </summary>
        public bool SupprimerRevue(Revue revue)
        {
            try
            {
                String jsonId = convertToJson("id", revue.Id);
                // 1. Delete dans revue
                List<Object> listeRevue = TraitementRecup<Object>(DELETE, "revue/" + jsonId, null);
                if (listeRevue == null) return false;
                // 2. Delete dans document
                List<Object> listeDoc = TraitementRecup<Object>(DELETE, "document/" + jsonId, null);
                return (listeDoc != null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Traitement de la récupération du retour de l'api
        /// </summary>
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
                    Console.WriteLine("code erreur = " + code + " message = " + (String)retour["message"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de l'accès à l'API : " + e.Message);
                Environment.Exit(0);
            }
            return liste;
        }

        /// <summary>
        /// Convertit en json un couple nom/valeur
        /// </summary>
        private String convertToJson(Object nom, Object valeur)
        {
            Dictionary<Object, Object> dictionary = new Dictionary<Object, Object>();
            dictionary.Add(nom, valeur);
            return JsonConvert.SerializeObject(dictionary);
        }

        /// <summary>
        /// Modification du convertisseur Json pour gérer le format de date
        /// </summary>
        private sealed class CustomDateTimeConverter : IsoDateTimeConverter
        {
            public CustomDateTimeConverter()
            {
                base.DateTimeFormat = "yyyy-MM-dd";
            }
        }

        /// <summary>
        /// Modification du convertisseur Json pour prendre en compte les booléens
        /// </summary>
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