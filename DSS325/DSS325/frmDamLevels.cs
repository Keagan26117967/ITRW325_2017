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
    public partial class frmDamLevels : Form
    {
        string myDBFile;
        public string conn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =";
        OleDbDataAdapter adapter;
        OleDbConnection myDB;

        public double[] arrDamLevelsMIN = new double[12];
        public double[] arrDamLevelsMAX = new double[12];

        string Dam;
        public frmDamLevels()
        {
            InitializeComponent();
        }

        public frmDamLevels(string Filepath)
        {
            InitializeComponent();
            myDBFile = Filepath;
            myDB = new OleDbConnection(conn + myDBFile);
            cbxDams.SelectedIndex = 0;
            RefreshDb();
        }

        private void RefreshDb()
        {
            myDB.Open();
            adapter = new OleDbDataAdapter("SELECT * FROM " + Dam, myDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Dam");
            dgvDamLevels.DataSource = ds;
            dgvDamLevels.DataMember = "Dam";
            myDB.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDBV_Click(object sender, EventArgs e)
        {
            string[,] arr2d = new string[dgvDamLevels.Rows.Count, dgvDamLevels.Columns.Count];
            for (int x = 0; x < arr2d.GetLength(0); x++)
                for (int i = 0; i < arr2d.GetLength(1); i++)
                    arr2d[x, i] = "" + dgvDamLevels.Rows[x].Cells[i].Value;
            CalculateMinMaxArrays myCal = new CalculateMinMaxArrays();
            myCal.setMinMaxArrays(arr2d);
            arrDamLevelsMIN = myCal.arrMIN;
            arrDamLevelsMAX = myCal.arrMAX;
        }

        private void cbxDams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDams.SelectedIndex == 0)
                Dam = "Alexandra";
            else if (cbxDams.SelectedIndex == 1)
                Dam = "Berg_River";
            else if (cbxDams.SelectedIndex == 2)
                Dam = "De_Villiers";
            else if (cbxDams.SelectedIndex == 3)
                Dam = "Hely_Hutchenson";
            else if (cbxDams.SelectedIndex == 4)
                Dam = "Kleinplaats";
            else if (cbxDams.SelectedIndex == 5)
                Dam = "Lewis_Gay";
            else if (cbxDams.SelectedIndex == 6)
                Dam = "Steenbras_Lower";
            else if (cbxDams.SelectedIndex == 7)
                Dam = "Steenbras_Upper";
            else if (cbxDams.SelectedIndex == 8)
                Dam = "TheeWaterkloof";
            else if (cbxDams.SelectedIndex == 9)
                Dam = "Victoria";
            else if (cbxDams.SelectedIndex == 10)
                Dam = "Voelvlei";
            else if (cbxDams.SelectedIndex == 11)
                Dam = "Wemmerhoek";
            else if (cbxDams.SelectedIndex == 12)
                Dam = "Woodhead";

            RefreshDb();
        }
    }
}
