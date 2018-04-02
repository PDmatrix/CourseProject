using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using static Photostudio.TablesFields;

namespace Photostudio
{
    public partial class AddRecForm : Form
    {
        public AddRecForm()
        {
            InitializeComponent();
            TablesClass.ShowGroupBox(Controls);
            TablesClass.RefreshGrid(dataGrid);
            //Заполнение ComboBox в зависимости от выбранной таблицы
            if (TablesClass.SelectedTable == Tables.ORDERS.Name())
            {
                TablesClass.FillComboBox(ORD_CustomersCB, Tables.CUSTOMERS.Name(), CustomerFields.CUS_Fullname.Name(), CustomerFields.CUS_Code.Name());
                TablesClass.FillComboBox(ORD_PhotographersCB, Tables.PHOTOGRAPHERS.Name(), PhotographersFileds.PHO_Fullname.Name(), PhotographersFileds.PHO_Code.Name());
                TablesClass.FillComboBox(ORD_ServicesCB, Tables.SERVICES.Name(), ServicesFileds.SER_Description.Name(), ServicesFileds.SER_Code.Name());
            }
            else if (TablesClass.SelectedTable == Tables.ASSISTANCE.Name())
            {
                TablesClass.FillComboBox(ASCE_AssistantCB, Tables.ASSISTANTS.Name(), AssistantsFileds.ASS_Fullname.Name(), AssistantsFileds.ASS_Code.Name());
                TablesClass.FillComboBoxAssistance(ASCE_OrderCB);
            }
        }

        //Добавление записи в таблицу ORDERS
        private void ORD_AddRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.AddRecord(Tables.ORDERS.Name(), new Dictionary<string, string>
            {
                {OrdersFileds.ORD_CusCode.Name(), ORD_CustomersCB.SelectedValue.ToString()},
                {OrdersFileds.ORD_PhoCode.Name(), ORD_PhotographersCB.SelectedValue.ToString()},
                {OrdersFileds.ORD_SerCode.Name(), ORD_ServicesCB.SelectedValue.ToString()},
                {OrdersFileds.ORD_Date.Name(), ORD_DateMTB.Text},
                {OrdersFileds.ORD_Exec.Name(), Convert.ToInt32(ORD_ExecCB.Checked).ToString()}
            });
            TablesClass.RefreshGrid(dataGrid);
        }

        //Добавление записи в таблицу CUSTOMERS
        private void CUS_AddRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.AddRecord(Tables.CUSTOMERS.Name(), new Dictionary<string, string>
            {
                {CustomerFields.CUS_Fullname.Name(), CUS_FullnameTB.Text},
                {CustomerFields.CUS_Adress.Name(), CUS_AdressTB.Text},
                {CustomerFields.CUS_Phone.Name(), CUS_PhoneMTB.Text}
            });
            TablesClass.RefreshGrid(dataGrid);
        }

        //Добавление записи в таблицу SERVICES
        private void SER_AddRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.AddRecord(Tables.SERVICES.Name(), new Dictionary<string, string>
            {
                {ServicesFileds.SER_Description.Name(), SER_DescriptionTB.Text},
                {ServicesFileds.SER_Price.Name(), SER_PriceTB.Text},
            });
            TablesClass.RefreshGrid(dataGrid);
        }

        //Добавление записи в таблицу ASSISTANTS
        private void ASS_AddRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.AddRecord(Tables.ASSISTANTS.Name(), new Dictionary<string, string>
            {
                {AssistantsFileds.ASS_Fullname.Name(), ASS_FullnameTB.Text},
                {AssistantsFileds.ASS_Phone.Name(), ASS_PhoneMTB.Text},
            });
            TablesClass.RefreshGrid(dataGrid);
        }

        //Добавление записи в таблицу ASSISTANCE
        private void ASCE_AddRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.AddRecord(Tables.ASSISTANCE.Name(), new Dictionary<string, string>
            {
                {AssistanceFileds.ASCE_AssCode.Name(), ASCE_AssistantCB.SelectedValue.ToString()},
                {AssistanceFileds.ASCE_OrdCode.Name(), ASCE_OrderCB.SelectedValue.ToString()},
            });
            TablesClass.RefreshGrid(dataGrid);
        }

        //Добавление записи в таблицу PHOTOGRAPHERS
        private void PHO_AddRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.AddRecord(Tables.PHOTOGRAPHERS.Name(), new Dictionary<string, string>
            {
                {PhotographersFileds.PHO_Fullname.Name(), PHO_FullnameTB.Text},
                {PhotographersFileds.PHO_Experience.Name(), PHO_ExperienceTB.Text},
                {PhotographersFileds.PHO_Date.Name(), PHO_DateMTB.Text},
                {PhotographersFileds.PHO_Phone.Name(), PHO_PhoneMTB.Text},
                {PhotographersFileds.PHO_Adress.Name(), PHO_AdressTB.Text}
            });
            TablesClass.RefreshGrid(dataGrid);
        }


        //Форматирование ComboBox для отображения
        private void ASCE_OrderCB_Format(object sender, ListControlConvertEventArgs e)
        {
            string[] names = e.Value.ToString().Split(';');
            try
            {
                e.Value = $@"Фотограф: {TablesClass.Abbrivation(names[0])} Заказчик: {TablesClass.Abbrivation(names[1])}";
            }
            catch (Exception exception)
            {
                //Console.WriteLine(exception);
                //throw;
            }
            
        }
    }
}
