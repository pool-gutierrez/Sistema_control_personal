using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HorarioDetalle
    {
        private int idhorario;
        private int iddiaslab;
        public int idhorario_dh
        {
            get { return idhorario; }
            set { idhorario = value; }
        }
        public int iddiaslab_dh
        {
            get { return iddiaslab; }
            set { iddiaslab = value; }
        }
        public HorarioDetalle()
        {
        }

        public HorarioDetalle(int idhorario_dh, int iddiaslab_dh)
        {
            this.idhorario_dh = idhorario_dh;
            this.iddiaslab_dh = iddiaslab_dh;
        }
    }
}
