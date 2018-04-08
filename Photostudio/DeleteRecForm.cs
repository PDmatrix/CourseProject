using System;
using System.Windows.Forms;
using static Photostudio.TablesFields;

namespace Photostudio
{
    public partial class DeleteRecForm : Form
    {
        private void RefreshControls()
        {
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

        public DeleteRecForm()
        {
            InitializeComponent();
            TablesClass.ShowGroupBox(Controls);
            RefreshControls();
        }

        private void ASCE_DeleteRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.DeleteRecord(TablesClass.SelectedTable, AssistanceFileds.ASCE_Code.Name() + "=" + ASCE_HelpCB.SelectedValue);
            RefreshControls();
        }

        private void PHO_DeleteRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.DeleteRecord(TablesClass.SelectedTable, PhotographersFileds.PHO_Code.Name() + "=" + PHO_FullnameCB.SelectedValue);
            RefreshControls();
        }

        private void ORD_DeleteRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.DeleteRecord(TablesClass.SelectedTable, OrdersFileds.ORD_Code.Name() + "=" + ORD_OrderCB.SelectedValue);
            RefreshControls();
        }

        private void CUS_DeleteRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.DeleteRecord(TablesClass.SelectedTable, CustomerFields.CUS_Code.Name() + "=" + CUS_FullnameCB.SelectedValue);
            RefreshControls();
        }

        private void SER_DeleteRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.DeleteRecord(TablesClass.SelectedTable, ServicesFileds.SER_Code.Name() + "=" + SER_DescriptionCB.SelectedValue);
            RefreshControls();
        }

        private void ASS_DeleteRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.DeleteRecord(TablesClass.SelectedTable, AssistantsFileds.ASS_Code.Name() + "=" + ASS_FullnameCB.SelectedValue);
            RefreshControls();
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
    }
}
