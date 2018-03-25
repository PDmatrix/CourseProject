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
    public partial class MainForm : Form
    {
        //public static string SelectedTable = "ORDERS";

        private void SelectTable(string table)
        {
            table = table.ToUpper();
            TablesClass.SelectedTable = table;
            selectedTableLabel.Text = $@"Выбрана таблица: {TablesClass.Table[table]}";
            tableDescription.Text = TablesClass.TableDescription[table];
        }

        private void ShowForm<T>() where T : Form, new()
        {
            T formVar = new T();
            formVar.Show();
            this.Hide();

        }

        public MainForm()
        {
            InitializeComponent();
            SelectTable("ORDERS");
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTable("ORDERS");    
        }

        private void фотографыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTable("PHOTOGRAPHERS");
        }

        private void ассистентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTable("ASSISTANTS");
        }

        private void заказчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTable("CUSTOMERS");
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTable("SERVICES");
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
