using System;

namespace LabSintaxis2_1_
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

                switch (op.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine(inputTexto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        int cantCarac = inputTexto.Length;
                        Console.WriteLine(cantCarac);
                        break;
                    default:
                        Console.WriteLine("La opcion ingresada no es valida.");
                        break;

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


