using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace pryArmanini_VerdulerosBD
{
    class ClsConexion
    {
        OleDbConnection cone;
        OleDbCommand cmdVendedor;
        OleDbCommand cmdProducto;
        OleDbDataReader rdrVendedor;
        OleDbDataReader rdrProducto;

        public void CargarDatos(ComboBox cmbNombreProducto, ComboBox cmbNombreVendedor)
        {
            string conexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VERDULEROS.mdb;";
            cmbNombreProducto.SelectedIndex = -1;
            cmbNombreVendedor.SelectedIndex = -1;
            try
            {
                cone = new OleDbConnection(conexion);
                cmdVendedor = new OleDbCommand();
                cmdVendedor.Connection = cone;
                cmdVendedor.CommandType = CommandType.TableDirect;
                cmdVendedor.CommandText = "Vendedores";

                cmdProducto = new OleDbCommand();
                cmdProducto.Connection = cone;
                cmdProducto.CommandType = CommandType.TableDirect;
                cmdProducto.CommandText = "Productos";

                cone.Open();
                rdrVendedor = cmdVendedor.ExecuteReader();
                rdrProducto = cmdProducto.ExecuteReader();

                cmbNombreVendedor.Items.Clear();
                cmbNombreProducto.Items.Clear();

                DataTable tablaVendedor = new DataTable();
                DataTable tablaProducto = new DataTable();

                if (rdrVendedor.HasRows)
                {
                    tablaVendedor.Load(rdrVendedor);
                    cmbNombreVendedor.DataSource = tablaVendedor;
                    cmbNombreVendedor.ValueMember = "IdVendedor";
                    cmbNombreVendedor.DisplayMember = "NombreVendedor";
                }

                if (rdrProducto.HasRows)
                {
                    tablaProducto.Load(rdrProducto);
                    cmbNombreProducto.DataSource = tablaProducto;
                    cmbNombreProducto.ValueMember = "IdProducto";
                    cmbNombreProducto.DisplayMember = "NomProducto";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        public void RegistrarVenta(string cmbNombreVendedor, string cmbNombreProducto, DateTime dtpFecha, string txtKilos)
        {

            string conexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VERDULEROS.mdb;";
            string sql = "INSERT INTO Ventas ([Cod Vendedor], [Cod Producto], Fecha, Kilos)" +
                         " VALUES (@vendedor, @producto, @fechaventa, @cantidad)";
            try
            {
                cone = new OleDbConnection(conexion);
                cmdVendedor = new OleDbCommand();
                cmdVendedor.Connection = cone;

                cmdVendedor.Connection.Open();
                cmdVendedor.CommandType = CommandType.Text;
                cmdVendedor.CommandText = sql;

                cmdVendedor.Parameters.AddWithValue("@vendedor", cmbNombreVendedor);
                cmdVendedor.Parameters.AddWithValue("@producto", cmbNombreProducto);
                cmdVendedor.Parameters.AddWithValue("@fechaventa", dtpFecha);
                cmdVendedor.Parameters.AddWithValue("@cantidad", txtKilos);

                cmdVendedor.ExecuteNonQuery();

                MessageBox.Show("Venta grabada con Exito!!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);

            }
        }
    }
}
