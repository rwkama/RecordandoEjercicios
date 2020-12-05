using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingWindowsForm
{
    public partial class CalcularESG : Form
    {
        public CalcularESG()
        {
            InitializeComponent();
           textBox1.KeyPress+= textBox1_KeyPress;
        }

        private void imgecuacion_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalculo_Click(object sender, EventArgs e)
        {

            double a, b, c;
            //obtenemos las variables a, b y c de losTextBox txta,txtb y txtc
            //para poder usarlas las convertimos a tipo Double
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            //realizamos la operación de la fórmulageneral, para obtener los dos valores de x
            // se repite la operación sólo se cambia el signo delresultado de la raíz
            //Math.sqrt determina la raíz cuadrada y Math.Pow se usapara potenciar una variable
            double raizPositiva = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
            double raizNegativa = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
            if (raizNegativa.ToString() == "NeuN" || raizPositiva.ToString() == "NeuN")
            {
                MessageBox.Show("No se encontraron raices reales en el calculo");
                Limpiar();
            }
            else if (raizPositiva != raizNegativa)
            {
                lblx1.Text = raizPositiva.ToString();
                lblx2.Text = raizNegativa.ToString();
            }
            else
            {
                lblx1.Text = raizPositiva.ToString();
            }
            //se imprimen los resultados de las x en susrespectivas etiquetas
            //lblx1.Text = raizPositiva.ToString();
            //lblx2.Text = raizNegativa.ToString();
            //las etiquetas se vuelven visibles pues supropiedad visible estaba en false
        }

        private void btrnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventoKeyPress(sender, e);
            
        }
        private void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            lblx1.Text = "";
            lblx2.Text = "";
        }
        private void eventoKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.') )
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;
            //}

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
