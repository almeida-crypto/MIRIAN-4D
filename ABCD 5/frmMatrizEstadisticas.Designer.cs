using System.Drawing;
using System.Windows.Forms;

namespace MatrizEstadisticasApp
{
    partial class frmMatrizEstadisticas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dgvCellStyleHeader = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvCellStyleDefault = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvColsStyleHeader = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvColsStyleDefault = new DataGridViewCellStyle();

            mnuPrincipal = new MenuStrip();
            tsmArchivo = new ToolStripMenuItem();
            tsmGenerar = new ToolStripMenuItem();
            tsmCargarEjemplo = new ToolStripMenuItem();
            tsmRecalcular = new ToolStripMenuItem();
            tsmLimpiar = new ToolStripMenuItem();
            tsmSeparador1 = new ToolStripSeparator();
            tsmSalir = new ToolStripMenuItem();
            tsmOpciones = new ToolStripMenuItem();
            tsmCopiarPdf = new ToolStripMenuItem();
            tsmAyuda = new ToolStripMenuItem();
            tsmAcercaDe = new ToolStripMenuItem();

            panelEncabezado = new Panel();
            picLogo = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();

            panelControles = new Panel();
            lblRangoMin = new Label();
            txtRangoMin = new TextBox();
            lblRangoMax = new Label();
            txtRangoMax = new TextBox();
            btnGenerarAleatorios = new Button();
            btnCargarEjemplo = new Button();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnCopiarFormatoPdf = new Button();
            btnSalir = new Button();

            tabPrincipal = new TabControl();
            tabGrafica = new TabPage();
            lblTituloMatriz = new Label();
            dgvMatriz = new DataGridView();
            lblTituloColumnas = new Label();
            dgvTotalesColumnas = new DataGridView();

            tabTextoPdf = new TabPage();
            lblInstruccionTexto = new Label();
            txtVistaFormatoPdf = new TextBox();
            btnCopiarTextoTab = new Button();

            mnuPrincipal.SuspendLayout();
            panelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelControles.SuspendLayout();
            tabPrincipal.SuspendLayout();
            tabGrafica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTotalesColumnas).BeginInit();
            tabTextoPdf.SuspendLayout();
            SuspendLayout();

            // 
            // mnuPrincipal
            // 
            mnuPrincipal.BackColor = Color.FromArgb(241, 245, 249);
            mnuPrincipal.Font = new Font("Segoe UI", 9.5F);
            mnuPrincipal.ImageScalingSize = new Size(20, 20);
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { tsmArchivo, tsmOpciones, tsmAyuda });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(1020, 29);
            mnuPrincipal.TabIndex = 0;
            mnuPrincipal.Text = "mnuPrincipal";

            // 
            // tsmArchivo
            // 
            tsmArchivo.DropDownItems.AddRange(new ToolStripItem[] { tsmGenerar, tsmCargarEjemplo, tsmRecalcular, tsmLimpiar, tsmSeparador1, tsmSalir });
            tsmArchivo.Name = "tsmArchivo";
            tsmArchivo.Size = new Size(73, 25);
            tsmArchivo.Text = "Archivo";

            // 
            // tsmGenerar
            // 
            tsmGenerar.Name = "tsmGenerar";
            tsmGenerar.ShortcutKeys = Keys.Control | Keys.G;
            tsmGenerar.Size = new Size(273, 26);
            tsmGenerar.Text = "1. Generar Aleatorios";
            tsmGenerar.Click += btnGenerarAleatorios_Click;

            // 
            // tsmCargarEjemplo
            // 
            tsmCargarEjemplo.Name = "tsmCargarEjemplo";
            tsmCargarEjemplo.ShortcutKeys = Keys.Control | Keys.E;
            tsmCargarEjemplo.Size = new Size(273, 26);
            tsmCargarEjemplo.Text = "2. Cargar Ejemplo PDF";
            tsmCargarEjemplo.Click += btnCargarEjemplo_Click;

            // 
            // tsmRecalcular
            // 
            tsmRecalcular.Name = "tsmRecalcular";
            tsmRecalcular.ShortcutKeys = Keys.F5;
            tsmRecalcular.Size = new Size(273, 26);
            tsmRecalcular.Text = "3. Recalcular Todo";
            tsmRecalcular.Click += btnCalcular_Click;

            // 
            // tsmLimpiar
            // 
            tsmLimpiar.Name = "tsmLimpiar";
            tsmLimpiar.ShortcutKeys = Keys.Control | Keys.L;
            tsmLimpiar.Size = new Size(273, 26);
            tsmLimpiar.Text = "4. Restaurar Datos";
            tsmLimpiar.Click += btnLimpiar_Click;

            // 
            // tsmSeparador1
            // 
            tsmSeparador1.Name = "tsmSeparador1";
            tsmSeparador1.Size = new Size(270, 6);

            // 
            // tsmSalir
            // 
            tsmSalir.Name = "tsmSalir";
            tsmSalir.ShortcutKeys = Keys.Alt | Keys.F4;
            tsmSalir.Size = new Size(273, 26);
            tsmSalir.Text = "5. Salir";
            tsmSalir.Click += btnSalir_Click;

            // 
            // tsmOpciones
            // 
            tsmOpciones.DropDownItems.AddRange(new ToolStripItem[] { tsmCopiarPdf });
            tsmOpciones.Name = "tsmOpciones";
            tsmOpciones.Size = new Size(85, 25);
            tsmOpciones.Text = "Opciones";

            // 
            // tsmCopiarPdf
            // 
            tsmCopiarPdf.Name = "tsmCopiarPdf";
            tsmCopiarPdf.ShortcutKeys = Keys.Control | Keys.C;
            tsmCopiarPdf.Size = new Size(280, 26);
            tsmCopiarPdf.Text = "Copiar Formato PDF";
            tsmCopiarPdf.Click += btnCopiarFormatoPdf_Click;

            // 
            // tsmAyuda
            // 
            tsmAyuda.DropDownItems.AddRange(new ToolStripItem[] { tsmAcercaDe });
            tsmAyuda.Name = "tsmAyuda";
            tsmAyuda.Size = new Size(65, 25);
            tsmAyuda.Text = "Ayuda";

            // 
            // tsmAcercaDe
            // 
            tsmAcercaDe.Name = "tsmAcercaDe";
            tsmAcercaDe.Size = new Size(224, 26);
            tsmAcercaDe.Text = "Acerca del Ejercicio 5";
            tsmAcercaDe.Click += tsmAcercaDe_Click;

            // 
            // panelEncabezado
            // 
            panelEncabezado.BackColor = Color.FromArgb(15, 23, 42);
            panelEncabezado.Controls.Add(picLogo);
            panelEncabezado.Controls.Add(lblTitulo);
            panelEncabezado.Controls.Add(lblSubtitulo);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 29);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(1020, 95);
            panelEncabezado.TabIndex = 1;

            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BorderStyle = BorderStyle.None;
            picLogo.Location = new Point(20, 10);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(75, 75);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(105, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(690, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Análisis Estadístico de Matriz 5x10 (A, B, C, D)";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitulo.Location = new Point(106, 55);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(705, 21);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Ejercicio 5: Suma y Promedio por Filas (A, B) y por Columnas (C, D) | POO en C# Windows Forms";

            // 
            // panelControles
            // 
            panelControles.BackColor = Color.White;
            panelControles.BorderStyle = BorderStyle.FixedSingle;
            panelControles.Controls.Add(lblRangoMin);
            panelControles.Controls.Add(txtRangoMin);
            panelControles.Controls.Add(lblRangoMax);
            panelControles.Controls.Add(txtRangoMax);
            panelControles.Controls.Add(btnGenerarAleatorios);
            panelControles.Controls.Add(btnCargarEjemplo);
            panelControles.Controls.Add(btnCalcular);
            panelControles.Controls.Add(btnLimpiar);
            panelControles.Controls.Add(btnCopiarFormatoPdf);
            panelControles.Controls.Add(btnSalir);
            panelControles.Location = new Point(20, 135);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(980, 80);
            panelControles.TabIndex = 2;

            // 
            // lblRangoMin
            // 
            lblRangoMin.AutoSize = true;
            lblRangoMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRangoMin.ForeColor = Color.FromArgb(30, 41, 59);
            lblRangoMin.Location = new Point(10, 16);
            lblRangoMin.Name = "lblRangoMin";
            lblRangoMin.Size = new Size(41, 20);
            lblRangoMin.TabIndex = 0;
            lblRangoMin.Text = "Mín:";

            // 
            // txtRangoMin
            // 
            txtRangoMin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtRangoMin.Location = new Point(53, 12);
            txtRangoMin.MaxLength = 5;
            txtRangoMin.Name = "txtRangoMin";
            txtRangoMin.Size = new Size(42, 30);
            txtRangoMin.TabIndex = 1;
            txtRangoMin.Text = "1";
            txtRangoMin.TextAlign = HorizontalAlignment.Center;

            // 
            // lblRangoMax
            // 
            lblRangoMax.AutoSize = true;
            lblRangoMax.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRangoMax.ForeColor = Color.FromArgb(30, 41, 59);
            lblRangoMax.Location = new Point(10, 46);
            lblRangoMax.Name = "lblRangoMax";
            lblRangoMax.Size = new Size(43, 20);
            lblRangoMax.TabIndex = 2;
            lblRangoMax.Text = "Máx:";

            // 
            // txtRangoMax
            // 
            txtRangoMax.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtRangoMax.Location = new Point(53, 43);
            txtRangoMax.MaxLength = 5;
            txtRangoMax.Name = "txtRangoMax";
            txtRangoMax.Size = new Size(42, 30);
            txtRangoMax.TabIndex = 3;
            txtRangoMax.Text = "9";
            txtRangoMax.TextAlign = HorizontalAlignment.Center;

            // 
            // btnGenerarAleatorios
            // 
            btnGenerarAleatorios.BackColor = Color.FromArgb(14, 116, 144);
            btnGenerarAleatorios.Cursor = Cursors.Hand;
            btnGenerarAleatorios.FlatAppearance.BorderSize = 0;
            btnGenerarAleatorios.FlatStyle = FlatStyle.Flat;
            btnGenerarAleatorios.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerarAleatorios.ForeColor = Color.White;
            btnGenerarAleatorios.Location = new Point(105, 20);
            btnGenerarAleatorios.Name = "btnGenerarAleatorios";
            btnGenerarAleatorios.Size = new Size(160, 40);
            btnGenerarAleatorios.TabIndex = 4;
            btnGenerarAleatorios.Text = "🎲 Aleatorios";
            btnGenerarAleatorios.UseVisualStyleBackColor = false;
            btnGenerarAleatorios.Click += btnGenerarAleatorios_Click;

            // 
            // btnCargarEjemplo
            // 
            btnCargarEjemplo.BackColor = Color.FromArgb(16, 185, 129);
            btnCargarEjemplo.Cursor = Cursors.Hand;
            btnCargarEjemplo.FlatAppearance.BorderSize = 0;
            btnCargarEjemplo.FlatStyle = FlatStyle.Flat;
            btnCargarEjemplo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCargarEjemplo.ForeColor = Color.White;
            btnCargarEjemplo.Location = new Point(275, 20);
            btnCargarEjemplo.Name = "btnCargarEjemplo";
            btnCargarEjemplo.Size = new Size(160, 40);
            btnCargarEjemplo.TabIndex = 5;
            btnCargarEjemplo.Text = "📄 Ejemplo PDF";
            btnCargarEjemplo.UseVisualStyleBackColor = false;
            btnCargarEjemplo.Click += btnCargarEjemplo_Click;

            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(217, 119, 6);
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(445, 20);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 40);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Recalcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;

            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(100, 116, 139);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(580, 20);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 40);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Restaurar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;

            // 
            // btnCopiarFormatoPdf
            // 
            btnCopiarFormatoPdf.BackColor = Color.FromArgb(79, 70, 229);
            btnCopiarFormatoPdf.Cursor = Cursors.Hand;
            btnCopiarFormatoPdf.FlatAppearance.BorderSize = 0;
            btnCopiarFormatoPdf.FlatStyle = FlatStyle.Flat;
            btnCopiarFormatoPdf.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCopiarFormatoPdf.ForeColor = Color.White;
            btnCopiarFormatoPdf.Location = new Point(700, 20);
            btnCopiarFormatoPdf.Name = "btnCopiarFormatoPdf";
            btnCopiarFormatoPdf.Size = new Size(160, 40);
            btnCopiarFormatoPdf.TabIndex = 8;
            btnCopiarFormatoPdf.Text = "📋 Copiar Formato";
            btnCopiarFormatoPdf.UseVisualStyleBackColor = false;
            btnCopiarFormatoPdf.Click += btnCopiarFormatoPdf_Click;

            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(225, 29, 72);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(870, 20);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 40);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            // 
            // tabPrincipal
            // 
            tabPrincipal.Controls.Add(tabGrafica);
            tabPrincipal.Controls.Add(tabTextoPdf);
            tabPrincipal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tabPrincipal.Location = new Point(20, 225);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(980, 480);
            tabPrincipal.TabIndex = 3;

            // 
            // tabGrafica
            // 
            tabGrafica.BackColor = Color.White;
            tabGrafica.Controls.Add(lblTituloMatriz);
            tabGrafica.Controls.Add(dgvMatriz);
            tabGrafica.Controls.Add(lblTituloColumnas);
            tabGrafica.Controls.Add(dgvTotalesColumnas);
            tabGrafica.Location = new Point(4, 32);
            tabGrafica.Name = "tabGrafica";
            tabGrafica.Padding = new Padding(15);
            tabGrafica.Size = new Size(972, 444);
            tabGrafica.TabIndex = 0;
            tabGrafica.Text = "📊 Grilla Interactiva (Matriz y Arreglos A, B, C, D)";

            // 
            // lblTituloMatriz
            // 
            lblTituloMatriz.AutoSize = true;
            lblTituloMatriz.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTituloMatriz.ForeColor = Color.FromArgb(30, 41, 59);
            lblTituloMatriz.Location = new Point(15, 12);
            lblTituloMatriz.Name = "lblTituloMatriz";
            lblTituloMatriz.Size = new Size(595, 25);
            lblTituloMatriz.TabIndex = 0;
            lblTituloMatriz.Text = "Matriz (5x10) y Arreglos por Fila: [A: Suma Fila] | [B: Promedio Fila]:";

            // 
            // dgvMatriz
            // 
            dgvMatriz.AllowUserToAddRows = false;
            dgvMatriz.AllowUserToDeleteRows = false;
            dgvMatriz.AllowUserToResizeRows = false;
            dgvMatriz.BackgroundColor = Color.FromArgb(248, 250, 252);
            dgvMatriz.BorderStyle = BorderStyle.Fixed3D;
            dgvCellStyleHeader.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCellStyleHeader.BackColor = Color.FromArgb(226, 232, 240);
            dgvCellStyleHeader.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvCellStyleHeader.ForeColor = Color.FromArgb(15, 23, 42);
            dgvCellStyleHeader.SelectionBackColor = SystemColors.Highlight;
            dgvCellStyleHeader.SelectionForeColor = SystemColors.HighlightText;
            dgvMatriz.ColumnHeadersDefaultCellStyle = dgvCellStyleHeader;
            dgvMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCellStyleDefault.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCellStyleDefault.BackColor = SystemColors.Window;
            dgvCellStyleDefault.Font = new Font("Segoe UI", 10F);
            dgvCellStyleDefault.ForeColor = SystemColors.ControlText;
            dgvCellStyleDefault.SelectionBackColor = Color.FromArgb(186, 230, 253);
            dgvCellStyleDefault.SelectionForeColor = Color.Black;
            dgvMatriz.DefaultCellStyle = dgvCellStyleDefault;
            dgvMatriz.Location = new Point(15, 42);
            dgvMatriz.Name = "dgvMatriz";
            dgvMatriz.RowHeadersWidth = 85;
            dgvMatriz.RowTemplate.Height = 34;
            dgvMatriz.Size = new Size(940, 205);
            dgvMatriz.TabIndex = 1;
            dgvMatriz.CellValueChanged += dgvMatriz_CellValueChanged;

            // 
            // lblTituloColumnas
            // 
            lblTituloColumnas.AutoSize = true;
            lblTituloColumnas.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTituloColumnas.ForeColor = Color.FromArgb(30, 41, 59);
            lblTituloColumnas.Location = new Point(15, 260);
            lblTituloColumnas.Name = "lblTituloColumnas";
            lblTituloColumnas.Size = new Size(612, 25);
            lblTituloColumnas.TabIndex = 2;
            lblTituloColumnas.Text = "Arreglos por Columna: [C: Suma Columna] | [D: Promedio Columna]:";

            // 
            // dgvTotalesColumnas
            // 
            dgvTotalesColumnas.AllowUserToAddRows = false;
            dgvTotalesColumnas.AllowUserToDeleteRows = false;
            dgvTotalesColumnas.AllowUserToResizeRows = false;
            dgvTotalesColumnas.BackgroundColor = Color.FromArgb(248, 250, 252);
            dgvTotalesColumnas.BorderStyle = BorderStyle.Fixed3D;
            dgvColsStyleHeader.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvColsStyleHeader.BackColor = Color.FromArgb(203, 213, 225);
            dgvColsStyleHeader.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvColsStyleHeader.ForeColor = Color.FromArgb(15, 23, 42);
            dgvColsStyleHeader.SelectionBackColor = SystemColors.Highlight;
            dgvColsStyleHeader.SelectionForeColor = SystemColors.HighlightText;
            dgvTotalesColumnas.ColumnHeadersDefaultCellStyle = dgvColsStyleHeader;
            dgvTotalesColumnas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColsStyleDefault.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvColsStyleDefault.BackColor = SystemColors.Window;
            dgvColsStyleDefault.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvColsStyleDefault.ForeColor = SystemColors.ControlText;
            dgvColsStyleDefault.SelectionBackColor = Color.FromArgb(186, 230, 253);
            dgvColsStyleDefault.SelectionForeColor = Color.Black;
            dgvTotalesColumnas.DefaultCellStyle = dgvColsStyleDefault;
            dgvTotalesColumnas.Location = new Point(15, 290);
            dgvTotalesColumnas.Name = "dgvTotalesColumnas";
            dgvTotalesColumnas.ReadOnly = true;
            dgvTotalesColumnas.RowHeadersWidth = 85;
            dgvTotalesColumnas.RowTemplate.Height = 34;
            dgvTotalesColumnas.Size = new Size(940, 130);
            dgvTotalesColumnas.TabIndex = 3;

            // 
            // tabTextoPdf
            // 
            tabTextoPdf.BackColor = Color.White;
            tabTextoPdf.Controls.Add(lblInstruccionTexto);
            tabTextoPdf.Controls.Add(txtVistaFormatoPdf);
            tabTextoPdf.Controls.Add(btnCopiarTextoTab);
            tabTextoPdf.Location = new Point(4, 32);
            tabTextoPdf.Name = "tabTextoPdf";
            tabTextoPdf.Padding = new Padding(15);
            tabTextoPdf.Size = new Size(972, 444);
            tabTextoPdf.TabIndex = 1;
            tabTextoPdf.Text = "📄 Formato de Impresión PDF (Inciso C)";

            // 
            // lblInstruccionTexto
            // 
            lblInstruccionTexto.AutoSize = true;
            lblInstruccionTexto.Font = new Font("Segoe UI", 10F);
            lblInstruccionTexto.ForeColor = Color.FromArgb(71, 85, 105);
            lblInstruccionTexto.Location = new Point(15, 15);
            lblInstruccionTexto.Name = "lblInstruccionTexto";
            lblInstruccionTexto.Size = new Size(646, 23);
            lblInstruccionTexto.TabIndex = 0;
            lblInstruccionTexto.Text = "Visualización idéntica al formato impreso especificado en el instrumento de evaluación:";

            // 
            // txtVistaFormatoPdf
            // 
            txtVistaFormatoPdf.BackColor = Color.FromArgb(15, 23, 42);
            txtVistaFormatoPdf.Font = new Font("Consolas", 10.5F);
            txtVistaFormatoPdf.ForeColor = Color.FromArgb(56, 189, 248);
            txtVistaFormatoPdf.Location = new Point(15, 45);
            txtVistaFormatoPdf.Multiline = true;
            txtVistaFormatoPdf.Name = "txtVistaFormatoPdf";
            txtVistaFormatoPdf.ReadOnly = true;
            txtVistaFormatoPdf.ScrollBars = ScrollBars.Both;
            txtVistaFormatoPdf.Size = new Size(940, 335);
            txtVistaFormatoPdf.TabIndex = 1;

            // 
            // btnCopiarTextoTab
            // 
            btnCopiarTextoTab.BackColor = Color.FromArgb(14, 116, 144);
            btnCopiarTextoTab.Cursor = Cursors.Hand;
            btnCopiarTextoTab.FlatAppearance.BorderSize = 0;
            btnCopiarTextoTab.FlatStyle = FlatStyle.Flat;
            btnCopiarTextoTab.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCopiarTextoTab.ForeColor = Color.White;
            btnCopiarTextoTab.Location = new Point(15, 390);
            btnCopiarTextoTab.Name = "btnCopiarTextoTab";
            btnCopiarTextoTab.Size = new Size(240, 40);
            btnCopiarTextoTab.TabIndex = 2;
            btnCopiarTextoTab.Text = "📋 Copiar Formato de Texto";
            btnCopiarTextoTab.UseVisualStyleBackColor = false;
            btnCopiarTextoTab.Click += btnCopiarFormatoPdf_Click;

            // 
            // frmMatrizEstadisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1020, 725);
            Controls.Add(tabPrincipal);
            Controls.Add(panelControles);
            Controls.Add(panelEncabezado);
            Controls.Add(mnuPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = mnuPrincipal;
            MaximizeBox = false;
            Name = "frmMatrizEstadisticas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMatrizEstadisticas - Ejercicio 5: Matriz 5x10 (Sumas y Promedios A, B, C, D)";
            Load += frmMatrizEstadisticas_Load;
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelControles.ResumeLayout(false);
            panelControles.PerformLayout();
            tabPrincipal.ResumeLayout(false);
            tabGrafica.ResumeLayout(false);
            tabGrafica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTotalesColumnas).EndInit();
            tabTextoPdf.ResumeLayout(false);
            tabTextoPdf.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuPrincipal;
        private ToolStripMenuItem tsmArchivo;
        private ToolStripMenuItem tsmGenerar;
        private ToolStripMenuItem tsmCargarEjemplo;
        private ToolStripMenuItem tsmRecalcular;
        private ToolStripMenuItem tsmLimpiar;
        private ToolStripSeparator tsmSeparador1;
        private ToolStripMenuItem tsmSalir;
        private ToolStripMenuItem tsmOpciones;
        private ToolStripMenuItem tsmCopiarPdf;
        private ToolStripMenuItem tsmAyuda;
        private ToolStripMenuItem tsmAcercaDe;

        private Panel panelEncabezado;
        private PictureBox picLogo;
        private Label lblTitulo;
        private Label lblSubtitulo;

        private Panel panelControles;
        private Label lblRangoMin;
        private TextBox txtRangoMin;
        private Label lblRangoMax;
        private TextBox txtRangoMax;
        private Button btnGenerarAleatorios;
        private Button btnCargarEjemplo;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnCopiarFormatoPdf;
        private Button btnSalir;

        private TabControl tabPrincipal;
        private TabPage tabGrafica;
        private Label lblTituloMatriz;
        private DataGridView dgvMatriz;
        private Label lblTituloColumnas;
        private DataGridView dgvTotalesColumnas;

        private TabPage tabTextoPdf;
        private Label lblInstruccionTexto;
        private TextBox txtVistaFormatoPdf;
        private Button btnCopiarTextoTab;
    }
}
