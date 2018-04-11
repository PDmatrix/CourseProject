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

        private void PHO_FullnameCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeTextPhotographers();
        }

        private void CUS_FullnameCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeTextCustomers();
        }

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

        private void SER_DescriptionCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeTextServices();
        }

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

        private void ASS_FullnameCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeTextAssistants();
        }

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
    }
}
