using RetrieveData;

namespace Categories
{
        public static class listCategories {
            public static List<string> RetrieveListCategories() {
                string[] allTheQuestions = File.ReadAllLines(Data.GetData());

                List<string> allTheCategories = new List<string>();

                for (var categoriesIndex = 0; categoriesIndex < allTheQuestions.Length; categoriesIndex++){
                    string[] category = allTheQuestions[categoriesIndex].Split(";");
                    if(allTheCategories.IndexOf(category[0]) == -1)
                    allTheCategories.Add(category[0]);
                }

                return allTheCategories;
            }
        }
}