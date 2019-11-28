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

namespace Vista
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            Acceso();
        }

        public void Acceso()
        {
            if (Program.Cargo == "Administrador")
            {
                btn_comp.Visible = true;
                btn_emp.Visible = true;
                btn_pro.Visible = true;
                btn_ven.Visible = true;
                btn_rep.Visible = true;
            }
            else
            {
                btn_comp.Visible = true;
                btn_emp.Visible = false;
                btn_pro.Visible = true;
                btn_ven.Visible = true;
                btn_rep.Visible = false;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


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


        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            lblUsuario.Text = Program.NombreEmpleadoLogueado;
            lblCargo.Text = Program.Cargo;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void btn_rv_Click(object sender, EventArgs e)
        {
            GenerarReporteV GR = new GenerarReporteV();
            GR.ShowDialog();
        }

        private void btn_Inv_Click(object sender, EventArgs e)
        {
            ReporteInvenario RI = new ReporteInvenario();
            RI.ShowDialog();
            
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
