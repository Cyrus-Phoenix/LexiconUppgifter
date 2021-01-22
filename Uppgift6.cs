using System;

namespace LexiconUppgifter
{
    class Uppgift6
    {
        public void Upgft6()
        {
            /* Funktion som genererar att slumpmässigt tal mellan 1 och 100. Användaren ska sedan gissa talet. 
             * Gissar användaren rätt så ska ett meddelande säga detta, samt hur många försök det tog. 
             * Gissar användaren fel ska ett meddelande visas som informerar ifall talet var för stort eller för litet*/
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 6 ==========================");
            while (true)
            {

                var number = new Random().Next(1, 100);
                var count = 0;

                //För och testa se så det funkar som det ska och kommenteras bort sedan.
                 Console.WriteLine("(fusk) Hemliga talet är : " + number);


                Console.Write("Gissa det hemliga talet: ");
               
                while (true)
                {
                    var guess = Convert.ToInt32(Console.ReadLine());
                    count++;
                    if(guess < number) {
                        Console.WriteLine("");
                        Console.WriteLine("Talet är för litet");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Talet är för stort");
                    }
                    else if (guess == number)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Bra jobbat!");
                       break;
                    }
                    
                    Console.Write("Försök igen: ");
                }
                Console.WriteLine("Du gissa rätt efter bara {0} försök!", count);



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
