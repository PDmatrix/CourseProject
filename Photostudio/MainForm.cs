using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            rightsLabel.Text = "Роль: " + TablesClass.Rights;

            if(TablesClass.Rights.Equals("Администратор"))
            {
                mainAdminPanel.Visible = true;
            } 
            else
            {
                mainOperPanel.Visible = true;
            }
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e) => SelectTable(Tables.ORDERS.Name());

        private void фотографыToolStripMenuItem_Click(object sender, EventArgs e) => SelectTable(Tables.PHOTOGRAPHERS.Name());

        private void ассистентыToolStripMenuItem_Click(object sender, EventArgs e) => SelectTable(Tables.ASSISTANTS.Name());

        private void заказчикиToolStripMenuItem_Click(object sender, EventArgs e) => SelectTable(Tables.CUSTOMERS.Name());

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e) => SelectTable(Tables.SERVICES.Name());

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e) => SelectTable(Tables.ASSISTANCE.Name());

        private void addRecBtn_Click(object sender, EventArgs e) => ShowForm<AddRecForm>();

        private void editRecBtn_Click(object sender, EventArgs e) => ShowForm<EditRecForm>();

        private void findRecBtn_Click(object sender, EventArgs e) => ShowForm<FindRecForm>();

        private void deleteRecBtn_Click(object sender, EventArgs e) => ShowForm<DeleteRecForm>();

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void reportBtn_Click(object sender, EventArgs e)
        {
            reportAdminPanel.Visible = true;
            mainAdminPanel.Visible = false;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Данное СУБД позволяет вносить запись, редактировать запись, удалять запись, искать запись " +
                            @"и составлять отчет по выбранной таблице." + Environment.NewLine +
                            @"Выбор таблицы осуществляется на нажатие кнопки меню Таблицы." + Environment.NewLine, @"Помощь");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void backBtn_Click(object sender, EventArgs e)
        {
            mainAdminPanel.Visible = true;
            reportAdminPanel.Visible = false;
        }

        private void TableReport()
        {
            var dbTable = TablesClass.TableDisplay[TablesClass.SelectedTable];
            var dialogResult = MessageBox.Show(@"Вы действительно хотите составить отчет по таблице " + dbTable,
                @"Отчет", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            Word._Application application = new Word.Application();
            Word._Document document = application.Documents.Add();
            Word.Paragraph paragraph = document.Content.Paragraphs.Add();
            application.Visible = true;
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

            List<List<string>> list;
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
        }

        private void tableReportBtn_Click(object sender, EventArgs e)
        {
            TableReport();
        }

        private void planBtn_Click(object sender, EventArgs e)
        {
            ShowForm<MakePlanForm>();
        }

        private void MonthSum()
        {
            var dialogResult = MessageBox.Show(@"Вы действительно хотите получить сводку за " +
                $@"{DateTime.Now.AddMonths(-1).ToString("MMMM").ToLower()} {DateTime.Now.AddMonths(-1).Year} года" ,
                @"Получение сводки", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            Word._Application application = new Word.Application();
            Word._Document document = application.Documents.Add();
            Word.Paragraph paragraph = document.Content.Paragraphs.Add();
            application.Visible = true;
            
            paragraph.Range.Font.Bold = 0;
            paragraph.Range.Font.Size = 14;
            paragraph.Range.Font.Name = "Times New Roman";
            paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            paragraph.Range.Text ="Сводка за " + DateTime.Now.AddMonths(-1).ToString("MMMM") + " " + DateTime.Now.AddMonths(-1).Year + "\n" + TablesClass.GetSummary();
        }

        private void monthSummaryBtn_Click(object sender, EventArgs e)
        {
            MonthSum();
        }

        private void viewPlanBtn_Click(object sender, EventArgs e)
        {
            ShowForm<ViewPlanForm>();
        }

        private void сменитьПраваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<PasswordForm>();
            this.Hide();
        }

        private void findOperBtn_Click(object sender, EventArgs e)
        {
            ShowForm<FindRecForm>();
        }

        private void reportOperBtn_Click(object sender, EventArgs e)
        {
            reportOperPanel.Visible = true;
            mainOperPanel.Visible = false;
        }

        private void checkPlnBtn_Click(object sender, EventArgs e)
        {
            ShowForm<ViewPlanForm>();
        }

        private void sumMonthBtn_Click(object sender, EventArgs e)
        {
            MonthSum();
        }

        private void tableReportOperBtn_Click(object sender, EventArgs e)
        {
            TableReport();
        }

        private void backOperBtn_Click(object sender, EventArgs e)
        {
            reportOperPanel.Visible = false;
            mainOperPanel.Visible = true;
        }
    }
}
