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
    public partial class FrmSuma : Form
    {
        public FrmSuma()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarar variables
            double n1, n2, resultado;

            //igualar las variables y realizar la conversion del tipo de datos
            n1 = double.Parse(txtNumero1.Text);
            n2 = Convert.ToDouble(txtNumero2.Text);

            //realizar calculo
            resultado = n1 + n2;

            //imprimir en pantalla resultado
            txtResultado.Text = Convert.ToString(resultado);
        }
    }
}
