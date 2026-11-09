using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencia
    {
        private int idasistencia;
        private String hentrada;
        private String hsalida;
        private String fecha;
        private String descripcion;
        private int idempleado;

        public int idasistencia_a
        {
            get { return idasistencia; }
            set { idasistencia = value; }
        }

        public String hentrada_a
        {
            get { return hentrada; }
            set { hentrada = value; }
        }

        public String hsalida_a
        {
            get { return hsalida; }
            set { hsalida = value; }
        }

        public String fecha_a
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public String descripcion_a
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int idempleado_a
        {
            get { return idempleado; }
            set { idempleado = value; }
        }

        public Asistencia() 
        { }

        public Asistencia(int idasistencia_a, String hentrada_a, String hsalida_a, String fecha_a, String descripcion_a, int idempleado_a)
        {
            this.idasistencia_a = idasistencia_a;
            this.hentrada_a = hentrada_a;
            this.hsalida_a = hsalida_a;
            this.fecha_a = fecha_a;
            this.descripcion_a = descripcion_a;
            this.idempleado_a = idempleado_a;
        }
    }
}
