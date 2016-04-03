using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Lp2_Rec
{
    class Circulo
    {
        private int raio;

        public Circulo()//Construtor
        {
            raio = 0;
        }

        public Circulo(int raioInicial)
        {
            raio = raioInicial;
        }

        public double Area()
        {
            return Math.PI * raio * raio;
        }

        public double Perimetro()
        {
            return Math.PI * raio * 2;
        }

        public double Volume()
        {
            return 4 * Math.PI * raio * raio * raio / 3;
        }
        public double AreaSuperficial()
        {
            return 4 * Math.PI * raio * raio;
        }
    }
}
