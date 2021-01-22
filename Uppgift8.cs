using System;
using System.IO;

namespace LexiconUppgifter
{
    class Uppgift8
    {
        public void Upgft8()
        {

            /* Funktion där en fil läses in från hårddisken (för enkelhetens skull kan man använda filen från uppgift 7) */
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT  8 ==========================");
            while (true)
            {
                String line;
                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    //**Platsen där filen är sparad**
                    StreamReader sr = new StreamReader(@"C:\Users\Azer\Desktop\Skolan\Programmerings Projekten\Sparade filer\HelloWorld.txt");
                    
                    //Read the first line of text
                    line = sr.ReadLine();

                    //Continue to read until you reach end of file
                    while (line != null)
                    {
                        //write the line to console window
                        Console.WriteLine(line);
                       
                        //Read the next line
                        line = sr.ReadLine();
                    }

                    //close the file
                    sr.Close();
                   
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Läst klart.");
                   
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
