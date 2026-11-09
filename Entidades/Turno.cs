using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {
        private int idturno;
        private String tipo;
        private String horaentrada;
        private String horasalida;

        public int idturno_t
        {
            get { return idturno; }
            set { idturno = value; }
        }

        public String tipo_t
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public String horaentrada_t
        {
            get { return horaentrada; }
            set { horaentrada = value; }
        }

        public String horasalida_t
        {
            get { return horasalida; }
            set { horasalida = value; }
        }

        public Turno() 
        { }

        public Turno(int idturno_t, String tipo_t, String horaentrada_t, String horasalida_t)
        {
            this.idturno_t = idturno_t;
            this.tipo_t = tipo_t;
            this.horaentrada_t = horaentrada_t;
            this.horasalida_t = horaentrada_t;
        }
    }
}
