using System;

namespace LexiconUppgifter
{
    class Uppgift5
    {


        public void Upgft5()
        {
            //Skriv en funktion som tar 2 input värden, sedan skriver ut vilken som är störst
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 5 ==========================");
            while (true)
            {

                Console.WriteLine("Var god skriv ett tal");
                var talEtt = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Var god skriv ett nytt tal");
                var talTva = Convert.ToInt32(Console.ReadLine());

                if(talEtt < talTva)
                {
                    Console.WriteLine("Den största talet mellan de två angivna är: {0}", talTva);
                }
                else
                Console.WriteLine("Den största talet mellan de två angivna är: {0}", talEtt);


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
