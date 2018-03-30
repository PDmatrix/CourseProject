using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using static Photostudio.TablesFields;

namespace Photostudio
{
    //Статический класс для работы с таблицами
    public static class TablesClass
    {
        //Переменная для выбора таблицы. По умолчанию выбрана таблица ORDERS
        public static string SelectedTable = Tables.ORDERS.Name();

        //Все таблицы и названия таблиц на русском языке
        public static readonly Dictionary<string, string> TableDisplay = new Dictionary<string, string> {
            //{ TablesFields.Tables.ORDERS.ToString(), "Заказы" },
            { Tables.ORDERS.Name(), "Заказы" },
            { Tables.PHOTOGRAPHERS.Name(), "Фотографы" },
            { Tables.ASSISTANTS.Name(), "Ассистенты" },
            { Tables.CUSTOMERS.Name(), "Заказчики" },
            { Tables.SERVICES.Name(), "Услуги" },
            { Tables.ASSISTANCE.Name(), "Помощь" },
        };

        //Все таблицы и их описание
        public static readonly Dictionary<string, string> TableDescription = new Dictionary<string, string>
        {
            { Tables.ORDERS.Name(), "Таблица представляет собой заказы фотостудии. Содержит код заказа, " +
                "клиента, фотографа, ассистента если имеется, услугу, дату выполнения и выполнен ли заказ." },
            { Tables.PHOTOGRAPHERS.Name(), "Таблица представляет собой фотографов. Содержит код фотографа, " +
                "фамилию, имя, отчество, стаж работы, дату рождения, телефон и адрес." },
            { Tables.ASSISTANTS.Name(), "Таблица представляет собой ассистентов. Содержит код ассистента, " +
                "фамилию, имя, отчество и телефон." },
            { Tables.CUSTOMERS.Name(), "Таблица представляет собой заказчиков. Содержит код заказчика, " +
                "фамилию, имя, отчество, адрес и телефон." },
            { Tables.SERVICES.Name(), "Таблица представляет собой услуги фотостудии. Содержит код услуги, " +
                "описание и цену." },
            { Tables.ASSISTANCE.Name(), "Таблица представляет собой помощь ассистентов в заказе. Содержит код помощи, " +
                "ассистента и заказ." }
        };

        //Метод для нахождения GroupBox и установки его видимости
        public static void ShowGroupBox(Control.ControlCollection gbCollection)
        {
            //Форматирует выбранную таблицу: Первая буква заглавная, остальные строчные и к ним добавлятеся постфикс GB
            gbCollection.Find(SelectedTable[0] + SelectedTable.ToLower().Remove(0, 1) + "GB", false)[0].Visible = true;
            //MessageBox.Show(ServicesFileds.SerCode.ToString());
        }

        //Подключение к базе данных
        private static readonly string CurrentDir = Path.GetDirectoryName(Path.GetDirectoryName(Environment.CurrentDirectory));
        private static readonly string ConnString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={CurrentDir}\db.mdb;Persist Security Info=False;";
        private static readonly OleDbConnection Conn = new OleDbConnection(ConnString);

        //Команда SQL
        private static readonly OleDbCommand DbCommand = new OleDbCommand();

        
        //Специальный DataSet для таблицы ASSISTANCE
        private static DataSet AssisntaceDataser()
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            DbCommand.CommandText = $"select ORDERS.ORD_Code,('Фотограф: ' + PHOTOGRAPHERS.PHO_Fullname + 'Заказчик: ' + CUSTOMERS.CUS_Fullname ) as PhoCus from (ORDERS inner join PHOTOGRAPHERS on ORDERS.ORD_PhoCode = PHOTOGRAPHERS.PHO_Code) inner join CUSTOMERS on ORDERS.ORD_CusCode = CUSTOMERS.CUS_Code";
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(DbCommand);
            da.Fill(ds, SelectedTable);
            return ds;
        }

        public static void FillComboBoxAssistance(ComboBox comboBox)
        {
            comboBox.DataSource = AssisntaceDataser().Tables[0];
            comboBox.DisplayMember = "PhoCus";
            comboBox.ValueMember = "ORD_Code";
            Conn.Close();
        }

        //Возвращает DataSet таблицы table
        private static DataSet NewDataSet(string table)
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            DbCommand.CommandText = $"select * from {table}";
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(DbCommand);
            da.Fill(ds, SelectedTable);
            return ds;
        }

        //Обновление DataGridView
        public static void RefreshGrid(DataGridView dataGrid)
        {
            dataGrid.DataSource = NewDataSet(SelectedTable);
            dataGrid.DataMember = SelectedTable;
            Conn.Close();
        }

        
        //Заполнение ComboBox
        public static void FillComboBox(ComboBox comboBox, string table, string display, string value)
        {
            comboBox.DataSource = NewDataSet(table).Tables[0];
            comboBox.DisplayMember = display;
            comboBox.ValueMember = value;
            Conn.Close();
        }

        //Добавление записи
        public static void AddRecord(string table, Dictionary<string,string> colval)
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            string values = "", columns = "";
            for (int i = 0; i < colval.Count; i++)
            {
                columns += $"{colval.ElementAt(i).Key},";
                values += $"'{colval.ElementAt(i).Value}',";
            }
            columns = columns.Remove(columns.Length - 1, 1);
            values = values.Remove(values.Length - 1, 1);
            try
            {
                DbCommand.CommandText = $"INSERT INTO {table}({columns}) VALUES({values});";
                DbCommand.ExecuteNonQuery();
                MessageBox.Show(@"Запись добавлена!", @"Успешно", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Запись не добавлена!", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Console.WriteLine(e);
                throw;
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
