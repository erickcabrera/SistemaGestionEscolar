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

namespace SistemaEscolar.Formularios
{
    public partial class FrmBienvenida : Form
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

        public FrmBienvenida()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        int contador = 0;
        private void Bienvenida_Load(object sender, EventArgs e)
        {
            timer.Start();
            proBar.Minimum = 0;
            proBar.Maximum = 100;
            proBar.Step = 2;
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
           
            
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {                       
            proBar.PerformStep();
            proBar.Value = contador;           
            if (proBar.Value == 100)
            {
                timer.Stop();
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
            contador++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
