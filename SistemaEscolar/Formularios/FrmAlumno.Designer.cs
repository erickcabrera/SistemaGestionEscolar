namespace SistemaEscolar.Formularios
{
    partial class FrmAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlumno));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBSalir = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.txtApellidoA = new System.Windows.Forms.TextBox();
            this.txtPadre = new System.Windows.Forms.TextBox();
            this.txtMadre = new System.Windows.Forms.TextBox();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.dtpFechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.rtbDireccionA = new System.Windows.Forms.RichTextBox();
            this.btnGuardarA = new System.Windows.Forms.Button();
            this.btnEditarA = new System.Windows.Forms.Button();
            this.btnEliminarA = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbSexoA = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtxtNIEA = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNumPartidaA = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefonoA = new System.Windows.Forms.MaskedTextBox();
            this.dvgDatosAlumnos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBMinimizar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatosAlumnos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Alumnos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(164)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.picBMinimizar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.picBSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 76);
            this.panel1.TabIndex = 1;
            // 
            // picBSalir
            // 
            this.picBSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBSalir.Image = ((System.Drawing.Image)(resources.GetObject("picBSalir.Image")));
            this.picBSalir.Location = new System.Drawing.Point(1211, 14);
            this.picBSalir.Name = "picBSalir";
            this.picBSalir.Size = new System.Drawing.Size(40, 42);
            this.picBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBSalir.TabIndex = 26;
            this.picBSalir.TabStop = false;
            this.picBSalir.Click += new System.EventHandler(this.picBSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "NIE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nombre del padre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(37, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nombre de la madre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(37, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nombre del encargado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(37, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Número de partida:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(37, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "Dirección:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(37, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 22);
            this.label11.TabIndex = 27;
            this.label11.Text = "Fecha de nacimiento:";
            // 
            // txtNombreA
            // 
            this.txtNombreA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreA.Location = new System.Drawing.Point(276, 15);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(258, 27);
            this.txtNombreA.TabIndex = 28;
            this.txtNombreA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreA_KeyPress);
            // 
            // txtApellidoA
            // 
            this.txtApellidoA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoA.Location = new System.Drawing.Point(276, 52);
            this.txtApellidoA.Name = "txtApellidoA";
            this.txtApellidoA.Size = new System.Drawing.Size(258, 27);
            this.txtApellidoA.TabIndex = 28;
            this.txtApellidoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoA_KeyPress);
            // 
            // txtPadre
            // 
            this.txtPadre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPadre.Location = new System.Drawing.Point(276, 263);
            this.txtPadre.Name = "txtPadre";
            this.txtPadre.Size = new System.Drawing.Size(258, 27);
            this.txtPadre.TabIndex = 28;
            this.txtPadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPadre_KeyPress);
            // 
            // txtMadre
            // 
            this.txtMadre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadre.Location = new System.Drawing.Point(276, 308);
            this.txtMadre.Name = "txtMadre";
            this.txtMadre.Size = new System.Drawing.Size(258, 27);
            this.txtMadre.TabIndex = 28;
            this.txtMadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMadre_KeyPress);
            // 
            // txtEncargado
            // 
            this.txtEncargado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncargado.Location = new System.Drawing.Point(276, 352);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(258, 27);
            this.txtEncargado.TabIndex = 28;
            this.txtEncargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEncargado_KeyPress);
            // 
            // dtpFechanacimiento
            // 
            this.dtpFechanacimiento.Location = new System.Drawing.Point(276, 184);
            this.dtpFechanacimiento.Name = "dtpFechanacimiento";
            this.dtpFechanacimiento.Size = new System.Drawing.Size(258, 20);
            this.dtpFechanacimiento.TabIndex = 29;
            // 
            // rtbDireccionA
            // 
            this.rtbDireccionA.Location = new System.Drawing.Point(276, 448);
            this.rtbDireccionA.Name = "rtbDireccionA";
            this.rtbDireccionA.Size = new System.Drawing.Size(258, 56);
            this.rtbDireccionA.TabIndex = 30;
            this.rtbDireccionA.Text = "";
            // 
            // btnGuardarA
            // 
            this.btnGuardarA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardarA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarA.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarA.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarA.Location = new System.Drawing.Point(31, 524);
            this.btnGuardarA.Name = "btnGuardarA";
            this.btnGuardarA.Size = new System.Drawing.Size(493, 34);
            this.btnGuardarA.TabIndex = 31;
            this.btnGuardarA.Text = "Guardar";
            this.btnGuardarA.UseVisualStyleBackColor = false;
            this.btnGuardarA.Click += new System.EventHandler(this.btnGuardarA_Click);
            // 
            // btnEditarA
            // 
            this.btnEditarA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarA.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarA.ForeColor = System.Drawing.Color.Black;
            this.btnEditarA.Location = new System.Drawing.Point(38, 523);
            this.btnEditarA.Name = "btnEditarA";
            this.btnEditarA.Size = new System.Drawing.Size(301, 35);
            this.btnEditarA.TabIndex = 33;
            this.btnEditarA.Text = "Editar";
            this.btnEditarA.UseVisualStyleBackColor = false;
            // 
            // btnEliminarA
            // 
            this.btnEliminarA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarA.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarA.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarA.Location = new System.Drawing.Point(356, 523);
            this.btnEliminarA.Name = "btnEliminarA";
            this.btnEliminarA.Size = new System.Drawing.Size(301, 35);
            this.btnEliminarA.TabIndex = 34;
            this.btnEliminarA.Text = "Eliminar";
            this.btnEliminarA.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(1023, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 22);
            this.label12.TabIndex = 27;
            this.label12.Text = "Registro de alumnos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(37, 396);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 22);
            this.label13.TabIndex = 35;
            this.label13.Text = "Sexo:";
            // 
            // cmbSexoA
            // 
            this.cmbSexoA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexoA.FormattingEnabled = true;
            this.cmbSexoA.Location = new System.Drawing.Point(276, 396);
            this.cmbSexoA.Name = "cmbSexoA";
            this.cmbSexoA.Size = new System.Drawing.Size(258, 29);
            this.cmbSexoA.TabIndex = 36;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mtxtNIEA
            // 
            this.mtxtNIEA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNIEA.Location = new System.Drawing.Point(276, 92);
            this.mtxtNIEA.Mask = "00000000";
            this.mtxtNIEA.Name = "mtxtNIEA";
            this.mtxtNIEA.Size = new System.Drawing.Size(258, 27);
            this.mtxtNIEA.TabIndex = 37;
            // 
            // mtxtNumPartidaA
            // 
            this.mtxtNumPartidaA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNumPartidaA.Location = new System.Drawing.Point(276, 137);
            this.mtxtNumPartidaA.Mask = "00000000";
            this.mtxtNumPartidaA.Name = "mtxtNumPartidaA";
            this.mtxtNumPartidaA.Size = new System.Drawing.Size(258, 27);
            this.mtxtNumPartidaA.TabIndex = 38;
            // 
            // mtxtTelefonoA
            // 
            this.mtxtTelefonoA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefonoA.Location = new System.Drawing.Point(276, 222);
            this.mtxtTelefonoA.Mask = "0000-0000";
            this.mtxtTelefonoA.Name = "mtxtTelefonoA";
            this.mtxtTelefonoA.Size = new System.Drawing.Size(258, 27);
            this.mtxtTelefonoA.TabIndex = 39;
            // 
            // dvgDatosAlumnos
            // 
            this.dvgDatosAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDatosAlumnos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dvgDatosAlumnos.Location = new System.Drawing.Point(38, 35);
            this.dvgDatosAlumnos.MultiSelect = false;
            this.dvgDatosAlumnos.Name = "dvgDatosAlumnos";
            this.dvgDatosAlumnos.ReadOnly = true;
            this.dvgDatosAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDatosAlumnos.Size = new System.Drawing.Size(619, 446);
            this.dvgDatosAlumnos.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.mtxtTelefonoA);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cmbSexoA);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnGuardarA);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.mtxtNumPartidaA);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.mtxtNIEA);
            this.panel2.Controls.Add(this.rtbDireccionA);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtNombreA);
            this.panel2.Controls.Add(this.dtpFechanacimiento);
            this.panel2.Controls.Add(this.txtApellidoA);
            this.panel2.Controls.Add(this.txtEncargado);
            this.panel2.Controls.Add(this.txtPadre);
            this.panel2.Controls.Add(this.txtMadre);
            this.panel2.Location = new System.Drawing.Point(12, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 579);
            this.panel2.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dvgDatosAlumnos);
            this.panel3.Controls.Add(this.btnEliminarA);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btnEditarA);
            this.panel3.Location = new System.Drawing.Point(590, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 579);
            this.panel3.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(445, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Registro de alumnos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-22, -44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // picBMinimizar
            // 
            this.picBMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBMinimizar.Image")));
            this.picBMinimizar.Location = new System.Drawing.Point(1160, 14);
            this.picBMinimizar.Name = "picBMinimizar";
            this.picBMinimizar.Size = new System.Drawing.Size(45, 42);
            this.picBMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBMinimizar.TabIndex = 30;
            this.picBMinimizar.TabStop = false;
            this.picBMinimizar.Click += new System.EventHandler(this.picBMinimizar_Click_1);
            // 
            // FrmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 676);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatosAlumnos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.TextBox txtApellidoA;
        private System.Windows.Forms.TextBox txtPadre;
        private System.Windows.Forms.TextBox txtMadre;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.DateTimePicker dtpFechanacimiento;
        private System.Windows.Forms.RichTextBox rtbDireccionA;
        private System.Windows.Forms.Button btnGuardarA;
        private System.Windows.Forms.Button btnEditarA;
        private System.Windows.Forms.Button btnEliminarA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSexoA;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox mtxtTelefonoA;
        private System.Windows.Forms.MaskedTextBox mtxtNumPartidaA;
        private System.Windows.Forms.MaskedTextBox mtxtNIEA;
        private System.Windows.Forms.DataGridView dvgDatosAlumnos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBMinimizar;
    }
}