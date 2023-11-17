using MostTopMan.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostTopMan
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            ReadOnlyCollection<BootingApplication> apps = BootingApplication.Load();
            dataGridView1.DataSource = apps;
        }

        private void MostTopButton_Click(object sender, EventArgs e)
        {
            Models.Logics.TopMost a = new Models.Logics.TopMost(25788);
            a.Execute();
        }
    }
}
