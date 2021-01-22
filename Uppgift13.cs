using System;
using System.Collections.Generic;
using System.Linq;

namespace LexiconUppgifter
{
    class Uppgift13
    {
        public void Upgft13()
        {
            //Funktion som tar två inputs från användaren och skriver sedan ut alla siffror som är mellan de två inputsen.
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 13 ==========================");
            while (true)
            {
                Console.Write("Input1: ");
                var input1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input2: ");
                var input2 = Convert.ToInt32(Console.ReadLine());

                IEnumerable<int> numbers = Enumerable.Range(input1, input2);

                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
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
