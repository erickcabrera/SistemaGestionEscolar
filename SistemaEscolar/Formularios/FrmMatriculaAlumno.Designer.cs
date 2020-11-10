namespace SistemaEscolar.Formularios
{
    partial class FrmMatriculaAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMatriculaAlumno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBSalir = new System.Windows.Forms.PictureBox();
            this.picBMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            this.dgvMatriculaAlumnos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.lblIdDetalle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIAlumno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombreA = new System.Windows.Forms.Label();
            this.lblApellidoA = new System.Windows.Forms.Label();
            this.dgvMatriculas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIdMatricula = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculaAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(164)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.picBSalir);
            this.panel1.Controls.Add(this.picBMinimizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 74);
            this.panel1.TabIndex = 0;
            // 
            // picBSalir
            // 
            this.picBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBSalir.Image = ((System.Drawing.Image)(resources.GetObject("picBSalir.Image")));
            this.picBSalir.Location = new System.Drawing.Point(1124, 20);
            this.picBSalir.Name = "picBSalir";
            this.picBSalir.Size = new System.Drawing.Size(40, 42);
            this.picBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBSalir.TabIndex = 28;
            this.picBSalir.TabStop = false;
            this.picBSalir.Click += new System.EventHandler(this.picBSalir_Click);
            // 
            // picBMinimizar
            // 
            this.picBMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBMinimizar.Image")));
            this.picBMinimizar.Location = new System.Drawing.Point(1073, 20);
            this.picBMinimizar.Name = "picBMinimizar";
            this.picBMinimizar.Size = new System.Drawing.Size(45, 42);
            this.picBMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBMinimizar.TabIndex = 27;
            this.picBMinimizar.TabStop = false;
            this.picBMinimizar.Click += new System.EventHandler(this.picBMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matriculación de estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grupo:";
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(90, 111);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(320, 29);
            this.cmbGrupos.TabIndex = 1;
            this.cmbGrupos.SelectedIndexChanged += new System.EventHandler(this.cmbGrupos_SelectedIndexChanged);
            // 
            // dgvMatriculaAlumnos
            // 
            this.dgvMatriculaAlumnos.AllowUserToAddRows = false;
            this.dgvMatriculaAlumnos.AllowUserToDeleteRows = false;
            this.dgvMatriculaAlumnos.AllowUserToResizeRows = false;
            this.dgvMatriculaAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriculaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculaAlumnos.Location = new System.Drawing.Point(449, 115);
            this.dgvMatriculaAlumnos.MultiSelect = false;
            this.dgvMatriculaAlumnos.Name = "dgvMatriculaAlumnos";
            this.dgvMatriculaAlumnos.ReadOnly = true;
            this.dgvMatriculaAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvMatriculaAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatriculaAlumnos.Size = new System.Drawing.Size(708, 232);
            this.dgvMatriculaAlumnos.TabIndex = 3;
            this.dgvMatriculaAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriculaAlumnos_CellClick);
            this.dgvMatriculaAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriculaAlumnos_CellDoubleClick);
            this.dgvMatriculaAlumnos.SelectionChanged += new System.EventHandler(this.dgvMatriculaAlumnos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 314);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(398, 33);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Matricular";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(549, 469);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(242, 33);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(549, 553);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(242, 33);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Dar de baja";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(892, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(265, 22);
            this.label12.TabIndex = 36;
            this.label12.Text = "Estudiantes no matriculados";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIdDetalle
            // 
            this.lblIdDetalle.AutoSize = true;
            this.lblIdDetalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdDetalle.Location = new System.Drawing.Point(213, 143);
            this.lblIdDetalle.Name = "lblIdDetalle";
            this.lblIdDetalle.Size = new System.Drawing.Size(35, 13);
            this.lblIdDetalle.TabIndex = 37;
            this.lblIdDetalle.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código alumno:";
            // 
            // lblIAlumno
            // 
            this.lblIAlumno.AutoSize = true;
            this.lblIAlumno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIAlumno.ForeColor = System.Drawing.Color.Black;
            this.lblIAlumno.Location = new System.Drawing.Point(172, 174);
            this.lblIAlumno.Name = "lblIAlumno";
            this.lblIAlumno.Size = new System.Drawing.Size(0, 22);
            this.lblIAlumno.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código alumno:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código alumno:";
            // 
            // lblNombreA
            // 
            this.lblNombreA.AutoSize = true;
            this.lblNombreA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreA.ForeColor = System.Drawing.Color.Black;
            this.lblNombreA.Location = new System.Drawing.Point(171, 217);
            this.lblNombreA.Name = "lblNombreA";
            this.lblNombreA.Size = new System.Drawing.Size(0, 22);
            this.lblNombreA.TabIndex = 0;
            this.lblNombreA.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblApellidoA
            // 
            this.lblApellidoA.AutoSize = true;
            this.lblApellidoA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoA.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoA.Location = new System.Drawing.Point(172, 264);
            this.lblApellidoA.Name = "lblApellidoA";
            this.lblApellidoA.Size = new System.Drawing.Size(0, 22);
            this.lblApellidoA.TabIndex = 0;
            this.lblApellidoA.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvMatriculas
            // 
            this.dgvMatriculas.AllowUserToAddRows = false;
            this.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculas.Location = new System.Drawing.Point(12, 422);
            this.dgvMatriculas.Name = "dgvMatriculas";
            this.dgvMatriculas.Size = new System.Drawing.Size(515, 223);
            this.dgvMatriculas.TabIndex = 38;
            this.dgvMatriculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriculas_CellClick);
            this.dgvMatriculas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriculas_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código de matricula seleccionada:";
            // 
            // lblIdMatricula
            // 
            this.lblIdMatricula.AutoSize = true;
            this.lblIdMatricula.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMatricula.ForeColor = System.Drawing.Color.Black;
            this.lblIdMatricula.Location = new System.Drawing.Point(353, 387);
            this.lblIdMatricula.Name = "lblIdMatricula";
            this.lblIdMatricula.Size = new System.Drawing.Size(0, 22);
            this.lblIdMatricula.TabIndex = 0;
            // 
            // FrmMatriculaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 657);
            this.Controls.Add(this.dgvMatriculas);
            this.Controls.Add(this.lblIdDetalle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvMatriculaAlumnos);
            this.Controls.Add(this.cmbGrupos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblIAlumno);
            this.Controls.Add(this.lblIdMatricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblApellidoA);
            this.Controls.Add(this.lblNombreA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMatriculaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetalleGradoSeccion";
            this.Load += new System.EventHandler(this.FrmMatriculaAlumno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculaAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBSalir;
        private System.Windows.Forms.PictureBox picBMinimizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrupos;
        private System.Windows.Forms.DataGridView dgvMatriculaAlumnos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblIdDetalle;
        private System.Windows.Forms.Label lblIAlumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApellidoA;
        private System.Windows.Forms.Label lblNombreA;
        private System.Windows.Forms.DataGridView dgvMatriculas;
        private System.Windows.Forms.Label lblIdMatricula;
        private System.Windows.Forms.Label label6;
    }
}