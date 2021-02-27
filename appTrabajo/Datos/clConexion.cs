using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace appTrabajo.Datos
{
    class clConexion
    {
        MySqlConnection objConexion = null;
        public clConexion()
        {
            try
            {
                objConexion = new MySqlConnection("server=localhost; user id=root;Port=3306;database=dbEmpresa;Password=3134281540");
            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message);
            }

        }
        public DataTable mtdDesconectado(string consulta)
        {

            objConexion.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, objConexion);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            objConexion.Close();
            return tblDatos;

        }

        internal DataTable mtdDesconectado()
        {
            throw new NotImplementedException();
        }

        internal void mtdConectado()
        {
            throw new NotImplementedException();
        }

        public int mtdConectado(string consulta)
        {
            objConexion.Open();

            MySqlCommand comando = new MySqlCommand(consulta, objConexion);

            int rows = comando.ExecuteNonQuery();
            objConexion.Close();
            return rows;

        }
    }
}
