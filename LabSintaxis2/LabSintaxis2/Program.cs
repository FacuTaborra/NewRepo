using System;

namespace LabSintaxis2
{
    class Program
    {
        static void Main()
        {
            string inputTexto;
            Console.WriteLine("Ingrese un texto: ");
            inputTexto = Console.ReadLine();

            if (inputTexto != "")
            {
                Console.WriteLine("1_Mostrar texto en mayusculas, 2_Mostrar texto en minusculas, 3_Mostrar cantidad de caracteres de texto");
                ConsoleKeyInfo op = Console.ReadKey();
                Console.WriteLine();

                if (op.Key == ConsoleKey.D1)
                {
                    Console.WriteLine(inputTexto.ToUpper());
                }
                else if (op.Key == ConsoleKey.D2)
                {
                    Console.WriteLine(inputTexto.ToLower());
                }
                else if (op.Key == ConsoleKey.D3)
                {
                    int cantCarac = inputTexto.Length;
                    Console.WriteLine(cantCarac);
                }
                else
                {
                    Console.WriteLine("La opcion ingresada no es valida.");
                }

                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("El texto no es valido");
            }
        }
    }
}
