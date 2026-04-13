//
using System;
using System.Data;

class program
{
    static void Main(string[] args)
    {
        //ASCII Title for the
        Console.WriteLine("===================================");

        // ASCII Art Text
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("    _    ___      _           _        _   ");
        Console.WriteLine("   / \\  |_ _|    / \\   ___ __(_)___   / |_ ");
        Console.WriteLine("  / _ \\  | |    / _ \\ / __/ __| / __| | __|");
        Console.WriteLine(" / ___ \\ | |   / ___ \\ (_| (__| \\__ \\ | |_ ");
        Console.WriteLine("/_/   \\_\\___| /_/   \\_\\___\\___|_|___/  \\__|");
        Console.WriteLine("                                           ");
        Console.ResetColor();
        Console.WriteLine("        AI Assistant");

        Console.WriteLine("------------------------------------");
        Console.WriteLine("");
        Console.Write("What is your name? ");
        String sName = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Wow, " + sName + " Sounds like a great name");

        //Options
        Console.WriteLine("------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Alright then " + sName + ", What would you like to do? (Only type in the number on your keyboard)");
        Console.WriteLine();

        Console.WriteLine("(1) How do you feel?");
        Console.WriteLine("(2) What is your purpose?");
        Console.WriteLine("(3) What can I ask of you, regarding cybersecurity?");
        Console.Write("Enter here: ");
        String sAnswer1 = Console.ReadLine();
        Console.WriteLine("");

        switch (sAnswer1)
        {
            case "1":
                Console.WriteLine("------------------------------------");
                Console.WriteLine("I feel great. Thank you so much for asking me " +sName+ 
                    ". I hope that as your AI assistant that I can be helpful to you.");
                break;

            case "2":
                Console.WriteLine("------------------------------------");
                Console.WriteLine("My purpose as an AI Assistant is to to help you be more aware of the dangers of the " +
                    "internet in terms of Cybersecurity, " +sName+ ".");
                break;

            case "3":
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                break;

            default:
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Error: Sorry, I couldn't really determine your answer of " + sAnswer1 +
                    ". Could you please rephrase your answer.");
                break;
        }



        Console.WriteLine("===================================");
    }
}

