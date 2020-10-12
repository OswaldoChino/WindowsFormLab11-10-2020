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
    public partial class FrmMayor : Form
    {
        public FrmMayor()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double n1, n2;
                string resultado;
                n1 = double.Parse(txtNumero1.Text);
                n2 = double.Parse(txtNumero2.Text);

                if (n1 > n2)
                {
                    resultado = "Numero 1 es mayor que numero 2";
                    txtResultado.Text = resultado;
                }
                else if (n2 > n1)
                {
                    resultado = "Numero 2 es mayor que numero 1";
                    txtResultado.Text = resultado;
                }
                else if (n2.Equals(n1))
                {
                    resultado = "Numero 1 es igual que numero 2 ";
                    txtResultado.Text = resultado;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se puede realizar esta operacion ", "Mayor menor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
            //else
            //{
            //   MessageBox.Show("nO SE PUEDE REALIZAR ESTA OPERACION ", "Mayor menor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //this.Dispose(); //ocultar 
            Application.Exit(); //cierra completamente el programa

        }
    }
}
