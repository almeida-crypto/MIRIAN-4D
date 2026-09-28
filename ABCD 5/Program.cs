using System;
using System.Windows.Forms;

namespace MatrizEstadisticasApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación de la Actividad 5 (Ejercicio 5).
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMatrizEstadisticas());
        }
    }
}
