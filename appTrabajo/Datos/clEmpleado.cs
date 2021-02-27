using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appTrabajo.Datos
{
    class clEmpleado
    {
        // atributos -- Propiedades
        public int idempleado { get; set; }
        public string documento { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string celular { get; set; }
        public string clave { get; set; }
        public int idtipoEmpleado { get; set; }
        public int idarea { get; set; }

        //metodos

        public DataTable mtdListar()
        {
            string consulta = "select * from empleado";
            clConexion objConexion = new clConexion();
            DataTable tblEmpleados = new DataTable();
            tblEmpleados = objConexion.mtdDesconectado(consulta);
            return tblEmpleados;

        }
        
        public void mtdRegistrar()
        {

        }
        public void mtdActualizar()
        {

        }


    }
}
