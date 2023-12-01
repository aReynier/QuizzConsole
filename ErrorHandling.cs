namespace ErrorHandling
{
    public static class BadEntry {
        public static string HandleBadEntry(string choice, int entryNumber) {
            //warning: this code need improvment   
            if (choice == null) {
                    choice = "";
                }

            while(!int.TryParse(choice, out int value)) {
                Console.WriteLine("Veuillez rentrer un nombre");
                choice = Console.ReadLine ();
                if (choice == null) {
                    choice = "";
                }
            }

            int choiceInt = int.Parse(choice);

            while(choiceInt < 1 || choiceInt > entryNumber){
                Console.WriteLine("Veuillez rentrer le bon nombre");
                choice = Console.ReadLine ();
                if (choice == null) {
                    choice = "";
                }
                choiceInt = int.Parse(choice);

                while(!int.TryParse(choice, out int value)) {
                    Console.WriteLine("Il faut un nombre");
                    choice = Console.ReadLine ();
                    if (choice == null) {
                        choice = "";
                    }
                    choiceInt = int.Parse(choice);
                }
            }

            Console.WriteLine("Choix pris en compte");
            return choice;
        }
    }
}