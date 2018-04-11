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
    public partial class MainForm : Form
    {

        //Выбор таблицы
        private void SelectTable(string table)
        {
            table = table.ToUpper();
            TablesClass.SelectedTable = table;
            selectedTableLabel.Text = $@"Выбрана таблица: {TablesClass.TableDisplay[table]}";
            tableDescription.Text = TablesClass.TableDescription[table];
        }

        //Вывод формы
        private void ShowForm<T>() where T : Form, new()
        {
            T formVar = new T();
            formVar.Show(this);
        }

        public MainForm()
        {
            InitializeComponent();
            SelectTable(Tables.ORDERS.Name());
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTable(Tables.ORDERS.Name());    
        }

        private void фотографыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTable(Tables.PHOTOGRAPHERS.Name());
        }

        private void ассистентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTable(Tables.ASSISTANTS.Name());
        }

        private void заказчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTable(Tables.CUSTOMERS.Name());
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTable(Tables.SERVICES.Name());
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTable(Tables.ASSISTANCE.Name());
        }

        private void addRecBtn_Click(object sender, EventArgs e)
        {
            ShowForm<AddRecForm>();
        }

        private void editRecBtn_Click(object sender, EventArgs e)
        {
            ShowForm<EditRecForm>();
        }

        private void findRecBtn_Click(object sender, EventArgs e)
        {
            ShowForm<FindRecForm>();
        }

        private void deleteRecBtn_Click(object sender, EventArgs e)
        {
            ShowForm<DeleteRecForm>();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
