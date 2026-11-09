using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Diaslaborales
    {
        private int iddiaslabor;
        private String dia;

        public int iddiaslabor_d
        {
            get { return iddiaslabor; }
            set { iddiaslabor = value; }
        }

        public String dia_d
        {
            get { return dia; }
            set { dia = value; }
        }

        public Diaslaborales() 
        { }

        public Diaslaborales(int iddiaslabor_d, String dia_d)
        {
            this.iddiaslabor_d = iddiaslabor_d;
            this.dia_d = dia_d;
        }
    }
}
