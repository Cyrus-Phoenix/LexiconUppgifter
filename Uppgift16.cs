﻿using System;


namespace LexiconUppgifter
{
    class Uppgift16
    {
        public void Upgft16()
        {
            while (true)
            {














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
