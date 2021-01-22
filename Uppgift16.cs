using System;


namespace LexiconUppgifter
{
    /* 
     * Funktion där användaren ska ange namnet på sin karaktär och namnet på en motståndare. 
     * Funktionen skall sedan själv lägga till slumpmässiga värden för Hälsa, Styrka och Tur, som sparas i en instans av en klass.
     */
    class Player
    {
        
        public string name;
        public int  health;
        public int  luck;
        public int  strength;

    }



    class Uppgift16
    {
        public void Upgft16()
        {
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 16 ==========================");
            while (true)
            {

                Console.WriteLine("");
                Random rnd = new Random();
                Console.WriteLine("Vad är din karaktärs namn? ");
                Player player = new Player();
                player.name = Console.ReadLine();
                player.health = rnd.Next(50, 100);
                player.luck = rnd.Next(1, 5);
                player.strength = rnd.Next(100,500);

                Console.WriteLine("");
                Console.WriteLine("Vad är din motståndarens namn? ");
                Player enemy = new Player();
                enemy.name = Console.ReadLine();
                enemy.health = rnd.Next(50, 100);
                enemy.luck = rnd.Next(1, 5);
                enemy.strength = rnd.Next(100, 500);

                Console.WriteLine("");
                Console.WriteLine("--------------------- Spelarna ---------------------");
                Console.WriteLine("Spelarens\nNamn: "+ player.name + "\nStyrka: "+ player.strength + "\nLiv: "+ player.health +"\nTur: " + player.luck);
                Console.WriteLine("");
                Console.WriteLine("Motståndarens\nNamn: " + enemy.name + "\nStyrka: "+ enemy.strength + "\nLiv: "+ enemy.health +"\nTur: " + enemy.luck);


                //Tillbaka till listan
                Console.WriteLine("");
                Console.Write("skriv 'tbx' för att återvända till val av uppgift ( annars klicka på 'enter' på tangentbordet för att köra uppgiften igen ): ");
                Console.WriteLine("");

                var tillbaka = Console.ReadLine();
                if (tillbaka == "tbx")
                    break;
            }

        }
    }
}
