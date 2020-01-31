using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Epsi.SuperCalculator.ConsoleApp
{
    class Operation
    {
            static void getResult(string[] args)
            {
                string Number1 = "";
                string Number2 = "";
                string Operation = "";
                string chaine = "";
                string number = "";
                int lengthNumber = 0;

                Regex RxNumber = new Regex("([0-9]+[^x,+,-,*,/])");

                Console.WriteLine("Entrer les nombres et les opérations (+ - / * )");
                chaine = Console.ReadLine();

                Console.WriteLine("L'opération est : " + chaine);
                string s1 = "good";
                string s = s1.Substring(0, 1);
                Console.WriteLine(s);

                Number1 = RxNumber.Match(chaine).ToString();
                lengthNumber = Number1.Length;
                chaine = chaine.Remove(0, lengthNumber);

                Operation = chaine.Substring(0, 1);
                lengthNumber = Operation.Length;
                chaine = chaine.Remove(0, lengthNumber);

                Number2 = RxNumber.Match(chaine).ToString();
                lengthNumber = Number2.Length;
                chaine = chaine.Remove(0, lengthNumber);

                Console.WriteLine("Suite les instructions, maintenant on a des nombres et l'opération séparement");
                Console.WriteLine("Nombre 1 : " + Number1);
                Console.WriteLine("Operation : " + Operation);
                Console.WriteLine("Nombre 2 : " + Number2);

                Console.ReadLine();
                Console.ReadKey();
            }


        }
    }
}
}
