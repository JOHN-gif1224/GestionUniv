# GestionUniv

Application web de gestion universitaire développée avec ASP.NET Core MVC.

## Description

Ce projet est une base d'application web MVC permettant de gérer une organisation universitaire avec une structure ASP.NET Core standard :

- Contrôleurs dans `GestionUniv/Controllers`
- Modèles dans `GestionUniv/Models`
- Vues dans `GestionUniv/Views`
- Fichiers statiques dans `GestionUniv/wwwroot`
- Configuration dans `appsettings.json`

Le projet utilise le framework ASP.NET Core et le pattern MVC.

## Prérequis

Avant de lancer le projet, assurez-vous d'avoir installé :

- .NET SDK 10 (ou la version compatible avec le projet)
- Git
- Un IDE comme Visual Studio 2022 ou VS Code

## Accès à ce dépôt par un utilisateur externe

Un utilisateur externe peut accéder au dépôt seulement dans l'un des cas suivants :

1. Le dépôt est public :
   - Il peut consulter le code directement sur GitHub.
   - Il peut le cloner avec la commande :

   ```bash
   git clone https://github.com/JOHN-gif1224/GestionUniv.git
   ```

2. Le dépôt est privé :
   - L'utilisateur doit être ajouté comme collaborateur ou avoir une invitation GitHub valide.
   - Sinon, l'accès est refusé sans authentification.

3. Téléchargement du projet :
   - Un utilisateur peut aussi télécharger le code en ZIP depuis la page GitHub du dépôt.

## Installation et exécution

```bash
git clone https://github.com/JOHN-gif1224/GestionUniv.git
cd GestionUniv

dotnet restore
dotnet build
dotnet run
```

Ensuite, ouvrez l'URL affichée par ASP.NET Core dans le navigateur, généralement :

- https://localhost:5001
- http://localhost:5000



## Fonctionnalités principales

- Architecture MVC standard
- Gestion des vues et des contrôleurs
- Gestion des erreurs via `ErrorViewModel`
- Configuration centralisée via `appsettings.json`
- Support du lancement local du projet ASP.NET Core

## Contribution

Les contributions sont les bienvenues. Pour proposer une amélioration :

1. Créez une branche
2. Modifiez le code
3. Faites un commit
4. Ouvrez une pull request

## Licence

Ce projet est fourni sans licence explicite. Vérifiez les paramètres du dépôt GitHub pour connaître les droits d'utilisation.

## Contact

Pour toute question ou demande d'accès au dépôt, contactez le propriétaire du dépôt sur GitHub : `JOHN-gif1224`.
