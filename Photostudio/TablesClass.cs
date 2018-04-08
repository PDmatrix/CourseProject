﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
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


        public static readonly Dictionary<string, string> FieldsDisplay = new Dictionary<string, string>
        {
            {AssistantsFileds.ASS_Code.Name(), "Код заказа"},
            {AssistantsFileds.ASS_Fullname.Name(), "ФИО ассистента"},
            {AssistantsFileds.ASS_Phone.Name(), "Номер телефона"},

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
                                             "ФИО, стаж работы, дату рождения, телефон и адрес."
            },
            {
                Tables.ASSISTANTS.Name(), "Таблица представляет собой ассистентов. Содержит код ассистента, " +
                                          "ФИО и телефон."
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
            $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={CurrentDir}\db.mdb;Persist Security Info=False;";

        private static readonly OleDbConnection Conn = new OleDbConnection(ConnString);

        //Команда SQL
        private static readonly OleDbCommand DbCommand = new OleDbCommand();

        //Метод для нахождения GroupBox и установки его видимости
        public static void ShowGroupBox(Control.ControlCollection gbCollection)
        {
            //Форматирует выбранную таблицу: Первая буква заглавная, остальные строчные и к ним добавлятеся постфикс GB
            gbCollection.Find(SelectedTable[0] + SelectedTable.ToLower().Remove(0, 1) + "GB", false)[0].Visible = true;
        }

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
                //Console.WriteLine(e);
            }
            finally
            {
                Conn.Close();
            }
        }
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

        public static string Abbrivation(string fullname, char symbol = ' ')
        {
            var namesplit = fullname.Split(symbol);
            var sec = namesplit[1][0].ToString() == '﻿'.ToString() ? namesplit[1][1] : namesplit[1][0];
            return $"{namesplit[0]} {sec}. {namesplit[2][0]}.";
        }
    }
}