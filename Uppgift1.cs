using System;

namespace LexiconUppgifter
{
    class Uppgift1

    // Funktion som skriver ut ”Hello World” i konsolen.
    {
        
        public void Upgft1()
        {
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 1 ==========================");
            while (true)
            {
                Console.WriteLine("Hello World!");
               

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
