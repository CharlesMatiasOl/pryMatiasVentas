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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //creo una bandera
            bool bandera = false;

            //Crea un archivo si no existe
            StreamWriter swArVendedor = new StreamWriter("./vendedor.txt", true);
            swArVendedor.Close();


            //Lee el archivo de texto 
            StreamReader srVendedor = new StreamReader("./vendedor.txt");

            //se crea una variable de tipo char para separar por caracter
            char separador = Convert.ToChar(";");


            //Mientras el archivo sea distinto al final
            while (!srVendedor.EndOfStream)
            {
                //Crea un Vector para almacenar los datos del archivo, y los separa con el Split (Divide una cadena)
                string[] vendedor = srVendedor.ReadLine().Split(separador);

                //Verifica que no se repita el id
                //En el caso de que este repetido bandera pasa a verdadero
                if (txtIdentificador.Text == vendedor[0])
                {
                    bandera = true;
                }
            }

            //Se cierra el archivo de texto
            srVendedor.Close();


            // En caso que el id no se repita escribe en el archivo, sino muestra un mensaje de id repetido
            if (bandera == false)
            {
                StreamWriter swVendedor = new StreamWriter("./vendedor.txt", true);
                swVendedor.WriteLine(txtIdentificador.Text + ";" + txtNombre.Text + ";" + txtActivo.Text + ";" + txtComision.Text);
                swVendedor.Close();

                MessageBox.Show("Datos cargados correctamente.", "Cargados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtIdentificador.Text = "";
                txtNombre.Text = "";
                txtActivo.Text = "";
                txtComision.Text = "";

                txtIdentificador.Focus();

            }
            else
            {
                MessageBox.Show("El numero de identificador ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtIdentificador.Text = "";
                txtNombre.Text = "";
                txtActivo.Text = "";
                txtComision.Text = "";

                txtIdentificador.Focus();

            }

        }
    }
}
