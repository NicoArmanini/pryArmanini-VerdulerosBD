using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryArmanini_VerdulerosBD
{
    public partial class frmRegistro : Form
    {

        OleDbConnection conn;
        OleDbCommand comm;
        OleDbDataReader rdr;

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
