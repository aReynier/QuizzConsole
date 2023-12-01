# Récupérer le projet

Bienvenue, pour récupérer le projet il suffit de copier le dépôt git.

# Lancer le projet 

Pour lancer le projet, une fois le dossier quizzconsole ouvert dans VScode, le lancer en cliquant sur la flèche de lancement/debug en haut à droite de la fenêtre.

# Les étapes de mon jeu de quizz :

## Fichier initial
Le début du code se trouve dans le fichier programme, il appelle deux méthodes liées à notre jeux: l'accueil et le choix initial

## Message d'accueil
La méthode PrintMessage de la classe WelcomeMessages sité dans le fichier Welcome accueille le joueur et lui explique le fonctionnement du quizz.à la suite de ces messages se trouve la méthode du menu racine.

## Menu racine
La méthode MakeRootMenuChoice de la classe RootMenuChoices situé dans le fichier RootMenu comporte les choix du menu. Trois choix sont proposés:
1. Démarrer un quizz au hasard"
2. Choisir une catégorie"
3. Quitter
il est demandé à l'utilisateur de rentrer une variable qui sera stockée et comparée au moyen d'un if si il correspond à l'un des trois choix. Si l'utilisateur ne rentre pas le nombre demandé, une méthode est placée préalablement à cette conditionnelle

## Gestion des erreurs d'entrée
Si l'entrée est différente des entrée attendues, c'est à dire si l'utilisateur rentre une entrée qui n'est pas un chiffre ou un mauvais chiffre, cette méthode bouclera avec un ensemble de while et de if tant que l'utilisateur ne rentrera pas le chiffre demandé. Cette méthode prend deux arguments d'entrée, le choix rentré en string ainsi que le nombre d'entrée attendu en int.

## Récupérer le fichier CSV

Utilisation de la méthode ... pour récupérer lSéparer les champs ...

### Récupérer la liste des questions

Quelle est la structure de ma liste de questions ?
 - **Les différents type de collection**

1. List<>
2. Dictionnary<>
3. string[]

Si on fait un tableau de string pour lister les intitulés, comment lier chaque question à ses réponses ?
Il est temps de construire des classes : une classe Question qui contient une liste de réponse.

## Acceuillir le joueur

## Demander la catégorie (dans un second temps) et filtrer la liste des questions

## Parcourir les questions (boucle)
Pour chacune d'entre elles
1. **Poser la question**

2. **Donner les réponses possibles**

3. **Vérifier si la réponse est bonne/mauvaise/une erreur**

4. **Informer l'utilisateur du résultat et afficher son score**

5. **Boucler**

## Afficher un message d'au revoir avec le score lorsque l'ensemble des questions ont été posées