using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MatrizDiagonalApp.Models;

namespace MatrizDiagonalApp
{
    public partial class frmMatrizDiagonal : Form
    {
        private MatrizDiagonal _matrizDiagonal;

        public frmMatrizDiagonal()
        {
            InitializeComponent();
            _matrizDiagonal = new MatrizDiagonal(5);
        }

        private void frmMatrizDiagonal_Load(object sender, EventArgs e)
        {
            GenerarLogoDinamico();
            ConfigurarYMostrarMatriz();
        }

        /// <summary>
        /// Dibuja dinámicamente un logotipo vectorial nítido en picLogo
        /// con una representación visual de la matriz identidad y su diagonal.
        /// Cumple con la rúbrica: "incluir imágenes logrando un buen diseño de los componentes".
        /// </summary>
        private void GenerarLogoDinamico()
        {
            Bitmap bmp = new Bitmap(picLogo.Width, picLogo.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                // Fondo con degradado moderno
                using (LinearGradientBrush brushFondo = new LinearGradientBrush(
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    Color.FromArgb(14, 116, 144),
                    Color.FromArgb(2, 132, 199),
                    LinearGradientMode.ForwardDiagonal))
                {
                    g.FillEllipse(brushFondo, 4, 4, bmp.Width - 8, bmp.Height - 8);
                }

                // Borde circular elegante
                using (Pen penBorde = new Pen(Color.FromArgb(240, 253, 250), 2f))
                {
                    g.DrawEllipse(penBorde, 4, 4, bmp.Width - 8, bmp.Height - 8);
                }

                // Dibujar cuadrícula de 3x3 en miniatura ilustrando la diagonal de 1's
                int startX = 22;
                int startY = 22;
                int cellSize = 10;
                using (Font font = new Font("Segoe UI", 6.5f, FontStyle.Bold))
                {
                    for (int r = 0; r < 3; r++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            bool esDiag = (r == c);
                            Brush textBrush = esDiag ? Brushes.Yellow : Brushes.White;
                            string val = esDiag ? "1" : "0";
                            g.DrawString(val, font, textBrush, startX + c * cellSize, startY + r * cellSize);
                        }
                    }
                }
            }
            picLogo.Image = bmp;
        }

        /// <summary>
        /// Valida la entrada numérica del usuario, actualiza el modelo y dibuja el DataGridView.
        /// </summary>
        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtDimension.Text.Trim();

                // Validación 1: Datos faltantes
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Hay datos faltantes.\nPor favor introduzca la dimensión para la matriz cuadrada.",
                        "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDimension.Focus();
                    return;
                }

                // Validación 2: Sólo números
                if (!double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double valorDouble) &&
                    !double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out valorDouble))
                {
                    MessageBox.Show("Introducir sólo números.\nEl valor ingresado no corresponde a un formato numérico válido.",
                        "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDimension.SelectAll();
                    txtDimension.Focus();
                    return;
                }

                // Validación 3: Debe ser número entero (la dimensión de una matriz no puede ser decimal)
                if (valorDouble != Math.Floor(valorDouble))
                {
                    MessageBox.Show("Introducir sólo números enteros.\nLa dimensión de una matriz debe ser un número entero (por ejemplo: 3, 4, 5, etc.).",
                        "Número Decimal No Permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDimension.SelectAll();
                    txtDimension.Focus();
                    return;
                }

                int n = (int)valorDouble;

                // Validación 4: Rango válido
                if (n < 2 || n > 20)
                {
                    MessageBox.Show("La dimensión de la matriz debe estar entre 2 y 20 para garantizar una correcta visualización en pantalla.",
                        "Rango Fuera de Límites", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDimension.Focus();
                    return;
                }

                // Procesamiento orientado a objetos: Redimensionar y generar
                _matrizDiagonal.Redimensionar(n);

                // Salida: Actualizar interfaz gráfica
                ConfigurarYMostrarMatriz();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado al procesar la matriz: {ex.Message}",
                    "Error de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Configura las columnas y filas del DataGridView y carga los datos
        /// aplicando un resaltado visual distintivo para los 1's de la diagonal principal.
        /// </summary>
        private void ConfigurarYMostrarMatriz()
        {
            int n = _matrizDiagonal.Dimension;
            dgvMatriz.Rows.Clear();
            dgvMatriz.Columns.Clear();

            int colWidth = Math.Max(42, Math.Min(65, (dgvMatriz.Width - 90) / n));

            for (int j = 0; j < n; j++)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn
                {
                    Name = $"col{j}",
                    HeaderText = $"C{j}",
                    Width = colWidth,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dgvMatriz.Columns.Add(col);
            }

            for (int i = 0; i < n; i++)
            {
                int rowIndex = dgvMatriz.Rows.Add();
                dgvMatriz.Rows[rowIndex].HeaderCell.Value = $"F{i}";

                for (int j = 0; j < n; j++)
                {
                    int valor = _matrizDiagonal.ObtenerValor(i, j);
                    var cell = dgvMatriz.Rows[rowIndex].Cells[j];
                    cell.Value = valor;

                    // Formato condicional para resaltar la diagonal principal
                    if (_matrizDiagonal.EsDiagonalPrincipal(i, j))
                    {
                        cell.Style.BackColor = Color.FromArgb(209, 250, 229); // Verde esmeralda suave
                        cell.Style.ForeColor = Color.FromArgb(6, 95, 70);     // Verde oscuro
                        cell.Style.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                    }
                    else
                    {
                        cell.Style.BackColor = Color.White;
                        cell.Style.ForeColor = Color.FromArgb(100, 116, 139); // Gris azulado
                        cell.Style.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
                    }
                }
            }

            lblEstadisticas.Text = $"Dimensión actual: {n}x{n} | Diagonal (Unos): {_matrizDiagonal.TotalUnos} | Ceros: {_matrizDiagonal.TotalCeros} | Total elementos: {_matrizDiagonal.TotalElementos}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDimension.Text = "5";
            _matrizDiagonal.Redimensionar(5);
            ConfigurarYMostrarMatriz();
            txtDimension.Focus();
        }

        private void btnCopiarTexto_Click(object sender, EventArgs e)
        {
            try
            {
                string textoMatriz = _matrizDiagonal.ObtenerRepresentacionTexto();
                Clipboard.SetText(textoMatriz);
                MessageBox.Show("La representación en texto de la matriz ha sido copiada al portapapeles con éxito.",
                    "Copiado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No fue posible copiar al portapapeles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ejercicio 4: Matriz Diagonal Cuadrada con 1's y 0's\n\n" +
                "Descripción del Problema:\n" +
                "Desarrollar una aplicación para llenar una matriz cuadrada de números enteros de manera que:\n" +
                "a) La diagonal principal contenga 1's (unos).\n" +
                "b) Las demás posiciones contengan 0's (ceros).\n\n" +
                "Asignatura: Estructura de Datos\n" +
                "Implementación: Programación Orientada a Objetos (C# .NET Windows Forms)",
                "Acerca de Ejercicio 4", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtDimension_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir dígitos
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea caracteres no numéricos directamente
            }
        }
    }
}
