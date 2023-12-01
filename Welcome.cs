using RootMenu;

namespace Welcome

{
    public static class WelcomeMessages {
        public static void PrintMessages() {
            Console.WriteLine("Bienvenue sur la plate-forme de quizz: que voulez-vous faire?");
            Console.WriteLine("Pour répondre, écrivez à chaque fois le chiffre correspondant");
            RootMenuChoices.MakeRootMenuChoice();
        }
    }
}