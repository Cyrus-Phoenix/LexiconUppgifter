using System;

namespace LexiconUppgifter
{
    class Uppgift10
    {

        public void Upgft10()
        {

            /*
             * Funktion där programmet skriver ut en multiplikationstabell från 1 till 10. 
             * En ”tab”ska läggas in efter varje nummer. 
             * Försök att ställa upp det så det blir relativt läsbart.
             */

            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 10 ==========================");
            while (true)
            {

                for (int tabell = 1; tabell <= 10; tabell++)
                {
                    Console.WriteLine(tabell + ":ans tabell");
                    for (int tal = 1; tal <= 10; tal++)
                    {
                        Console.Write(tabell + "x" + tal + "=" + tabell * tal + "   ");
                        
                    }
                    Console.WriteLine("");
                  
                }


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
