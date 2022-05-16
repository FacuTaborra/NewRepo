using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad en letras");
            string line;
            line= Console.ReadLine();
            if (line.All(char.IsDigit))
            {


                if (line == "veinte")
                {
                    Console.WriteLine("OK");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("NO ES UNA PALABRA");
                Console.ReadKey();
        
            }
    }
}
}

