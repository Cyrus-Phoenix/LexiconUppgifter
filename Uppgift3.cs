using System;

namespace LexiconUppgifter
{
    class Uppgift3
    {
        //Funktion som ändrar färgen på texten i konsolen (och ändrar tillbaka om man använder funktionen igen
        public static void resetConsole()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void resetToMenu()
        {
            
        }
        public void Upgft3()
        {
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 3 ==========================");
            while (true)
            {

                

                if (Console.ForegroundColor != ConsoleColor.Gray)
                {
                    Console.ResetColor();
                    //resetConsole();
                    Console.WriteLine("Text färgen är återställd");
                }
                else if(Console.ForegroundColor == ConsoleColor.Gray)
                {
                    // Set the Foreground color to blue 
                    Console.ForegroundColor
                        = ConsoleColor.Green;
                    Console.WriteLine("Text färgen ändrats till: {0}",
                                         Console.ForegroundColor);

                }

                Console.WriteLine("");


                //Tillbaka till listan
                Console.WriteLine("");
                Console.Write("skriv 'tbx' för att återvända till val av uppgift ( annars klicka på 'enter' på tangentbordet för att köra uppgiften igen ): ");
                Console.WriteLine("");
                var input = Console.ReadLine();
                if (input.ToLower() == "tbx")
                    break;

            }
        }
    }
}
