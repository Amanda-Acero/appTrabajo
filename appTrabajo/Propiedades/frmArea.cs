using appTrabajo.Datos;
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
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            mtdCargar();
        }

        private void mtdCargar()
        {
            clArea objArea = new clArea();
            DataTable tblArea = new DataTable();
            tblArea = objArea.mtdListar();
            dgvArea.DataSource = tblArea;
            
        }

        private void dgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int idarea = 0;
        private void dgvArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idarea =int.Parse (dgvArea.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtArea.Text = dgvArea.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSueldo.Text = dgvArea.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescripcion.Text = dgvArea.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            clArea objArea = new clArea();
            objArea.idarea = idarea;
            objArea.area = txtArea.Text;
            objArea.sueldo = double.Parse(txtSueldo.Text);
            objArea.descripcion = txtDescripcion.Text;
            int fila=objArea.mtdActualizar();
            if (fila>0)
            {
                MessageBox.Show("Actualizado");
                mtdCargar();
            }

        }
    }
}
