using System;
using System.IO;

namespace LexiconUppgifter
{
    class Uppgift7
    {
       
        public void Upgft7()
        {

            /* Funktion där användaren skriver in en textrad, som sedan sparas i en fil på hårddisken */
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT  7 ==========================");
            while (true)
            {

                try
                {
                    //**OBS** Ändra detta till där du vill att den skall sparas då detta är till en plats på min disk!
                    string path = @"C:\Users\Azer\Desktop\Skolan\Programmerings Projekten\Sparade filer\HelloWorld.txt";

                        Console.WriteLine("Skriv text som skall sparas.");
                        string Text = Console.ReadLine();


                        //Skriver över data till filen
                        File.WriteAllText(path, Text);
                       
                    
                    
                }

                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Sparat klart!");
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
