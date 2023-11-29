using System.Linq;

namespace Questions
{
    public static class QuestionLoop {
        public static void QuestionInflux(string categoryName) {
            //Player's score
            var score = 0;
            
            //Retrieve question datas
            string filePath = @"C:\Users\Utilisateur\Documents\formation simplon .NET\001-projet quizz\QuizzConsole\Data\QuestionsExample.csv";
            
            //Found how to filter questions with the right category
            string[] allTheQuestions = File.ReadAllLines(filePath);

            string[] filteredQuestions = allTheQuestions.Where(question => question.Contains(categoryName)).ToArray();
            
            Console.WriteLine($"Les questions concerneront la catégorie {categoryName}");
            for (int quizIndex = 0; quizIndex < filteredQuestions.Length; quizIndex++) {
                Console.WriteLine($"Voici la question {quizIndex + 1}");
                
                //Question isolation, put into arrays
                //Multidimentionnal array?
                string[] question = filteredQuestions[quizIndex].Split(";");
                Console.WriteLine(question[0]);
                Console.WriteLine(question[1]);
                string[] questionProposals = question[2].Split("/");

                for (int questionIndex = 0; questionIndex < questionProposals.Length; questionIndex++) {
                    Console.WriteLine($"{questionIndex + 1}. {questionProposals[questionIndex]}");
                }
                var answer = Console.ReadLine ();

                //Check the answer
                if (answer == question[3]){
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
        }
    }
}
