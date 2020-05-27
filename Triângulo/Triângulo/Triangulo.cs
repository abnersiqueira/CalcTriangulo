using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triângulo
{
    public class Triangulo
    {
        public double ladoA {get; set;}
        public double ladoB {get; set;}
        public double ladoC {get; set;}
        public string tipo {get; set;}
        public string msg = "";

        public string Verificar(string Lado1, string Lado2, string Lado3)
        {
                this.ladoA = Convert.ToDouble(Lado1);
                this.ladoB = Convert.ToDouble(Lado2);
                this.ladoC = Convert.ToDouble(Lado3);
           
            if(ladoA == ladoB && ladoB == ladoC)
            {
                tipo = "Equilátero";
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                tipo = "Isóceles";
            }
            else
            {
                tipo = "Escaleno";
            }
            return tipo;
        }
    }
}
