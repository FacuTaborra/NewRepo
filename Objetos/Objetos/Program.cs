using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Provincias = new List<string>();
            Provincias.Add("Salta");
            Provincias.Add("Jujuy");
            Provincias.Add("Misiones");
            Provincias.Add("Chaco");
            Provincias.Add("Tucumán");
            Provincias.Add("La Rioja");
            Provincias.Add("San Juan");
            Provincias.Add("San Luis");
            Provincias.Add("Córdoba");
            Provincias.Add("Catamarca");
            Provincias.Add("Formosa");
            Provincias.Add("Mendoza");
            Provincias.Add("Corrientes");
            Provincias.Add("Santiago del Estero");
            Provincias.Add("Entre Rios");
            Provincias.Add("Santa Fe");
            Provincias.Add("Buenos Aires");
            Provincias.Add("La Pampa");
            Provincias.Add("Neuquén");
            Provincias.Add("Rio Negro");
            Provincias.Add("Santa Cruz");
            Provincias.Add("Chubut");
            Provincias.Add("Tierra del Fuego");


            IEnumerable<string> prov = Provincias.Where(p => p.StartsWith("S") || p.StartsWith("T"));

            foreach (string p in prov)
            {
                Console.WriteLine(p);
            }
            
            Console.ReadLine();


        }
    }
}
