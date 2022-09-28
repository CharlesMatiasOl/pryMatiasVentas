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
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            StreamReader srCliente = new StreamReader("./Cliente.txt");

            char separador = Convert.ToChar(";");

            while (!srCliente.EndOfStream)
            {
                string[] idCliente = srCliente.ReadLine().Split(separador);

                lstCliente.Items.Add(idCliente[0]);
            }

            srCliente.Close();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            StreamReader srVentas = new StreamReader("./venta.txt");

            char separador = Convert.ToChar(";");


            //DateTime fecha = dtpFecha.Value.Date;
            //string varFecha = DateTime.Parse(fecha);
            //var parsedDate = DateTime.Parse(dateInput);

            string fecha = DateTime.MaxValue.ToString(maskFecha.Text);

            string ventaLinea = srVentas.ReadLine();

            string[] ventas = srVentas.ReadLine().Split(separador);


            while (!srVentas.EndOfStream & ventas[2] != lstCliente.Text & ventas[3] != fecha)
            {

            }


            while (!srVentas.EndOfStream & ventas[2] == lstCliente.Text & ventas[3] == fecha)
            {
                dgvBusqueda.Rows.Add(ventas);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
