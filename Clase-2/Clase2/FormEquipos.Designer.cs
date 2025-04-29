namespace Clase2
{
    partial class FormEquipos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            grpCrearEquipos = new GroupBox();
            btnCrearEquipo = new Button();
            txtPais = new TextBox();
            lblPais = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            grpEliminarEquipos = new GroupBox();
            cboEquipos = new ComboBox();
            btnEliminarEquipo = new Button();
            lblEliminarEquipo = new Label();
            lstEquipos = new ListBox();
            grpCrearEquipos.SuspendLayout();
            grpEliminarEquipos.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 156);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // grpCrearEquipos
            // 
            grpCrearEquipos.Controls.Add(btnCrearEquipo);
            grpCrearEquipos.Controls.Add(txtPais);
            grpCrearEquipos.Controls.Add(lblPais);
            grpCrearEquipos.Controls.Add(txtNombre);
            grpCrearEquipos.Controls.Add(lblNombre);
            grpCrearEquipos.Location = new Point(12, 12);
            grpCrearEquipos.Name = "grpCrearEquipos";
            grpCrearEquipos.Size = new Size(337, 214);
            grpCrearEquipos.TabIndex = 1;
            grpCrearEquipos.TabStop = false;
            grpCrearEquipos.Text = "Crear Equipos";
            // 
            // btnCrearEquipo
            // 
            btnCrearEquipo.Location = new Point(218, 171);
            btnCrearEquipo.Name = "btnCrearEquipo";
            btnCrearEquipo.Size = new Size(88, 23);
            btnCrearEquipo.TabIndex = 4;
            btnCrearEquipo.Text = "Crear Equipo";
            btnCrearEquipo.UseVisualStyleBackColor = true;
            btnCrearEquipo.Click += btnCrearEquipo_Click;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(137, 110);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(169, 23);
            txtPais.TabIndex = 3;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(31, 113);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 2;
            lblPais.Text = "Pais";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(169, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(31, 64);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // grpEliminarEquipos
            // 
            grpEliminarEquipos.Controls.Add(cboEquipos);
            grpEliminarEquipos.Controls.Add(btnEliminarEquipo);
            grpEliminarEquipos.Controls.Add(lblEliminarEquipo);
            grpEliminarEquipos.Location = new Point(364, 12);
            grpEliminarEquipos.Name = "grpEliminarEquipos";
            grpEliminarEquipos.Size = new Size(284, 214);
            grpEliminarEquipos.TabIndex = 5;
            grpEliminarEquipos.TabStop = false;
            grpEliminarEquipos.Text = "Eliminar Equipos";
            // 
            // cboEquipos
            // 
            cboEquipos.FormattingEnabled = true;
            cboEquipos.Location = new Point(99, 88);
            cboEquipos.Name = "cboEquipos";
            cboEquipos.Size = new Size(159, 23);
            cboEquipos.TabIndex = 5;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.Location = new Point(170, 171);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(88, 23);
            btnEliminarEquipo.TabIndex = 4;
            btnEliminarEquipo.Text = "Eliminar";
            btnEliminarEquipo.UseVisualStyleBackColor = true;
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // lblEliminarEquipo
            // 
            lblEliminarEquipo.AutoSize = true;
            lblEliminarEquipo.Location = new Point(40, 91);
            lblEliminarEquipo.Name = "lblEliminarEquipo";
            lblEliminarEquipo.Size = new Size(44, 15);
            lblEliminarEquipo.TabIndex = 2;
            lblEliminarEquipo.Text = "Equipo";
            // 
            // lstEquipos
            // 
            lstEquipos.FormattingEnabled = true;
            lstEquipos.ItemHeight = 15;
            lstEquipos.Location = new Point(12, 251);
            lstEquipos.Name = "lstEquipos";
            lstEquipos.Size = new Size(636, 109);
            lstEquipos.TabIndex = 6;
            // 
            // FormEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 440);
            Controls.Add(lstEquipos);
            Controls.Add(grpEliminarEquipos);
            Controls.Add(grpCrearEquipos);
            Controls.Add(label1);
            Name = "FormEquipos";
            Text = "Formulario de Equipos";
            grpCrearEquipos.ResumeLayout(false);
            grpCrearEquipos.PerformLayout();
            grpEliminarEquipos.ResumeLayout(false);
            grpEliminarEquipos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpCrearEquipos;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnCrearEquipo;
        private TextBox txtPais;
        private Label lblPais;
        private GroupBox grpEliminarEquipos;
        private Button btnEliminarEquipo;
        private Label lblEliminarEquipo;
        private ComboBox cboEquipos;
        private ListBox lstEquipos;
    }
}