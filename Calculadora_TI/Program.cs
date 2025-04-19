using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_TI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// Aquí se inicia el formulario.
        /// </summary>
        [STAThread] // Indica que se usará el modelo de subprocesamiento de un solo hilo para Windows Forms.
        static void Main()
        {
            Application.EnableVisualStyles(); // Habilita estilos visuales modernos para los controles.
            Application.SetCompatibleTextRenderingDefault(false); // Usa GDI+ en lugar de GDI para renderizar texto.
            Application.Run(new Form1()); // Ejecuta el formulario principal llamado Form1.
        }
    }
}
