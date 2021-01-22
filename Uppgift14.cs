using System;
using System.Linq;

namespace LexiconUppgifter
{
    class Uppgift14
    {
        //Funktion där användaren skickar in ett antal värden (komma-separerade siffror) som sedan sorteras och skrivs ut efter udda och jämna värden.
        public void Upgft14()
        {
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 14 ==========================");
            while (true) { 
            Console.WriteLine("Var god och ange hur många nummer som vill skrivas och sorteras: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Var god och skriv nummerna som ska sorteras följt av kommatecken:");
            string input = Console.ReadLine();

            int[] numbers = input.Split(',').Select(input => Convert.ToInt32(input)).ToArray();
            Array.Sort(numbers);
            
            // test värden: 21,35,2,55,6,1,4,32
            #region Sorteringen
            int[] even = new int[arraySize];
            int [] odd = new int[arraySize];

            int j = 0, k = 0 /*oddChecker = 0, evenChecker = 0*/;

            for (int i = 0; i < numbers.Length; i++)
            {
                if  (numbers[i] % 2 == 0)
                {
                    even[j] = numbers[i];
                    ++j;
                    //evenChecker = 1;

                }
                else
                {
                    odd[k] = numbers[i];
                    ++k;
                    //oddChecker = 1;
                }

            }

            #region vet ej vf detta skrivet, kan kanske tas bort.
            //if (oddChecker == 0)
            //{

            //    Console.WriteLine("jämn");

            //}

            //if (evenChecker == 0)
            //{


            //    Console.WriteLine("udda");

            //}
            #endregion
            Console.WriteLine("");
            Console.WriteLine("Jämna nummer:");

            for (int i = 0; i < j; i++)
            {
                if (i != j - 1)
                {
                    Console.WriteLine(even[i] + ",");
                }
                else
                {
                    Console.WriteLine(even[i]);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Udda nummer::");
            for (int i = 0; i < k; i++)
            {
                if (i != k - 1)
                
                {
                    Console.WriteLine(odd[i] + ",");
                }
                else
                {
                    Console.WriteLine(odd[i]);
                }
            }
                #endregion

                //Tillbaka till listan
                Console.WriteLine("");
                Console.Write("skriv 'tbx' för att återvända till val av uppgift ( annars klicka på 'enter' på tangentbordet för att köra uppgiften igen ): ");
                Console.WriteLine("");
                var tillbaka = Console.ReadLine();
                if (tillbaka.ToLower() == "tbx")
                    break;
            }
        }
    }
}
