using RetrieveData;
using ErrorHandling;
using BackToMenu;

namespace Questions
{
    public static class QuestionLoop {
        public static void QuestionInflux(string categoryName) {
            //Player's score
            var score = 0;
            
            //Found how to filter questions with the right category
            string[] allTheQuestions = File.ReadAllLines(Data.GetData());

            string[] filteredQuestions = allTheQuestions.Where(question => question.Contains(categoryName)).ToArray();
            
            Console.WriteLine($"Les questions concerneront la catégorie {categoryName}");
            for (int quizIndex = 0; quizIndex < filteredQuestions.Length; quizIndex++) {
                Console.WriteLine($"Voici la question {quizIndex + 1}");
                
                //Question isolation, put into arrays
                //Multidimentionnal array?
                string[] question = filteredQuestions[quizIndex].Split(";");
                Console.WriteLine(question[1]);
                string[] questionProposals = question[2].Split("/");

                for (int questionIndex = 0; questionIndex < questionProposals.Length; questionIndex++) {
                    Console.WriteLine($"{questionIndex + 1}. {questionProposals[questionIndex]}");
                }
                Console.WriteLine($"Il y a actuellement {questionProposals.Length} réponses possibles");
                
                string answer = Console.ReadLine ();
                answer = BadEntry.HandleBadEntry(answer, questionProposals.Length);

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
            Console.WriteLine($"-------");

            BackToMenuProposal.BackToMenuChoice();
        }
    }
}
