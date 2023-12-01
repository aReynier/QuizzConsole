using Questions;
using Categories;
using CategoriesChoices;
using ErrorHandling;

namespace RootMenu
{
    public static class RootMenuChoices {
        public static void MakeRootMenuChoice() {
            Console.WriteLine("1. Démarrer un quizz au hasard");
            Console.WriteLine("2. Choisir une catégorie");
            Console.WriteLine("3. Quitter");

            //First demand
            var welcomeChoice = Console.ReadLine ();
            //error entry handling
            welcomeChoice = BadEntry.HandleBadEntry(welcomeChoice,3);

            if (welcomeChoice == "1"){
                Console.WriteLine($"Vous avez choisi {welcomeChoice}");

                //Retrieve categories from the method
                List<string> categoriesMethod = listCategories.RetrieveListCategories();
                int randomCategoryInt = new Random().Next(0,categoriesMethod.Count);
                
                //Question loop with a random category
                QuestionLoop.QuestionInflux(categoriesMethod[randomCategoryInt]);
                
            }else if(welcomeChoice == "2") {
                ChooseCategories.RetrieveCategory();
            }else if(welcomeChoice == "3") {
            // Left the game part
            Console.WriteLine("Au revoir");
            }
        }
    }
}