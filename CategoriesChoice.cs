using Questions;
using Categories;
using ErrorHandling;

namespace CategoriesChoices
{
    public static class RetrieveCategory {
        public static void ChooseCategories() { 
            //Retrieve categories from the method
            List<string> categoriesMethod = listCategories.RetrieveListCategories();
            
            for(var secondCategoryIndex = 0; secondCategoryIndex < categoriesMethod.Count; secondCategoryIndex++){
                Console.WriteLine($"{secondCategoryIndex + 1}. {categoriesMethod[secondCategoryIndex]}");
            }

            Console.WriteLine($"Il y a {categoriesMethod.Count} catégories");
            Console.WriteLine("Quelle catégorie choisissez-vous?");

            //Ask the user
            var categoryChoiceString = Console.ReadLine ();
            categoryChoiceString = BadEntry.HandleBadEntry(categoryChoiceString, categoriesMethod.Count);

            //Send response according to the user choice
            int categoryChoiceInt = int.Parse(categoryChoiceString);
            QuestionLoop.QuestionInflux(categoriesMethod[categoryChoiceInt - 1]);

        }
    }
}