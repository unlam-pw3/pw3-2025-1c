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
            cbEquipoLocal = new ComboBox();
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
            cbEquipoVisitante = new ComboBox();
            lblGolesVisitante = new Label();
            cboGolesVisitante = new ComboBox();
            lblEquipoVisitante = new Label();
            btnRefrescarGrilla = new Button();
            gbAgregarEquipo = new GroupBox();
            tbPaisEquipo = new TextBox();
            label2 = new Label();
            tbNombreEquipo = new TextBox();
            label1 = new Label();
            btnAgregarEquipo = new Button();
            groupBox1 = new GroupBox();
            btnRefrescarListaEnEliminarEquipo = new Button();
            btnEliminarEquipo = new Button();
            cbEliminarEquipo = new ComboBox();
            label3 = new Label();
            btnRefrescarEquipos = new Button();
            grpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            grpVisitante.SuspendLayout();
            gbAgregarEquipo.SuspendLayout();
            groupBox1.SuspendLayout();
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
            grpLocal.Controls.Add(cbEquipoLocal);
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
            // cbEquipoLocal
            // 
            cbEquipoLocal.FormattingEnabled = true;
            cbEquipoLocal.Location = new Point(66, 66);
            cbEquipoLocal.Name = "cbEquipoLocal";
            cbEquipoLocal.Size = new Size(167, 23);
            cbEquipoLocal.TabIndex = 4;
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
            cmdRegistrarResultado.Location = new Point(144, 221);
            cmdRegistrarResultado.Name = "cmdRegistrarResultado";
            cmdRegistrarResultado.Size = new Size(184, 50);
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
            grpVisitante.Controls.Add(cbEquipoVisitante);
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
            // cbEquipoVisitante
            // 
            cbEquipoVisitante.FormattingEnabled = true;
            cbEquipoVisitante.Location = new Point(66, 67);
            cbEquipoVisitante.Name = "cbEquipoVisitante";
            cbEquipoVisitante.Size = new Size(167, 23);
            cbEquipoVisitante.TabIndex = 4;
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
            btnRefrescarGrilla.Location = new Point(336, 221);
            btnRefrescarGrilla.Name = "btnRefrescarGrilla";
            btnRefrescarGrilla.Size = new Size(200, 50);
            btnRefrescarGrilla.TabIndex = 5;
            btnRefrescarGrilla.Text = "Refrescar Grilla";
            btnRefrescarGrilla.UseVisualStyleBackColor = true;
            btnRefrescarGrilla.Click += btnRefrescarGrilla_Click;
            // 
            // gbAgregarEquipo
            // 
            gbAgregarEquipo.Controls.Add(tbPaisEquipo);
            gbAgregarEquipo.Controls.Add(label2);
            gbAgregarEquipo.Controls.Add(tbNombreEquipo);
            gbAgregarEquipo.Controls.Add(label1);
            gbAgregarEquipo.Controls.Add(btnAgregarEquipo);
            gbAgregarEquipo.Location = new Point(542, 44);
            gbAgregarEquipo.Name = "gbAgregarEquipo";
            gbAgregarEquipo.Size = new Size(246, 196);
            gbAgregarEquipo.TabIndex = 6;
            gbAgregarEquipo.TabStop = false;
            gbAgregarEquipo.Text = "Agregar Equipo";
            // 
            // tbPaisEquipo
            // 
            tbPaisEquipo.Location = new Point(13, 124);
            tbPaisEquipo.Name = "tbPaisEquipo";
            tbPaisEquipo.Size = new Size(227, 23);
            tbPaisEquipo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 101);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Pais del Equipo";
            // 
            // tbNombreEquipo
            // 
            tbNombreEquipo.Location = new Point(13, 67);
            tbNombreEquipo.Name = "tbNombreEquipo";
            tbNombreEquipo.Size = new Size(227, 23);
            tbNombreEquipo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 44);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre Equipo:";
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Location = new Point(13, 156);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(227, 23);
            btnAgregarEquipo.TabIndex = 0;
            btnAgregarEquipo.Text = "Agregar Equipo";
            btnAgregarEquipo.UseVisualStyleBackColor = true;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRefrescarListaEnEliminarEquipo);
            groupBox1.Controls.Add(btnEliminarEquipo);
            groupBox1.Controls.Add(cbEliminarEquipo);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(794, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 196);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eliminar Equipo";
            // 
            // btnRefrescarListaEnEliminarEquipo
            // 
            btnRefrescarListaEnEliminarEquipo.Location = new Point(122, 22);
            btnRefrescarListaEnEliminarEquipo.Name = "btnRefrescarListaEnEliminarEquipo";
            btnRefrescarListaEnEliminarEquipo.Size = new Size(118, 23);
            btnRefrescarListaEnEliminarEquipo.TabIndex = 3;
            btnRefrescarListaEnEliminarEquipo.Text = "Refrescar Lista";
            btnRefrescarListaEnEliminarEquipo.UseVisualStyleBackColor = true;
            btnRefrescarListaEnEliminarEquipo.Click += btnRefrescarListaEnEliminarEquipo_Click;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.Location = new Point(6, 105);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(234, 23);
            btnEliminarEquipo.TabIndex = 2;
            btnEliminarEquipo.Text = "Eliminar Equipo";
            btnEliminarEquipo.UseVisualStyleBackColor = true;
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // cbEliminarEquipo
            // 
            cbEliminarEquipo.FormattingEnabled = true;
            cbEliminarEquipo.Location = new Point(6, 67);
            cbEliminarEquipo.Name = "cbEliminarEquipo";
            cbEliminarEquipo.Size = new Size(234, 23);
            cbEliminarEquipo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 44);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "Equipo";
            // 
            // btnRefrescarEquipos
            // 
            btnRefrescarEquipos.Location = new Point(14, 221);
            btnRefrescarEquipos.Name = "btnRefrescarEquipos";
            btnRefrescarEquipos.Size = new Size(124, 50);
            btnRefrescarEquipos.TabIndex = 8;
            btnRefrescarEquipos.Text = "Refrescar Equipos";
            btnRefrescarEquipos.UseVisualStyleBackColor = true;
            btnRefrescarEquipos.Click += btnRefrescarEquipos_Click;
            // 
            // frmResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 482);
            Controls.Add(btnRefrescarEquipos);
            Controls.Add(groupBox1);
            Controls.Add(gbAgregarEquipo);
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
            gbAgregarEquipo.ResumeLayout(false);
            gbAgregarEquipo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private TextBox txtEquipoVisitante;
        private ComboBox cboGolesVisitante;
        private Label lblEquipoVisitante;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Local;
        private DataGridViewTextBoxColumn Resultado;
        private DataGridViewTextBoxColumn Visitante;
        private Button btnRefrescarGrilla;
        private ComboBox cbEquipoLocal;
        private ComboBox cbEquipoVisitante;
        private GroupBox gbAgregarEquipo;
        private Button btnAgregarEquipo;
        private TextBox tbPaisEquipo;
        private Label label2;
        private TextBox tbNombreEquipo;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private ComboBox cbEliminarEquipo;
        private Button btnEliminarEquipo;
        private Button btnRefrescarListaEnEliminarEquipo;
        private Button btnRefrescarEquipos;
    }
}
