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
    public partial class FrmOperaciones1 : Form

    {
        double resultado;
        public FrmOperaciones1()
        {
            InitializeComponent();
            lstOperaciones.Items.Clear();
            lstOperaciones.Items.Add("Suma");
            lstOperaciones.Items.Add("Resta");
            lstOperaciones.Items.Add("Multiplicacion");
            lstOperaciones.Items.Add("Division");

        }

        private void FrmOperaciones1_Load(object sender, EventArgs e)
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
            if (lstOperaciones.SelectedItem.ToString() == "Suma")
            {
                resultado = n1 + n2;
            }

            else if (lstOperaciones.SelectedItem.ToString() == "Resta")

            {
                resultado = n1 - n2;
            }
            else if (lstOperaciones.SelectedItem.ToString() == "Multiplicacion")

            {
                resultado = n1*n2;
            }
            else
            {
                if (n2 != 0)
                {
                    resultado = n1 / n2;

                }
                else
                {
                    MessageBox.Show("el valor numero 2 diferente de 0... ","operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }


            //imprimir en pantalla resultado
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Clear();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
