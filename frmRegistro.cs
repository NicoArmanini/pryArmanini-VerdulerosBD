﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Net.WebRequestMethods;

namespace pryArmanini_VerdulerosBD
{
    public partial class frmRegistro : Form
    { 
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            ClsConexion objCnn = new ClsConexion();
            objCnn.CargarDatos(cmbNombreProducto, cmbNombreVendedor);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsConexion Datos1 = new ClsConexion();
                Datos1.RegistrarVenta(cmbNombreVendedor.Text, cmbNombreProducto.Text, dtpFecha.Value, txtKilos.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
