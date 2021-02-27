using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTrabajo.Propiedades
{
    public partial class frmEjercicio : Form
    {
        public frmEjercicio()
        {
            InitializeComponent();
        }

        private void frmEjercicio_Load(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            frmArea objfrmArea = new frmArea();
            objfrmArea.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleado objfrmjEmpleado = new frmEmpleado();
            objfrmjEmpleado.Show();
        }
    }
}
