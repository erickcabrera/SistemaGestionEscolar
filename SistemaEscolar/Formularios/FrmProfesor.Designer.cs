namespace SistemaEscolar.Formularios
{
    partial class FrmProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBMinimizar = new System.Windows.Forms.PictureBox();
            this.picBSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtEmailP = new System.Windows.Forms.TextBox();
            this.dtpFechaP = new System.Windows.Forms.DateTimePicker();
            this.cmbSexoP = new System.Windows.Forms.ComboBox();
            this.rtbDireccionP = new System.Windows.Forms.RichTextBox();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.dgvDatosP = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEditarP = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtxtTelefonoP = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDUIP = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNITP = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNumEscalafonP = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFoto = new System.Windows.Forms.Button();
            this.openFileFoto = new System.Windows.Forms.OpenFileDialog();
            this.pbFotoProfesor = new System.Windows.Forms.PictureBox();
            this.lblIdProfesor = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRutaFoto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(164)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.picBMinimizar);
            this.panel1.Controls.Add(this.picBSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 76);
            this.panel1.TabIndex = 2;
            // 
            // picBMinimizar
            // 
            this.picBMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBMinimizar.Image")));
            this.picBMinimizar.Location = new System.Drawing.Point(1197, 20);
            this.picBMinimizar.Name = "picBMinimizar";
            this.picBMinimizar.Size = new System.Drawing.Size(45, 42);
            this.picBMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBMinimizar.TabIndex = 39;
            this.picBMinimizar.TabStop = false;
            this.picBMinimizar.Click += new System.EventHandler(this.picBMinimizar_Click_2);
            // 
            // picBSalir
            // 
            this.picBSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBSalir.Image = ((System.Drawing.Image)(resources.GetObject("picBSalir.Image")));
            this.picBSalir.Location = new System.Drawing.Point(1248, 20);
            this.picBSalir.Name = "picBSalir";
            this.picBSalir.Size = new System.Drawing.Size(40, 42);
            this.picBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBSalir.TabIndex = 26;
            this.picBSalir.TabStop = false;
            this.picBSalir.Click += new System.EventHandler(this.picBSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Profesores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(48, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(48, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Teléfono:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(48, 279);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(186, 22);
            this.label.TabIndex = 28;
            this.label.Text = "Correo electrónico:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(48, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 22);
            this.label7.TabIndex = 28;
            this.label7.Text = "DUI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(48, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "NIT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(48, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 22);
            this.label9.TabIndex = 28;
            this.label9.Text = "Número de escalafón:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(48, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "Sexo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(48, 480);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "Dirección:";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreP.Location = new System.Drawing.Point(276, 112);
            this.txtNombreP.MaxLength = 50;
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(258, 27);
            this.txtNombreP.TabIndex = 1;
            this.txtNombreP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreP_KeyPress);
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoP.Location = new System.Drawing.Point(276, 152);
            this.txtApellidoP.MaxLength = 50;
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(258, 27);
            this.txtApellidoP.TabIndex = 2;
            this.txtApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoP_KeyPress);
            // 
            // txtEmailP
            // 
            this.txtEmailP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailP.Location = new System.Drawing.Point(276, 279);
            this.txtEmailP.MaxLength = 150;
            this.txtEmailP.Name = "txtEmailP";
            this.txtEmailP.Size = new System.Drawing.Size(258, 27);
            this.txtEmailP.TabIndex = 5;
            this.txtEmailP.TextChanged += new System.EventHandler(this.txtEmailP_TextChanged);
            // 
            // dtpFechaP
            // 
            this.dtpFechaP.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaP.Location = new System.Drawing.Point(276, 194);
            this.dtpFechaP.Name = "dtpFechaP";
            this.dtpFechaP.Size = new System.Drawing.Size(258, 20);
            this.dtpFechaP.TabIndex = 3;
            // 
            // cmbSexoP
            // 
            this.cmbSexoP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexoP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexoP.FormattingEnabled = true;
            this.cmbSexoP.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexoP.Location = new System.Drawing.Point(276, 440);
            this.cmbSexoP.Name = "cmbSexoP";
            this.cmbSexoP.Size = new System.Drawing.Size(258, 29);
            this.cmbSexoP.TabIndex = 9;
            // 
            // rtbDireccionP
            // 
            this.rtbDireccionP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDireccionP.Location = new System.Drawing.Point(276, 484);
            this.rtbDireccionP.MaxLength = 100;
            this.rtbDireccionP.Name = "rtbDireccionP";
            this.rtbDireccionP.Size = new System.Drawing.Size(258, 48);
            this.rtbDireccionP.TabIndex = 10;
            this.rtbDireccionP.Text = "";
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarP.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarP.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarP.Location = new System.Drawing.Point(576, 600);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(160, 38);
            this.btnGuardarP.TabIndex = 12;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.UseVisualStyleBackColor = false;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // dgvDatosP
            // 
            this.dgvDatosP.AllowUserToAddRows = false;
            this.dgvDatosP.AllowUserToDeleteRows = false;
            this.dgvDatosP.AllowUserToOrderColumns = true;
            this.dgvDatosP.AllowUserToResizeRows = false;
            this.dgvDatosP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosP.Location = new System.Drawing.Point(576, 152);
            this.dgvDatosP.MultiSelect = false;
            this.dgvDatosP.Name = "dgvDatosP";
            this.dgvDatosP.ReadOnly = true;
            this.dgvDatosP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosP.Size = new System.Drawing.Size(719, 417);
            this.dgvDatosP.TabIndex = 15;
            this.dgvDatosP.SelectionChanged += new System.EventHandler(this.dgvDatosP_SelectionChanged);
            this.dgvDatosP.DoubleClick += new System.EventHandler(this.dgvDatosP_DoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(1085, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 22);
            this.label12.TabIndex = 35;
            this.label12.Text = "Registro de profesores";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnEditarP
            // 
            this.btnEditarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarP.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarP.ForeColor = System.Drawing.Color.Black;
            this.btnEditarP.Location = new System.Drawing.Point(851, 600);
            this.btnEditarP.Name = "btnEditarP";
            this.btnEditarP.Size = new System.Drawing.Size(160, 38);
            this.btnEditarP.TabIndex = 13;
            this.btnEditarP.Text = "Editar";
            this.btnEditarP.UseVisualStyleBackColor = false;
            this.btnEditarP.Click += new System.EventHandler(this.btnEditarP_Click);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarP.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarP.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarP.Location = new System.Drawing.Point(1135, 600);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(160, 38);
            this.btnEliminarP.TabIndex = 14;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = false;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mtxtTelefonoP
            // 
            this.mtxtTelefonoP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefonoP.Location = new System.Drawing.Point(276, 238);
            this.mtxtTelefonoP.Mask = "0000-0000";
            this.mtxtTelefonoP.Name = "mtxtTelefonoP";
            this.mtxtTelefonoP.Size = new System.Drawing.Size(258, 27);
            this.mtxtTelefonoP.TabIndex = 4;
            // 
            // mtxtDUIP
            // 
            this.mtxtDUIP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDUIP.Location = new System.Drawing.Point(276, 321);
            this.mtxtDUIP.Mask = "00000000-0";
            this.mtxtDUIP.Name = "mtxtDUIP";
            this.mtxtDUIP.Size = new System.Drawing.Size(258, 27);
            this.mtxtDUIP.TabIndex = 6;
            // 
            // mtxtNITP
            // 
            this.mtxtNITP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNITP.Location = new System.Drawing.Point(276, 359);
            this.mtxtNITP.Mask = "0000-000000-000-0";
            this.mtxtNITP.Name = "mtxtNITP";
            this.mtxtNITP.Size = new System.Drawing.Size(258, 27);
            this.mtxtNITP.TabIndex = 7;
            // 
            // mtxtNumEscalafonP
            // 
            this.mtxtNumEscalafonP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNumEscalafonP.Location = new System.Drawing.Point(276, 399);
            this.mtxtNumEscalafonP.Mask = "0000000";
            this.mtxtNumEscalafonP.Name = "mtxtNumEscalafonP";
            this.mtxtNumEscalafonP.Size = new System.Drawing.Size(258, 27);
            this.mtxtNumEscalafonP.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(48, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Foto:";
            // 
            // txtFoto
            // 
            this.txtFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtFoto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoto.ForeColor = System.Drawing.Color.Black;
            this.txtFoto.Location = new System.Drawing.Point(276, 547);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(258, 22);
            this.txtFoto.TabIndex = 11;
            this.txtFoto.Text = "Seleccionar foto...";
            this.txtFoto.UseVisualStyleBackColor = false;
            this.txtFoto.Click += new System.EventHandler(this.txtFoto_Click);
            // 
            // pbFotoProfesor
            // 
            this.pbFotoProfesor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFotoProfesor.Location = new System.Drawing.Point(276, 575);
            this.pbFotoProfesor.Name = "pbFotoProfesor";
            this.pbFotoProfesor.Size = new System.Drawing.Size(77, 79);
            this.pbFotoProfesor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoProfesor.TabIndex = 40;
            this.pbFotoProfesor.TabStop = false;
            // 
            // lblIdProfesor
            // 
            this.lblIdProfesor.AutoSize = true;
            this.lblIdProfesor.Location = new System.Drawing.Point(1024, 116);
            this.lblIdProfesor.Name = "lblIdProfesor";
            this.lblIdProfesor.Size = new System.Drawing.Size(55, 13);
            this.lblIdProfesor.TabIndex = 41;
            this.lblIdProfesor.Text = "IdProfesor";
            this.lblIdProfesor.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(678, 107);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(333, 27);
            this.txtBuscar.TabIndex = 43;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(572, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 24);
            this.label13.TabIndex = 42;
            this.label13.Text = "Buscar: ";
            // 
            // lblRutaFoto
            // 
            this.lblRutaFoto.AutoSize = true;
            this.lblRutaFoto.Location = new System.Drawing.Point(373, 616);
            this.lblRutaFoto.Name = "lblRutaFoto";
            this.lblRutaFoto.Size = new System.Drawing.Size(46, 13);
            this.lblRutaFoto.TabIndex = 44;
            this.lblRutaFoto.Text = "rutaFoto";
            this.lblRutaFoto.Visible = false;
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1321, 666);
            this.Controls.Add(this.lblRutaFoto);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblIdProfesor);
            this.Controls.Add(this.pbFotoProfesor);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtNumEscalafonP);
            this.Controls.Add(this.mtxtNITP);
            this.Controls.Add(this.mtxtDUIP);
            this.Controls.Add(this.mtxtTelefonoP);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.btnEditarP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvDatosP);
            this.Controls.Add(this.btnGuardarP);
            this.Controls.Add(this.rtbDireccionP);
            this.Controls.Add(this.cmbSexoP);
            this.Controls.Add(this.dtpFechaP);
            this.Controls.Add(this.txtEmailP);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProfesor";
            this.Load += new System.EventHandler(this.FrmProfesor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtEmailP;
        private System.Windows.Forms.DateTimePicker dtpFechaP;
        private System.Windows.Forms.ComboBox cmbSexoP;
        private System.Windows.Forms.RichTextBox rtbDireccionP;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.DataGridView dgvDatosP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEditarP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox mtxtNITP;
        private System.Windows.Forms.MaskedTextBox mtxtDUIP;
        private System.Windows.Forms.MaskedTextBox mtxtTelefonoP;
        private System.Windows.Forms.MaskedTextBox mtxtNumEscalafonP;
        private System.Windows.Forms.PictureBox picBMinimizar;
        private System.Windows.Forms.Button txtFoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileFoto;
        private System.Windows.Forms.PictureBox pbFotoProfesor;
        private System.Windows.Forms.Label lblIdProfesor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRutaFoto;
    }
}