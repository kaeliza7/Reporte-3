﻿using System;
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
    public partial class ReporteInvenario : Form
    {
        public ReporteInvenario()
        {
            InitializeComponent();
        }

        private void ReporteInvenario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.Inventario_Reporte' Puede moverla o quitarla según sea necesario.
            this.Inventario_ReporteTableAdapter.Fill(this.DataSetPrincipal.Inventario_Reporte);

            this.reportViewer1.RefreshReport();
        }

    }
}
