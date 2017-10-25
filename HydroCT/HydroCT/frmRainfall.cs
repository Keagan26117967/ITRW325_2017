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
using System.IO;

namespace HydroCT
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

        private void frmRainfall_Load(object sender, EventArgs e)
        {
          

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
    }
}
