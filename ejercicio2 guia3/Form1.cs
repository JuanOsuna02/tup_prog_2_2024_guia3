using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2_guia3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PRESUPUESTO p;
        private void btnPresup_Click(object sender, EventArgs e)
        {
            DatosCliente datosCliente = new DatosCliente();
            if(datosCliente.ShowDialog() == DialogResult.OK ) 
            {
                string NomCliente=datosCliente.tbNombre.Text;
                string DirCliente=datosCliente.tbDireccion.Text;

                p=new PRESUPUESTO(NomCliente,DirCliente);

                lblNombre.Text = $"{NomCliente}";
                lbDireccion.Text = $"{DirCliente}";
            
            
            }
        }

        private void btnAgregarPro_Click(object sender, EventArgs e)
        {
            producto Nuevo;
            AgregarProducto agregarProducto = new AgregarProducto();
            if(agregarProducto.ShowDialog() == DialogResult.OK )
            {

                string descripcion=agregarProducto.tbDescripcion.Text;
                double precio = Convert.ToDouble(agregarProducto.tbPrecio.Text);
                int TipoM = agregarProducto.cbTipoM.SelectedIndex;
                    ;

                if (agregarProducto.cbProducto.SelectedIndex == 0)
                {
                    double Largo=Convert.ToDouble(agregarProducto.tbLaego.Text);
                    Nuevo=new Mesa(Largo,descripcion,precio,TipoM);
                    p.AgregarProducto(Nuevo);


                }
                else if (agregarProducto.cbProducto.SelectedIndex == 1)
                {
                    Nuevo=new Silla(descripcion,precio,TipoM);
                    p.AgregarProducto(Nuevo) ;
                }

            }
        }

        private void btnVerPres_Click(object sender, EventArgs e)
        {
            PresupuestoVer presupuestoVer = new PresupuestoVer();
            presupuestoVer.tbver.AppendText($"Cliente:{p.Cliente} \n Direccion:{p.Direccion} \n Items Presupuestados: \n ");
            foreach (producto v in p.presupuestados)
            {
                
                    presupuestoVer.tbver.AppendText($"{v.VerDetalle()}");
                
                
            }

            presupuestoVer.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
