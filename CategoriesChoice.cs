using Questions;
using Categories;

namespace CategoriesChoices
{
    public static class ChooseCategories {
        public static void RetrieveCategory() { 
            Console.WriteLine("Quelle catégorie choisissez-vous?");

            //Retrieve categories from the method
            List<string> categoriesMethodTest = listCategories.RetrieveListCategories();
            
            for(var secondCategoryIndex = 0; secondCategoryIndex < categoriesMethodTest.Count; secondCategoryIndex++){
                Console.WriteLine($"{secondCategoryIndex + 1}. {categoriesMethodTest[secondCategoryIndex]}");
            }

            var categoryChoiceString = Console.ReadLine ();
            //Watch out, errors to prevent 
            int categoryChoiceInt = int.Parse(categoryChoiceString);

            //Watch out, errors to prevent 
            QuestionLoop.QuestionInflux(categoriesMethodTest[categoryChoiceInt - 1]);
        }
    }
}