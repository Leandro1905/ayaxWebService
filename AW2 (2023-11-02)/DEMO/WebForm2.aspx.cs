using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEMO
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            ProgramadorDatos pd = new ProgramadorDatos();
            Programador p = pd.Buscar(Convert.ToInt32(TxtDni.Text));
            
            if(p.Dni==0)
            {
                LblMensaje.Text = "EL DNI INGRESADO NO EXISTE";
            }
            else
            {
                LblNombre.Text = p.Nombre;
                LblSexo.Text = p.Sexo;
                LblMensaje.Text = "";
            }
         

        }
    }
}