using Categories;
using Questions;

namespace RandomCategory {
    public static class RamdomCategoryList {
        public static void GenerateRandomCategory() {
                //Retrieve categories from the method
                List<string> categoriesMethod = listCategories.RetrieveListCategories();
                int randomCategoryInt = new Random().Next(0,categoriesMethod.Count);

                QuestionLoop.QuestionInflux(categoriesMethod[randomCategoryInt]);
               
        }  
    }
}       