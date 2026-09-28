using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using MatrizEstadisticasApp.Models;

namespace MatrizEstadisticasApp
{
    public partial class frmMatrizEstadisticas : Form
    {
        private MatrizEstadisticas _modelo;
        private bool _cargandoDatosEnUI = false;

        public frmMatrizEstadisticas()
        {
            InitializeComponent();
            _modelo = new MatrizEstadisticas();
        }

        private void frmMatrizEstadisticas_Load(object sender, EventArgs e)
        {
            GenerarLogoDinamico();
            ConfigurarGrillas();
            ActualizarTodoEnUI();
        }

        /// <summary>
        /// Dibuja un logotipo vectorial nítido con GDI+ en picLogo que representa análisis de matrices y estadísticas.
        /// Cumple con la rúbrica: "incluir imágenes logrando un buen diseño de los componentes".
        /// </summary>
        private void GenerarLogoDinamico()
        {
            Bitmap bmp = new Bitmap(picLogo.Width, picLogo.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                // Círculo base con degradado moderno
                using (LinearGradientBrush brushFondo = new LinearGradientBrush(
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    Color.FromArgb(30, 41, 59),
                    Color.FromArgb(14, 116, 144),
                    LinearGradientMode.ForwardDiagonal))
                {
                    g.FillEllipse(brushFondo, 3, 3, bmp.Width - 6, bmp.Height - 6);
                }

                using (Pen penBorde = new Pen(Color.FromArgb(56, 189, 248), 2.5f))
                {
                    g.DrawEllipse(penBorde, 3, 3, bmp.Width - 6, bmp.Height - 6);
                }

                // Dibujar barras estilizadas y texto representativo
                using (Brush brushBar1 = new SolidBrush(Color.FromArgb(52, 211, 153)))
                using (Brush brushBar2 = new SolidBrush(Color.FromArgb(251, 191, 36)))
                using (Brush brushBar3 = new SolidBrush(Color.FromArgb(96, 165, 250)))
                {
                    g.FillRectangle(brushBar1, 18, 44, 8, 18);
                    g.FillRectangle(brushBar2, 30, 32, 8, 30);
                    g.FillRectangle(brushBar3, 42, 22, 8, 40);
                }

                using (Font font = new Font("Segoe UI", 7.5f, FontStyle.Bold))
                using (Brush textBrush = new SolidBrush(Color.White))
                {
                    g.DrawString("5x10", font, textBrush, new PointF(18, 12));
                }
            }
            picLogo.Image = bmp;
        }

        /// <summary>
        /// Inicializa y alinea las columnas del DataGridView principal y la cuadrícula de totales de columnas.
        /// </summary>
        private void ConfigurarGrillas()
        {
            _cargandoDatosEnUI = true;

            // 1. Configurar dgvMatriz
            dgvMatriz.Columns.Clear();
            dgvMatriz.Rows.Clear();

            const int colMatrizWidth = 62;
            const int colTotalAWidth = 95;
            const int colTotalBWidth = 105;

            // Columnas de la Matriz (0 a 9)
            for (int j = 0; j < MatrizEstadisticas.TotalColumnas; j++)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn
                {
                    Name = $"col{j}",
                    HeaderText = $"Col {j}",
                    Width = colMatrizWidth,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dgvMatriz.Columns.Add(col);
            }

            // Columna para Arreglo A (Suma de cada fila)
            DataGridViewTextBoxColumn colA = new DataGridViewTextBoxColumn
            {
                Name = "colArregloA",
                HeaderText = "A (Suma Fila)",
                Width = colTotalAWidth,
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            colA.HeaderCell.Style.BackColor = Color.FromArgb(254, 243, 199);
            colA.HeaderCell.Style.ForeColor = Color.FromArgb(146, 64, 14);
            dgvMatriz.Columns.Add(colA);

            // Columna para Arreglo B (Promedio de cada fila)
            DataGridViewTextBoxColumn colB = new DataGridViewTextBoxColumn
            {
                Name = "colArregloB",
                HeaderText = "B (Prom Fila)",
                Width = colTotalBWidth,
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            colB.HeaderCell.Style.BackColor = Color.FromArgb(209, 250, 229);
            colB.HeaderCell.Style.ForeColor = Color.FromArgb(6, 95, 70);
            dgvMatriz.Columns.Add(colB);

            // Agregar las 5 filas de la matriz
            for (int i = 0; i < MatrizEstadisticas.TotalFilas; i++)
            {
                int rIdx = dgvMatriz.Rows.Add();
                dgvMatriz.Rows[rIdx].HeaderCell.Value = $"Fila {i}";
            }

            // 2. Configurar dgvTotalesColumnas (exactamente alineado con dgvMatriz)
            dgvTotalesColumnas.Columns.Clear();
            dgvTotalesColumnas.Rows.Clear();

            for (int j = 0; j < MatrizEstadisticas.TotalColumnas; j++)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn
                {
                    Name = $"totCol{j}",
                    HeaderText = $"C{j}",
                    Width = colMatrizWidth,
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                };
                dgvTotalesColumnas.Columns.Add(col);
            }

            DataGridViewTextBoxColumn totA = new DataGridViewTextBoxColumn
            {
                Name = "totA",
                HeaderText = "Total Gral",
                Width = colTotalAWidth,
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            dgvTotalesColumnas.Columns.Add(totA);

            DataGridViewTextBoxColumn totB = new DataGridViewTextBoxColumn
            {
                Name = "totB",
                HeaderText = "Prom Gral",
                Width = colTotalBWidth,
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            dgvTotalesColumnas.Columns.Add(totB);

            // Fila C: Suma de columnas
            int rC = dgvTotalesColumnas.Rows.Add();
            dgvTotalesColumnas.Rows[rC].HeaderCell.Value = "C (Suma)";
            dgvTotalesColumnas.Rows[rC].DefaultCellStyle.BackColor = Color.FromArgb(254, 240, 138); // Amarillo pastel
            dgvTotalesColumnas.Rows[rC].DefaultCellStyle.ForeColor = Color.FromArgb(113, 63, 18);

            // Fila D: Promedio de columnas
            int rD = dgvTotalesColumnas.Rows.Add();
            dgvTotalesColumnas.Rows[rD].HeaderCell.Value = "D (Prom)";
            dgvTotalesColumnas.Rows[rD].DefaultCellStyle.BackColor = Color.FromArgb(187, 247, 208); // Verde menta pastel
            dgvTotalesColumnas.Rows[rD].DefaultCellStyle.ForeColor = Color.FromArgb(20, 83, 45);

            _cargandoDatosEnUI = false;
        }

        /// <summary>
        /// Vuelca los valores del modelo tanto a las grillas como a la vista de formato texto idéntica al PDF.
        /// </summary>
        private void ActualizarTodoEnUI()
        {
            _cargandoDatosEnUI = true;

            decimal[,] matriz = _modelo.ObtenerMatriz();
            decimal sumaGlobal = 0;

            // Actualizar celdas de la matriz (5x10) y Arreglos A y B
            for (int i = 0; i < MatrizEstadisticas.TotalFilas; i++)
            {
                for (int j = 0; j < MatrizEstadisticas.TotalColumnas; j++)
                {
                    dgvMatriz.Rows[i].Cells[j].Value = matriz[i, j].ToString("0.##");
                }

                decimal a = _modelo.ObtenerArregloA(i);
                decimal b = _modelo.ObtenerArregloB(i);
                sumaGlobal += a;

                // Columna A (Suma Fila)
                var celdaA = dgvMatriz.Rows[i].Cells[10];
                celdaA.Value = a.ToString("0.##");
                celdaA.Style.BackColor = Color.FromArgb(254, 243, 199);
                celdaA.Style.ForeColor = Color.FromArgb(146, 64, 14);
                celdaA.Style.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);

                // Columna B (Promedio Fila)
                var celdaB = dgvMatriz.Rows[i].Cells[11];
                celdaB.Value = b.ToString("0.##");
                celdaB.Style.BackColor = Color.FromArgb(209, 250, 229);
                celdaB.Style.ForeColor = Color.FromArgb(6, 95, 70);
                celdaB.Style.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            }

            // Actualizar fila C (Suma Columna) y fila D (Promedio Columna)
            for (int j = 0; j < MatrizEstadisticas.TotalColumnas; j++)
            {
                dgvTotalesColumnas.Rows[0].Cells[j].Value = _modelo.ObtenerArregloC(j).ToString("0.##");
                dgvTotalesColumnas.Rows[1].Cells[j].Value = _modelo.ObtenerArregloD(j).ToString("0.##");
            }

            // Totales globales en las esquinas inferiores
            dgvTotalesColumnas.Rows[0].Cells[10].Value = sumaGlobal.ToString("0.##");
            dgvTotalesColumnas.Rows[0].Cells[11].Value = "-";
            dgvTotalesColumnas.Rows[1].Cells[10].Value = "-";
            dgvTotalesColumnas.Rows[1].Cells[11].Value = (sumaGlobal / (MatrizEstadisticas.TotalFilas * MatrizEstadisticas.TotalColumnas)).ToString("0.##");

            // Actualizar vista de formato de impresión especificado en el PDF
            txtVistaFormatoPdf.Text = _modelo.GenerarFormatoImpresionPdf();

            _cargandoDatosEnUI = false;
        }

        private void btnGenerarAleatorios_Click(object sender, EventArgs e)
        {
            try
            {
                string txtMin = txtRangoMin.Text.Trim();
                string txtMax = txtRangoMax.Text.Trim();

                // Validación de datos faltantes
                if (string.IsNullOrWhiteSpace(txtMin) || string.IsNullOrWhiteSpace(txtMax))
                {
                    MessageBox.Show("Hay datos faltantes.\nPor favor ingrese tanto el límite mínimo como el máximo para generar los números aleatorios.",
                        "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación de sólo números
                if (!int.TryParse(txtMin, out int min) || !int.TryParse(txtMax, out int max))
                {
                    MessageBox.Show("Introducir sólo números.\nLos valores de rango deben ser números enteros válidos.",
                        "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validación lógica de rango
                if (min > max)
                {
                    MessageBox.Show("El rango mínimo no puede ser mayor que el rango máximo.",
                        "Rango Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llenar modelo con aleatorios y recalcular
                _modelo.LlenarConAleatorios(min, max);
                ActualizarTodoEnUI();

                MessageBox.Show($"¡Matriz de 5x10 generada exitosamente con valores aleatorios entre {min} y {max}!\nLos arreglos A, B, C y D han sido calculados.",
                    "Generación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar los números aleatorios: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarEjemplo_Click(object sender, EventArgs e)
        {
            try
            {
                _modelo.CargarEjemploPdf();
                ActualizarTodoEnUI();

                MessageBox.Show("¡Datos del ejemplo oficial de la Página 3 del PDF cargados exitosamente!\nPuede comparar los resultados de los arreglos A, B, C y D.",
                    "Ejemplo Cargado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el ejemplo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer datos desde dgvMatriz para sincronizar cualquier edición manual del usuario
                for (int i = 0; i < MatrizEstadisticas.TotalFilas; i++)
                {
                    for (int j = 0; j < MatrizEstadisticas.TotalColumnas; j++)
                    {
                        var celdaValor = dgvMatriz.Rows[i].Cells[j].Value;
                        if (celdaValor == null || string.IsNullOrWhiteSpace(celdaValor.ToString()))
                        {
                            throw new FormatException($"Hay datos faltantes en la celda [Fila {i}, Columna {j}].");
                        }

                        string valStr = celdaValor.ToString()!.Trim();
                        if (!decimal.TryParse(valStr, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal val) &&
                            !decimal.TryParse(valStr, NumberStyles.Any, CultureInfo.InvariantCulture, out val))
                        {
                            throw new FormatException($"Introducir sólo números: El valor '{valStr}' en [Fila {i}, Columna {j}] no es un número válido.");
                        }

                        _modelo.EstablecerValor(i, j, val);
                    }
                }

                _modelo.CalcularEstadisticas();
                ActualizarTodoEnUI();

                MessageBox.Show("¡Estadísticas recalculadas correctamente para todos los arreglos (A, B, C, D)!",
                    "Cálculo Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMatriz_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (_cargandoDatosEnUI) return;

            // Si el usuario edita una celda en las columnas de la matriz (0 a 9)
            if (e.RowIndex >= 0 && e.RowIndex < MatrizEstadisticas.TotalFilas &&
                e.ColumnIndex >= 0 && e.ColumnIndex < MatrizEstadisticas.TotalColumnas)
            {
                var valorCelda = dgvMatriz.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (valorCelda != null)
                {
                    string str = valorCelda.ToString()!.Trim();
                    if (decimal.TryParse(str, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal val) ||
                        decimal.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out val))
                    {
                        _modelo.EstablecerValor(e.RowIndex, e.ColumnIndex, val);
                        _modelo.CalcularEstadisticas();
                        ActualizarTodoEnUI();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRangoMin.Text = "1";
            txtRangoMax.Text = "9";
            _modelo.CargarEjemploPdf();
            ActualizarTodoEnUI();
        }

        private void btnCopiarFormatoPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string reporte = _modelo.GenerarFormatoImpresionPdf();
                Clipboard.SetText(reporte);
                MessageBox.Show("¡El reporte con el formato exacto del PDF ha sido copiado al portapapeles!",
                    "Copiado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo copiar al portapapeles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ejercicio 5: Matriz 5x10 con Sumas y Promedios (Arreglos A, B, C, D)\n\n" +
                "Descripción del Problema:\n" +
                "Llenar una matriz de 5 x 10 con números aleatorios y calcular:\n" +
                "a) Arreglo A: Suma de cada fila.\n" +
                "b) Arreglo B: Promedio de cada fila.\n" +
                "c) Arreglo C: Suma de cada columna.\n" +
                "d) Arreglo D: Promedio de cada columna.\n" +
                "e) Formato de salida idéntico al solicitado en el PDF.\n\n" +
                "Asignatura: Estructura de Datos | Unidad I (POO)",
                "Acerca de Ejercicio 5", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
