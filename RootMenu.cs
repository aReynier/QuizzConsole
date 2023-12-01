using RandomCategory;
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
                //Question loop with a random category
                RamdomCategoryList.GenerateRandomCategory();
 
            }else if(welcomeChoice == "2") {
                RetrieveCategory.ChooseCategories();
            }else if(welcomeChoice == "3") {
                // Left the game part
                Console.WriteLine("Au revoir");
            }
        }
    }
}