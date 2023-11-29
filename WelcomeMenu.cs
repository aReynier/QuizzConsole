using Questions;
using Categories;
using CategoriesChoices;

namespace WelcomeMenu
{
    public static class WelcomeChoices {
        public static void MakeWelcomeChoice() {
            var welcomeChoice = Console.ReadLine ();
            if (welcomeChoice == "1"){
                Console.WriteLine($"Vous avez choisi {welcomeChoice}");

                //Retrieve categories from the method
                List<string> categoriesMethodTest = listCategories.RetrieveListCategories();
                
                int randomQuizzInt = new Random().Next(0,categoriesMethodTest.Count);
                
                QuestionLoop.QuestionInflux(categoriesMethodTest[randomQuizzInt]);
                
            }else if(welcomeChoice == "2") {
                Console.WriteLine($"Vous avez choisi {welcomeChoice}");
                ChooseCategories.RetrieveCategory();
            }else if(welcomeChoice == "3") {
                Console.WriteLine($"Vous avez choisi {welcomeChoice}");
            // Left the game part
            Console.WriteLine("Au revoir");
            }
        }
    }
}