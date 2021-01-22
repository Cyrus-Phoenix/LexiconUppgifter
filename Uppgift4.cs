using System;

namespace LexiconUppgifter
{
    class Uppgift4
    {
        public void Upgft4()
        {
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 4 ==========================");
            //Funktion för att skriva ut dagens datum

            while (true)
            {

                DateTime now = DateTime.Now;
                Console.WriteLine("Dagens datum är den {0} / {1} / {2}", now.DayOfYear, now.Month, now.Year);
                //alternativt
                Console.WriteLine("");
                Console.WriteLine("Dagens datum är den {0}", now.Date);




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
