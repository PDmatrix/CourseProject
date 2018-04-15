using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using static Photostudio.TablesFields;
using System.Reflection;

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

        private void reportBtn_Click(object sender, EventArgs e)
        {
            var dbTable = TablesClass.TableDisplay[TablesClass.SelectedTable];
            var dialogResult = MessageBox.Show(@"Вы действительно хотите составить отчет по таблице " + dbTable,
                @"Отчет", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Word._Application application = new Word.Application();
                Word._Document document = application.Documents.Add();
                Word.Paragraph paragraph = document.Content.Paragraphs.Add();
                paragraph.Range.Text = TablesClass.TableDisplay[TablesClass.SelectedTable];

                paragraph.Range.Font.Bold = 16;
                paragraph.Range.Font.Size = 14;
                paragraph.Range.Font.Name = "Times New Roman";
                paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                paragraph.Range.InsertParagraphAfter();

                paragraph.Range.Font.Bold = 0;
                paragraph.Range.Font.Size = 12;
                paragraph.Range.Font.Name = "Times New Roman";
                paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                var list = new List<List<string>>();
                if (TablesClass.SelectedTable == Tables.ORDERS.Name())
                {
                    list = TablesClass.GetList(TablesClass.SelectedTable,
                        new Dictionary<string, Dictionary<string, string>>
                        {
                            {
                                Tables.CUSTOMERS.Name(),
                                new Dictionary<string, string>
                                {
                                    {CustomerFields.CUS_Fullname.Name(), CustomerFields.CUS_Code.Name()}
                                }
                            },
                            {
                                Tables.PHOTOGRAPHERS.Name(),
                                new Dictionary<string, string>
                                {
                                    {PhotographersFileds.PHO_Fullname.Name(), PhotographersFileds.PHO_Code.Name()}
                                }
                            },
                            {
                                Tables.SERVICES.Name(),
                                new Dictionary<string, string>
                                {
                                    {ServicesFileds.SER_Description.Name(), ServicesFileds.SER_Code.Name()}
                                }
                            }
                        });
                }
                else if (TablesClass.SelectedTable == Tables.ASSISTANCE.Name())
                {
                    list = TablesClass.GetList(TablesClass.SelectedTable,
                        new Dictionary<string, Dictionary<string, string>>
                        {
                            {
                                Tables.ASSISTANTS.Name(),
                                new Dictionary<string, string>
                                {
                                    {AssistantsFileds.ASS_Fullname.Name(), AssistantsFileds.ASS_Code.Name()}
                                }
                            },
                            {
                                Tables.ORDERS.Name(),
                                new Dictionary<string, string>
                                {
                                    {OrdersFileds.ORD_Date.Name(), OrdersFileds.ORD_Code.Name()}
                                }
                            },
                        });
                }
                else
                {
                    list = TablesClass.GetList(TablesClass.SelectedTable);
                }
                var numCols = TablesClass.FieldsDisplay.Count(r =>
                    r.Key.Substring(0,3) == TablesClass.SelectedTable.Substring(0,3).ToUpper());
                Word.Table table = document.Tables.Add(paragraph.Range, list.Count, numCols);

                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 0; j < numCols; j++)
                    {
                        table.Cell(i + 1, j + 1).Range.Text = list[i][j];
                    }
                }
                application.Visible = true;
            }
        }
    }
}
