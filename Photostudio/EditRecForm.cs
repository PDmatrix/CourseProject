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
    public partial class EditRecForm : Form
    {
        //Заполнение элементов согласно выбранному элементу ComboBox
        private void ChangeTextPhotographers()
        {
            TablesClass.ChangeText(Controls, TablesClass.SelectedTable.Name(), PhotographersFileds.PHO_Code.Name() + '=' + PHO_FullnameCB.SelectedValue,
                new Dictionary<Control, string>
                {
                    {PHO_FullnameTB, PhotographersFileds.PHO_Fullname.Name()},
                    {PHO_ExperienceTB, PhotographersFileds.PHO_Experience.Name()},
                    {PHO_DateMTB, PhotographersFileds.PHO_Date.Name()},
                    {PHO_PhoneMTB, PhotographersFileds.PHO_Phone.Name()},
                    {PHO_AdressTB, PhotographersFileds.PHO_Adress.Name()},
                });
        }

        private void ChangeTextCustomers()
        {
            TablesClass.ChangeText(Controls, TablesClass.SelectedTable.Name(), CustomerFields.CUS_Code.Name() + '=' + CUS_FullnameCB.SelectedValue,
                new Dictionary<Control, string>
                {
                    {CUS_FullnameTB, CustomerFields.CUS_Fullname.Name()},
                    {CUS_AdressTB, CustomerFields.CUS_Adress.Name()},
                    {CUS_PhoneMTB, CustomerFields.CUS_Phone.Name()}
                });
        }

        private void ChangeTextServices()
        {

            TablesClass.ChangeText(Controls, TablesClass.SelectedTable.Name(), ServicesFileds.SER_Code.Name() + '=' + SER_DescriptionCB.SelectedValue,
                new Dictionary<Control, string>
                {
                    {SER_DescriptionTB, ServicesFileds.SER_Description.Name()},
                    {SER_PriceTB, ServicesFileds.SER_Price.Name()}
                });
        }

        private void ChangeTextAssistants()
        {

            TablesClass.ChangeText(Controls, TablesClass.SelectedTable.Name(), AssistantsFileds.ASS_Code.Name() + '=' + ASS_FullnameCB.SelectedValue,
                new Dictionary<Control, string>
                {
                    {ASS_FullnameTB, AssistantsFileds.ASS_Fullname.Name()},
                    {ASS_PhoneMTB, AssistantsFileds.ASS_Phone.Name()}
                });
        }

        private void ChangeTexOrders()
        {

            TablesClass.ChangeText(Controls, TablesClass.SelectedTable.Name(), OrdersFileds.ORD_Code.Name() + '=' + ORD_OrderCB.SelectedValue,
                new Dictionary<Control, string>
                {
                    {ORD_DateMTB, OrdersFileds.ORD_Date.Name()},
                    {ORD_ExecCB, OrdersFileds.ORD_Exec.Name()},
                    {ORD_CustomersCB, OrdersFileds.ORD_CusCode.Name()},
                    {ORD_PhotographersCB, OrdersFileds.ORD_PhoCode.Name()},
                    {ORD_ServicesCB, OrdersFileds.ORD_SerCode.Name()}
                });

        }

        private void ChangeTextAssistance()
        {
            TablesClass.ChangeText(Controls, TablesClass.SelectedTable.Name(), AssistanceFileds.ASCE_Code.Name() + '=' + ASCE_HelpCB.SelectedValue,
                new Dictionary<Control, string>
                {
                    {ASCE_AssistantCB, AssistanceFileds.ASCE_AssCode.Name()},
                    {ASCE_OrderCB, AssistanceFileds.ASCE_OrdCode.Name()}
                });

        }

        //Функция для обновления всех элеменов
        private void RefreshControls()
        {
            //TablesClass.RefreshGrid(dataGrid);
            if (TablesClass.SelectedTable == Tables.ORDERS.Name())
            {
                TablesClass.FillComboBoxAssistance(ORD_OrderCB);
                TablesClass.FillComboBox(ORD_CustomersCB, Tables.CUSTOMERS.Name(), CustomerFields.CUS_Fullname.Name(),
                    CustomerFields.CUS_Code.Name());
                TablesClass.FillComboBox(ORD_PhotographersCB, Tables.PHOTOGRAPHERS.Name(),
                    PhotographersFileds.PHO_Fullname.Name(), PhotographersFileds.PHO_Code.Name());
                TablesClass.FillComboBox(ORD_ServicesCB, Tables.SERVICES.Name(), ServicesFileds.SER_Description.Name(),
                    ServicesFileds.SER_Code.Name());
                ChangeTexOrders();
            }
            else if (TablesClass.SelectedTable == Tables.ASSISTANCE.Name())
            {
                TablesClass.FillComboBoxFindAssistance(ASCE_HelpCB);
                TablesClass.FillComboBox(ASCE_AssistantCB, Tables.ASSISTANTS.Name(),
                    AssistantsFileds.ASS_Fullname.Name(), AssistantsFileds.ASS_Code.Name());
                TablesClass.FillComboBoxAssistance(ASCE_OrderCB);
                ChangeTextAssistance();
            }
            else if (TablesClass.SelectedTable == Tables.ASSISTANTS.Name())
            {
                TablesClass.FillComboBox(ASS_FullnameCB, Tables.ASSISTANTS.Name(), AssistantsFileds.ASS_Fullname.Name(),
                    AssistantsFileds.ASS_Code.Name());
                ChangeTextAssistants();
            }
            else if (TablesClass.SelectedTable == Tables.PHOTOGRAPHERS.Name())
            {
                TablesClass.FillComboBox(PHO_FullnameCB, Tables.PHOTOGRAPHERS.Name(),
                    PhotographersFileds.PHO_Fullname.Name(), PhotographersFileds.PHO_Code.Name());
                ChangeTextPhotographers();
            }
            else if (TablesClass.SelectedTable == Tables.CUSTOMERS.Name())
            {
                TablesClass.FillComboBox(CUS_FullnameCB, Tables.CUSTOMERS.Name(), CustomerFields.CUS_Fullname.Name(),
                    CustomerFields.CUS_Code.Name());
                ChangeTextCustomers();
            }
            else if (TablesClass.SelectedTable == Tables.SERVICES.Name())
            {
                TablesClass.FillComboBox(SER_DescriptionCB, Tables.SERVICES.Name(),
                    ServicesFileds.SER_Description.Name(), ServicesFileds.SER_Code.Name());
                ChangeTextServices();
            }
        }

        public EditRecForm()
        {
            InitializeComponent();
            TablesClass.ShowGroupBox(Controls);
            RefreshControls();
        }

        //Редактирование записи таблицы ASSISTANCE
        private void ASCE_EditRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.EditRecord(TablesClass.SelectedTable.Name(),new Dictionary<string, string>
            {
                {AssistanceFileds.ASCE_Code.Name(), ASCE_HelpCB.SelectedValue.ToString()}
            }, new Dictionary<string, string>
            {
                {AssistanceFileds.ASCE_AssCode.Name(), ASCE_AssistantCB.SelectedValue.ToString()},
                {AssistanceFileds.ASCE_OrdCode.Name(), ASCE_OrderCB.SelectedValue.ToString()}
            });
            RefreshControls();
        }

        //Редактирование записи таблицы PHOTOGRAPHERS
        private void PHO_EditRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.EditRecord(TablesClass.SelectedTable.Name(),new Dictionary<string, string>
            {
                {PhotographersFileds.PHO_Code.Name(), PHO_FullnameCB.SelectedValue.ToString()}
            }, new Dictionary<string, string>
            {
                {PhotographersFileds.PHO_Fullname.Name(), PHO_FullnameTB.Text},
                {PhotographersFileds.PHO_Experience.Name(), PHO_ExperienceTB.Text},
                {PhotographersFileds.PHO_Date.Name(), PHO_DateMTB.Text},
                {PhotographersFileds.PHO_Phone.Name(), PHO_PhoneMTB.Text},
                {PhotographersFileds.PHO_Adress.Name(), PHO_AdressTB.Text}
            });
            RefreshControls();
            
        }

        //Редактирование записи таблицы CUSTOMERS
        private void CUS_EditRecordBTN_Click(object sender, EventArgs e)
        {
            TablesClass.EditRecord(TablesClass.SelectedTable.Name(),new Dictionary<string, string>
            {
                {CustomerFields.CUS_Code.Name(), CUS_FullnameCB.SelectedValue.ToString()}
            }, new Dictionary<string, string>
            {
                {CustomerFields.CUS_Fullname.Name(), CUS_FullnameTB.Text},
                {CustomerFields.CUS_Adress.Name(), CUS_AdressTB.Text},
                {CustomerFields.CUS_Phone.Name(), CUS_PhoneMTB.Text},
            });
            RefreshControls();
        }

        //Редактирование записи таблицы SERVICES
        private void SER_EditRecordBTN_Click(object sender, EventArgs e)
        {

            TablesClass.EditRecord(TablesClass.SelectedTable.Name(),new Dictionary<string, string>
            {
                {ServicesFileds.SER_Code.Name(), SER_DescriptionCB.SelectedValue.ToString()}
            }, new Dictionary<string, string>
            {
                {ServicesFileds.SER_Description.Name(), SER_DescriptionTB.Text},
                {ServicesFileds.SER_Price.Name(), SER_PriceTB.Text}
            });
            RefreshControls();
        }

        //Редактирование записи таблицы ASSISTANTS
        private void ASS_EditRecordBTN_Click(object sender, EventArgs e)
        {

            TablesClass.EditRecord(TablesClass.SelectedTable.Name(),new Dictionary<string, string>
            {
                {AssistantsFileds.ASS_Code.Name(), ASS_FullnameCB.SelectedValue.ToString()}
            }, new Dictionary<string, string>
            {
                {AssistantsFileds.ASS_Fullname.Name(), ASS_FullnameTB.Text},
                {AssistantsFileds.ASS_Phone.Name(), ASS_PhoneMTB.Text}
            });
            RefreshControls();
        }

        //Редактирование записи таблицы ORDERS
        private void ORD_EditRecordBTN_Click(object sender, EventArgs e)
        {

            TablesClass.EditRecord(TablesClass.SelectedTable.Name(),new Dictionary<string, string>
            {
                {OrdersFileds.ORD_Code.Name(), ORD_OrderCB.SelectedValue.ToString()}
            }, new Dictionary<string, string>
            {
                {OrdersFileds.ORD_CusCode.Name(), ORD_CustomersCB.SelectedValue.ToString()},
                {OrdersFileds.ORD_PhoCode.Name(), ORD_PhotographersCB.SelectedValue.ToString()},
                {OrdersFileds.ORD_SerCode.Name(), ORD_ServicesCB.SelectedValue.ToString()},
                {OrdersFileds.ORD_Date.Name(), ORD_DateMTB.Text},
                {OrdersFileds.ORD_Exec.Name(), Convert.ToInt32(ORD_ExecCB.Checked).ToString()}
            });
            RefreshControls();
        }

        //Изменение элементов при выборе другого значения в ComboBox
        private void PHO_FullnameCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeTextPhotographers();
        }

        private void CUS_FullnameCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeTextCustomers();
        }

        private void SER_DescriptionCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeTextServices();
        }

        private void ASS_FullnameCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeTextAssistants();
        }

        private void ORD_OrderCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeTexOrders();
        }

        private void ASCE_HelpCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeTextAssistance();
        }

        //Форматирование ComboBox для отображения
        private void ASCE_OrderCB_Format(object sender, ListControlConvertEventArgs e)
        {
            TablesClass.Format(ref e, "Заказчик: {0} Фотограф: {1}");
        }

        private void ORD_OrderCB_Format(object sender, ListControlConvertEventArgs e)
        {
            TablesClass.Format(ref e, "Заказчик: {0} Фотограф: {1}");
        }

        private void ASCE_HelpCB_Format(object sender, ListControlConvertEventArgs e)
        {
            TablesClass.Format(ref e, "Ассистент: {0} Заказчик: {1} Фотограф: {2}");
        }
    }
}
