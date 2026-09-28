using System.Drawing;
using System.Windows.Forms;

namespace MatrizDiagonalApp
{
    partial class frmMatrizDiagonal
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

            mnuPrincipal = new MenuStrip();
            tsmArchivo = new ToolStripMenuItem();
            tsmGenerar = new ToolStripMenuItem();
            tsmLimpiar = new ToolStripMenuItem();
            tsmSeparador1 = new ToolStripSeparator();
            tsmSalir = new ToolStripMenuItem();
            tsmOpciones = new ToolStripMenuItem();
            tsmCopiarTexto = new ToolStripMenuItem();
            tsmAyuda = new ToolStripMenuItem();
            tsmAcercaDe = new ToolStripMenuItem();

            panelEncabezado = new Panel();
            picLogo = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();

            panelControles = new Panel();
            lblDimension = new Label();
            txtDimension = new TextBox();
            btnGenerarMatriz = new Button();
            btnLimpiar = new Button();
            btnCopiarTexto = new Button();
            btnSalir = new Button();

            panelResultados = new Panel();
            lblResultadoTitulo = new Label();
            lblEstadisticas = new Label();
            dgvMatriz = new DataGridView();

            mnuPrincipal.SuspendLayout();
            panelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelControles.SuspendLayout();
            panelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).BeginInit();
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
            mnuPrincipal.Size = new Size(860, 29);
            mnuPrincipal.TabIndex = 0;
            mnuPrincipal.Text = "mnuPrincipal";

            // 
            // tsmArchivo
            // 
            tsmArchivo.DropDownItems.AddRange(new ToolStripItem[] { tsmGenerar, tsmLimpiar, tsmSeparador1, tsmSalir });
            tsmArchivo.Name = "tsmArchivo";
            tsmArchivo.Size = new Size(73, 25);
            tsmArchivo.Text = "Archivo";

            // 
            // tsmGenerar
            // 
            tsmGenerar.Name = "tsmGenerar";
            tsmGenerar.ShortcutKeys = Keys.Control | Keys.G;
            tsmGenerar.Size = new Size(244, 26);
            tsmGenerar.Text = "1. Generar Matriz";
            tsmGenerar.Click += btnGenerarMatriz_Click;

            // 
            // tsmLimpiar
            // 
            tsmLimpiar.Name = "tsmLimpiar";
            tsmLimpiar.ShortcutKeys = Keys.Control | Keys.L;
            tsmLimpiar.Size = new Size(244, 26);
            tsmLimpiar.Text = "2. Limpiar / Restaurar";
            tsmLimpiar.Click += btnLimpiar_Click;

            // 
            // tsmSeparador1
            // 
            tsmSeparador1.Name = "tsmSeparador1";
            tsmSeparador1.Size = new Size(241, 6);

            // 
            // tsmSalir
            // 
            tsmSalir.Name = "tsmSalir";
            tsmSalir.ShortcutKeys = Keys.Alt | Keys.F4;
            tsmSalir.Size = new Size(244, 26);
            tsmSalir.Text = "3. Salir";
            tsmSalir.Click += btnSalir_Click;

            // 
            // tsmOpciones
            // 
            tsmOpciones.DropDownItems.AddRange(new ToolStripItem[] { tsmCopiarTexto });
            tsmOpciones.Name = "tsmOpciones";
            tsmOpciones.Size = new Size(85, 25);
            tsmOpciones.Text = "Opciones";

            // 
            // tsmCopiarTexto
            // 
            tsmCopiarTexto.Name = "tsmCopiarTexto";
            tsmCopiarTexto.ShortcutKeys = Keys.Control | Keys.C;
            tsmCopiarTexto.Size = new Size(256, 26);
            tsmCopiarTexto.Text = "Copiar Formato Texto";
            tsmCopiarTexto.Click += btnCopiarTexto_Click;

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
            tsmAcercaDe.Text = "Acerca del Ejercicio 4";
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
            panelEncabezado.Size = new Size(860, 95);
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
            lblTitulo.Size = new Size(592, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Matriz Cuadrada con Diagonal de Unos (1's)";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitulo.Location = new Point(106, 55);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(596, 21);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Ejercicio 4: Diagonal Principal con 1's y demás posiciones con 0's | POO y Matrices";

            // 
            // panelControles
            // 
            panelControles.BackColor = Color.White;
            panelControles.BorderStyle = BorderStyle.FixedSingle;
            panelControles.Controls.Add(lblDimension);
            panelControles.Controls.Add(txtDimension);
            panelControles.Controls.Add(btnGenerarMatriz);
            panelControles.Controls.Add(btnLimpiar);
            panelControles.Controls.Add(btnCopiarTexto);
            panelControles.Controls.Add(btnSalir);
            panelControles.Location = new Point(20, 140);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(820, 75);
            panelControles.TabIndex = 2;

            // 
            // lblDimension
            // 
            lblDimension.AutoSize = true;
            lblDimension.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDimension.ForeColor = Color.FromArgb(30, 41, 59);
            lblDimension.Location = new Point(15, 26);
            lblDimension.Name = "lblDimension";
            lblDimension.Size = new Size(183, 23);
            lblDimension.TabIndex = 0;
            lblDimension.Text = "Dimensión (N x N):";

            // 
            // txtDimension
            // 
            txtDimension.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtDimension.Location = new Point(190, 22);
            txtDimension.MaxLength = 2;
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(65, 32);
            txtDimension.TabIndex = 1;
            txtDimension.Text = "5";
            txtDimension.TextAlign = HorizontalAlignment.Center;
            txtDimension.KeyPress += txtDimension_KeyPress;

            // 
            // btnGenerarMatriz
            // 
            btnGenerarMatriz.BackColor = Color.FromArgb(14, 116, 144);
            btnGenerarMatriz.Cursor = Cursors.Hand;
            btnGenerarMatriz.FlatAppearance.BorderSize = 0;
            btnGenerarMatriz.FlatStyle = FlatStyle.Flat;
            btnGenerarMatriz.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerarMatriz.ForeColor = Color.White;
            btnGenerarMatriz.Location = new Point(270, 18);
            btnGenerarMatriz.Name = "btnGenerarMatriz";
            btnGenerarMatriz.Size = new Size(130, 38);
            btnGenerarMatriz.TabIndex = 2;
            btnGenerarMatriz.Text = "Generar";
            btnGenerarMatriz.UseVisualStyleBackColor = false;
            btnGenerarMatriz.Click += btnGenerarMatriz_Click;

            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(100, 116, 139);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(410, 18);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 38);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Restaurar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;

            // 
            // btnCopiarTexto
            // 
            btnCopiarTexto.BackColor = Color.FromArgb(16, 149, 193);
            btnCopiarTexto.Cursor = Cursors.Hand;
            btnCopiarTexto.FlatAppearance.BorderSize = 0;
            btnCopiarTexto.FlatStyle = FlatStyle.Flat;
            btnCopiarTexto.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCopiarTexto.ForeColor = Color.White;
            btnCopiarTexto.Location = new Point(535, 18);
            btnCopiarTexto.Name = "btnCopiarTexto";
            btnCopiarTexto.Size = new Size(140, 38);
            btnCopiarTexto.TabIndex = 4;
            btnCopiarTexto.Text = "Copiar Tabla";
            btnCopiarTexto.UseVisualStyleBackColor = false;
            btnCopiarTexto.Click += btnCopiarTexto_Click;

            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(225, 29, 72);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(685, 18);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 38);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            // 
            // panelResultados
            // 
            panelResultados.BackColor = Color.White;
            panelResultados.BorderStyle = BorderStyle.FixedSingle;
            panelResultados.Controls.Add(lblResultadoTitulo);
            panelResultados.Controls.Add(lblEstadisticas);
            panelResultados.Controls.Add(dgvMatriz);
            panelResultados.Location = new Point(20, 230);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(820, 420);
            panelResultados.TabIndex = 3;

            // 
            // lblResultadoTitulo
            // 
            lblResultadoTitulo.AutoSize = true;
            lblResultadoTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblResultadoTitulo.ForeColor = Color.FromArgb(30, 41, 59);
            lblResultadoTitulo.Location = new Point(20, 15);
            lblResultadoTitulo.Name = "lblResultadoTitulo";
            lblResultadoTitulo.Size = new Size(346, 25);
            lblResultadoTitulo.TabIndex = 0;
            lblResultadoTitulo.Text = "Visualización de la Matriz Cuadrada:";

            // 
            // lblEstadisticas
            // 
            lblEstadisticas.AutoSize = true;
            lblEstadisticas.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            lblEstadisticas.ForeColor = Color.FromArgb(71, 85, 105);
            lblEstadisticas.Location = new Point(20, 45);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(420, 21);
            lblEstadisticas.TabIndex = 1;
            lblEstadisticas.Text = "Dimensión actual: 5x5 | Total 1's: 5 | Total 0's: 20 | Total elementos: 25";

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
            dgvCellStyleHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvCellStyleHeader.ForeColor = Color.FromArgb(15, 23, 42);
            dgvCellStyleHeader.SelectionBackColor = SystemColors.Highlight;
            dgvCellStyleHeader.SelectionForeColor = SystemColors.HighlightText;
            dgvMatriz.ColumnHeadersDefaultCellStyle = dgvCellStyleHeader;
            dgvMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCellStyleDefault.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCellStyleDefault.BackColor = SystemColors.Window;
            dgvCellStyleDefault.Font = new Font("Segoe UI", 11F);
            dgvCellStyleDefault.ForeColor = SystemColors.ControlText;
            dgvCellStyleDefault.SelectionBackColor = Color.FromArgb(186, 230, 253);
            dgvCellStyleDefault.SelectionForeColor = Color.Black;
            dgvMatriz.DefaultCellStyle = dgvCellStyleDefault;
            dgvMatriz.Location = new Point(20, 80);
            dgvMatriz.Name = "dgvMatriz";
            dgvMatriz.ReadOnly = true;
            dgvMatriz.RowHeadersWidth = 70;
            dgvMatriz.RowTemplate.Height = 36;
            dgvMatriz.Size = new Size(776, 320);
            dgvMatriz.TabIndex = 2;

            // 
            // frmMatrizDiagonal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(860, 675);
            Controls.Add(panelResultados);
            Controls.Add(panelControles);
            Controls.Add(panelEncabezado);
            Controls.Add(mnuPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = mnuPrincipal;
            MaximizeBox = false;
            Name = "frmMatrizDiagonal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMatrizDiagonal - Ejercicio 4 (Matriz Identidad con POO)";
            Load += frmMatrizDiagonal_Load;
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelControles.ResumeLayout(false);
            panelControles.PerformLayout();
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuPrincipal;
        private ToolStripMenuItem tsmArchivo;
        private ToolStripMenuItem tsmGenerar;
        private ToolStripMenuItem tsmLimpiar;
        private ToolStripSeparator tsmSeparador1;
        private ToolStripMenuItem tsmSalir;
        private ToolStripMenuItem tsmOpciones;
        private ToolStripMenuItem tsmCopiarTexto;
        private ToolStripMenuItem tsmAyuda;
        private ToolStripMenuItem tsmAcercaDe;

        private Panel panelEncabezado;
        private PictureBox picLogo;
        private Label lblTitulo;
        private Label lblSubtitulo;

        private Panel panelControles;
        private Label lblDimension;
        private TextBox txtDimension;
        private Button btnGenerarMatriz;
        private Button btnLimpiar;
        private Button btnCopiarTexto;
        private Button btnSalir;

        private Panel panelResultados;
        private Label lblResultadoTitulo;
        private Label lblEstadisticas;
        private DataGridView dgvMatriz;
    }
}
