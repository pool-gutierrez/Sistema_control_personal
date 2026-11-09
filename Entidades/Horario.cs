using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Horario
    {
        private int idhorario;
        private String inicio;
        private String fin;
        private String iniciodescan;
        private String findescan;
        private String descripcion;
        private int idturno;

        public int idhorario_h
        {
            get { return idhorario; }
            set { idhorario = value; }
        }

        public String inicio_h
        {
            get { return inicio; }
            set { inicio = value; }
        }

        public String fin_h
        {
            get { return fin; }
            set { fin = value; }
        }

        public String iniciodescan_h
        {
            get { return iniciodescan;}
            set { iniciodescan = value; }
        }

        public String findescan_h
        {
            get { return findescan; }
            set { findescan = value; }
        }

        public String descripcion_h
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int idturno_h
        {
            get { return idturno; }
            set { idturno = value; }
        }

        public Horario()
        { }

        public Horario(int idhorario_h, String inicio_h, String fin_h, String iniciodescan_h, String findescan_h, String descripcion_h, int idturno_h)
        {
            this.idhorario_h = idhorario_h;
            this.inicio_h = inicio_h;
            this.fin_h = fin_h;
            this.iniciodescan_h = iniciodescan_h;
            this.findescan_h = findescan_h;
            this.descripcion_h = descripcion_h;
            this.idturno_h = idturno_h;
        }
    }
}
