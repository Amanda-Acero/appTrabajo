﻿using appTrabajo.Datos;
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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            clEmpleado objEmpleado = new clEmpleado();
            DataTable tblEmpleado = new DataTable();
            tblEmpleado = objEmpleado.mtdListar();
            dgvEmpleado.DataSource = tblEmpleado;

        }
    }
}
