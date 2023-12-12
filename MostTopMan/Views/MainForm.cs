using TopMostMan.Models.Entitys;
using TopMostMan.Models.Interface;
using TopMostMan.Models.Logics;
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

namespace TopMostMan
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            HandleEvents();
        }

        private void HandleEvents()
        {
            LoadButton.Click += (sender, e) => LoadButtonClick?.Invoke(this, EventArgs.Empty);
            ReleaseButton.Click += (sender, e) => ReleaseButtonClick?.Invoke(this, EventArgs.Empty);
            TopMostButton.Click += (sender, e) => TopMostButtonClick?.Invoke(this, EventArgs.Empty);
        }

        public IEnumerable<BootingApplication> Applications
        {
            set
            {
                ProcessGrid.DataSource = value;
            }
        }

        public bool ApplicationExists
        {
            get
            {
                return ProcessGrid.RowCount > 0;
            }
        }


        public BootingApplication CurrentApplication
        {
            get
            {
                DataGridViewRow selectedRow = ProcessGrid.SelectedRows[0];
                return selectedRow.DataBoundItem as BootingApplication;
            }
        }

        public event EventHandler LoadButtonClick;
        public event EventHandler ReleaseButtonClick;
        public event EventHandler TopMostButtonClick;
    }
}
