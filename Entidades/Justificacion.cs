using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Justificacion
    {
        private int idjustificacion;
        private String fecha;
        private String justificacion;
        private String estado;
        private int idempleado;

        public int idjustificacion_j
        {
            get { return idjustificacion; }
            set { idjustificacion = value; }
        }

        public String fecha_j
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public String justificacion_j
        {
            get { return justificacion; }
            set { justificacion = value; }
        }

        public String estado_j
        {
            get { return estado; }
            set { estado = value; }
        }

        public int idempleado_j
        {
            get { return idempleado; }
            set { idempleado = value; }
        }

        public Justificacion() 
        { }

        public Justificacion(int idjustificacion_j, String fecha_j, String justificacion_j, String estado_j, int idempleado_j)
        {
            this.idjustificacion_j = idjustificacion_j;
            this.fecha_j = fecha_j;
            this.justificacion_j = justificacion_j;
            this.estado_j = estado_j;
            this.idempleado_j = idempleado_j;
        }
    }
}
