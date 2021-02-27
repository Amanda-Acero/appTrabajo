using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appTrabajo.Datos;
using appTrabajo.Propiedades;

namespace appTrabajo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clPrincipal objPrincipal = new clPrincipal();
            List<clPrincipal> listaPrincipal = new List<clPrincipal>();
            listaPrincipal=objPrincipal.mtdPrincipal();
            int contador = 0;
            for (int i = 0; i < listaPrincipal.Count; i++)
            {
                if (listaPrincipal[i].email==txtUsuario.Text && listaPrincipal[i].clave==txtContraseña.Text)
                {
                    contador = 1;
                }
            }
            if (contador==1)
            {
                frmEjercicio objfrmEjercicio = new frmEjercicio();
                objfrmEjercicio.Show();
               
                
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña fallidos");
            }
            
        }


    }
}
