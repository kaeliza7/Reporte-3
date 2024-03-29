﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
    public class clsDetalleVenta
    {
        clsManejador M = new clsManejador();
        public Int32 IdProducto { get; set; }
        public Int32 IdVenta { get; set; }
        public Int32 Cantidad { get; set; }
        public Decimal SubTotal { get; set; }

        public String RegistrarDetalleVenta()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdProducto", IdProducto));
                lst.Add(new clsParametro("@IdVenta", IdVenta));
                lst.Add(new clsParametro("@Cantidad", Cantidad));
                lst.Add(new clsParametro("@SubTotal", SubTotal));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                M.EjecutarSP("RegistrarDetalleVenta", ref lst);
                Mensaje = lst[4].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }
}
