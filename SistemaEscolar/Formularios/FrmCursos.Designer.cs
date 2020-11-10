namespace SistemaEscolar.Formularios
{
    partial class FrmCursos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBMinimizar = new System.Windows.Forms.PictureBox();
            this.dgvDetalleGrado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIdMateria = new System.Windows.Forms.Label();
            this.lblIdProfesor = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblIdCurso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleGrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(164)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.picBSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picBMinimizar);
            this.panel1.Location = new System.Drawing.Point(-2, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 82);
            this.panel1.TabIndex = 0;
            // 
            // picBSalir
            // 
            this.picBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBSalir.Image = ((System.Drawing.Image)(resources.GetObject("picBSalir.Image")));
            this.picBSalir.Location = new System.Drawing.Point(880, 31);
            this.picBSalir.Name = "picBSalir";
            this.picBSalir.Size = new System.Drawing.Size(40, 42);
            this.picBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBSalir.TabIndex = 30;
            this.picBSalir.TabStop = false;
            this.picBSalir.Click += new System.EventHandler(this.picBSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de cursos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picBMinimizar
            // 
            this.picBMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBMinimizar.Image")));
            this.picBMinimizar.Location = new System.Drawing.Point(829, 31);
            this.picBMinimizar.Name = "picBMinimizar";
            this.picBMinimizar.Size = new System.Drawing.Size(45, 42);
            this.picBMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBMinimizar.TabIndex = 29;
            this.picBMinimizar.TabStop = false;
            this.picBMinimizar.Click += new System.EventHandler(this.picBMinimizar_Click);
            // 
            // dgvDetalleGrado
            // 
            this.dgvDetalleGrado.AllowUserToAddRows = false;
            this.dgvDetalleGrado.AllowUserToDeleteRows = false;
            this.dgvDetalleGrado.AllowUserToResizeRows = false;
            this.dgvDetalleGrado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleGrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleGrado.Location = new System.Drawing.Point(382, 109);
            this.dgvDetalleGrado.MultiSelect = false;
            this.dgvDetalleGrado.Name = "dgvDetalleGrado";
            this.dgvDetalleGrado.ReadOnly = true;
            this.dgvDetalleGrado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleGrado.Size = new System.Drawing.Size(555, 212);
            this.dgvDetalleGrado.TabIndex = 1;
            this.dgvDetalleGrado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleGrado_CellContentDoubleClick);
            this.dgvDetalleGrado.CellContextMenuStripChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleGrado_CellContextMenuStripChanged);
            this.dgvDetalleGrado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleGrado_CellDoubleClick);
            this.dgvDetalleGrado.SelectionChanged += new System.EventHandler(this.dgvDetalleGrado_SelectionChanged);
            this.dgvDetalleGrado.DoubleClick += new System.EventHandler(this.dgvDetalleGrado_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Materia:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(136, 109);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(209, 21);
            this.cmbMaterias.TabIndex = 2;
            this.cmbMaterias.SelectedIndexChanged += new System.EventHandler(this.cmbMaterias_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Profesor:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(136, 170);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(209, 21);
            this.cmbProfesor.TabIndex = 2;
            this.cmbProfesor.SelectedIndexChanged += new System.EventHandler(this.cmbProfesor_SelectedIndexChanged);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(31, 228);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(314, 40);
            this.btnAsignar.TabIndex = 3;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // dgvCurso
            // 
            this.dgvCurso.AllowUserToAddRows = false;
            this.dgvCurso.AllowUserToDeleteRows = false;
            this.dgvCurso.AllowUserToResizeRows = false;
            this.dgvCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Location = new System.Drawing.Point(31, 409);
            this.dgvCurso.MultiSelect = false;
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.ReadOnly = true;
            this.dgvCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurso.Size = new System.Drawing.Size(569, 189);
            this.dgvCurso.TabIndex = 1;
            this.dgvCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellClick);
            this.dgvCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellContentClick);
            this.dgvCurso.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellDoubleClick);
            this.dgvCurso.SelectionChanged += new System.EventHandler(this.dgvCurso_SelectionChanged);
            this.dgvCurso.DoubleClick += new System.EventHandler(this.dgvCurso_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(774, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selección de Grupo";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cursos registrados";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(623, 431);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(314, 40);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(623, 518);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(314, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblIdMateria
            // 
            this.lblIdMateria.AutoSize = true;
            this.lblIdMateria.BackColor = System.Drawing.SystemColors.Window;
            this.lblIdMateria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdMateria.Location = new System.Drawing.Point(133, 145);
            this.lblIdMateria.Name = "lblIdMateria";
            this.lblIdMateria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdMateria.Size = new System.Drawing.Size(35, 13);
            this.lblIdMateria.TabIndex = 4;
            this.lblIdMateria.Text = "label6";
            this.lblIdMateria.Visible = false;
            // 
            // lblIdProfesor
            // 
            this.lblIdProfesor.AutoSize = true;
            this.lblIdProfesor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdProfesor.Location = new System.Drawing.Point(133, 194);
            this.lblIdProfesor.Name = "lblIdProfesor";
            this.lblIdProfesor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdProfesor.Size = new System.Drawing.Size(35, 13);
            this.lblIdProfesor.TabIndex = 5;
            this.lblIdProfesor.Text = "label7";
            this.lblIdProfesor.Visible = false;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDetalle.Location = new System.Drawing.Point(660, 85);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDetalle.Size = new System.Drawing.Size(0, 21);
            this.lblDetalle.TabIndex = 6;
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.AutoSize = true;
            this.lblIdCurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCurso.Location = new System.Drawing.Point(466, 375);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(57, 21);
            this.lblIdCurso.TabIndex = 7;
            this.lblIdCurso.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(210, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código de curso seleccionado:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(378, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código de grupo seleccionado:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(949, 610);
            this.Controls.Add(this.lblIdCurso);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblIdProfesor);
            this.Controls.Add(this.lblIdMateria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMaterias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCurso);
            this.Controls.Add(this.dgvDetalleGrado);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.FrmCursos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleGrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetalleGrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox picBSalir;
        private System.Windows.Forms.PictureBox picBMinimizar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblIdProfesor;
        private System.Windows.Forms.Label lblIdMateria;
        private System.Windows.Forms.Label lblIdCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}