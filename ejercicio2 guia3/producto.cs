using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_guia3
{
     abstract internal class producto
     {
        protected string Descripcion;
        protected double PrecioBase;
        protected int Tipo;


        
        public producto(string descripcion,double precio,int tipo)
        {
            Descripcion = descripcion;
            PrecioBase = precio;
            Tipo = tipo;
        }
        public abstract double Precio();
        public abstract string VerDetalle();
        
        
     }
}
