using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numeros = new List<int>();

            int i = 0;
            while (i<10)
            {
                Console.WriteLine("Ingrese un número");
                int num = int.Parse(Console.ReadLine());
                Numeros.Add(num);
                i++;
            }

            var mayores = Numeros.Where(n => n>20);

            foreach (int m in mayores) 
            { 
         
                Console.WriteLine(m);
            }

            Console.ReadLine();
        }
    }
}
