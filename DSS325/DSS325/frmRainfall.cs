using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS325
{
    public partial class frmRainfall : Form
    {
        string myDBFile;
        public string conn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =";
        OleDbDataAdapter adapter;
        OleDbConnection myDB;

        public frmRainfall()
        {
            InitializeComponent();
        }

        public frmRainfall(string Filepath)
        {
            InitializeComponent();
            myDBFile = Filepath;
            myDB = new OleDbConnection(conn + myDBFile);
            RefreshDb();
        }

        private void RefreshDb()
        {
            myDB.Open();
            adapter = new OleDbDataAdapter("SELECT * FROM Rainfall", myDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Rainfall");
            dgvRainfall.DataSource = ds;
            dgvRainfall.DataMember = "Rainfall";
            myDB.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDBV_Click(object sender, EventArgs e)
        {
            string[,] arr2d = new string[dgvRainfall.Rows.Count, dgvRainfall.Columns.Count];
            for (int x = 0; x < arr2d.GetLength(0); x++)
                for (int i = 0; i < arr2d.GetLength(1); i++)
                    arr2d[x, i] = "" + dgvRainfall.Rows[x].Cells[i].Value;
            CalculateMinMaxArrays myCal = new CalculateMinMaxArrays();
            myCal.setMinMaxArrays(arr2d);
        }
    }
}
