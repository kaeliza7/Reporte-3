using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class GenerarReporteV : Form
    {
        public GenerarReporteV()
        {
            InitializeComponent();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            ReporteVentas Mostrar = new ReporteVentas();
            Mostrar.Fecha = dtp_fecha.Value;
            Mostrar.Show();
            Visible = false;


        }

        private void GenerarReporteV_Load(object sender, EventArgs e)
        {

        }
    }
}
