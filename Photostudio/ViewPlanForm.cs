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
using Microsoft.Office.Interop.Word;
using Application = System.Windows.Forms.Application;

namespace Photostudio
{
    public partial class ViewPlanForm : Form
    {
        public ViewPlanForm()
        {
            InitializeComponent();
        }

        private void viewPlanBTN_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Вы действительно хотите просмотреть план за " + monthTB.Text.ToLower() + @" " + yearTB.Text + @" года?",
                @"Просмотр плана", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            string path = Environment.CurrentDirectory + "\\Планы\\" + monthTB.Text.ToLower() + "_" + yearTB.Text + ".docx";
            FileInfo fileInf = new FileInfo(path);
            if (!fileInf.Exists)
            {
                MessageBox.Show(@"Файл плана не существует!");
                return;
            }

            _Application application = new Microsoft.Office.Interop.Word.Application();
            application.Documents.Open(path);
            application.Visible = true;
        }
    }
}
