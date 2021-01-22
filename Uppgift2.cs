using System;

namespace LexiconUppgifter
{
    class Uppgift2
    {
        //Funktion som tar in input från användaren (Förnamn, Efternamn, Ålder) och sedan skriver ut dessa i konsolen

        public void Upgft2()
        {
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 2 ==========================");
            while (true)
            {
                
            Console.WriteLine("Var god och skriv ditt förnamn:");
            var fnamn = Console.ReadLine();

            Console.WriteLine("Var god och skriv ditt efternamn:");
            var enamn = Console.ReadLine();

            Console.WriteLine("Var god och skriv din ålder:");
            var ålder = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Hej, {0} {1} som är {2}år!", fnamn,enamn,ålder  );
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
