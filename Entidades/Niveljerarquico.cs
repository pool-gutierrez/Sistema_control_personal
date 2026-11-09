using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Niveljerarquico
    {
        private int idnivel;
        private String nombre;
        private String descripcion;
        private int idcargo;

        public int idnivel_n
        {
            get { return idnivel; }
            set { idnivel = value; }
        }

        public String nombre_n
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String descripcion_n
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int idcargo_n
        {
            get { return idcargo; }
            set { idcargo = value; }
        }

        public Niveljerarquico() 
        { }

        public Niveljerarquico(int idnivel_n, String nombre_n, String descripcion_n, int idcargo_n)
        {
            this.idnivel_n = idnivel_n;
            this.nombre_n = nombre_n;
            this.descripcion_n = descripcion_n;
            this.idcargo_n = idcargo_n;
        }
    }
}
