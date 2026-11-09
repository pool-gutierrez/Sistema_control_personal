using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Departamento
    {
        private int iddepartam;
        private String nombredep;
        private String descripciondep;
        private int numtrabajadores;

        public int iddepartam_d
        {
            get { return iddepartam;}
            set { iddepartam = value; }
        }

        public String nombredep_d
        {
            get { return nombredep; }
            set { nombredep = value; }
        }

        public String descripciondep_d
        {
            get { return descripciondep; }
            set { descripciondep = value; }
        }

        public int numtrabajadores_d
        {
            get { return numtrabajadores; }
            set { numtrabajadores = value; }
        }

        public Departamento() 
        { }

        public Departamento(int iddepartam_d, String nombredep_d, String descripciondep_d, int numtrabajadores_d)
        {
            this.iddepartam_d = iddepartam_d;
            this.nombredep_d = nombredep_d;
            this.descripciondep_d = descripciondep_d;
            this.numtrabajadores_d = numtrabajadores_d;
        }
    }
}
