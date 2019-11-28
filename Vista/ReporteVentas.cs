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
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();
        }

        public DateTime Fecha { get; set; }
        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.Ventas_Reporte' Puede moverla o quitarla según sea necesario.
            this.Ventas_ReporteTableAdapter.Fill(this.DataSetPrincipal.Ventas_Reporte,Fecha);

            this.reportViewer1.RefreshReport();
        }
    }
}
