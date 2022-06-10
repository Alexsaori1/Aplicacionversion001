using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioEscritoProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Borrar()
        {
            txtNumero1.Clear();
            txtRespuesta.Clear();

        }
        private void Mostrar(String numero)
        {
            String numero1 = txtNumero1.Text;
            numero = numero1;
            double numero2 = 0.0;

            if (double.TryParse(numero, out numero2)) {

                switch (numero2)
                {

                    case 0:

                        txtRespuesta.Text = "Cero";


                        break;


                    case 1:

                        txtRespuesta.Text = "Uno";


                        break;

                    case 2:

                        txtRespuesta.Text = "Dos";


                        break;

                    case 3:

                        txtRespuesta.Text = "Tres";


                        break;

                    case 4:

                        txtRespuesta.Text = "Cuatro";


                        break;

                    case 5:

                        txtRespuesta.Text = "Cinco";


                        break;

                    case 6:

                        txtRespuesta.Text = "Seis";


                        break;

                    case 7:

                        txtRespuesta.Text = "Siete";


                        break;

                    case 8:

                        txtRespuesta.Text = "Ocho";


                        break;

                    case 9:

                        txtRespuesta.Text = "Nueve";


                        break;


                    default:

                        txtRespuesta.Text = "Error, por favor ingrese un numero entre 0 y 9";


                        break;


                }
            } else {

                MessageBox.Show("Error, solo puede ingresar numeros enteros del 0 al 9");

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Mostrar(txtNumero1.Text);
        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar();
        }
    }
}
