using System;

namespace LexiconUppgifter
{
    class Uppgift11
    {

        
            public void Upgft11()
        {
            /* 
             * Funktion som skapar två arrayer. Den första fylls med slumpmässiga tal. Den andra fylls med talen från den första i stigande ordning.
             */
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 11 ==========================");
            while (true)
            {

                int Min = 0;
                int Max = 20;

                // Första Array
                int[] test1 = new int[5];

                Random randNum = new Random();
                for (int i = 0; i < test1.Length; i++)
                {
                    test1[i] = randNum.Next(Min, Max);
                }

                foreach ( var number in test1 )
                {
                    Console.WriteLine("Första Array "+number);
                }


                // Andra Array
                int[] test2 = new int[5];

                test1.CopyTo(test2,0);
                Array.Sort(test2);

                foreach (var number in test2)
                {
                    Console.WriteLine("Andra Array "+number);
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
