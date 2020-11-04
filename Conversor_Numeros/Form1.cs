using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Sale de la app
            Application.Exit();

        } // Fin botón Salir

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try {
                // Conversión de string a numero enter
                int numDecimal = Convert.ToInt32(textDecimal.Text);

                // Llamada del método convertir y asignación al textBox correspondiente
                textBinario.Text = convertir(numDecimal, 2);
                textOctal.Text = convertir(numDecimal, 8);
                textHexadecimal.Text = convertir(numDecimal, 16);
            }
            catch(Exception ex) {
                MessageBox.Show(this, "Ha ocurrido un error. \nError: " + ex.Message, "Advertencia", MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }            
        } // Fin botón convertir

        public static string convertir(int numero, int baseNumero)
        // Funcion que devuelve el numero convertido en la base dada
        {
            string[] matrizLetras = { "A", "B", "C", "D", "E", "F" };
            string resultado = "";
            int resto;
            while (numero >= baseNumero)
            {
                resto = numero % baseNumero;
                resultado = resto > 9 ? matrizLetras[resto - 10] + resultado : Convert.ToString(resto) + resultado;
                numero = numero / baseNumero;
            }
            resultado = Convert.ToString(numero) + resultado;

            return resultado;


        } // Fin convertir
    } // Fin formulario
} // Fin namespace
