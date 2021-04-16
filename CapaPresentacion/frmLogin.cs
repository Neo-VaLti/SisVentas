using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblhora.Text = DateTime.Now.ToString();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable Datos = CapaNegocio.NTrabajador.Login(this.TxtUsuario.Text, this.txtPass.Text);
            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No tiene acceso al sistema ","Sistema de ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                frmPrincipa1 frm = new frmPrincipa1();
                frm.Idtrabajador = Datos.Rows[0][0].ToString();
                frm.Apellidos = Datos.Rows[0][1].ToString();
                frm.Nombre = Datos.Rows[0][2].ToString();
                frm.Acceso = Datos.Rows[0][3].ToString();

                frm.Show();
                this.Hide();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
