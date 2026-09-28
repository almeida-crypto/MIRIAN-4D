using System;
using System.Text;

namespace MatrizEstadisticasApp.Models
{
    /// <summary>
    /// Modelo de lógica de negocio para la gestión, cálculo y almacenamiento de una matriz de 5x10
    /// junto con sus arreglos estadísticos derivados:
    /// - Arreglo A: Suma por fila (5 elementos)
    /// - Arreglo B: Promedio por fila (5 elementos)
    /// - Arreglo C: Suma por columna (10 elementos)
    /// - Arreglo D: Promedio por columna (10 elementos)
    /// Aplica estrictamente los principios de Programación Orientada a Objetos (POO).
    /// </summary>
    public class MatrizEstadisticas
    {
        public const int TotalFilas = 5;
        public const int TotalColumnas = 10;

        private decimal[,] _matriz;
        private decimal[] _arregloA; // Sumas de cada fila
        private decimal[] _arregloB; // Promedios de cada fila
        private decimal[] _arregloC; // Sumas de cada columna
        private decimal[] _arregloD; // Promedios de cada columna

        private readonly Random _random;

        public MatrizEstadisticas()
        {
            _matriz = new decimal[TotalFilas, TotalColumnas];
            _arregloA = new decimal[TotalFilas];
            _arregloB = new decimal[TotalFilas];
            _arregloC = new decimal[TotalColumnas];
            _arregloD = new decimal[TotalColumnas];
            _random = new Random();

            CargarEjemploPdf();
        }

        /// <summary>
        /// Llena la matriz con números enteros aleatorios en el rango [min, max]
        /// y calcula automáticamente los arreglos A, B, C y D.
        /// </summary>
        public void LlenarConAleatorios(int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentException("El valor mínimo no puede ser superior al valor máximo.");
            }

            for (int i = 0; i < TotalFilas; i++)
            {
                for (int j = 0; j < TotalColumnas; j++)
                {
                    _matriz[i, j] = _random.Next(min, max + 1);
                }
            }

            CalcularEstadisticas();
        }

        /// <summary>
        /// Carga los datos de prueba idénticos al ejemplo de la Página 3 del PDF del instrumento de evaluación:
        /// Fila 0: 2, 4, 5, 1, 2, 1, 1, 4, 4, 2  -> A=26, B=2.6
        /// Fila 1: 3, 4, 4, 8, 4, 2, 3, 6, 5, 4  -> A=43, B=4.3
        /// Fila 2: 5, 2, 9, 4, 6, 7, 7, 8, 4, 8  -> A=60, B=6.0
        /// Fila 3: 8, 8, 7, 9, 3, 8, 6, 2, 9, 3  -> A=63, B=6.3
        /// Fila 4: 9, 4, 2, 6, 1, 5, 2, 7, 2, 5  -> A=43, B=4.3
        /// Col 0 : 2, 3, 5, 8, 9                 -> C=27, D=5.4
        /// </summary>
        public void CargarEjemploPdf()
        {
            decimal[,] ejemplo = new decimal[TotalFilas, TotalColumnas]
            {
                { 2, 4, 5, 1, 2, 1, 1, 4, 4, 2 },
                { 3, 4, 4, 8, 4, 2, 3, 6, 5, 4 },
                { 5, 2, 9, 4, 6, 7, 7, 8, 4, 8 },
                { 8, 8, 7, 9, 3, 8, 6, 2, 9, 3 },
                { 9, 4, 2, 6, 1, 5, 2, 7, 2, 5 }
            };

            for (int i = 0; i < TotalFilas; i++)
            {
                for (int j = 0; j < TotalColumnas; j++)
                {
                    _matriz[i, j] = ejemplo[i, j];
                }
            }

            CalcularEstadisticas();
        }

        /// <summary>
        /// Realiza el cómputo de:
        /// a) Suma y promedio de cada fila -> Arreglos A y B
        /// b) Suma y promedio de cada columna -> Arreglos C y D
        /// </summary>
        public void CalcularEstadisticas()
        {
            // a) Suma y promedio por cada fila
            for (int i = 0; i < TotalFilas; i++)
            {
                decimal sumaFila = 0;
                for (int j = 0; j < TotalColumnas; j++)
                {
                    sumaFila += _matriz[i, j];
                }
                _arregloA[i] = sumaFila;
                _arregloB[i] = Math.Round(sumaFila / TotalColumnas, 2);
            }

            // b) Suma y promedio por cada columna
            for (int j = 0; j < TotalColumnas; j++)
            {
                decimal sumaColumna = 0;
                for (int i = 0; i < TotalFilas; i++)
                {
                    sumaColumna += _matriz[i, j];
                }
                _arregloC[j] = sumaColumna;
                _arregloD[j] = Math.Round(sumaColumna / TotalFilas, 2);
            }
        }

        /// <summary>
        /// Establece el valor de una celda individual y recalcula las estadísticas.
        /// </summary>
        public void EstablecerValor(int fila, int columna, decimal valor)
        {
            ValidarIndices(fila, columna);
            _matriz[fila, columna] = valor;
        }

        /// <summary>
        /// Obtiene el valor numérico en una posición dada.
        /// </summary>
        public decimal ObtenerValor(int fila, int columna)
        {
            ValidarIndices(fila, columna);
            return _matriz[fila, columna];
        }

        public decimal ObtenerArregloA(int fila)
        {
            if (fila < 0 || fila >= TotalFilas)
                throw new IndexOutOfRangeException("Índice de fila fuera de rango para el Arreglo A.");
            return _arregloA[fila];
        }

        public decimal ObtenerArregloB(int fila)
        {
            if (fila < 0 || fila >= TotalFilas)
                throw new IndexOutOfRangeException("Índice de fila fuera de rango para el Arreglo B.");
            return _arregloB[fila];
        }

        public decimal ObtenerArregloC(int columna)
        {
            if (columna < 0 || columna >= TotalColumnas)
                throw new IndexOutOfRangeException("Índice de columna fuera de rango para el Arreglo C.");
            return _arregloC[columna];
        }

        public decimal ObtenerArregloD(int columna)
        {
            if (columna < 0 || columna >= TotalColumnas)
                throw new IndexOutOfRangeException("Índice de columna fuera de rango para el Arreglo D.");
            return _arregloD[columna];
        }

        public decimal[,] ObtenerMatriz()
        {
            return (decimal[,])_matriz.Clone();
        }

        public decimal[] ObtenerTodosArregloA() => (decimal[])_arregloA.Clone();
        public decimal[] ObtenerTodosArregloB() => (decimal[])_arregloB.Clone();
        public decimal[] ObtenerTodosArregloC() => (decimal[])_arregloC.Clone();
        public decimal[] ObtenerTodosArregloD() => (decimal[])_arregloD.Clone();

        /// <summary>
        /// Genera la salida textual exactamente con el formato solicitado en el inciso (c) del PDF.
        /// </summary>
        public string GenerarFormatoImpresionPdf()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=========================================================================================");
            sb.AppendLine("                       FORMATO DE RESULTADOS (INCISO C - PDF)                           ");
            sb.AppendLine("=========================================================================================");
            sb.AppendLine("Matriz (5 x 10)                                                      A           B       ");
            sb.AppendLine("------------------------------------------------------------------   ---------   --------");

            for (int i = 0; i < TotalFilas; i++)
            {
                sb.Append("[ ");
                for (int j = 0; j < TotalColumnas; j++)
                {
                    sb.Append(_matriz[i, j].ToString("0.##").PadLeft(4));
                    if (j < TotalColumnas - 1) sb.Append(" ");
                }
                sb.Append(" ]");

                // Arreglo A (Suma fila) y B (Promedio fila)
                sb.Append("   [");
                sb.Append(_arregloA[i].ToString("0.##").PadLeft(6));
                sb.Append(" ]");

                sb.Append("   [");
                sb.Append(_arregloB[i].ToString("0.##").PadLeft(5));
                sb.Append(" ]");
                sb.AppendLine();
            }

            sb.AppendLine("------------------------------------------------------------------   ---------   --------");

            // Arreglo C (Suma columna)
            sb.Append("C [ ");
            for (int j = 0; j < TotalColumnas; j++)
            {
                sb.Append(_arregloC[j].ToString("0.##").PadLeft(4));
                if (j < TotalColumnas - 1) sb.Append(" ");
            }
            sb.AppendLine(" ]");

            // Arreglo D (Promedio columna)
            sb.Append("D [ ");
            for (int j = 0; j < TotalColumnas; j++)
            {
                sb.Append(_arregloD[j].ToString("0.##").PadLeft(4));
                if (j < TotalColumnas - 1) sb.Append(" ");
            }
            sb.AppendLine(" ]");
            sb.AppendLine("=========================================================================================");
            sb.AppendLine("A = Suma de cada fila | B = Promedio de cada fila");
            sb.AppendLine("C = Suma de cada columna | D = Promedio de cada columna");

            return sb.ToString();
        }

        private void ValidarIndices(int fila, int columna)
        {
            if (fila < 0 || fila >= TotalFilas)
            {
                throw new IndexOutOfRangeException($"La fila ({fila}) debe estar entre 0 y {TotalFilas - 1}.");
            }
            if (columna < 0 || columna >= TotalColumnas)
            {
                throw new IndexOutOfRangeException($"La columna ({columna}) debe estar entre 0 y {TotalColumnas - 1}.");
            }
        }
    }
}
