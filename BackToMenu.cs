using ErrorHandling;
using RootMenu;

namespace BackToMenu
{
 public static class BackToMenuProposal {
        public static void BackToMenuChoice() {

            Console.WriteLine("1. Revenir au menu initial");
            Console.WriteLine("2. Quitter le jeux");

            var menuChoice = Console.ReadLine ();
            menuChoice = BadEntry.HandleBadEntry(menuChoice, 2);

            if (menuChoice == "1"){
                RootMenuChoices.MakeRootMenuChoice();
            } else if (menuChoice == "2") {
                Console.WriteLine("Au revoir");
            }
        }
    }
}