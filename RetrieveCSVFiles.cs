namespace RetrieveCSVFiles

{
    public static class RetrieveCSVFilesNumber {

        public static void HaveCSVFilesNumber() {
            string folderPath = @"C:\Users\Utilisateur\Documents\formation simplon .NET\001-projet quizz\QuizzConsole\Data";

            string[] csvFiles = Directory.GetFiles(folderPath, "*.csv");

            if (csvFiles.Any())
            {
                Console.WriteLine($"Il y a actuellement {csvFiles.Length} quizz");
            }
        }
    }
}