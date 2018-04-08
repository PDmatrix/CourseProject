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
            if (TablesClass.SelectedTable == Tables.ORDERS.Name())
            {
                TablesClass.FillComboBoxAssistance(ORD_OrderCB);
            }
            else if (TablesClass.SelectedTable == Tables.ASSISTANCE.Name())
            {
                TablesClass.FillComboBoxFindAssistance(ASCE_HelpCB);
            }
            else if (TablesClass.SelectedTable == Tables.ASSISTANTS.Name())
            {
                TablesClass.FillComboBox(ASS_FullnameCB, Tables.ASSISTANTS.Name(), AssistantsFileds.ASS_Fullname.Name(),
                    AssistantsFileds.ASS_Code.Name());
            }
            else if (TablesClass.SelectedTable == Tables.PHOTOGRAPHERS.Name())
            {
                TablesClass.FillComboBox(PHO_FullnameCB, Tables.PHOTOGRAPHERS.Name(),
                    PhotographersFileds.PHO_Fullname.Name(), PhotographersFileds.PHO_Code.Name());
            }
            else if (TablesClass.SelectedTable == Tables.CUSTOMERS.Name())
            {
                TablesClass.FillComboBox(CUS_FullnameCB, Tables.CUSTOMERS.Name(), CustomerFields.CUS_Fullname.Name(),
                    CustomerFields.CUS_Code.Name());
            }
            else if (TablesClass.SelectedTable == Tables.SERVICES.Name())
            {
                TablesClass.FillComboBox(SER_DescriptionCB, Tables.SERVICES.Name(),
                    ServicesFileds.SER_Description.Name(), ServicesFileds.SER_Code.Name());
            }
        }

        private void ASS_FindRecordBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                TablesClass.FindRecord(TablesClass.SelectedTable,
                    ASS_FullnameCB.ValueMember + " = " + ASS_FullnameCB.SelectedValue),
                TablesClass.TableDisplay[TablesClass.SelectedTable]);
        }

        private void PHO_FindRecordBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                TablesClass.FindRecord(TablesClass.SelectedTable,
                    PHO_FullnameCB.ValueMember + " = " + PHO_FullnameCB.SelectedValue),
                TablesClass.TableDisplay[TablesClass.SelectedTable]);
        }

        private void CUS_FindRecordBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                TablesClass.FindRecord(TablesClass.SelectedTable,
                    CUS_FullnameCB.ValueMember + " = " + CUS_FullnameCB.SelectedValue),
                TablesClass.TableDisplay[TablesClass.SelectedTable]);
        }

        private void SER_FindRecordBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                TablesClass.FindRecord(TablesClass.SelectedTable,
                    SER_DescriptionCB.ValueMember + " = " + SER_DescriptionCB.SelectedValue),
                TablesClass.TableDisplay[TablesClass.SelectedTable]);
        }

        private void ORD_FindRecordBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                TablesClass.FindRecord(TablesClass.SelectedTable,
                    ORD_OrderCB.ValueMember + " = " + ORD_OrderCB.SelectedValue, new Dictionary<string,Dictionary<string,string>>
                    {
                        {Tables.CUSTOMERS.Name(), new Dictionary<string, string> {{CustomerFields.CUS_Fullname.Name(), CustomerFields.CUS_Code.Name()}}},
                        {Tables.PHOTOGRAPHERS.Name(), new Dictionary<string, string> {{PhotographersFileds.PHO_Fullname.Name(), PhotographersFileds.PHO_Code.Name()}}},
                        {Tables.SERVICES.Name(), new Dictionary<string, string> {{ServicesFileds.SER_Description.Name(), ServicesFileds.SER_Code.Name()}}}
                    }),
                TablesClass.TableDisplay[TablesClass.SelectedTable]);
        }

        private void ASCE_FindRecordBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                TablesClass.FindRecord(TablesClass.SelectedTable,
                    ASCE_HelpCB.ValueMember + " = " + ASCE_HelpCB.SelectedValue, new Dictionary<string,Dictionary<string,string>>
                    {
                        {Tables.ASSISTANTS.Name(), new Dictionary<string, string> {{AssistantsFileds.ASS_Fullname.Name(), AssistantsFileds.ASS_Code.Name()}}},
                        {Tables.ORDERS.Name(), new Dictionary<string, string> {{OrdersFileds.ORD_Date.Name(), OrdersFileds.ORD_Code.Name()}}},
                    }),
                TablesClass.TableDisplay[TablesClass.SelectedTable]);
        }

        private void ORD_OrderCB_Format(object sender, ListControlConvertEventArgs e)
        {
            string[] names = e.Value.ToString().Split(';');
            try
            {
                e.Value =
                    $@"Заказчик: {TablesClass.Abbrivation(names[0])} Фотограф: {TablesClass.Abbrivation(names[1])}";
            }
            catch
            {
                // ignored
            }
        }

        private void ASCE_HelpCB_Format(object sender, ListControlConvertEventArgs e)
        {
            string[] names = e.Value.ToString().Split(';');
            try
            {
                e.Value =
                    $@"Ассистент: {TablesClass.Abbrivation(names[0])} Заказчик: {TablesClass.Abbrivation(names[1])} Фотограф: {TablesClass.Abbrivation(names[2])}";
            }
            catch
            {
                // ignored
            }
        }
    }
}

