using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace Photostudio
{
    public partial class MakePlanForm : Form
    {
        public MakePlanForm()
        {
            InitializeComponent();
        }

        private void makePlanBTN_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Вы действительно хотите составить план за " + monthTB.Text.ToLower() + @" " + yearTB.Text + @" года?",
                @"Создание плана", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            _Application application = new Application();
            _Document document = application.Documents.Add();
            Paragraph paragraph = document.Content.Paragraphs.Add();
            application.Visible = true;

            paragraph.Range.Font.Bold = 0;
            paragraph.Range.Font.Size = 14;
            paragraph.Range.Font.Name = "Times New Roman";
            paragraph.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            paragraph.Range.Text = $"Дата: {monthTB.Text.ToLower()} {yearTB.Text} год\n" +
                                   $"Количество заказов: {numOrdersTB.Text}\n" +
                                   $"Доход: {incomeTB.Text} руб.\n" +
                                   $"Расход: {consumptionTB.Text} руб.\n" +
                                   $"Чистый заработок: {Convert.ToInt32(incomeTB.Text) - Convert.ToInt32(consumptionTB.Text)} руб.";
            document.SaveAs(Environment.CurrentDirectory + "\\Планы\\" + monthTB.Text.ToLower() + "_" + yearTB.Text, WdSaveFormat.wdFormatDocumentDefault);
        }
    }
}
