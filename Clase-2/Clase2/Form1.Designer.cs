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
            comboEquipoLocal1 = new ComboBox();
            lblGolesLocal = new Label();
            cboGolesLocal = new ComboBox();
            lblEquipoLocal = new Label();
            cmdRegistrarResultado = new Button();
            dgvResultados = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Local = new DataGridViewTextBoxColumn();
            Resultado = new DataGridViewTextBoxColumn();
            Visitante = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewCheckBoxColumn();
            Objeto = new DataGridViewTextBoxColumn();
            grpVisitante = new GroupBox();
            comboEquipoVisitante2 = new ComboBox();
            lblGolesVisitante = new Label();
            cboGolesVisitante = new ComboBox();
            lblEquipoVisitante = new Label();
            btnRefrescarGrilla = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            RefrescarEquipos = new Button();
            btnRegistrarEquipo = new Button();
            label1 = new Label();
            textEquipo = new TextBox();
            comboBoxPaises = new ComboBox();
            label2 = new Label();
            dataEquipos = new DataGridView();
            Equipo = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            EliminarEquipo = new DataGridViewCheckBoxColumn();
            ObjetoEquipo = new DataGridViewTextBoxColumn();
            grpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            grpVisitante.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataEquipos).BeginInit();
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
            grpLocal.Controls.Add(comboEquipoLocal1);
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
            // comboEquipoLocal1
            // 
            comboEquipoLocal1.FormattingEnabled = true;
            comboEquipoLocal1.Location = new Point(66, 65);
            comboEquipoLocal1.Name = "comboEquipoLocal1";
            comboEquipoLocal1.Size = new Size(167, 23);
            comboEquipoLocal1.TabIndex = 4;
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
            cmdRegistrarResultado.Size = new Size(164, 50);
            cmdRegistrarResultado.TabIndex = 2;
            cmdRegistrarResultado.Text = "Registrar Resultado";
            cmdRegistrarResultado.UseVisualStyleBackColor = true;
            cmdRegistrarResultado.Click += cmdRegistrarResultado_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { Fecha, Local, Resultado, Visitante, Eliminar, Objeto });
            dgvResultados.Location = new Point(12, 283);
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
            // Eliminar
            // 
            Eliminar.HeaderText = "Seleccionar";
            Eliminar.Name = "Eliminar";
            // 
            // Objeto
            // 
            Objeto.HeaderText = "Objeto";
            Objeto.Name = "Objeto";
            Objeto.Visible = false;
            // 
            // grpVisitante
            // 
            grpVisitante.Controls.Add(comboEquipoVisitante2);
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
            // comboEquipoVisitante2
            // 
            comboEquipoVisitante2.FormattingEnabled = true;
            comboEquipoVisitante2.Location = new Point(66, 62);
            comboEquipoVisitante2.Name = "comboEquipoVisitante2";
            comboEquipoVisitante2.Size = new Size(167, 23);
            comboEquipoVisitante2.TabIndex = 4;
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
            cboGolesVisitante.Location = new Point(66, 113);
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
            btnRefrescarGrilla.Location = new Point(199, 221);
            btnRefrescarGrilla.Name = "btnRefrescarGrilla";
            btnRefrescarGrilla.Size = new Size(158, 50);
            btnRefrescarGrilla.TabIndex = 5;
            btnRefrescarGrilla.Text = "Refrescar Grilla";
            btnRefrescarGrilla.UseVisualStyleBackColor = true;
            btnRefrescarGrilla.Click += btnRefrescarGrilla_Click;
            // 
            // button1
            // 
            button1.Location = new Point(378, 221);
            button1.Name = "button1";
            button1.Size = new Size(158, 50);
            button1.TabIndex = 6;
            button1.Text = "Eliminar\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(RefrescarEquipos);
            groupBox1.Controls.Add(btnRegistrarEquipo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textEquipo);
            groupBox1.Controls.Add(comboBoxPaises);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(551, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 171);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Visitante";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 8F);
            button4.Location = new Point(240, 123);
            button4.Name = "button4";
            button4.Size = new Size(96, 32);
            button4.TabIndex = 10;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // RefrescarEquipos
            // 
            RefrescarEquipos.Font = new Font("Segoe UI", 8F);
            RefrescarEquipos.Location = new Point(124, 123);
            RefrescarEquipos.Name = "RefrescarEquipos";
            RefrescarEquipos.Size = new Size(96, 32);
            RefrescarEquipos.TabIndex = 9;
            RefrescarEquipos.Text = "Refrescar";
            RefrescarEquipos.UseVisualStyleBackColor = true;
            RefrescarEquipos.Click += RefrescarEquipos_Click;
            // 
            // btnRegistrarEquipo
            // 
            btnRegistrarEquipo.Font = new Font("Segoe UI", 8F);
            btnRegistrarEquipo.Location = new Point(6, 123);
            btnRegistrarEquipo.Name = "btnRegistrarEquipo";
            btnRegistrarEquipo.Size = new Size(96, 32);
            btnRegistrarEquipo.TabIndex = 8;
            btnRegistrarEquipo.Text = "Registrar";
            btnRegistrarEquipo.UseVisualStyleBackColor = true;
            btnRegistrarEquipo.Click += btnRegistrarEquipo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 82);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 3;
            label1.Text = "Pais";
            // 
            // textEquipo
            // 
            textEquipo.Location = new Point(66, 30);
            textEquipo.Name = "textEquipo";
            textEquipo.Size = new Size(167, 23);
            textEquipo.TabIndex = 2;
            // 
            // comboBoxPaises
            // 
            comboBoxPaises.FormattingEnabled = true;
            comboBoxPaises.Location = new Point(66, 74);
            comboBoxPaises.Name = "comboBoxPaises";
            comboBoxPaises.Size = new Size(167, 23);
            comboBoxPaises.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Equipo";
            // 
            // dataEquipos
            // 
            dataEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEquipos.Columns.AddRange(new DataGridViewColumn[] { Equipo, Pais, EliminarEquipo, ObjetoEquipo });
            dataEquipos.Location = new Point(557, 221);
            dataEquipos.Name = "dataEquipos";
            dataEquipos.Size = new Size(336, 253);
            dataEquipos.TabIndex = 7;
            // 
            // Equipo
            // 
            Equipo.HeaderText = "Equipo";
            Equipo.Name = "Equipo";
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.Name = "Pais";
            // 
            // EliminarEquipo
            // 
            EliminarEquipo.HeaderText = "Seleccionar";
            EliminarEquipo.Name = "EliminarEquipo";
            // 
            // ObjetoEquipo
            // 
            ObjetoEquipo.HeaderText = "Column1";
            ObjetoEquipo.Name = "ObjetoEquipo";
            ObjetoEquipo.Visible = false;
            // 
            // frmResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 486);
            Controls.Add(dataEquipos);
            Controls.Add(groupBox1);
            Controls.Add(button1);
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
            ((System.ComponentModel.ISupportInitialize)dataEquipos).EndInit();
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
        private Button btnRefrescarGrilla;
        private Button button1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Local;
        private DataGridViewTextBoxColumn Resultado;
        private DataGridViewTextBoxColumn Visitante;
        private DataGridViewCheckBoxColumn Eliminar;
        private DataGridViewTextBoxColumn Objeto;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textEquipo;
        private ComboBox comboBoxPaises;
        private Label label2;
        private Button btnRegistrarEquipo;
        private DataGridView dataEquipos;
        private Button RefrescarEquipos;
        private Button button4;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn Pais;
        private DataGridViewCheckBoxColumn EliminarEquipo;
        private DataGridViewTextBoxColumn ObjetoEquipo;
        private ComboBox comboEquipoLocal1;
        private ComboBox comboEquipoVisitante2;
    }
}
