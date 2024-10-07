using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_guia3
{
    internal class Silla : producto

    {
        public Silla(string descripcion, double precioB, int tipo) : base(descripcion, precioB, tipo)
        {

        }

        public override double Precio()
        {
            double precioFinal=(   PrecioBase  * (1 + Tipo * 0.33));
            return precioFinal;
        }
        public override string VerDetalle()
        {
            string material;
            if (Tipo == 0) 
            {
                material = "Pino";
            }
            else if (Tipo == 1) {
                material = "Algarrobo";
            }
            else
            {
                material = "Caoba";
            }
            double p=Precio();

            return $"{Descripcion}-SILLA-{material}-{p}";
        }
    }
}
