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
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фотографыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ассистентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказчикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedTableLabel = new System.Windows.Forms.Label();
            this.addRecBtn = new System.Windows.Forms.Button();
            this.editRecBtn = new System.Windows.Forms.Button();
            this.findRecBtn = new System.Windows.Forms.Button();
            this.deleteRecBtn = new System.Windows.Forms.Button();
            this.tableDescription = new System.Windows.Forms.RichTextBox();
            this.reportBtn = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
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
            this.выходToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem,
            this.фотографыToolStripMenuItem,
            this.ассистентыToolStripMenuItem,
            this.заказчикиToolStripMenuItem,
            this.услугиToolStripMenuItem});
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
            this.addRecBtn.Location = new System.Drawing.Point(12, 51);
            this.addRecBtn.Name = "addRecBtn";
            this.addRecBtn.Size = new System.Drawing.Size(133, 27);
            this.addRecBtn.TabIndex = 2;
            this.addRecBtn.Text = "Добавить запись";
            this.addRecBtn.UseVisualStyleBackColor = true;
            this.addRecBtn.Click += new System.EventHandler(this.addRecBtn_Click);
            // 
            // editRecBtn
            // 
            this.editRecBtn.Location = new System.Drawing.Point(12, 84);
            this.editRecBtn.Name = "editRecBtn";
            this.editRecBtn.Size = new System.Drawing.Size(133, 27);
            this.editRecBtn.TabIndex = 3;
            this.editRecBtn.Text = "Редактировать запись";
            this.editRecBtn.UseVisualStyleBackColor = true;
            this.editRecBtn.Click += new System.EventHandler(this.editRecBtn_Click);
            // 
            // findRecBtn
            // 
            this.findRecBtn.Location = new System.Drawing.Point(12, 117);
            this.findRecBtn.Name = "findRecBtn";
            this.findRecBtn.Size = new System.Drawing.Size(133, 27);
            this.findRecBtn.TabIndex = 4;
            this.findRecBtn.Text = "Найти запись";
            this.findRecBtn.UseVisualStyleBackColor = true;
            this.findRecBtn.Click += new System.EventHandler(this.findRecBtn_Click);
            // 
            // deleteRecBtn
            // 
            this.deleteRecBtn.Location = new System.Drawing.Point(12, 150);
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
            this.tableDescription.Location = new System.Drawing.Point(179, 51);
            this.tableDescription.Name = "tableDescription";
            this.tableDescription.ReadOnly = true;
            this.tableDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableDescription.Size = new System.Drawing.Size(256, 135);
            this.tableDescription.TabIndex = 6;
            this.tableDescription.Text = "TableDescription";
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(12, 183);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(133, 27);
            this.reportBtn.TabIndex = 7;
            this.reportBtn.Text = "Составить отчет";
            this.reportBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.tableDescription);
            this.Controls.Add(this.deleteRecBtn);
            this.Controls.Add(this.findRecBtn);
            this.Controls.Add(this.editRecBtn);
            this.Controls.Add(this.addRecBtn);
            this.Controls.Add(this.selectedTableLabel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учета деятельности фотостудии";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
    }
}

