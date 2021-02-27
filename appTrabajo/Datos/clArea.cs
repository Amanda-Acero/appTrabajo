using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appTrabajo.Datos
{
    class clArea
    {
        //atributos -- Propiedades
        public int idarea { get; set; }
        public string area { get; set; }
        public double sueldo { get; set; }
        public string descripcion { get; set; }

        //metodos 
        public DataTable mtdListar()
        {
            string consulta = "select * from area";
            clConexion objConexion = new clConexion();
            DataTable tblAreas = new DataTable();
            tblAreas=objConexion.mtdDesconectado(consulta);
            return tblAreas;
        }
        public void mtdRegistrar()
        {

        }
        public int mtdActualizar()
        {
            string consulta = "update area set area = '" + area + "', sueldo=" + sueldo + ", descripcion= '" + descripcion + "' where idarea ="+idarea+"";
            clConexion objConexion = new clConexion();
            int fila = objConexion.mtdConectado(consulta);
            return fila;

        }
        public void mtdEliminar()
        {

        }


    }
}
