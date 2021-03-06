﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HydroCT
{
    public partial class frmMain : Form
    {

        string Filepath;
        public frmMain()
        {
            InitializeComponent();
            Filepath = "";
        }

        private void btnRainfall_Click(object sender, EventArgs e)
        {

            if (Filepath == "")
            {
                MessageBox.Show("Please Select Data Source", "Select Data Source", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectDataSource();
              
            }
            else
            {
                frmRainfall rainfall = new frmRainfall(Filepath);
                rainfall.Show();
                this.Hide();
            }
        }

        private void btnDamLevels_Click(object sender, EventArgs e)
        {

            if (Filepath == "")
            {
                MessageBox.Show("Please Select Data Source", "Select Data Source", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectDataSource();
            }
            else
            {
                frmDamLevels damlevels = new frmDamLevels(Filepath);
                damlevels.Show();
                this.Hide();
            }
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

        private void selectDataSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            selectDataSource();
        }
    }
}
