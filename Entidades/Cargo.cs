using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cargo
    {
        private int idcargo;
        private String nombrecar;
        private String descripcioncar;
        private int iddep;

        public int idcargo_c
        {
            get { return idcargo; }
            set { idcargo = value; }
        }

        public String nombrecar_c
        {
            get { return nombrecar; }
            set { nombrecar = value; }
        }

        public String descripcioncar_c
        {
            get { return descripcioncar; }
            set { descripcioncar = value; }
        }

        public int iddep_c
        {
            get { return iddep; }
            set { iddep = value; }
        }

        public Cargo() 
        { }

        public Cargo(int idcargo_c, String nombrecar_c, String descripcioncar_c, int iddep_c)
        {
            this.idcargo_c = idcargo_c;
            this.nombrecar_c = nombrecar_c;
            this.descripcioncar_c = descripcioncar_c;
            this.iddep_c = iddep_c;
        }
    }
}
