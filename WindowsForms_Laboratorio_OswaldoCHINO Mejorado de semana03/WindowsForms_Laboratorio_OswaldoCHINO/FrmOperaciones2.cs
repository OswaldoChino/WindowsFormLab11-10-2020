using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Laboratorio_OswaldoCHINO
{
    public partial class FrmOperaciones2 : Form
    {
        double resultado;
        public FrmOperaciones2()
        {
            InitializeComponent();
        }

        private void rbtnDivision_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarar variables
            double n1, n2;

            //igualar las variables y realizar la conversion del tipo de datos
            n1 = double.Parse(txtNumero1.Text);
            n2 = Convert.ToDouble(txtNumero2.Text);

            //realizar calculo
            if (rbtnSuma.Checked == true)
            {
                resultado = n1 + n2;
            }

            else if (rbtnResta.Checked == true)

            {
                resultado = n1 - n2;
            }
            else if (rbtnMultiplicacion.Checked == true)

            {
                resultado = n1 * n2;
            }
            else
            {
                if (n2 != 0)
                {
                    resultado = n1 / n2;
                    

                }
                else
                {
                    MessageBox.Show("el valor numero 2 diferente de 0... ", "operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }


            //imprimir en pantalla resultado
            //txtResultado.Text = Convert.ToString(resultado);
            txtResultado.Text = string.Format("{0:n2}", (Math.Truncate(resultado * 100) / 100));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Clear();
        }

        private void FrmOperaciones2_Load(object sender, EventArgs e)
        {

        }

        private void rbtnSuma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnResta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
