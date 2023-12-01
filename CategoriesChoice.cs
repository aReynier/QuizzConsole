using Questions;
using Categories;
using System.Security.Cryptography.X509Certificates;
using ErrorHandling;

namespace CategoriesChoices
{
    public static class ChooseCategories {
        public static void RetrieveCategory() { 
            //Retrieve categories from the method
            List<string> categoriesMethod = listCategories.RetrieveListCategories();
            
            for(var secondCategoryIndex = 0; secondCategoryIndex < categoriesMethod.Count; secondCategoryIndex++){
                Console.WriteLine($"{secondCategoryIndex + 1}. {categoriesMethod[secondCategoryIndex]}");
            }

            Console.WriteLine($"Il y a {categoriesMethod.Count} catégories");
            Console.WriteLine("Quelle catégorie choisissez-vous?");
            //First demand
            var categoryChoiceString = Console.ReadLine ();
            categoryChoiceString = BadEntry.HandleBadEntry(categoryChoiceString, categoriesMethod.Count);

            if (categoryChoiceString != null) {
                int categoryChoiceInt = int.Parse(categoryChoiceString);
                //Watch out, errors to prevent 
                QuestionLoop.QuestionInflux(categoriesMethod[categoryChoiceInt - 1]);
            } 

            while (categoryChoiceString == null) {
                categoryChoiceString = Console.ReadLine ();
                categoryChoiceString = BadEntry.HandleBadEntry(categoryChoiceString, categoriesMethod.Count);
            }

            if (categoryChoiceString != null) {
                int categoryChoiceInt = int.Parse(categoryChoiceString);
                //Watch out, errors to prevent 
                QuestionLoop.QuestionInflux(categoriesMethod[categoryChoiceInt - 1]);
            }

           }
    }
}