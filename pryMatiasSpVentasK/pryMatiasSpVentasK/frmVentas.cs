using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace pryMatiasSpVentasK
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            //Creo una bandera
            bool bandera = false;


            //Crea un archivo si no existe
            StreamWriter swArVenta = new StreamWriter("./venta.txt", true);

            swArVenta.Close();

            //Lee el archivo de texto
            StreamReader srVenta = new StreamReader("./venta.txt");


            //se crea una variable de tipo char para separar por caracter
            char separador = Convert.ToChar(";");


            //Mientras el archivo sea distinto al final
            while (!srVenta.EndOfStream)
            {
                //Crea un Vector para almacenar los datos del archivo, y los separa con el Split (Divide una cadena)
                string[] venta = srVenta.ReadLine().Split(separador);


                //Verifica que no se repita el id
                //En el caso de que este repetido bandera pasa a verdadero
                if (txtNumeroFac.Text == venta[0])
                {
                    bandera = true;
                }
            }

            //Se cierra el archivo de texto
            srVenta.Close();


            // En caso que el id no se repita escribe en el archivo, sino muestra un mensaje de id repetido
            if (bandera == false)
            {

                StreamWriter swVenta = new StreamWriter("./venta.txt", true);

                DateTime fecha = dtpFecha.Value.Date;

                swVenta.WriteLine(lstFactura.Text + ";" + txtNumeroFac.Text + ";" + fecha + ";" + lstIdCliente.Text + ";" + lstIdVendedor.Text + ";" + txtMonto.Text);
                swVenta.Close();

                MessageBox.Show("Datos cargados correctamente.", "Cargados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lstFactura.Text = "";
                txtNumeroFac.Text = "";
                lstIdCliente.Text = "";
                lstIdVendedor.Text = "";
                txtMonto.Text = "";

                lstFactura.Focus();

            }


            else
            {
                MessageBox.Show("El numero de factura ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lstFactura.Text = "";
                txtNumeroFac.Text = "";
                lstIdCliente.Text = "";
                lstIdVendedor.Text = "";
                txtMonto.Text = "";

                lstFactura.Focus();


            }
        }
    }
}
