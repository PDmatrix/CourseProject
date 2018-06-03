using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Photostudio.TablesFields;

namespace Photostudio
{
    //Статический класс для работы с таблицами
    public static class TablesClass
    {
        

        //Переменная для выбора таблицы. По умолчанию выбрана таблица ORDERS
        public static string SelectedTable = Tables.ORDERS.Name();

        public static string Rights;

        //Все таблицы и названия таблиц на русском языке
        public static readonly Dictionary<string, string> TableDisplay = new Dictionary<string, string>
        {
            //{ TablesFields.Tables.ORDERS.ToString(), "Заказы" },
            {Tables.ORDERS.Name(), "Заказы"},
            {Tables.PHOTOGRAPHERS.Name(), "Фотографы"},
            {Tables.ASSISTANTS.Name(), "Ассистенты"},
            {Tables.CUSTOMERS.Name(), "Заказчики"},
            {Tables.SERVICES.Name(), "Услуги"},
            {Tables.ASSISTANCE.Name(), "Помощь"}
        };
        
        //Все поля базы даынных и названия на русском
        public static readonly Dictionary<string, string> FieldsDisplay = new Dictionary<string, string>
        {
            {AssistantsFileds.ASS_Code.Name(), "Код заказа"},
            {AssistantsFileds.ASS_Fullname.Name(), "ФИО ассистента"},
            {AssistantsFileds.ASS_Phone.Name(), "Номер телефона"},
            {AssistantsFileds.ASS_Salary.Name(), "Зарплата"},

            {CustomerFields.CUS_Code.Name(), "Код заказчика"},
            {CustomerFields.CUS_Fullname.Name(), "ФИО заказчика"},
            {CustomerFields.CUS_Adress.Name(), "Адрес заказчика"},
            {CustomerFields.CUS_Phone.Name(), "Номер телефона"},

            {OrdersFileds.ORD_Code.Name(), "Код заказа"},
            {OrdersFileds.ORD_CusCode.Name(), "Код заказчика"},
            {OrdersFileds.ORD_Date.Name(), "Дата выполнения"},
            {OrdersFileds.ORD_Exec.Name(), "Статус заказа"},
            {OrdersFileds.ORD_PhoCode.Name(), "Код фотографа"},
            {OrdersFileds.ORD_SerCode.Name(), "Код услуги"},

            {PhotographersFileds.PHO_Code.Name(), "Код фотографа"},
            {PhotographersFileds.PHO_Adress.Name(), "Адрес"},
            {PhotographersFileds.PHO_Date.Name(), "Дата рождения"},
            {PhotographersFileds.PHO_Experience.Name(), "Опыт"},
            {PhotographersFileds.PHO_Fullname.Name(), "ФИО фотографа"},
            {PhotographersFileds.PHO_Phone.Name(), "Номер телефона"},
            {PhotographersFileds.PHO_Salary.Name(), "Зарплата"},

            {ServicesFileds.SER_Code.Name(), "Код услуги"},
            {ServicesFileds.SER_Description.Name(), "Описание"},
            {ServicesFileds.SER_Price.Name(), "Цена"},

            {AssistanceFileds.ASCE_Code.Name(), "Код помощи"},
            {AssistanceFileds.ASCE_AssCode.Name(), "Код помощника"},
            {AssistanceFileds.ASCE_OrdCode.Name(), "Код заказа"}
        };

        //Все таблицы и их описание
        public static readonly Dictionary<string, string> TableDescription = new Dictionary<string, string>
        {
            {
                Tables.ORDERS.Name(), "Таблица представляет собой заказы фотостудии. Содержит код заказа, " +
                                      "клиента, фотографа, ассистента если имеется, услугу, дату выполнения и выполнен ли заказ."
            },
            {
                Tables.PHOTOGRAPHERS.Name(), "Таблица представляет собой фотографов. Содержит код фотографа, " +
                                             "ФИО, стаж работы, дату рождения, телефон, адрес и зарплату"
            },
            {
                Tables.ASSISTANTS.Name(), "Таблица представляет собой ассистентов. Содержит код ассистента, " +
                                          "ФИО, телефон и зарплату."
            },
            {
                Tables.CUSTOMERS.Name(), "Таблица представляет собой заказчиков. Содержит код заказчика, " +
                                         "ФИО, адрес и телефон."
            },
            {
                Tables.SERVICES.Name(), "Таблица представляет собой услуги фотостудии. Содержит код услуги, " +
                                        "описание и цену."
            },
            {
                Tables.ASSISTANCE.Name(),
                "Таблица представляет собой помощь ассистентов в заказе. Содержит код помощи, " +
                "ассистента и заказ."
            }
        };

        //Подключение к базе данных
        private static readonly string CurrentDir =
            Path.GetDirectoryName(Path.GetDirectoryName(Environment.CurrentDirectory));

        private static readonly string ConnString =
            $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db.mdb;Persist Security Info=False;";

        private static readonly OleDbConnection Conn = new OleDbConnection(ConnString);

        //Команда SQL
        private static readonly OleDbCommand DbCommand = new OleDbCommand();

        //Метод для нахождения GroupBox и установки его видимости
        public static void ShowGroupBox(Control.ControlCollection gbCollection)
        {
            //Форматирует выбранную таблицу: Первая буква заглавная, остальные строчные и к ним добавлятеся постфикс GB
            gbCollection.Find(SelectedTable[0] + SelectedTable.ToLower().Remove(0, 1) + "GB", false)[0].Visible = true;
        }

        //Специальное заполнение ComboBox
        public static void FillComboBoxAssistance(ComboBox comboBox)
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            DbCommand.CommandText =
                "select ORDERS.ORD_Code,(CUSTOMERS.CUS_Fullname + ';' + PHOTOGRAPHERS.PHO_Fullname + ';') as PhoCus from (ORDERS inner join PHOTOGRAPHERS on ORDERS.ORD_PhoCode = PHOTOGRAPHERS.PHO_Code) inner join CUSTOMERS on ORDERS.ORD_CusCode = CUSTOMERS.CUS_Code";
            var ds = new DataSet();
            var da = new OleDbDataAdapter(DbCommand);
            da.Fill(ds, SelectedTable);
            comboBox.DataSource = ds.Tables[0];
            comboBox.DisplayMember = "PhoCus";
            comboBox.ValueMember = "ORD_Code";
            Conn.Close();
        }

        //Специальное заполнение ComboBox
        public static void FillComboBoxFindAssistance(ComboBox comboBox)
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            DbCommand.CommandText =
                "select ASSISTANCE.ASCE_Code,(ASSISTANTS.ASS_Fullname + ';' + CUSTOMERS.CUS_Fullname + ';' + PHOTOGRAPHERS.PHO_Fullname + ';') as AssPhoCus from (((ASSISTANCE inner join ORDERS on ASSISTANCE.ASCE_OrdCode = ORDERS.ORD_Code) inner join PHOTOGRAPHERS on ORDERS.ORD_PhoCode = PHOTOGRAPHERS.PHO_Code) inner join CUSTOMERS on ORDERS.ORD_CusCode = CUSTOMERS.CUS_Code) inner join ASSISTANTS on ASSISTANCE.ASCE_AssCode = ASSISTANTS.ASS_Code";
            var ds = new DataSet();
            var da = new OleDbDataAdapter(DbCommand);
            da.Fill(ds, SelectedTable);
            comboBox.DataSource = ds.Tables[0];
            comboBox.DisplayMember = "AssPhoCus";
            comboBox.ValueMember = "ASCE_Code";
            Conn.Close();
        }

        //Возвращает DataSet таблицы table
        private static DataSet NewDataSet(string table)
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            DbCommand.CommandText = $"select * from {table}";
            var ds = new DataSet();
            var da = new OleDbDataAdapter(DbCommand);
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
        public static void AddRecord(string table, Dictionary<string, string> colval)
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            string values = "", columns = "";
            for (var i = 0; i < colval.Count; i++)
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
                MessageBox.Show(@"Запись не добавлена!" + Environment.NewLine + e.Message, @"Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                Conn.Close();
            }
        }

        //Обновление записи
        public static void EditRecord(string table, Dictionary<string, string> id, Dictionary<string, string> colval)
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            string vals = "";
            for (var i = 0; i < colval.Count; i++)
            {
                vals += $"{colval.ElementAt(i).Key} = '{colval.ElementAt(i).Value}',";
            }
            vals = vals.Remove(vals.Length - 1, 1);
            try
            {
                DbCommand.CommandText = $"UPDATE {table} SET {vals} WHERE {id.First().Key} = {id.First().Value};";
                DbCommand.ExecuteNonQuery();
                MessageBox.Show(@"Запись изменена!", @"Успешно", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Ошибка редактирования!" + Environment.NewLine + e.Message, @"Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
                //Console.WriteLine(e);
            }
            finally
            {
                Conn.Close();
            }
        }

        //Простой поиск записи
        public static string FindRecord(string table, string cond)
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            DbCommand.CommandText = $"select * from {table} where {cond}";
            string ret = "";
            try
            {
                using (OleDbDataReader reader = DbCommand.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        for (int i = 1; i < reader.FieldCount; i++)
                        {
                            ret = ret + FieldsDisplay[reader.GetName(i)] + ": " +
                                  (reader.GetValue(i).GetType().IsEquivalentTo(typeof(DateTime))
                                      ? reader.GetDateTime(i).ToShortDateString()
                                      : reader.GetValue(i)) + '\n';
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Запись не найдена!" + Environment.NewLine + e.Message, @"Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                Conn.Close();
            }
            return ret;
        }

        //Поиск записи и замена найденных кодов на значения
        public static string FindRecord(string table, string cond, Dictionary<string, Dictionary<string, string>> vals)
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            DbCommand.CommandText = $"select * from {table} where {cond}";
            List<string> name = new List<string>();
            List<string> val = new List<string>();
            try
            {
                using (OleDbDataReader reader = DbCommand.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        for (int i = 1; i < reader.FieldCount; i++)
                        {
                            name.Add(FieldsDisplay[reader.GetName(i)]);
                            val.Add(reader.GetValue(i).GetType().IsEquivalentTo(typeof(DateTime))
                                ? reader.GetDateTime(i).ToShortDateString()
                                : (reader.GetValue(i).ToString() == "False")
                                    ? "Не выполнен"
                                    : (reader.GetValue(i).ToString() == "True")
                                        ? "Выполнен"
                                        : reader.GetValue(i).ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Ошибка при поиске!" + Environment.NewLine + e.Message, @"Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                Conn.Close();
            }
            List<string> conds = new List<string>(val.Where(r => int.TryParse(r, out int _)));
            if (conds.Count != vals.Count)
            {
                throw new Exception("Не совпадает длина параметров");
            }

            string ret = "";
            try
            {
                Conn.Open();
                DbCommand.Connection = Conn;
                int i;
                for (i = 0; i < conds.Count; i++)
                {
                    DbCommand.CommandText = $"select {vals.ElementAt(i).Value.ElementAt(0).Key} from {vals.ElementAt(i).Key} where {vals.ElementAt(i).Value.ElementAt(0).Value} = {conds[i]}";
                    using (OleDbDataReader reader = DbCommand.ExecuteReader())
                    {
                        while (reader != null && reader.Read())
                        {
                            for (int j = 0; j < vals.ElementAt(i).Value.ElementAt(0).Key.Split(',').Length; j++)
                            {
                                ret = ret + FieldsDisplay[reader.GetName(j)] + ": " + (reader.GetValue(j).GetType().IsEquivalentTo(typeof(DateTime))
                                          ? reader.GetDateTime(j).ToShortDateString()
                                          : (reader.GetValue(j).ToString() == "False")
                                              ? "Не выполнен"
                                              : (reader.GetValue(j).ToString() == "True")
                                                  ? "Выполнен"
                                                  : reader.GetValue(j).ToString()) + '\n';
                            }
                            val.Remove(val.First());
                            name.Remove(name.First());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Ошибка при поиске!" + Environment.NewLine + e.Message, @"Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                Conn.Close();
            }
            for (int i = 0; i < val.Count; i++)
            {
                ret = ret + name[i] + ": " + val[i] + '\n';
            }
            return ret;
        }

        //Удаление записи
        public static void DeleteRecord(string table, string cond)
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            try
            {
                DbCommand.CommandText = $"delete from {table} where {cond}";
                DbCommand.ExecuteNonQuery();
                MessageBox.Show(@"Запись удалена!", @"Успешно", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Ошибка при удалении!" + Environment.NewLine + e.Message, @"Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
                //Console.WriteLine(e);
            }
            finally
            {
                Conn.Close();
            }
        }

        //Изменение полного имени на аббривиатуру
        private static string Abbrivation(string fullname, char symbol = ' ')
        {
            var namesplit = fullname.Split(symbol);
            var sec = namesplit[1][0].ToString() == '﻿'.ToString() ? namesplit[1][1] : namesplit[1][0];
            return $"{namesplit[0]} {sec}. {namesplit[2][0]}.";
        }

        //Обновление текстовых и других элементов
        public static void ChangeText(Control.ControlCollection gbCollection, string table, string cond, Dictionary<Control, string> ctrlField)
        {
            string fields = "";
            foreach (var item in ctrlField)
            {
                fields = fields + item.Value + ',';
            }
            fields = fields.Remove(fields.Length - 1, 1);
            if (Conn.State != ConnectionState.Closed)
            {
                Conn.Close();
            }
            Conn.Open();
            DbCommand.Connection = Conn;
            DbCommand.CommandText = $"select {fields} from {table} where {cond}";
            try
            {
                using (OleDbDataReader reader = DbCommand.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var control = gbCollection.Find(ctrlField.ElementAt(i).Key.Name, true)[0];
                            if (control is CheckBox checkBox)
                            {
                                checkBox.Checked = Convert.ToBoolean(reader.GetValue(i).ToString());
                            }
                            else if(control is ComboBox comboBox)
                            {
                                comboBox.SelectedValue = Convert.ToInt32(reader.GetValue(i));
                            }
                            else
                            {
                                control.Text = reader.GetValue(i).ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Ошибка при изменении текста!" + Environment.NewLine + e.Message, @"Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                Conn.Close();
            }
        }

        //Форматирование ComboBox
        public static void Format(ref ListControlConvertEventArgs listControl, string format)
        {
            try
            {
                string[] names = listControl.Value.ToString().Split(';');
                for (var i = 0; i < names.Length - 1; i++)
                {
                        names[i] = Abbrivation(names[i]);
                }
                listControl.Value = string.Format(format, names.ToArray<object>());
            }
            catch
            {
                // ignored
            }
        }

        //Простой список записей
        public static List<List<string>> GetList(string table)
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            DbCommand.CommandText = $"select * from {table}";
            List<List<string>> list = new List<List<string>>();
            try
            {
                using (OleDbDataReader reader = DbCommand.ExecuteReader())
                {
                    var headers = false;
                    while (reader != null && reader.Read())
                    {
                        List<string> tempList = new List<string>();
                        List<string> headList = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (!headers)
                            {
                                headList.Add(FieldsDisplay[reader.GetName(i)]);
                            }
                            tempList.Add(reader.GetValue(i).GetType().IsEquivalentTo(typeof(DateTime))
                                ? reader.GetDateTime(i).ToShortDateString()
                                : (reader.GetValue(i).ToString() == "False")
                                    ? "Не выполнен"
                                    : (reader.GetValue(i).ToString() == "True")
                                        ? "Выполнен"
                                        : reader.GetValue(i).ToString());
                        }
                        if (!headers)
                        {
                            list.Add(headList);
                        }
                        list.Add(tempList);
                        headers = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Ошибка при поиске!" + Environment.NewLine + e.Message, @"Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                Conn.Close();
            }

            return list;
        }

        //Список записей с заменой
        public static List<List<string>> GetList(string table, Dictionary<string, Dictionary<string, string>> vals)
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            DbCommand.CommandText = $"select * from {table}";
            List<List<string>> list = new List<List<string>>();
            try
            {
                using (OleDbDataReader reader = DbCommand.ExecuteReader())
                {
                    var headers = false;
                    while (reader != null && reader.Read())
                    {
                        List<string> tempList = new List<string>();
                        List<string> headList = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (!headers)
                            {
                                headList.Add(FieldsDisplay[reader.GetName(i)]);
                            }
                            tempList.Add(reader.GetValue(i).GetType().IsEquivalentTo(typeof(DateTime))
                                ? reader.GetDateTime(i).ToShortDateString()
                                : (reader.GetValue(i).ToString() == "False")
                                    ? "Не выполнен"
                                    : (reader.GetValue(i).ToString() == "True")
                                        ? "Выполнен"
                                        : reader.GetValue(i).ToString());
                        }
                        if (!headers)
                        {
                            list.Add(headList);
                        }
                        list.Add(tempList);
                        headers = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Ошибка при поиске!" + Environment.NewLine + e.Message, @"Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                Conn.Close();
            }
            try
            {
                Conn.Open();
                DbCommand.Connection = Conn;
                int i;
                var headers = false;
                for (i = 1; i < list.Count; i++)
                {
                    var conds = new List<string>(list[i].Where(r => int.TryParse(r, out int _)));
                    conds.RemoveAt(0);
                    for (int j = 0; j < conds.Count; j++)
                    {
                        DbCommand.CommandText = $"select {vals.ElementAt(j).Value.ElementAt(0).Key} from {vals.ElementAt(j).Key} where {vals.ElementAt(j).Value.ElementAt(0).Value} = {conds[j]}";
                        using (OleDbDataReader reader = DbCommand.ExecuteReader())
                        {
                            
                            while (reader != null && reader.Read())
                            {
                                for (int l = 0; l < vals.ElementAt(j).Value.ElementAt(0).Key.Split(',').Length; l++)
                                {
                                    var temp = reader.GetValue(l).GetType().IsEquivalentTo(typeof(DateTime))
                                     ? reader.GetDateTime(l).ToShortDateString()
                                     : (reader.GetValue(l).ToString() == "False")
                                         ? "Не выполнен"
                                         : (reader.GetValue(l).ToString() == "True")
                                             ? "Выполнен"
                                             : reader.GetValue(l).ToString();
                                    list[i][j + 1] = temp;
                                    if (!headers)
                                    {
                                        list[0][j + 1] = FieldsDisplay[reader.GetName(l)];
                                    } 
                                }
                            }
                        }
                    }
                    headers = true;
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(@"Ошибка при поиске!" + Environment.NewLine + e.Message, @"Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                Conn.Close();
            }

            return list;
        }

        //Сводка за месяц
        public static string GetSummary()
        {
            Conn.Open();
            DbCommand.Connection = Conn;
            DbCommand.CommandText = "SELECT ORDERS.ORD_Code, PHOTOGRAPHERS.PHO_Salary, SERVICES.SER_Price, ORDERS.ORD_Date FROM SERVICES INNER JOIN (PHOTOGRAPHERS INNER JOIN ORDERS ON PHOTOGRAPHERS.PHO_Code = ORDERS.ORD_PhoCode) ON SERVICES.SER_Code = ORDERS.ORD_SerCode;";
            int income = 0, consumption = 0, numOrd = 0;
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);       
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);
            try
            {
                using (OleDbDataReader reader = DbCommand.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        if (Convert.ToDateTime(reader.GetValue(3)) < first ||
                            Convert.ToDateTime(reader.GetValue(3)) > last) continue;
                        numOrd++;
                        income += Convert.ToInt32(reader.GetValue(2));
                        consumption += Convert.ToInt32(reader.GetValue(1));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Ошибка при поиске!" + Environment.NewLine + e.Message, @"Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                Conn.Close();
            }
            Conn.Open();
            DbCommand.Connection = Conn;
            DbCommand.CommandText = "SELECT ORDERS.ORD_Date, ASSISTANTS.ASS_Salary FROM ASSISTANTS INNER JOIN (ORDERS INNER JOIN ASSISTANCE ON ORDERS.ORD_Code = ASSISTANCE.ASCE_OrdCode) ON ASSISTANTS.ASS_Code = ASSISTANCE.ASCE_AssCode;";
            try
            {
                using (OleDbDataReader reader = DbCommand.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        if (Convert.ToDateTime(reader.GetValue(0)) < first ||
                            Convert.ToDateTime(reader.GetValue(0)) > last) continue;
                        
                        consumption += Convert.ToInt32(reader.GetValue(1));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Ошибка при поиске!" + Environment.NewLine + e.Message, @"Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                Conn.Close();
            }
            return  $"Количество заказов: {numOrd}\n" +
                    $"Доход: {income} руб.\n" +
                    $"Расход: {consumption} руб.\n" +
                    $"Чистый заработок: {income - consumption} руб.";;
        }
    }
}