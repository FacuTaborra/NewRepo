using System;
using static System.Console;

namespace Clases
{
    public class A
    {
        protected string nomIns;
        protected string NombreInstancia;

        public A()
            : this("Instancia sin nombre")
        {}
        public A(string a)
        {
            nomIns = a;
        }

        public void MostrarNombre (string nomIns)
        {
            Console.WriteLine(nomIns);
        }

        public void M1()
        {
            Console.WriteLine("Metodo 1 invocado");
        }
        public void M2()
        {
            Console.WriteLine("Metodo 2 invocado");
        }
        public void M3()
        {
            Console.WriteLine("Metodo 3 invocado");
        }

    }
}
