using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;

namespace DEMO
{
    public class ProgramadorDatos
    {
        SqlConnection conector;
        SqlCommand comando;
        string sql;

        public ProgramadorDatos()
        {
            conector = new SqlConnection("Data Source=.;Initial Catalog=Demo;Integrated Security=True");
            comando = new SqlCommand();
            sql = "";
        }
        public Programador Buscar(int dni)
        {
            conector.Open();
            
            sql = @" 
                SELECT dni, nombre,
                CASE sexo WHEN 'F' THEN 'FEMENINO' ELSE 'MASCULINO' END AS sexo
                FROM Programadores
                WHERE dni=@dni       
            ";

            Programador p = new Programador();

            comando.Connection = conector;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@dni", dni);

            SqlDataReader dr = comando.ExecuteReader();
            if(dr.HasRows==true)
            {
                dr.Read();
                p.Dni = (int) dr["dni"];
                p.Nombre = dr["nombre"].ToString();
                p.Sexo = dr["sexo"].ToString();
            }
            else
            {
                p.Dni = 0;
                p.Nombre = "";
                p.Sexo = "";
            }

            dr.Close();
            conector.Close();

            return p;
        }
    }
}