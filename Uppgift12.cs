using System;

namespace LexiconUppgifter
{
    class Uppgift12
    {
        public void Upgft12()
        {
            Console.WriteLine("========================== VÄLKOMMEN TILL UPPGIFT 12 ==========================");
            while (true)
            {
                string string1, rev;
                Console.Write("Skriv ett ord för och se om de är Palindrom: ");
                string1 = Console.ReadLine();

                //Lägg orden i array
                char[] ch = string1.ToCharArray();
                
                //omvänd arrayem
                Array.Reverse(ch);
                rev = new string(ch);

                //Se om de är Palindrom
                bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
                if (b == true)
                {
                    Console.WriteLine("" + string1 + " är Palindrom!");
                }
                else
                {
                    Console.WriteLine(" " + string1 + " är inte Palindrom!");
                }


                #region Test1
                //string _inputstr, _reversestr = string.Empty;
                //Console.Write("Enter a string : ");
                //_inputstr = Console.ReadLine();
                //if (_inputstr != null)
                //{
                //    for (int i = _inputstr.Length - 1; i >= 0; i--)
                //    {
                //        _reversestr += _inputstr[i].ToString();
                //    }

                //    if (_reversestr == _inputstr)
                //    {
                //        Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
                //    }
                //    else
                //    {
                //        Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
                //    }
                //}
                //Console.ReadLine();

                #endregion


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
