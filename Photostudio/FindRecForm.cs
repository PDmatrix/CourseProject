using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photostudio
{
    public partial class FindRecForm : Form
    {
        public FindRecForm()
        {
            InitializeComponent();
            TablesClass.ShowGroupBox(Controls);
        }

        private void FindRecForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
