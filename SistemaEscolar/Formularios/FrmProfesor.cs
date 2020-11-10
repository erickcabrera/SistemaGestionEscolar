using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SistemaEscolar.Formularios;
using System.Text.RegularExpressions;
using SistemaEscolar.Clases;
using System.IO;

namespace SistemaEscolar.Formularios
{
    public partial class FrmProfesor : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
         );
        public FrmProfesor()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        
       
        private bool validarCampos()
        {
            //esta variable verifica si se está validando algo
            bool validado = true;

           //if para validar camppos vacíos en el formulario de Profesor
            
            if(txtApellidoP.Text==String.Empty)
            {
                validado = false;
                errorProvider1.SetError(txtApellidoP, "Ingresar los apellidos del docente");
            }
            if (txtNombreP.Text == String.Empty)
            {
                validado = false;
                errorProvider1.SetError(txtNombreP, "Ingresar los nombres del docente");
            }

            if (mtxtDUIP.MaskFull) { }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtDUIP, "Ingresar el número de DUI");
            }

            if (mtxtNITP.MaskFull) { }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtNITP, "Ingresar el número de NIT del docente");
            }

            if(txtNombreP.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtNombreP, "Ingresar el nombre del docente");
            }

            if (mtxtNumEscalafonP.MaskFull) { }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtNumEscalafonP, "Ingresar el número de escalafón");
            }

            if (mtxtTelefonoP.MaskFull) { }
            else
            {
                validado = false;
                errorProvider1.SetError(mtxtTelefonoP, "Ingresar el número de teléfono del docente");
            }

            if(txtEmailP.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtEmailP, "Ingresar el correo electrónico del docente");
            }

            if(rtbDireccionP.Text=="")
            {
                validado = false;
                errorProvider1.SetError(rtbDireccionP, "Proporcione una dirección de vivienda");
            }

            return validado;
        }


        //borrar los mensajes que provee el error provider
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtApellidoP, "");
            errorProvider1.SetError(mtxtDUIP, "");
            errorProvider1.SetError(mtxtNITP, "");
            errorProvider1.SetError(txtNombreP, "");
            errorProvider1.SetError(mtxtNumEscalafonP, "");
            errorProvider1.SetError(mtxtTelefonoP, "");
            errorProvider1.SetError(txtEmailP, "");
            errorProvider1.SetError(dtpFechaP, "");
            errorProvider1.SetError(rtbDireccionP, "");
            errorProvider1.SetError(dtpFechaP, "");
        }

        private bool ValidarFechaySexo()

        {
            DateTime FechaNacimiento = dtpFechaP.Value;
            bool validarF = true;


            if (FechaNacimiento > System.DateTime.Now.Date )
            {
                validarF = false;
                errorProvider1.SetError(dtpFechaP, "La fecha no puede ser mayor a la fecha de este día");

            }
            if (cmbSexoP.SelectedIndex == -1)
            {
                validarF = false;
                errorProvider1.SetError(cmbSexoP, "Este campo no puede estar vacío");
            }
            return validarF;
        }

        private bool validarCorreo(string correo)
        {
            string cadena = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, cadena))
            {
                if (Regex.Replace(correo, cadena, String.Empty).Length == 0)
                {
                    return true;
                   
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            //validaciones
            BorrarMensaje();
            if (validarCampos() && ValidarFechaySexo() && correo())
            {
                //creo un objeto de la clase persona y guardo a través de las propiedades 
                if (txtFoto.Text == "Seleccionar foto...")
                {
                    MessageBox.Show("Debe seleccionar una foto", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        Profesor profesor = new Profesor();

                        profesor.Nombres = txtNombreP.Text;
                        profesor.Apellidos = txtApellidoP.Text;
                        profesor.FechaNac = Convert.ToString(dtpFechaP.Value.ToString("yyyy-MM-dd"));
                        profesor.Telefono = mtxtTelefonoP.Text;
                        profesor.Correo = txtEmailP.Text;
                        profesor.Dui = mtxtDUIP.Text;
                        profesor.Nit = mtxtNITP.Text;
                        profesor.NumEscalafon = mtxtNumEscalafonP.Text;
                        profesor.Sexo = cmbSexoP.Text;
                        profesor.Direccion = rtbDireccionP.Text;

                        byte[] file = null;
                        Stream stream = openFileFoto.OpenFile();

                        using (MemoryStream ms = new MemoryStream())
                        {
                            stream.CopyTo(ms);
                            file = ms.ToArray();
                        }

                        profesor.Foto = file;

                        if (profesor.Agregar(profesor.Nombres, profesor.Apellidos, profesor.FechaNac, profesor.Sexo, profesor.Telefono, profesor.Direccion,  profesor.Foto, profesor.Dui, profesor.Nit, profesor.Correo, profesor.NumEscalafon) == true)
                        {
                            MessageBox.Show("El registro ha sido agregado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarDataGrid();
                            Limpiar();
                            btnEliminarP.Enabled = false;
                            btnGuardarP.Enabled = true;
                            btnEditarP.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el registro", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Error al registrar el profesor " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizarDataGrid()
        {
            Profesor profesor = new Profesor();
            dgvDatosP.DataSource = null;
            dgvDatosP.DataSource = profesor.Mostrar();
            dgvDatosP.ClearSelection();
        }


        private void Limpiar()
        {
            txtNombreP.Clear();
            txtApellidoP.Clear();
            dtpFechaP.Value = DateTime.Now;
            mtxtTelefonoP.Clear();
            txtEmailP.Text = String.Empty;
            mtxtDUIP.Clear();
            mtxtNITP.Clear();
            mtxtNumEscalafonP.Clear();
            cmbSexoP.SelectedIndex = -1;
            rtbDireccionP.Clear();
            pbFotoProfesor.Image = null;
            pbFotoProfesor.BackgroundImage = null;
            txtFoto.Text = "Seleccionar foto...";

            txtNombreP.Focus();
            lblIdProfesor.Text = "";
        }

        private void picBSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuAdmin f = new FrmMenuAdmin();
            f.Show();
        }

        private void picBMinimizar_Click(object sender, EventArgs e)
        {

        }

        private bool correo()
        {
            bool ok = true;
            BorrarMensaje();

            if (validarCorreo(txtEmailP.Text) || txtEmailP.Text == "")
            {

            }
            else
            {
                ok = false;
                errorProvider1.SetError(txtEmailP, "El formato del correo no es válido");
              
            }
            return ok;
        }
       

        private void txtEmailP_TextChanged(object sender, EventArgs e)
        {

           
           
            
        }

        private void txtNombreP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condición para validar sólo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtNombreP, "En este campo sólo se permiten letras");
            }
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condición para validar sólo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtApellidoP, "En este campo sólo se permiten letras");
            }
        }

        private void picBMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBMinimizar_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtFoto_Click(object sender, EventArgs e)
        {
            openFileFoto.InitialDirectory = "C:\\";
            openFileFoto.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            try
            {
                if (openFileFoto.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = openFileFoto.FileName;
                    txtFoto.Text = sourceFile;
                    
                    System.IO.FileStream fs = new System.IO.FileStream(sourceFile, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    pbFotoProfesor.Image = System.Drawing.Image.FromStream(fs);
                    fs.Close();
                    btnGuardarP.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            BorrarMensaje();
            dtpFechaP.Value.ToString("yyyy-MM-dd");
            Profesor profesor = new Profesor();
            try
            {
                ActualizarDataGrid();
                btnEditarP.Enabled = false;
                btnEliminarP.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al mostrar datos " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatosP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatosP.SelectedRows.Count > 0)
            {
                try
                {
                    Limpiar();
                    btnEditarP.Enabled = false;
                    btnEliminarP.Enabled = true;
                    btnGuardarP.Enabled = true;
                    lblIdProfesor.Text = dgvDatosP.CurrentRow.Cells["Num"].Value.ToString();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void dgvDatosP_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDatosP.SelectedRows.Count > 0)
            {
                lblIdProfesor.Text = dgvDatosP.CurrentRow.Cells["Num"].Value.ToString();
                txtNombreP.Text = dgvDatosP.CurrentRow.Cells["Nombres"].Value.ToString();
                txtApellidoP.Text = dgvDatosP.CurrentRow.Cells["Apellidos"].Value.ToString();
                dtpFechaP.Value = DateTime.Parse(dgvDatosP.CurrentRow.Cells["Fecha de nacimiento"].Value.ToString());
                mtxtTelefonoP.Text = dgvDatosP.CurrentRow.Cells["Teléfono"].Value.ToString();
                txtEmailP.Text = dgvDatosP.CurrentRow.Cells["Correo"].Value.ToString();
                mtxtDUIP.Text = dgvDatosP.CurrentRow.Cells["DUI"].Value.ToString();
                mtxtNITP.Text = dgvDatosP.CurrentRow.Cells["NIT"].Value.ToString();
                mtxtNumEscalafonP.Text = dgvDatosP.CurrentRow.Cells["Escalafon"].Value.ToString();
                cmbSexoP.Text = dgvDatosP.CurrentRow.Cells["Sexo"].Value.ToString();
                rtbDireccionP.Text = dgvDatosP.CurrentRow.Cells["Dirección"].Value.ToString();

                Profesor profesor = new Profesor();

                try
                {
                    string idProfesor = lblIdProfesor.Text;
                    profesor.ExtraerFoto(idProfesor, pbFotoProfesor);
                }
                catch (Exception ex)
                {   
                    Console.WriteLine("Error al cargar foto " + ex.Message);
                }
                
                btnEditarP.Enabled = true;
                btnEliminarP.Enabled = false;
                btnGuardarP.Enabled = false;
                txtNombreP.Focus();
                dgvDatosP.CurrentCell.Selected = false;
                dgvDatosP.ClearSelection();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor","¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            if (dgvDatosP.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro numero " + lblIdProfesor.Text + "?", "SALIR", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Profesor profesor = new Profesor();

                    if (profesor.Eliminar(int.Parse(lblIdProfesor.Text)) == true)
                    {
                        MessageBox.Show("El registro ha sido eliminado correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDataGrid();
                        Limpiar();
                        btnEliminarP.Enabled = false;
                        btnGuardarP.Enabled = true;
                        btnEditarP.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el alumno", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (resultado == DialogResult.No)
                {
                    btnEliminarP.Enabled = false;
                    dgvDatosP.ClearSelection();
                    Limpiar();
                    
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Profesor profesor = new Profesor();

                dgvDatosP.DataSource = null;
                dgvDatosP.DataSource = profesor.Buscar(txtBuscar.Text.Trim());
                dgvDatosP.ClearSelection();
                txtBuscar.Focus();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al buscar datos" + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {
            //validaciones
            BorrarMensaje();
            if (validarCampos() && ValidarFechaySexo() && correo())
            {
                try
                {
                    Profesor profesor = new Profesor();

                    profesor.Nombres = txtNombreP.Text;
                    profesor.Apellidos = txtApellidoP.Text;
                    profesor.FechaNac = Convert.ToString(dtpFechaP.Value.ToString("yyyy-MM-dd"));
                    profesor.Telefono = mtxtTelefonoP.Text;
                    profesor.Correo = txtEmailP.Text;
                    profesor.Dui = mtxtDUIP.Text;
                    profesor.Nit = mtxtNITP.Text;
                    profesor.NumEscalafon = mtxtNumEscalafonP.Text;
                    profesor.Sexo = cmbSexoP.Text;
                    profesor.Direccion = rtbDireccionP.Text;

                    if (txtFoto.Text != "Seleccionar foto...")
                    {
                        byte[] file = null;
                        Stream stream = openFileFoto.OpenFile();

                        using (MemoryStream ms = new MemoryStream())
                        {
                            stream.CopyTo(ms);
                            file = ms.ToArray();
                        }
                        profesor.Foto = file;
                    }
                    else
                    {
                        ImageConverter converter = new ImageConverter();

                        profesor.Foto = (byte[])converter.ConvertTo(pbFotoProfesor.Image, typeof(byte[]));
                    }
                    if (profesor.Modificar(int.Parse(lblIdProfesor.Text), profesor.Nombres, profesor.Apellidos, profesor.FechaNac, profesor.Sexo, profesor.Telefono, profesor.Direccion, profesor.Foto, profesor.Dui, profesor.Nit, profesor.Correo, profesor.NumEscalafon) == true)
                    {
                        MessageBox.Show("Los datos del profesor han sido modificados correctamente", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDataGrid();
                        Limpiar();
                        lblIdProfesor.Text = "";
                        lblRutaFoto.Text = "";
                        btnEditarP.Enabled = false;
                        btnGuardarP.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el registro", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error al modificar datos " + Ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEmailP_Leave(object sender, EventArgs e)
        {
            correo();
        }
    }
}
