namespace Clase2
{
    partial class frmResultados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpFechaResultado = new DateTimePicker();
            grpLocal = new GroupBox();
            cboEquipoLocal = new ComboBox();
            lblGolesLocal = new Label();
            cboGolesLocal = new ComboBox();
            lblEquipoLocal = new Label();
            cmdRegistrarResultado = new Button();
            dgvResultados = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Local = new DataGridViewTextBoxColumn();
            Resultado = new DataGridViewTextBoxColumn();
            Visitante = new DataGridViewTextBoxColumn();
            grpVisitante = new GroupBox();
            cboEquipoVisitante = new ComboBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            lblGolesVisitante = new Label();
            cboGolesVisitante = new ComboBox();
            lblEquipoVisitante = new Label();
            btnRefrescarGrilla = new Button();
            grpEquipos = new GroupBox();
            btnEquipos = new Button();
            txtNombreEquipo = new TextBox();
            lblNombreEquipo = new Label();
            grpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            grpVisitante.SuspendLayout();
            groupBox1.SuspendLayout();
            grpEquipos.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFechaResultado
            // 
            dtpFechaResultado.Location = new Point(12, 12);
            dtpFechaResultado.Name = "dtpFechaResultado";
            dtpFechaResultado.Size = new Size(524, 23);
            dtpFechaResultado.TabIndex = 0;
            // 
            // grpLocal
            // 
            grpLocal.Controls.Add(cboEquipoLocal);
            grpLocal.Controls.Add(lblGolesLocal);
            grpLocal.Controls.Add(cboGolesLocal);
            grpLocal.Controls.Add(lblEquipoLocal);
            grpLocal.Location = new Point(14, 44);
            grpLocal.Name = "grpLocal";
            grpLocal.Size = new Size(250, 171);
            grpLocal.TabIndex = 1;
            grpLocal.TabStop = false;
            grpLocal.Text = "Local";
            // 
            // cboEquipoLocal
            // 
            cboEquipoLocal.FormattingEnabled = true;
            cboEquipoLocal.Location = new Point(66, 65);
            cboEquipoLocal.Name = "cboEquipoLocal";
            cboEquipoLocal.Size = new Size(167, 23);
            cboEquipoLocal.TabIndex = 4;
            // 
            // lblGolesLocal
            // 
            lblGolesLocal.AutoSize = true;
            lblGolesLocal.Location = new Point(6, 113);
            lblGolesLocal.Name = "lblGolesLocal";
            lblGolesLocal.Size = new Size(36, 15);
            lblGolesLocal.TabIndex = 3;
            lblGolesLocal.Text = "Goles";
            // 
            // cboGolesLocal
            // 
            cboGolesLocal.FormattingEnabled = true;
            cboGolesLocal.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            cboGolesLocal.Location = new Point(66, 113);
            cboGolesLocal.Name = "cboGolesLocal";
            cboGolesLocal.Size = new Size(167, 23);
            cboGolesLocal.TabIndex = 1;
            // 
            // lblEquipoLocal
            // 
            lblEquipoLocal.AutoSize = true;
            lblEquipoLocal.Location = new Point(6, 65);
            lblEquipoLocal.Name = "lblEquipoLocal";
            lblEquipoLocal.Size = new Size(44, 15);
            lblEquipoLocal.TabIndex = 0;
            lblEquipoLocal.Text = "Equipo";
            // 
            // cmdRegistrarResultado
            // 
            cmdRegistrarResultado.Location = new Point(12, 221);
            cmdRegistrarResultado.Name = "cmdRegistrarResultado";
            cmdRegistrarResultado.Size = new Size(252, 50);
            cmdRegistrarResultado.TabIndex = 2;
            cmdRegistrarResultado.Text = "Registrar Resultado";
            cmdRegistrarResultado.UseVisualStyleBackColor = true;
            cmdRegistrarResultado.Click += cmdRegistrarResultado_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { Fecha, Local, Resultado, Visitante });
            dgvResultados.Location = new Point(13, 283);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(523, 191);
            dgvResultados.TabIndex = 3;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Local
            // 
            Local.HeaderText = "Local";
            Local.Name = "Local";
            Local.ReadOnly = true;
            // 
            // Resultado
            // 
            Resultado.HeaderText = "Resultado";
            Resultado.Name = "Resultado";
            Resultado.ReadOnly = true;
            // 
            // Visitante
            // 
            Visitante.HeaderText = "Visitante";
            Visitante.Name = "Visitante";
            Visitante.ReadOnly = true;
            // 
            // grpVisitante
            // 
            grpVisitante.Controls.Add(cboEquipoVisitante);
            grpVisitante.Controls.Add(groupBox1);
            grpVisitante.Controls.Add(lblGolesVisitante);
            grpVisitante.Controls.Add(cboGolesVisitante);
            grpVisitante.Controls.Add(lblEquipoVisitante);
            grpVisitante.Location = new Point(286, 44);
            grpVisitante.Name = "grpVisitante";
            grpVisitante.Size = new Size(250, 171);
            grpVisitante.TabIndex = 4;
            grpVisitante.TabStop = false;
            grpVisitante.Text = "Visitante";
            // 
            // cboEquipoVisitante
            // 
            cboEquipoVisitante.FormattingEnabled = true;
            cboEquipoVisitante.Location = new Point(66, 65);
            cboEquipoVisitante.Name = "cboEquipoVisitante";
            cboEquipoVisitante.Size = new Size(167, 23);
            cboEquipoVisitante.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(256, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(175, 186);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Visitante";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 113);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Goles";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            comboBox1.Location = new Point(66, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Equipo";
            // 
            // lblGolesVisitante
            // 
            lblGolesVisitante.AutoSize = true;
            lblGolesVisitante.Location = new Point(6, 113);
            lblGolesVisitante.Name = "lblGolesVisitante";
            lblGolesVisitante.Size = new Size(36, 15);
            lblGolesVisitante.TabIndex = 3;
            lblGolesVisitante.Text = "Goles";
            // 
            // cboGolesVisitante
            // 
            cboGolesVisitante.FormattingEnabled = true;
            cboGolesVisitante.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            cboGolesVisitante.Location = new Point(66, 110);
            cboGolesVisitante.Name = "cboGolesVisitante";
            cboGolesVisitante.Size = new Size(167, 23);
            cboGolesVisitante.TabIndex = 1;
            // 
            // lblEquipoVisitante
            // 
            lblEquipoVisitante.AutoSize = true;
            lblEquipoVisitante.Location = new Point(6, 65);
            lblEquipoVisitante.Name = "lblEquipoVisitante";
            lblEquipoVisitante.Size = new Size(44, 15);
            lblEquipoVisitante.TabIndex = 0;
            lblEquipoVisitante.Text = "Equipo";
            // 
            // btnRefrescarGrilla
            // 
            btnRefrescarGrilla.Location = new Point(286, 221);
            btnRefrescarGrilla.Name = "btnRefrescarGrilla";
            btnRefrescarGrilla.Size = new Size(250, 50);
            btnRefrescarGrilla.TabIndex = 5;
            btnRefrescarGrilla.Text = "Refrescar Grilla";
            btnRefrescarGrilla.UseVisualStyleBackColor = true;
            btnRefrescarGrilla.Click += btnRefrescarGrilla_Click;
            // 
            // grpEquipos
            // 
            grpEquipos.Controls.Add(btnEquipos);
            grpEquipos.Controls.Add(txtNombreEquipo);
            grpEquipos.Controls.Add(lblNombreEquipo);
            grpEquipos.Location = new Point(552, 44);
            grpEquipos.Name = "grpEquipos";
            grpEquipos.Size = new Size(187, 171);
            grpEquipos.TabIndex = 6;
            grpEquipos.TabStop = false;
            grpEquipos.Text = "Equipos";
            // 
            // btnEquipos
            // 
            btnEquipos.Location = new Point(24, 113);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(141, 31);
            btnEquipos.TabIndex = 4;
            btnEquipos.Text = "Cargar Equipo";
            btnEquipos.UseVisualStyleBackColor = true;
            btnEquipos.Click += btnAgregarEquipo_Click;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(63, 65);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(114, 23);
            txtNombreEquipo.TabIndex = 3;
            // 
            // lblNombreEquipo
            // 
            lblNombreEquipo.AutoSize = true;
            lblNombreEquipo.Location = new Point(6, 68);
            lblNombreEquipo.Name = "lblNombreEquipo";
            lblNombreEquipo.Size = new Size(51, 15);
            lblNombreEquipo.TabIndex = 0;
            lblNombreEquipo.Text = "Nombre";
            // 
            // frmResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 486);
            Controls.Add(grpEquipos);
            Controls.Add(btnRefrescarGrilla);
            Controls.Add(grpVisitante);
            Controls.Add(dgvResultados);
            Controls.Add(cmdRegistrarResultado);
            Controls.Add(grpLocal);
            Controls.Add(dtpFechaResultado);
            Name = "frmResultados";
            Text = "Formulario de Resultados";
            grpLocal.ResumeLayout(false);
            grpLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            grpVisitante.ResumeLayout(false);
            grpVisitante.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpEquipos.ResumeLayout(false);
            grpEquipos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpFechaResultado;
        private GroupBox grpLocal;
        private ComboBox cboGolesLocal;
        private Label lblEquipoLocal;
        private Button cmdRegistrarResultado;
        private Label lblGolesLocal;
        private DataGridView dgvResultados;
        private GroupBox grpVisitante;
        private Label lblGolesVisitante;
        private ComboBox cboGolesVisitante;
        private Label lblEquipoVisitante;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Local;
        private DataGridViewTextBoxColumn Resultado;
        private DataGridViewTextBoxColumn Visitante;
        private Button btnRefrescarGrilla;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private GroupBox grpEquipos;
        private Button btnEquipos;
        private TextBox txtNombreEquipo;
        private Label lblNombreEquipo;
        private ComboBox cboEquipoLocal;
        private ComboBox cboEquipoVisitante;
    }
}
