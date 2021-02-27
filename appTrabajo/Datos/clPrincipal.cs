using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appTrabajo.Datos
{
    class clPrincipal
    {
        public string email { get; set; }
        public string clave { get; set; }
        public List<clPrincipal> mtdPrincipal()
        {
            string cosulta = "select email, clave from empleado";
            DataTable resultado = new DataTable();
            clConexion objConexion = new clConexion();
            resultado = objConexion.mtdDesconectado(cosulta);
            List<clPrincipal> listPrincipal = new List<clPrincipal>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clPrincipal objPrincipal = new clPrincipal();
                objPrincipal.email = resultado.Rows[i][0].ToString();
                objPrincipal.clave = resultado.Rows[i][1].ToString();
                listPrincipal.Add(objPrincipal);
            }
            return listPrincipal;
        }
    }
}
