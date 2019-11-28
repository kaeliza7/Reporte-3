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
    public partial class FrmRegistrarEmpleados : Form
    {
        clsCargo C = new clsCargo();
        clsEmpleado E = new clsEmpleado();
        int Listado = 0;
        public FrmRegistrarEmpleados()
        {
            InitializeComponent();
        }

        private void FrmRegistrarEmpleados_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            comboBox1.DataSource = C.Listar();
            comboBox1.DisplayMember = "Descripcion";
            comboBox1.ValueMember = "IdCargo";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            FrmListadoEmpleados LE = new FrmListadoEmpleados();
            if (ValidarCampos())
            {
                E.IdEmpleado = Convert.ToInt32(txtIdE.Text);
                E.IdCargo = Convert.ToInt32(comboBox1.SelectedValue);
                E.Dni = txtDni.Text;
                E.Apellidos = txtApellidos.Text;
                E.Nombres = txtNombres.Text;
                E.Sexo = rbnMasculino.Checked == true ? 'M' : 'F';
                E.FechaNac = Convert.ToDateTime(dateTimePicker1.Value);
                E.Direccion = txtDireccion.Text;
                MessageBox.Show(E.MantenimientoEmpleados(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Limpiar();
                LE.Visible = true;
                Visible = false;
            }
                
            
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtDni.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDni, "Ingresar nombre del producto");
            }
            if (txtApellidos.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApellidos, "Ingresar precio");
            }
            if (txtDireccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, "Ingresar cantidad de stock");
            }
            if (txtNombres.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombres, "Ingresar cantidad de stock");
            }
           
            return ok;
        }
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtNombres, "");
            errorProvider1.SetError(txtApellidos, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(txtDni, "");
        }
        private void Limpiar()
        {
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtDni.Clear();
            txtNombres.Clear();
            rbnMasculino.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            txtIdE.Clear();
            Program.IdCargo = 0;
            comboBox1.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (Listado)
            {
                case 0: CargarComboBox(); break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void FrmRegistrarEmpleados_Activated(object sender, EventArgs e)
        {
            if (Program.IdCargo != 0) comboBox1.SelectedValue = Program.IdCargo;

            lblUsuario.Text = Program.NombreEmpleadoLogueado;
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
    }
}
