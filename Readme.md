# Récupérer le projet

Bienvenue, pour récupérer le projet il suffit de copier le dépôt git.

# Lancer le projet 

Pour lancer le projet, une fois le dossier QuizzConsole ouvert dans VS, le lancer en cliquant sur la flèche

# Les étapes de mon jeu de quizz :

## Fichier initial (Program)
Le début du code se trouve dans le fichier programme, il appelle deux méthodes liées à notre jeux: l'accueil et le choix initial

## Message d'accueil (Welcome)
La méthode PrintMessage de la classe WelcomeMessages sité dans le fichier Welcome accueille le joueur et lui explique le fonctionnement du quizz.à la suite de ces messages se trouve la méthode du menu racine.

## Menu racine (RootMenu)
La méthode MakeRootMenuChoice de la classe RootMenuChoices situé dans le fichier RootMenu comporte les choix du menu. Trois choix sont proposés:
1. Démarrer un quizz au hasard"
2. Choisir une catégorie"
3. Quitter
il est demandé à l'utilisateur de rentrer une variable qui sera stockée et comparée au moyen d'un if si il correspond à l'un des trois choix. Si l'utilisateur ne rentre pas le nombre demandé, une méthode est placée préalablement à cette conditionnelle

## Gestion des erreurs d'entrée (ErrorHandling)
Si l'entrée est différente des entrée attendues, c'est à dire si l'utilisateur rentre une entrée qui n'est pas un chiffre ou un mauvais chiffre, cette méthode bouclera avec un ensemble de while et de if tant que l'utilisateur ne rentrera pas le chiffre demandé. Cette méthode prend deux arguments d'entrée, le choix rentré en string ainsi que le nombre d'entrée attendu en int.

## Récupérer le fichier CSV (RetrieveData)

Utilisation de la méthode GetData dans la classe Data du fichier RetrieveData, récupération des données au moyen d'un chemin absolu.

## Récupérer les catégories (Categories)
1. string[] allTheQuestions
Récupération de toutes les question dans un tableau

2. List<string> allTheCategories
Récupération de toutes les catégories dans une liste vide

Ensuite une boucle est faites avec chaque question, dans cette boucle, il est testé à chaque question si le nom n'est pas présent dans la liste. Lorsque le nom est manquant, il est ajouté à la liste.

Enfin, Cette méthode renvoie les catégories une fois toutes la questions passées en revue.

## Passage d'une catégorie au hasard (RandomCategory)
Utilisation de la méthode GenerateRandomCategory de RandomCategoryList dans le fichier RandomCategory. Utilisation des catégories pour générer une catégorie au hasard dans une variable.

## Choisir la catégorie (CategoriesChoice)
Utilisation de la méthode ChooseCategory de retrieveCategory dans le ficher Category. La liste de catégorie de la méthode précédente est récupéré, présenté au moyen d'une boucle.
Il est demandé à l'utilisateur de rentré un choix, géré par ErrorHandling.
Une fois son choix effectué, le nom de la catégorie est renvoyé au flux de question conformément au choix numérique de l'utilisateur

## Récupérer la liste des questions (Questions)

Méthode de gestion du flux de question QuestionInflux dans la classe QuestionLoop dans le fichier Questions. Le score utilisateur est initialisé dans une variable.
. string[] allTheQuestions
Les données des questions sont récupérées dans un tableau.
. string[] filteredQuestions
Le tableau est flitré en fonction du nom de la catégorie reçu par la méthode, précédemment choisie ou au hasard en fonction du choix de l'utilisateur, dont le nombre est passé en paramètre.

1. **Poser les question avec une boucle**
. for()
Ensuite, les lignes sont bouclée, donnant une ligne = traitement d'une question. 
. string[] question
Chaque ligne et splité en tableau pour récupérer les types de données
Pour poser la question on affiche l'index question[1]
2. **Donner les réponses possibles**
. string[] questionProposals
Le tableau question est lui même splité dans une autre tableau pour récupérer les réponses.
une boucle for () est faite pour afficher chaque réponse

3. **Vérifier si la réponse est bonne/mauvaise/une erreur**
Un string answer est demandé à l'utilisateur qui doit entrer un numéro, toujours pris en charge par le ErrorHandling. Cette réponse est comparée à question[3] qui correspond au numéro de la bonne réponse

4. **Informer l'utilisateur du résultat et afficher son score**
Dans la conditionnelle un message est affiché et si la réponse est bonne, en plus du message le score est incrémenté. Dans les deux cas le score est affiché.

La réponse de l'utilisateur est demandée avec ErrorHandling, la réponse est comparée avec la réponse attendue, si c'est le cas, la réponse est comptée comme bonne et l'utilisateur reçoit un point de plus, autremeent la réponse est comptée comme fausse.
A la fin de la boucle des questions le score final de l'utilisateur est annoncé

## Après le quizz (BackToMenu)
Une fois le quizz fait, il est proposé à l'utilisateur de revenir au menu racine ou de quitter le jeux, comme ailleurs, présence du ErrorHandling
