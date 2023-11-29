using System;
using System.IO;

using Welcome;
using WelcomeMenu;
using Questions;

internal class Program
{
    private static void Main(string[] args)
    {
        WelcomeMessages.PrintMessages();
        WelcomeChoices.MakeWelcomeChoice();
    }
}