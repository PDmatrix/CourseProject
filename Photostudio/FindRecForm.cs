using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Photostudio.TablesFields;

namespace Photostudio
{
    public partial class FindRecForm : Form
    {
        public FindRecForm()
        {
            InitializeComponent();
            TablesClass.ShowGroupBox(Controls);
            TablesClass.RefreshGrid(dataGrid);
            /*if (TablesClass.SelectedTable == Tables.ORDERS.Name())
            {
                TablesClass.FillComboBox(ORD_CustomersCB, Tables.CUSTOMERS.Name(), CustomerFields.CUS_Fullname.Name(), CustomerFields.CUS_Code.Name());
            }
            else if (TablesClass.SelectedTable == Tables.ASSISTANCE.Name())
            {
                TablesClass.FillComboBox(ASCE_AssistantCB, Tables.ASSISTANTS.Name(), AssistantsFileds.ASS_Fullname.Name(), AssistantsFileds.ASS_Code.Name());
                TablesClass.FillComboBoxAssistance(ASCE_OrderCB);
            }*/
        }

        private void FindRecForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
        }

        private void ASS_FindRecordBTN_Click(object sender, EventArgs e)
        {

        }

        private void PHO_FindRecordBTN_Click(object sender, EventArgs e)
        {

        }

        private void CUS_FindRecordBTN_Click(object sender, EventArgs e)
        {

        }

        private void SER_FindRecordBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
