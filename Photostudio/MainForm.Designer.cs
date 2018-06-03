namespace Photostudio
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПраваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фотографыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ассистентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказчикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedTableLabel = new System.Windows.Forms.Label();
            this.addRecBtn = new System.Windows.Forms.Button();
            this.editRecBtn = new System.Windows.Forms.Button();
            this.findRecBtn = new System.Windows.Forms.Button();
            this.deleteRecBtn = new System.Windows.Forms.Button();
            this.tableDescription = new System.Windows.Forms.RichTextBox();
            this.reportBtn = new System.Windows.Forms.Button();
            this.mainAdminPanel = new System.Windows.Forms.Panel();
            this.reportAdminPanel = new System.Windows.Forms.Panel();
            this.viewPlanBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.monthSummaryBtn = new System.Windows.Forms.Button();
            this.planBtn = new System.Windows.Forms.Button();
            this.tableReportBtn = new System.Windows.Forms.Button();
            this.rightsLabel = new System.Windows.Forms.Label();
            this.mainOperPanel = new System.Windows.Forms.Panel();
            this.reportOperBtn = new System.Windows.Forms.Button();
            this.findOperBtn = new System.Windows.Forms.Button();
            this.reportOperPanel = new System.Windows.Forms.Panel();
            this.tableReportOperBtn = new System.Windows.Forms.Button();
            this.checkPlnBtn = new System.Windows.Forms.Button();
            this.backOperBtn = new System.Windows.Forms.Button();
            this.sumMonthBtn = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.mainAdminPanel.SuspendLayout();
            this.reportAdminPanel.SuspendLayout();
            this.mainOperPanel.SuspendLayout();
            this.reportOperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.таблицыToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(458, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.сменитьПраваToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // сменитьПраваToolStripMenuItem
            // 
            this.сменитьПраваToolStripMenuItem.Name = "сменитьПраваToolStripMenuItem";
            this.сменитьПраваToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.сменитьПраваToolStripMenuItem.Text = "Сменить права";
            this.сменитьПраваToolStripMenuItem.Click += new System.EventHandler(this.сменитьПраваToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem,
            this.фотографыToolStripMenuItem,
            this.ассистентыToolStripMenuItem,
            this.заказчикиToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // фотографыToolStripMenuItem
            // 
            this.фотографыToolStripMenuItem.Name = "фотографыToolStripMenuItem";
            this.фотографыToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.фотографыToolStripMenuItem.Text = "Фотографы";
            this.фотографыToolStripMenuItem.Click += new System.EventHandler(this.фотографыToolStripMenuItem_Click);
            // 
            // ассистентыToolStripMenuItem
            // 
            this.ассистентыToolStripMenuItem.Name = "ассистентыToolStripMenuItem";
            this.ассистентыToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ассистентыToolStripMenuItem.Text = "Ассистенты";
            this.ассистентыToolStripMenuItem.Click += new System.EventHandler(this.ассистентыToolStripMenuItem_Click);
            // 
            // заказчикиToolStripMenuItem
            // 
            this.заказчикиToolStripMenuItem.Name = "заказчикиToolStripMenuItem";
            this.заказчикиToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.заказчикиToolStripMenuItem.Text = "Заказчики";
            this.заказчикиToolStripMenuItem.Click += new System.EventHandler(this.заказчикиToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // selectedTableLabel
            // 
            this.selectedTableLabel.AutoSize = true;
            this.selectedTableLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectedTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedTableLabel.Location = new System.Drawing.Point(362, 24);
            this.selectedTableLabel.Margin = new System.Windows.Forms.Padding(4);
            this.selectedTableLabel.Name = "selectedTableLabel";
            this.selectedTableLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.selectedTableLabel.Size = new System.Drawing.Size(96, 20);
            this.selectedTableLabel.TabIndex = 1;
            this.selectedTableLabel.Text = "selectedTable";
            // 
            // addRecBtn
            // 
            this.addRecBtn.Location = new System.Drawing.Point(3, 3);
            this.addRecBtn.Name = "addRecBtn";
            this.addRecBtn.Size = new System.Drawing.Size(133, 27);
            this.addRecBtn.TabIndex = 2;
            this.addRecBtn.Text = "Добавить запись";
            this.addRecBtn.UseVisualStyleBackColor = true;
            this.addRecBtn.Click += new System.EventHandler(this.addRecBtn_Click);
            // 
            // editRecBtn
            // 
            this.editRecBtn.Location = new System.Drawing.Point(3, 36);
            this.editRecBtn.Name = "editRecBtn";
            this.editRecBtn.Size = new System.Drawing.Size(133, 27);
            this.editRecBtn.TabIndex = 3;
            this.editRecBtn.Text = "Редактировать запись";
            this.editRecBtn.UseVisualStyleBackColor = true;
            this.editRecBtn.Click += new System.EventHandler(this.editRecBtn_Click);
            // 
            // findRecBtn
            // 
            this.findRecBtn.Location = new System.Drawing.Point(3, 69);
            this.findRecBtn.Name = "findRecBtn";
            this.findRecBtn.Size = new System.Drawing.Size(133, 27);
            this.findRecBtn.TabIndex = 4;
            this.findRecBtn.Text = "Найти запись";
            this.findRecBtn.UseVisualStyleBackColor = true;
            this.findRecBtn.Click += new System.EventHandler(this.findRecBtn_Click);
            // 
            // deleteRecBtn
            // 
            this.deleteRecBtn.Location = new System.Drawing.Point(3, 102);
            this.deleteRecBtn.Name = "deleteRecBtn";
            this.deleteRecBtn.Size = new System.Drawing.Size(133, 27);
            this.deleteRecBtn.TabIndex = 5;
            this.deleteRecBtn.Text = "Удалить запись";
            this.deleteRecBtn.UseVisualStyleBackColor = true;
            this.deleteRecBtn.Click += new System.EventHandler(this.deleteRecBtn_Click);
            // 
            // tableDescription
            // 
            this.tableDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tableDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableDescription.Location = new System.Drawing.Point(179, 74);
            this.tableDescription.Name = "tableDescription";
            this.tableDescription.ReadOnly = true;
            this.tableDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableDescription.Size = new System.Drawing.Size(256, 135);
            this.tableDescription.TabIndex = 6;
            this.tableDescription.Text = "TableDescription";
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(3, 135);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(133, 27);
            this.reportBtn.TabIndex = 7;
            this.reportBtn.Text = "Отчеты";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // mainAdminPanel
            // 
            this.mainAdminPanel.Controls.Add(this.deleteRecBtn);
            this.mainAdminPanel.Controls.Add(this.reportBtn);
            this.mainAdminPanel.Controls.Add(this.addRecBtn);
            this.mainAdminPanel.Controls.Add(this.editRecBtn);
            this.mainAdminPanel.Controls.Add(this.findRecBtn);
            this.mainAdminPanel.Location = new System.Drawing.Point(12, 45);
            this.mainAdminPanel.Name = "mainAdminPanel";
            this.mainAdminPanel.Size = new System.Drawing.Size(161, 166);
            this.mainAdminPanel.TabIndex = 8;
            this.mainAdminPanel.Visible = false;
            // 
            // reportAdminPanel
            // 
            this.reportAdminPanel.Controls.Add(this.viewPlanBtn);
            this.reportAdminPanel.Controls.Add(this.backBtn);
            this.reportAdminPanel.Controls.Add(this.monthSummaryBtn);
            this.reportAdminPanel.Controls.Add(this.planBtn);
            this.reportAdminPanel.Controls.Add(this.tableReportBtn);
            this.reportAdminPanel.Location = new System.Drawing.Point(12, 45);
            this.reportAdminPanel.Name = "reportAdminPanel";
            this.reportAdminPanel.Size = new System.Drawing.Size(161, 166);
            this.reportAdminPanel.TabIndex = 9;
            this.reportAdminPanel.Visible = false;
            // 
            // viewPlanBtn
            // 
            this.viewPlanBtn.Location = new System.Drawing.Point(3, 69);
            this.viewPlanBtn.Name = "viewPlanBtn";
            this.viewPlanBtn.Size = new System.Drawing.Size(133, 27);
            this.viewPlanBtn.TabIndex = 12;
            this.viewPlanBtn.Text = "Посмотреть план";
            this.viewPlanBtn.UseVisualStyleBackColor = true;
            this.viewPlanBtn.Click += new System.EventHandler(this.viewPlanBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(3, 135);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(133, 27);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "<-- Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // monthSummaryBtn
            // 
            this.monthSummaryBtn.Location = new System.Drawing.Point(3, 102);
            this.monthSummaryBtn.Name = "monthSummaryBtn";
            this.monthSummaryBtn.Size = new System.Drawing.Size(133, 27);
            this.monthSummaryBtn.TabIndex = 10;
            this.monthSummaryBtn.Text = "Сводка за месяц";
            this.monthSummaryBtn.UseVisualStyleBackColor = true;
            this.monthSummaryBtn.Click += new System.EventHandler(this.monthSummaryBtn_Click);
            // 
            // planBtn
            // 
            this.planBtn.Location = new System.Drawing.Point(3, 36);
            this.planBtn.Name = "planBtn";
            this.planBtn.Size = new System.Drawing.Size(133, 27);
            this.planBtn.TabIndex = 9;
            this.planBtn.Text = "Составить план";
            this.planBtn.UseVisualStyleBackColor = true;
            this.planBtn.Click += new System.EventHandler(this.planBtn_Click);
            // 
            // tableReportBtn
            // 
            this.tableReportBtn.Location = new System.Drawing.Point(3, 6);
            this.tableReportBtn.Name = "tableReportBtn";
            this.tableReportBtn.Size = new System.Drawing.Size(133, 27);
            this.tableReportBtn.TabIndex = 8;
            this.tableReportBtn.Text = "Составить отчет";
            this.tableReportBtn.UseVisualStyleBackColor = true;
            this.tableReportBtn.Click += new System.EventHandler(this.tableReportBtn_Click);
            // 
            // rightsLabel
            // 
            this.rightsLabel.AutoSize = true;
            this.rightsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightsLabel.Location = new System.Drawing.Point(178, 47);
            this.rightsLabel.Margin = new System.Windows.Forms.Padding(4);
            this.rightsLabel.Name = "rightsLabel";
            this.rightsLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.rightsLabel.Size = new System.Drawing.Size(96, 20);
            this.rightsLabel.TabIndex = 10;
            this.rightsLabel.Text = "selectedTable";
            // 
            // mainOperPanel
            // 
            this.mainOperPanel.Controls.Add(this.reportOperBtn);
            this.mainOperPanel.Controls.Add(this.findOperBtn);
            this.mainOperPanel.Location = new System.Drawing.Point(12, 45);
            this.mainOperPanel.Name = "mainOperPanel";
            this.mainOperPanel.Size = new System.Drawing.Size(161, 166);
            this.mainOperPanel.TabIndex = 11;
            this.mainOperPanel.Visible = false;
            // 
            // reportOperBtn
            // 
            this.reportOperBtn.Location = new System.Drawing.Point(3, 39);
            this.reportOperBtn.Name = "reportOperBtn";
            this.reportOperBtn.Size = new System.Drawing.Size(133, 27);
            this.reportOperBtn.TabIndex = 7;
            this.reportOperBtn.Text = "Отчеты";
            this.reportOperBtn.UseVisualStyleBackColor = true;
            this.reportOperBtn.Click += new System.EventHandler(this.reportOperBtn_Click);
            // 
            // findOperBtn
            // 
            this.findOperBtn.Location = new System.Drawing.Point(3, 8);
            this.findOperBtn.Name = "findOperBtn";
            this.findOperBtn.Size = new System.Drawing.Size(133, 27);
            this.findOperBtn.TabIndex = 4;
            this.findOperBtn.Text = "Найти запись";
            this.findOperBtn.UseVisualStyleBackColor = true;
            this.findOperBtn.Click += new System.EventHandler(this.findOperBtn_Click);
            // 
            // reportOperPanel
            // 
            this.reportOperPanel.Controls.Add(this.tableReportOperBtn);
            this.reportOperPanel.Controls.Add(this.checkPlnBtn);
            this.reportOperPanel.Controls.Add(this.backOperBtn);
            this.reportOperPanel.Controls.Add(this.sumMonthBtn);
            this.reportOperPanel.Location = new System.Drawing.Point(12, 45);
            this.reportOperPanel.Name = "reportOperPanel";
            this.reportOperPanel.Size = new System.Drawing.Size(161, 166);
            this.reportOperPanel.TabIndex = 12;
            this.reportOperPanel.Visible = false;
            // 
            // tableReportOperBtn
            // 
            this.tableReportOperBtn.Location = new System.Drawing.Point(3, 69);
            this.tableReportOperBtn.Name = "tableReportOperBtn";
            this.tableReportOperBtn.Size = new System.Drawing.Size(133, 27);
            this.tableReportOperBtn.TabIndex = 13;
            this.tableReportOperBtn.Text = "Составить отчет";
            this.tableReportOperBtn.UseVisualStyleBackColor = true;
            this.tableReportOperBtn.Click += new System.EventHandler(this.tableReportOperBtn_Click);
            // 
            // checkPlnBtn
            // 
            this.checkPlnBtn.Location = new System.Drawing.Point(3, 7);
            this.checkPlnBtn.Name = "checkPlnBtn";
            this.checkPlnBtn.Size = new System.Drawing.Size(133, 27);
            this.checkPlnBtn.TabIndex = 12;
            this.checkPlnBtn.Text = "Посмотреть план";
            this.checkPlnBtn.UseVisualStyleBackColor = true;
            this.checkPlnBtn.Click += new System.EventHandler(this.checkPlnBtn_Click);
            // 
            // backOperBtn
            // 
            this.backOperBtn.Location = new System.Drawing.Point(3, 100);
            this.backOperBtn.Name = "backOperBtn";
            this.backOperBtn.Size = new System.Drawing.Size(133, 27);
            this.backOperBtn.TabIndex = 11;
            this.backOperBtn.Text = "<-- Назад";
            this.backOperBtn.UseVisualStyleBackColor = true;
            this.backOperBtn.Click += new System.EventHandler(this.backOperBtn_Click);
            // 
            // sumMonthBtn
            // 
            this.sumMonthBtn.Location = new System.Drawing.Point(3, 39);
            this.sumMonthBtn.Name = "sumMonthBtn";
            this.sumMonthBtn.Size = new System.Drawing.Size(133, 27);
            this.sumMonthBtn.TabIndex = 10;
            this.sumMonthBtn.Text = "Сводка за месяц";
            this.sumMonthBtn.UseVisualStyleBackColor = true;
            this.sumMonthBtn.Click += new System.EventHandler(this.sumMonthBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.rightsLabel);
            this.Controls.Add(this.tableDescription);
            this.Controls.Add(this.selectedTableLabel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.mainAdminPanel);
            this.Controls.Add(this.reportOperPanel);
            this.Controls.Add(this.reportAdminPanel);
            this.Controls.Add(this.mainOperPanel);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учета деятельности фотостудии";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainAdminPanel.ResumeLayout(false);
            this.reportAdminPanel.ResumeLayout(false);
            this.mainOperPanel.ResumeLayout(false);
            this.reportOperPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.Label selectedTableLabel;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фотографыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ассистентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказчикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.Button addRecBtn;
        private System.Windows.Forms.Button editRecBtn;
        private System.Windows.Forms.Button findRecBtn;
        private System.Windows.Forms.Button deleteRecBtn;
        private System.Windows.Forms.RichTextBox tableDescription;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Panel mainAdminPanel;
        private System.Windows.Forms.Panel reportAdminPanel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button monthSummaryBtn;
        private System.Windows.Forms.Button planBtn;
        private System.Windows.Forms.Button tableReportBtn;
        private System.Windows.Forms.Button viewPlanBtn;
        private System.Windows.Forms.ToolStripMenuItem сменитьПраваToolStripMenuItem;
        private System.Windows.Forms.Label rightsLabel;
        private System.Windows.Forms.Panel mainOperPanel;
        private System.Windows.Forms.Button reportOperBtn;
        private System.Windows.Forms.Button findOperBtn;
        private System.Windows.Forms.Panel reportOperPanel;
        private System.Windows.Forms.Button checkPlnBtn;
        private System.Windows.Forms.Button backOperBtn;
        private System.Windows.Forms.Button sumMonthBtn;
        private System.Windows.Forms.Button tableReportOperBtn;
    }
}

