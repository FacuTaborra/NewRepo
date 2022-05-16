using System;
using static System.Console;

namespace Clases
{
    class B : A
    {

        public B(string a)
            : base(a)
        {
            nomIns = "Instancia de B";
        }

        public void M4()
        {
            Console.WriteLine("Metodo del Hijo Invocado");
        }
           
    }
}