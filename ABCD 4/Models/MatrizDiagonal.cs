using System;

namespace MatrizDiagonalApp.Models
{
    /// <summary>
    /// Modelo de lógica de negocio para la gestión y generación de una matriz cuadrada
    /// donde la diagonal principal contiene 1's y las demás posiciones contienen 0's (Matriz Identidad).
    /// Cumple con los principios de Programación Orientada a Objetos (POO) y separación de capas.
    /// </summary>
    public class MatrizDiagonal
    {
        private int _dimension;
        private int[,] _matriz;

        /// <summary>
        /// Obtiene la dimensión de la matriz cuadrada (N x N).
        /// </summary>
        public int Dimension
        {
            get => _dimension;
            private set
            {
                if (value < 2)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La dimensión de la matriz debe ser de al menos 2x2.");
                }
                if (value > 30)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La dimensión máxima recomendada para visualización es de 30x30.");
                }
                _dimension = value;
            }
        }

        /// <summary>
        /// Total de elementos contenidos en la matriz cuadrada (N x N).
        /// </summary>
        public int TotalElementos => _dimension * _dimension;

        /// <summary>
        /// Cantidad de unos (1) esperados en la matriz (elementos en la diagonal principal).
        /// </summary>
        public int TotalUnos => _dimension;

        /// <summary>
        /// Cantidad de ceros (0) esperados en la matriz (elementos fuera de la diagonal principal).
        /// </summary>
        public int TotalCeros => TotalElementos - TotalUnos;

        /// <summary>
        /// Constructor por defecto que inicializa una matriz cuadrada de 5x5.
        /// </summary>
        public MatrizDiagonal() : this(5)
        {
        }

        /// <summary>
        /// Constructor que inicializa la matriz con una dimensión personalizada.
        /// </summary>
        /// <param name="dimension">Tamaño de la matriz cuadrada (N x N).</param>
        public MatrizDiagonal(int dimension)
        {
            Dimension = dimension;
            _matriz = new int[_dimension, _dimension];
            LlenarMatrizDiagonal();
        }

        /// <summary>
        /// Llena la matriz cuadrada de forma que la diagonal principal contenga 1's
        /// y todas las demás posiciones contengan 0's.
        /// Algoritmo: Si fila == columna -> valor = 1, de lo contrario -> valor = 0.
        /// </summary>
        public void LlenarMatrizDiagonal()
        {
            for (int i = 0; i < _dimension; i++)
            {
                for (int j = 0; j < _dimension; j++)
                {
                    if (EsDiagonalPrincipal(i, j))
                    {
                        _matriz[i, j] = 1;
                    }
                    else
                    {
                        _matriz[i, j] = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Determina si una posición (fila, columna) corresponde a la diagonal principal.
        /// </summary>
        /// <param name="fila">Índice de la fila (0 a N-1).</param>
        /// <param name="columna">Índice de la columna (0 a N-1).</param>
        /// <returns>True si fila == columna, de lo contrario False.</returns>
        public bool EsDiagonalPrincipal(int fila, int columna)
        {
            return fila == columna;
        }

        /// <summary>
        /// Obtiene el valor en la posición especificada.
        /// </summary>
        public int ObtenerValor(int fila, int columna)
        {
            ValidarIndices(fila, columna);
            return _matriz[fila, columna];
        }

        /// <summary>
        /// Establece el valor en la posición especificada.
        /// </summary>
        public void EstablecerValor(int fila, int columna, int valor)
        {
            ValidarIndices(fila, columna);
            _matriz[fila, columna] = valor;
        }

        /// <summary>
        /// Redimensiona la matriz cuadrada a un nuevo tamaño y regenera los valores.
        /// </summary>
        /// <param name="nuevaDimension">Nuevo tamaño N x N.</param>
        public void Redimensionar(int nuevaDimension)
        {
            Dimension = nuevaDimension;
            _matriz = new int[_dimension, _dimension];
            LlenarMatrizDiagonal();
        }

        /// <summary>
        /// Devuelve una copia de la matriz bidimensional interna.
        /// </summary>
        public int[,] ObtenerMatriz()
        {
            return (int[,])_matriz.Clone();
        }

        /// <summary>
        /// Genera una representación en cadena de texto formateada de la matriz.
        /// </summary>
        public string ObtenerRepresentacionTexto()
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine($"--- Matriz Cuadrada de {_dimension}x{_dimension} (Diagonal Principal = 1, Demás = 0) ---");
            for (int i = 0; i < _dimension; i++)
            {
                sb.Append("[ ");
                for (int j = 0; j < _dimension; j++)
                {
                    sb.Append(_matriz[i, j].ToString().PadLeft(3));
                    if (j < _dimension - 1) sb.Append(" ");
                }
                sb.AppendLine(" ]");
            }
            sb.AppendLine($"Total Elementos: {TotalElementos} | Diagonal (Unos): {TotalUnos} | Ceros: {TotalCeros}");
            return sb.ToString();
        }

        /// <summary>
        /// Valida que los índices proporcionados estén dentro de los límites de la matriz.
        /// </summary>
        private void ValidarIndices(int fila, int columna)
        {
            if (fila < 0 || fila >= _dimension)
            {
                throw new IndexOutOfRangeException($"El índice de fila ({fila}) está fuera de los límites [0, {_dimension - 1}].");
            }
            if (columna < 0 || columna >= _dimension)
            {
                throw new IndexOutOfRangeException($"El índice de columna ({columna}) está fuera de los límites [0, {_dimension - 1}].");
            }
        }
    }
}
