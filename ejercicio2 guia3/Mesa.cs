using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_guia3
{
    internal class Mesa:producto
    {
        private double largo;

        public Mesa(double largo,string descripcion, double Precio,int Tipo):base(descripcion, Precio, Tipo)
        {
            this.largo = largo;
        }

        public override double Precio()
        {
           double PrecioF=(PrecioBase*largo)*(1+Tipo*0.33);
            return PrecioF;
        }
        public override string VerDetalle()
        {
            string material;
            if (Tipo == 0)
            {
                material = "Pino";
            }
            else if (Tipo == 1)
            {
                material = "Algarrobo";
            }
            else
            {
                material = "Caoba";
            }
            double p = Precio();
            return $"{Descripcion}-MESA({largo}-{material}-{p})";
        }
    }
}
