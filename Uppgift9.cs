using System;

namespace LexiconUppgifter
{
    class Uppgift9
    {
        public void Upgft9()
        {

            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 9 ==========================");
            while (true)
            {

                Console.WriteLine("Ange tal: ");
                var Tal = Convert.ToDecimal(Console.ReadLine());
                decimal root = (decimal)Math.Sqrt((double)Tal);
                double Potens2 = 2;
                double Potens10 = 10;

                
                var p2 = (decimal)Math.Pow((double)Tal, (double)Potens2);
                var p10 = (decimal)Math.Pow((double)Tal, (double)Potens10);

                Console.WriteLine("Rooten ur {0} är {1}", Tal, root );
                Console.WriteLine("Basen {0} och potens {1} = {2}", Tal, Potens2, p2);
                Console.WriteLine("Basen {0} och potens {1} = {2}", Tal, Potens10, p10);




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
