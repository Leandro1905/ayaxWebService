using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEMO
{
    public class Programador
    {
        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public Programador()
        {

        }

        public Programador(int dni, string nombre, string sexo)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.sexo = sexo;
        }
    }
}