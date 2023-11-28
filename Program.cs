using System;
using Questions;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        //Welcome the player
        Console.WriteLine("Bienvenue sur la plate-forme de quizz: que voulez-vous faire?");
        Console.WriteLine("1. Démarrer un quizz au hasard");
        Console.WriteLine("2. Choisir une catégorie");
        Console.WriteLine("3. Quitter");
        Console.WriteLine("Ecrivez le chiffre correspondant");
        var text = Console.ReadLine ();

        //quizz part
        if (text == "1") {
            //Player's score
            var score = 0;

            //Retrieve question datas
            string filePath = @"C:\Users\Utilisateur\Documents\formation simplon .NET\001-projet quizz\QuizzConsole\Data\QuestionsExample.csv";
            string[] allTheQuestions = File.ReadAllLines(filePath);
            
            for (int quizIndex = 0; quizIndex < allTheQuestions.Length; quizIndex++) {
                Console.WriteLine($"Voici la question {quizIndex + 1}");
                //Question isolation, put into arrays
                //Multidimentionnal array?
                string[] question = allTheQuestions[quizIndex].Split(";");
                Console.WriteLine(question[0]);
                string[] questionProposals = question[1].Split("/");

                for (int questionIndex = 0; questionIndex < questionProposals.Length; questionIndex++) {
                    Console.WriteLine($"{questionIndex + 1}. {questionProposals[questionIndex]}");
                }
                var answer = Console.ReadLine ();

                //Check the answer
                if (answer == question[2]){
                    Console.WriteLine("Bravo! C'est la bonne réponse");
                    score ++;
                    Console.WriteLine($"Votre score est de {score}");
                    Console.WriteLine($"-------");
                } else {
                    Console.WriteLine("Mauvaise réponse");
                    Console.WriteLine($"Votre score est de {score}");
                    Console.WriteLine($"-------");
                }
            }

            Console.WriteLine($"Votre score final est de {score}");
            Console.WriteLine("Le quizz est terminé");

            //Give the player the pportunity to choose options again
        } else if (text == "2") {
            //category part
            Console.WriteLine("Cette fonctionnalité n'est pas encore disponible");
        }else if (text == "3") {
            //Left the game part
            Console.WriteLine("Au revoir");
        }
    }
}