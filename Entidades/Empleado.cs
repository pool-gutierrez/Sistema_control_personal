using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        private int idempleado;
        private String appat;
        private String apmat;
        private String nombres;
        private String dni;
        private String sexo;
        private String telfijo;
        private String celular;
        private String direccion;
        private String ciudad;
        private String distrito;
        private String estado;
        private int idturno;
        private int idhorario;
        private int iddepartamento;
        private int idcargo;

        public int id_empleado
        {
            get { return idempleado; }
            set { idempleado = value; }
        }

        public String ape_pat_emp
        {
            get { return appat; }
            set { appat = value; }
        }

        public String ape_mat_emp
        {
            get { return apmat; }
            set { apmat = value; }
        }

        public String nombres_emp
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public String dni_emp
        {
            get { return dni; }
            set { dni = value; }
        }

        public String sexo_emp
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public String telfijo_emp
        {
            get { return telfijo; }
            set { telfijo = value; }
        }

        public String celular_emp
        {
            get { return celular; }
            set { celular = value; }
        }

        public String dir_emp
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public String ciudad_emp
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public String distrito_emp
        {
            get { return distrito; }
            set { distrito = value; }
        }

        public String estado_emp
        {
            get { return estado; }
            set { estado = value; }
        }

        public int id_turno
        {
            get { return idturno; }
            set { idturno = value; }
        }

        public int id_horario
        {
            get { return idhorario; }
            set { idhorario = value; }
        }

        public int id_departamento
        {
            get { return iddepartamento; }
            set { iddepartamento = value; }
        }

        public int id_cargo
        {
            get { return idcargo; }
            set { idcargo = value; }
        }

        public Empleado()
        {
        }

        public Empleado(int id_empleado, String ape_pat_emp, String ape_mat_emp, String nombres_emp, String dni_emp, String sexo_emp, 
            String telfijo_emp, String celular_emp, String dir_emp, String ciudad_emp, String distrito_emp, String estado_emp, 
            int id_turno, int id_horario, int id_departamento, int id_cargo)
        {
            this.id_empleado = id_empleado;
            this.ape_pat_emp = ape_pat_emp;
            this.ape_mat_emp = ape_mat_emp;
            this.nombres_emp = nombres_emp;
            this.dni_emp = dni_emp;
            this.sexo_emp = sexo_emp;
            this.telfijo_emp = telfijo_emp;
            this.celular_emp = celular_emp;
            this.dir_emp = dir_emp;
            this.ciudad_emp = ciudad_emp;
            this.distrito_emp = distrito_emp;
            this.estado_emp = estado_emp;
            this.id_turno = id_turno;
            this.id_horario = id_horario;
            this.id_departamento = id_departamento;
            this.id_cargo = id_cargo;
        }
    }
}
