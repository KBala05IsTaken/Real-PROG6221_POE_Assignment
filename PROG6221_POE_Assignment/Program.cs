//
using System;
using System.Data;
using System.Media;
using System.Xml.Linq;

class program
{
    static void Main(string[] args)
    {
        //ASCII Title for the
        Console.WriteLine("===================================");
         
        // ASCII Art Text
        Console.ForegroundColor = ConsoleColor.Blue;//Changes the ASCII title to blue
        Console.WriteLine("    _    ___      _           _        _   ");
        Console.WriteLine("   / \\  |_ _|    / \\   ___ __(_)___   / |_ ");
        Console.WriteLine("  / _ \\  | |    / _ \\ / __/ __| / __| | __|");
        Console.WriteLine(" / ___ \\ | |   / ___ \\ (_| (__| \\__ \\ | |_ ");
        Console.WriteLine("/_/   \\_\\___| /_/   \\_\\___\\___|_|___/  \\__|");
        Console.WriteLine("                                           ");
        Console.ResetColor();
        Console.WriteLine("        AI Assistant");
        String sName = "";

        InputtingName(sName);//Uses a method to get the user's name
        

        //Asks for the user's name
        Console.WriteLine("------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Alright then " + sName + ", What would you like to do? (Only type in the number on your keyboard)");
        Console.WriteLine();


        //Based on the different number the user chooses the bot will give a differnt result
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("(1) How do you feel?");
        Console.WriteLine("(2) What is your purpose?");
        Console.WriteLine("(3) What can I ask of you, regarding cybersecurity?");
        Console.ResetColor();
        Console.Write("Enter here: ");
        String sAnswer1 = Console.ReadLine();
        Console.WriteLine("");

        switch (sAnswer1)
        {   //Choi
            case "1":
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("I feel great. Thank you so much for asking me " +sName+ 
                    ". I hope that as your AI assistant that I can be helpful to you.");
                Console.ResetColor();
                break;

            case "2":
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("My purpose as an AI Assistant is to to help you be more aware of the dangers of the " +
                    "internet in terms of Cybersecurity, " +sName+ ".");
                Console.ResetColor();
                break;

            case "3":
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Okay then " +sName+ ", what would you like to know about?");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("(1) Password safety");
                Console.WriteLine("(2) Phishing");
                Console.WriteLine("(3) Safe browsing");
                Console.ResetColor();
                Console.Write("Enter here: ");
                String sAnswer2 = Console.ReadLine();
                Console.WriteLine("");

                switch(sAnswer2)
                {
                    case "1":
                        Console.WriteLine("------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Password safety refers to the collection of practices and " +
                            "technologies used to protect your accounts from unauthorized access. " +
                            "It serves as your primary line of defense against hackers who attempt to steal " +
                            "personal information, identity, or money.");
                        Console.ResetColor();
                        break;

                    case "2":
                        Console.WriteLine("------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Phishing is a cyberattack where scammers impersonate trusted " +
                            "entities via email, text, or phone to steal sensitive information—passwords, " +
                            "credit card numbers, or bank details. Attackers use urgent, alarming messages to " +
                            "trick victims into clicking malicious links, downloading malware, or visiting fake websites.");
                        Console.ResetColor();
                        break;

                    case "3":
                        Console.WriteLine("------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Safe Browsing launched in 2005 to protect users across the web from phishing " +
                            "attacks, and has evolved to give users tools to help protect themselves from web-based threats " +
                            "like malware, unwanted software, and social engineering across desktop and mobile platforms.");
                        Console.ResetColor();
                        break;

                    default:
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Error: Sorry, I couldn't really determine your answer of " + sAnswer2);
                        break;
                }
                break;

            default:
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Error: Sorry, I couldn't really determine your answer of " + sAnswer1);
                break;
        }



        Console.WriteLine("===================================");
    }
    public static void InputtingName(string name) 
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("");
        Console.Write("What is your name? ");
        name = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Wow, " + name + " Sounds like a great name");
    }
}



