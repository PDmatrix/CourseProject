using System;
using System.Windows.Forms;
using static Photostudio.TablesFields;

namespace Photostudio
{
    public partial class DeleteRecForm : Form
    {
        //Функция для обновления всех элеменов
        private void RefreshControls()
        {
            //TablesClass.RefreshGrid(dataGrid);
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

        //Удаление записи из таблицы ASSISTANCE
        private void ASCE_DeleteRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.DeleteRecord(TablesClass.SelectedTable, AssistanceFileds.ASCE_Code.Name() + "=" + ASCE_HelpCB.SelectedValue);
            RefreshControls();
        }

        //Удаление записи из таблицы PHOTOGRAPHERS
        private void PHO_DeleteRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.DeleteRecord(TablesClass.SelectedTable, PhotographersFileds.PHO_Code.Name() + "=" + PHO_FullnameCB.SelectedValue);
            RefreshControls();
        }

        //Удаление записи из таблицы ORDERS
        private void ORD_DeleteRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.DeleteRecord(TablesClass.SelectedTable, OrdersFileds.ORD_Code.Name() + "=" + ORD_OrderCB.SelectedValue);
            RefreshControls();
        }

        //Удаление записи из таблицы CUSTOMERS
        private void CUS_DeleteRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.DeleteRecord(TablesClass.SelectedTable, CustomerFields.CUS_Code.Name() + "=" + CUS_FullnameCB.SelectedValue);
            RefreshControls();
        }

        //Удаление записи из таблицы SERVICES
        private void SER_DeleteRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.DeleteRecord(TablesClass.SelectedTable, ServicesFileds.SER_Code.Name() + "=" + SER_DescriptionCB.SelectedValue);
            RefreshControls();
        }

        //Удаление записи из таблицы ASSISTANTS
        private void ASS_DeleteRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.DeleteRecord(TablesClass.SelectedTable, AssistantsFileds.ASS_Code.Name() + "=" + ASS_FullnameCB.SelectedValue);
            RefreshControls();
        }

        //Форматирование ComboBox для отображения
        private void ASCE_HelpCB_Format(object sender, ListControlConvertEventArgs e)
        {
            TablesClass.Format(ref e, "Ассистент: {0} Заказчик: {1} Фотограф: {2}");
        }

        private void ORD_OrderCB_Format(object sender, ListControlConvertEventArgs e)
        {
            TablesClass.Format(ref e, "Заказчик: {0} Фотограф: {1}");
        }
    }
}
