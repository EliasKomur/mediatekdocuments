# MediatekDocuments

Ce dépôt est un fork du dépôt d'origine [CNED-SLAM/MediaTekDocuments](https://github.com/CNED-SLAM/MediaTekDocuments) qui contient, dans son readme, la présentation de l'application d'origine (fonctionnalités de consultation).

## Présentation

Cette application de bureau C# (.NET Framework 4.7.2) permet au personnel d'une médiathèque de gérer l'ensemble du catalogue de documents (livres, DVD, revues), les commandes, les abonnements et le suivi des exemplaires. Elle communique avec une API REST PHP hébergée en ligne sur AlwaysData.

Par rapport à l'application d'origine, les fonctionnalités suivantes ont été ajoutées.

---

## Fonctionnalités ajoutées

### Authentification
Un formulaire de connexion s'affiche au démarrage de l'application. L'utilisateur doit saisir son login et son mot de passe. Les droits d'accès sont adaptés selon le service de l'utilisateur connecté :
- **admin** : accès complet à toutes les fonctionnalités
- **prêts** : accès en lecture seule aux documents (pas de modification, pas de commandes)
- **culture** : accès refusé

### Gestion des documents (ajout, modification, suppression)
Dans les onglets Livres, DVD et Revues, il est désormais possible d'**ajouter**, **modifier** et **supprimer** des documents via des boutons dédiés. Les formulaires comportent des contrôles de saisie (champs obligatoires, formats).

### Gestion des commandes de livres et DVD
Un nouvel onglet permet de gérer les commandes de livres et DVD :
- Créer une commande (date, montant, nombre d'exemplaires)
- Faire évoluer le stade de la commande (en cours de livraison → livrée → réglée)
- Supprimer une commande (uniquement si elle est encore en cours)

### Gestion des abonnements aux revues
Un nouvel onglet permet de gérer les abonnements aux revues :
- Créer un abonnement avec date de fin
- Supprimer un abonnement
- Alerte automatique si un abonnement expire dans moins de 30 jours

### Suivi de l'état des exemplaires
Dans l'onglet de réception des revues, il est désormais possible de :
- Modifier l'état d'un exemplaire (disponible, emprunté, en retard...)
- Supprimer un exemplaire

---

## L'API REST en ligne

L'application est configurée pour utiliser l'API REST hébergée sur AlwaysData :

```
https://eliask.alwaysdata.net
```

Le dépôt de l'API REST est disponible ici :
[github.com/EliasKomur/rest_mediatekdocuments](https://github.com/EliasKomur/rest_mediatekdocuments)

Le mode opératoire complet pour utiliser l'API est disponible dans le README de ce dépôt.

### Où trouver les ressources
- **Installeur (.msi)** : dossier `MediaTekDocumentsSetup/Debug/`
- **Script SQL de la BDD** : dépôt API (`rest_mediatekdocuments/mediatek86.sql`)
- **Documentation technique** : générée en XML dans `bin/Debug/MediaTekDocuments.xml`

---

## Installation et utilisation en local

### Prérequis
- Visual Studio 2022 (ou 2019) avec .NET Framework 4.7.2
- WampServer (ou équivalent) pour l'API en local
- Git

### Étapes

**1. Cloner le dépôt**
```bash
git clone https://github.com/EliasKomur/mediatekdocuments.git
```

**2. Récupérer et installer l'API REST en local**

Cloner le dépôt de l'API dans le dossier `www` de WampServer :
```bash
git clone https://github.com/EliasKomur/rest_mediatekdocuments.git
```
Suivre le mode opératoire dans le README de ce dépôt pour installer les dépendances et la BDD.

**3. Configurer l'URL de l'API dans App.config**

Pour utiliser l'API en local, modifier la valeur dans `MediaTekDocuments/App.config` :
```xml
<add key="ApiUrl" value="http://localhost/rest_mediatekdocuments/" />
```

Pour utiliser l'API en ligne :
```xml
<add key="ApiUrl" value="https://eliask.alwaysdata.net/" />
```

**4. Ouvrir la solution dans Visual Studio**

Ouvrir `MediaTekDocuments.sln`, puis lancer avec F5.

**5. Identifiants de connexion**

Les identifiants sont disponibles dans la table `utilisateur` de la base de données. Ils sont fournis séparément au formateur.

---

## Lancer les tests

Ouvrir la solution dans Visual Studio, puis dans le menu **Test → Exécuter tous les tests**.

Ou via la commande :
```bash
dotnet test
```

---

## Technologies utilisées

| Technologie | Version |
|-------------|---------|
| C# / .NET Framework | 4.7.2 |
| Windows Forms | — |
| Newtonsoft.Json | 13.0.4 |
| MSTest | 2.2.10 |
| Serilog | 2.10.0 |
