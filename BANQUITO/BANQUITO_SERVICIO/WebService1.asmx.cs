using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data.SqlClient;
using System.Data;

namespace BANQUITO_SERVICIO
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string SoyLindo(string nombre)
        {
            string valor = "";

            if(nombre=="MIGUEL")
            {
                valor = "USTED ES MUY LINDO";
            }else
            {
                valor = "USTED ES MUY FEO";
            }
            return valor;
        }

        [WebMethod]
        public decimal ValorDelVerde(string fecha)
        {
            decimal valor;

            try
            {
                string sql = $"SELECT cotizacion FROM Dolar WHERE fecha='{fecha}'";
                string cadena = "Data Source=.;Initial Catalog=Banquito;Integrated Security=True";

                SqlDataAdapter adaptador = new SqlDataAdapter(sql, cadena);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                valor = Convert.ToDecimal(tabla.Rows[0]["cotizacion"]);

            }
            catch (Exception ex)
            {
                valor = 0;
            }
          

            return valor;
        }

        [WebMethod]
        public string PasoFecha(string fecha)
        {
            return fecha;
        }
    }
}
