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
using Controlador;

namespace Vista
{
    public partial class FrmRegistrarUsuarios : Form
    {
        clsUsuario U = new clsUsuario();
        public FrmRegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCampos())
            {
                if (Program.IdEmpleado != 0)
                {
                    U.IdEmpleado = Program.IdEmpleado;
                    U.User = txtUser.Text;
                    U.Password = txtPassword.Text;
                    MessageBox.Show(U.RegistrarUsuarios(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Lo Sentimos, Pero Usted debe Eligir un \n Empleado para Crear una Cuenta de Usuario.\n \n G R A C I A S.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                FrmListadoEmpleados LE = new FrmListadoEmpleados();
                LE.Visible = true;
                Visible = false;
            }
        }
        private void Limpiar()
        {
            txtPassword.Clear();
            txtUser.Clear();
            Program.IdEmpleado = 0;
            txtUser.Focus();
            lblCargo.Text = "";
            lblDni.Text = "";
            lblEmpleado.Text = "";
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtUser.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUser, "Ingresar usuario");
            }
            if (txtPassword.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPassword, "Ingresar contraseña");
            }
            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtUser, "");
            errorProvider1.SetError(txtPassword, "");
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            BorrarMensajeError();
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtUser, "Solo acepta letras");
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmRegistrarUsuarios_Activated(object sender, EventArgs e)
        {
            lblUsuario.Text = Program.NombreEmpleadoLogueado;
        }

        private void btn_ven_Click(object sender, EventArgs e)
        {
            FrmRegistrarVentas RV = new FrmRegistrarVentas();
            RV.Visible = true;
            Visible = false;
        }

        private void btn_comp_Click(object sender, EventArgs e)
        {
            FrmRegistrarProductos RP = new FrmRegistrarProductos();
            RP.Visible = true;
            Visible = false;
        }

        private void btn_pro_Click(object sender, EventArgs e)
        {
            FrmListadoProductos LP = new FrmListadoProductos();
            LP.Visible = true;
            Visible = false;
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            FrmListadoEmpleados LE = new FrmListadoEmpleados();
            LE.Visible = true;
            Visible = false;
        }

        private void btn_rep_Click(object sender, EventArgs e)
        {
            pnl_rep.Visible = true;
        }

        private void btn_rv_Click(object sender, EventArgs e)
        {

        }

        private void btn_re_Click(object sender, EventArgs e)
        {

        }

        private void bnt_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_max.Visible = true;
            btn_res.Visible = false;
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max.Visible = false;
            btn_res.Visible = true;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
