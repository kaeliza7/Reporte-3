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
using System.Text.RegularExpressions;

namespace Vista
{
    public partial class FrmRegistrarProductos : Form
    {
        private clsCategoria C = new clsCategoria();
        private clsProducto P = new clsProducto();
        public FrmRegistrarProductos()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProductos_Load(object sender, EventArgs e)
        {
            ListarElementos();
        }
        private void ListarElementos()
        {
            if (IdC.Text.Trim() != "")
            {
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DataSource = C.Listar();
                cbxCategoria.SelectedValue = IdC.Text;
            }
            else
            {
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DataSource = C.Listar();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String Mensaje = "";
            BorrarMensajeError();
            if (ValidarCampos())
            {
                if (Program.Evento == 0)
                {
                    P.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                    P.Producto = txtProducto.Text;
                    P.PrecioCompra = Convert.ToDecimal(txtPCompra.Text);
                    P.Stock = Convert.ToInt32(txtStock.Text);
                    Mensaje = P.RegistrarProductos();
                    if (Mensaje == "Este Producto ya ha sido Registrado.")
                    {
                        MessageBox.Show(Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
                else
                {
                    P.IdP = Convert.ToInt32(txtIdP.Text);
                    P.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                    P.Producto = txtProducto.Text;
                    P.PrecioCompra = Convert.ToDecimal(txtPCompra.Text);
                    P.Stock = Convert.ToInt32(txtStock.Text);
                    MessageBox.Show(P.ActualizarProductos(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar?", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Limpiar();
                FrmListadoProductos LP = new FrmListadoProductos();
                LP.timer1.Start();
                LP.Visible = true;
                Visible = false;
            }
        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtProducto.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtProducto, "Ingresar nombre del producto");
            }
            if (txtPCompra.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPCompra, "Ingresar precio");
            }
            if (txtStock.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtStock, "Ingresar cantidad de stock");
            }
            return ok;
        }
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtProducto, "");
            errorProvider1.SetError(txtPCompra, "");
            errorProvider1.SetError(txtStock, "");
        }
        private void Limpiar()
        {
            txtProducto.Text = "";
            txtPCompra.Clear();
            IdC.Clear();
            txtIdP.Clear();
            txtStock.Clear();
            txtProducto.Focus();
        }

        private void txtPCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            BorrarMensajeError();
            if (this.txtPCompra.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtPCompra, "Ingresar formato correcto Ej. 23.00");
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtPCompra, "Ingresar formato correcto Ej. 23.00");

                }
                else if (e.KeyChar == 32)
                {
                    e.Handled = false;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            BorrarMensajeError();
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtStock, "Solo acepta numeros");
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            BorrarMensajeError();
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtProducto, "Solo acepta numeros y letras");
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

        private void FrmRegistrarProductos_Activated(object sender, EventArgs e)
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
            FrmListadoProductos RP = new FrmListadoProductos();
            RP.Visible = true;
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
            this.WindowState = FormWindowState.Maximized;
            btn_max.Visible = false;
            btn_res.Visible = true;
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_max.Visible = true;
            btn_res.Visible = false;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria C = new FrmRegistrarCategoria();
            C.Visible = true;
            Visible = true;
        }
    }
}
