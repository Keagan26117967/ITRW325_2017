using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS325
{
    public partial class DBSelectMenu : Form
    {
        string Filepath;
        public DBSelectMenu()
        {
            InitializeComponent();
            Filepath = "";
        }

        private void btnDBV_Click(object sender, EventArgs e)
        {

        }

        private void selectDataSource()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "DB(.accdb)|*.accdb";
            open.FilterIndex = 1;
            open.InitialDirectory = Directory.GetCurrentDirectory();
            open.Title = "Data Source";
            open.ShowDialog();
            Filepath = open.FileName;
        }

        private void btnSelectDB_Click(object sender, EventArgs e)
        {
            selectDataSource();
        }
    }
}
