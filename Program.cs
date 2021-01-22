using System;

namespace LexiconUppgifter
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = true;


            while (i)
            {
                Console.WriteLine("Var god och välj uppgift 1-16 eller skriv 0 för att avsluta: ");
                
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                    break;

                switch (input)
                {
                        //Funktion som skriver ut ”Hello World” i konsolen
                    case 1:
                        var E1 = new Uppgift1();
                        E1.Upgft1();
                        break;
                    
                        //Funktion som tar in input från användaren (Förnamn, Efternamn, Ålder) och sedan skriver ut dessa i konsolen
                    case 2:
                        var E2 = new Uppgift2();
                        E2.Upgft2();
                        break;
                       
                        //Funktion som ändrar färgen på texten i konsolen(och ändrar tillbaka om man använder funktionen igen
                    case 3:
                        var E3 = new Uppgift3();
                        E3.Upgft3();
                        break;
                       
                        //Funktion för att skriva ut dagens datum
                    case 4:
                        var E4 = new Uppgift4();
                        E4.Upgft4();
                        break;
                       
                        //Funktion som tar två input värden, sedan skriver ut vilket av dem som är störst.
                    case 5:
                        var E5 = new Uppgift5();
                        E5.Upgft5();
                        break;
                       
                        //Funktion som genererar att slumpmässigt tal mellan 1 och 100. Användaren ska sedan gissa talet. 
                        //Gissar användaren rätt så ska ett meddelande säga detta, samt hur många försök det tog. 
                        //Gissar användaren fel ska ett meddelande visas som informerar ifall talet var för stort eller för litet
                    case 6:
                        var E6 = new Uppgift6();
                        E6.Upgft6();
                        break;
                       
                        //Funktion där användaren skriver in en textrad, som sedan sparas i en fil på hårddisken
                    case 7:
                        var E7 = new Uppgift7();
                        E7.Upgft7();
                        break;
                       
                        //Funktion där en fil läses in från hårddisken (för enkelhetens skull kan man använda filen från uppgift 7)
                    case 8:
                        var E8 = new Uppgift8();
                        E8.Upgft8();
                        break;
                       
                        //Funktion där användaren skickar in ett decimaltal och får tillbaka roten ur, upphöjt till 2 och upphöjt till 10
                    case 9:
                        var E9 = new Uppgift9();
                        E9.Upgft9();
                        break;
                       
                        //Funktion där programmet skriver ut en multiplikationstabell från 1 till 10. En ”tab” ska läggas in efter varje nummer. 
                        //Försöka att ställa upp det så det blir relativt läsbart.
                    case 10:
                        var E10 = new Uppgift10();
                        E10.Upgft10();
                        break;
                       
                        //Funktion som skapar två arrayer. Den första fylls med slumpmässiga tal. 
                        //Den andra fylls med talen från den första i stigande ordning.
                    case 11:
                        var E11 = new Uppgift11();
                        E11.Upgft11();
                        break;
                       
                        //Funktion som tar en input från användaren och kontrollerar ifall det är en palindrom (alltså samma ord från båda håll, såsom Anna eller radar.
                    case 12:
                        var E12 = new Uppgift12();
                        E12.Upgft12();
                        break;
                      
                        //Funktion som tar två inputs från användaren och skriver sedan ut alla siffror som är mellan de två inputsen.
                    case 13:
                        var E13 = new Uppgift13();
                        E13.Upgft13();
                        break;
                      
                        //Funktion där användaren skickar in ett antal värden (komma-separerade siffror) som sedan sorteras och skrivs ut efter udda och jämna värden.
                    case 14:
                        var E14 = new Uppgift14();
                        E14.Upgft14();
                        break;
                       
                        //Funktion där användaren skriver in ett antal värden (komma-separerade siffor) som sedan adderas och skrivs ut.
                    case 15:
                        var E15 = new Uppgift15();
                        E15.Upgft15();
                        break;
                       
                        //Funktion där användaren ska ange namnet på sin karaktär och namnet på en motståndare. 
                        //Funktionen skall sedan själv lägga till slumpmässiga värden för Hälsa, Styrka och Tur, som sparas i en instans av en klass.
                    case 16:
                        var E16 = new Uppgift16();
                        E16.Upgft16();
                        break;

                    default:
                        Console.WriteLine("That exercise do not exist yet, please choose an exercise 1-16:");
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                }



            }
        }
    }
}
