using System;   

namespace Clases
{
    public class A
    {
        public string NombreInstancia;

        public A()
        {
            this.NombreInstancia = "Instancia sin nombre";
        }
        public A (string nombre)
        {
            this.NombreInstancia = nombre;
        }

        public void MostrarNombre()
        {
            Console.WriteLine(NombreInstancia);
        }
        public void M1()
        {
            Console.WriteLine("El metodo M1 fue invocado");
        }
        public void M2()
        {
            Console.WriteLine("El metodo M2 fue invocado");
        }
        public void M3()
        {
            Console.WriteLine("El metodo M3 fue invocado");
        }
    }
}
