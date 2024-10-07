using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_guia3
{
    internal class PRESUPUESTO
    {
        public int CantidadProductos {  get; private set; }
        public double CostoTotal {  get; private set; }
        public string Cliente;
        public string Direccion;
        public ArrayList presupuestados=new ArrayList();

        public PRESUPUESTO(string cliente,string direccion)
        {
            this.Cliente=cliente;
            this.Direccion=direccion;
        }

        public void AgregarProducto(producto producto)
        {
            presupuestados.Add(producto);
            CantidadProductos++;
            CostoTotal=+producto.Precio();

        }

        public producto VerProducto(int idx) {

            producto aux = (producto)presupuestados[idx];
            return aux;
        
        }
    }
}
