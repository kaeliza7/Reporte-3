using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
    public class clsVentas
    {
        clsManejador M = new clsManejador();

        public int IdEmpleado { get; set; }

        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }


        public String GenerarIdVenta()
        {
            List<clsParametro> lst = new List<clsParametro>();
            int objIdVenta;
            try
            {
                lst.Add(new clsParametro("@IdVenta", "", SqlDbType.Int, ParameterDirection.Output, 4));
                M.EjecutarSP("GenerarIdVenta", ref lst);
                objIdVenta = Convert.ToInt32(lst[0].Valor.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToString(objIdVenta);
        }

        public String RegistrarVenta()
        {
            String Mensaje = "";
            List<clsParametro> lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@IdEmpleado", IdEmpleado));
                lst.Add(new clsParametro("@FechaVenta", FechaVenta));
                lst.Add(new clsParametro("@Total", Total));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                M.EjecutarSP("RegistrarVenta", ref lst);
                return Mensaje = lst[3].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
