using System;
using System.Windows.Forms;

namespace MatrizDiagonalApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación de la Actividad 4 (Ejercicio 4).
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMatrizDiagonal());
        }
    }
}
