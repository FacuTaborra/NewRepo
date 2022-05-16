using System;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            int i;
            string[] cadenas = new string[cantIteraciones];

            for (i = 0; i < cantIteraciones; i++)
            {
                cadenas[i] =  Console.ReadLine();
            }

            for (i=cantIteraciones; i>0; i--)
            {
                Console.WriteLine(cadenas[i]);
            }
        }
    }
}
