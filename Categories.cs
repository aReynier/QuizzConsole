namespace Categories
{
        public static class listCategories {
            public static List<string> RetrieveListCategories() {
                string filePath = @"C:\Users\Utilisateur\Documents\formation simplon .NET\001-projet quizz\QuizzConsole\Data\QuestionsExample.csv";
            string[] allTheQuestions = File.ReadAllLines(filePath);

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