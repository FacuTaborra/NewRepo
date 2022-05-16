using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaNumero
{
    class Jugada
    {
        int _numero;
        private int _intentos;
        private int _adivino;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public int Adivino {
            get => _adivino;
            set {
                _adivino = value;
            }
        }

        public int Intentos {
            get => _intentos;
            set {
                _intentos = value;
            }
        }

        public int Numero {
            get => _numero;
            set {
                _numero =  value;
            }
        }

        public void Comparar()
        {
            throw new System.NotImplementedException();
        }
    }
}
