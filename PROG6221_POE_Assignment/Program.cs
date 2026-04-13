//
using System;

class program
{
    static void Main(string[] args)
    {
       //ASCII Title for the
        Console.WriteLine("===================================");

        // ASCII Art Text
        Console.WriteLine("    _    ___      _           _        _   ");
        Console.WriteLine("   / \\  |_ _|    / \\   ___ __(_)___   / |_ ");
        Console.WriteLine("  / _ \\  | |    / _ \\ / __/ __| / __| | __|");
        Console.WriteLine(" / ___ \\ | |   / ___ \\ (_| (__| \\__ \\ | |_ ");
        Console.WriteLine("/_/   \\_\\___| /_/   \\_\\___\\___|_|___/  \\__|");
        Console.WriteLine("                                           ");
        Console.WriteLine("        AI Assistant");

        Console.WriteLine("------------------------------------");
        Console.WriteLine("");
        Console.Write("What is your name? ");
        String sName = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Wow, " + sName + " Sounds like a great name"); 
    }
}
