using System;
using System.Linq;

namespace LexiconUppgifter
{
    class Uppgift15
    {
        //Funktion där användaren skriver in ett antal värden (komma-separerade siffor) som sedan adderas och skrivs ut.
        public void Upgft15()
        {
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 15 ==========================");
            while (true)
            {
                #region Med komma-separation

                Console.Write("Var god och skriv nummerna som ska summeras följt av kommatecken:");
                string input = Console.ReadLine();

                int[] numbers = input.Split(',').Select(input => Convert.ToInt32(input)).ToArray();
                int summa = numbers.Sum();
                Console.WriteLine("Summan av nummerna är: " + summa);

                #endregion


                #region Utan komma-separation
                //var sum = 0;
                //while (true)
                //{
                //    Console.Write("Skriv antal nummer (eller 'ok' för att avsluta o summera dom): ");
                //    var input = Console.ReadLine();

                //    if (input.ToLower() == "ok")
                //        break;

                //    sum += Convert.ToInt32(input);
                //}
                //Console.WriteLine("summan av nummerna är: " + sum);
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
