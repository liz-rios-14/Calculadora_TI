using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_TI
{
    public partial class Form1: Form
    {
        public Form1()
        {
            // Método que inicializa los componentes del formulario (controles, eventos, etc.)
            InitializeComponent();
        }
       private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try

            {
                // Convertimos el contenido de los TextBox a números reales
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                // Realizamos la suma
                double suma = num1 + num2;
                // Mostramos el resultado en el TextBox de resultado
                txtRes.Text = suma.ToString();
            }

            catch (FormatException)

            {
                // Mostramos un mensaje si los datos ingresados no son válidos (no numéricos)
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }
        
        private void btnRestar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Convertimos el contenido de los TextBox a números reales
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                // Realizamos la resta
                double resta = num1 - num2;
                // Mostramos el resultado en el TextBox de resultado
                txtRes.Text = resta.ToString();
            }
            catch (FormatException)
            {
                // Mensaje si los datos ingresados no son válidos
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }

        private void btnMultiplicar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Convertimos el contenido de los TextBox a números reales
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                // Realizamos la multiplicación
                double multiplicacion = num1 * num2;
                // Mostramos el resultado en el TextBox de resultado
                txtRes.Text = multiplicacion.ToString();
            }
            catch (FormatException)
            {
                // Mensaje si los datos ingresados no son válidos
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            // Limpiar todos los TextBox
            txtNum1.Clear();
            txtNum2.Clear();
            txtRes.Clear();

            // Colocar el cursor en el primer TextBox
            txtNum1.Focus();
        }
    }
}
