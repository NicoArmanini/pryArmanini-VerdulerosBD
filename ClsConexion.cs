using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace PryVentasVerduleros_Cantallops
{
    class ClsConexion
    {
        OleDbConnection cnn;
        OleDbCommand cmdVendedor;
        OleDbCommand cmdProducto;
        OleDbCommand cmdVentas;
        OleDbDataReader rdrVendedor;
        OleDbDataReader rdrProducto;
        OleDbDataReader rdrVentas;

        public void CargarDatos(ComboBox cmbProducto, ComboBox cmbVendedor)
        {
            string conexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VERDULEROS.mdb;";
            cmbProducto.SelectedIndex = -1;
            cmbVendedor.SelectedIndex = -1;
            try
            {
                cnn = new OleDbConnection(conexion);
                cmdVendedor = new OleDbCommand();
                cmdVendedor.Connection = cnn;
                cmdVendedor.CommandType= CommandType.TableDirect;
                cmdVendedor.CommandText = "Vendedores";

                cmdProducto = new OleDbCommand();
                cmdProducto.Connection = cnn;
                cmdProducto.CommandType = CommandType.TableDirect;
                cmdProducto.CommandText = "Productos";

                cmdVentas = new OleDbCommand();
                cmdVentas.Connection = cnn;
                cmdVentas.CommandType = CommandType.TableDirect;
                cmdVentas.CommandText = "Ventas";

                cnn.Open();

                rdrVendedor = cmdVendedor.ExecuteReader();
                rdrProducto = cmdProducto.ExecuteReader();
                rdrVentas = cmdVentas.ExecuteReader();

                HashSet<string> Vendedores = new HashSet<string>();
                HashSet<string> Productos = new HashSet<string>();


                while (rdrVendedor.Read())
                {
                    string Vendedor = rdrVendedor[1].ToString();
                    Vendedores.Add(Vendedor);
                }

                while (rdrProducto.Read())
                {
                    string Producto = rdrProducto[1].ToString();
                    Productos.Add(Producto);
                }

                cmbProducto.Items.AddRange(Productos.ToArray());
                cmbVendedor.Items.AddRange(Vendedores.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);

            }
        }
    }
}
