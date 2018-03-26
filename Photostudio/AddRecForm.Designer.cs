namespace Photostudio
{
    partial class AddRecForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrdersGB = new System.Windows.Forms.GroupBox();
            this.ORD_DateLabel = new System.Windows.Forms.Label();
            this.ORD_ServicesLabel = new System.Windows.Forms.Label();
            this.ORD_PhotographersLabel = new System.Windows.Forms.Label();
            this.ORD_CustomersLabe = new System.Windows.Forms.Label();
            this.ORD_DateMTB = new System.Windows.Forms.MaskedTextBox();
            this.ORD_AddRecordBTN = new System.Windows.Forms.Button();
            this.ORD_ExecCB = new System.Windows.Forms.CheckBox();
            this.ORD_ServicesCB = new System.Windows.Forms.ComboBox();
            this.ORD_PhotographersCB = new System.Windows.Forms.ComboBox();
            this.ORD_CustomersCB = new System.Windows.Forms.ComboBox();
            this.PhotographersGB = new System.Windows.Forms.GroupBox();
            this.AssistantsGB = new System.Windows.Forms.GroupBox();
            this.CustomersGB = new System.Windows.Forms.GroupBox();
            this.CUS_AddRecordBTN = new System.Windows.Forms.Button();
            this.CUS_PhoneLabel = new System.Windows.Forms.Label();
            this.CUS_AddressLabel = new System.Windows.Forms.Label();
            this.CUS_FullnameLabel = new System.Windows.Forms.Label();
            this.CUS_PhoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.CUS_AdressTB = new System.Windows.Forms.TextBox();
            this.CUS_FullnameTB = new System.Windows.Forms.TextBox();
            this.ServicesGB = new System.Windows.Forms.GroupBox();
            this.AssistanceGB = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.SER_DescriptionTB = new System.Windows.Forms.TextBox();
            this.SER_PriceTB = new System.Windows.Forms.TextBox();
            this.SER_DescriptionLabel = new System.Windows.Forms.Label();
            this.SER_PriceLabel = new System.Windows.Forms.Label();
            this.SER_AddRecordBTN = new System.Windows.Forms.Button();
            this.ASS_FullnameLabel = new System.Windows.Forms.Label();
            this.ASS_PhoneLabel = new System.Windows.Forms.Label();
            this.ASS_FullnameTB = new System.Windows.Forms.TextBox();
            this.ASS_PhoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.ASS_AddRecordBTN = new System.Windows.Forms.Button();
            this.ASCE_AssistantCB = new System.Windows.Forms.ComboBox();
            this.ASCE_OrderCB = new System.Windows.Forms.ComboBox();
            this.ASCE_AssistantLabel = new System.Windows.Forms.Label();
            this.ASCE_PhotographerLabel = new System.Windows.Forms.Label();
            this.ASCE_AddRecordBTN = new System.Windows.Forms.Button();
            this.OrdersGB.SuspendLayout();
            this.AssistantsGB.SuspendLayout();
            this.CustomersGB.SuspendLayout();
            this.ServicesGB.SuspendLayout();
            this.AssistanceGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGB
            // 
            this.OrdersGB.Controls.Add(this.ORD_DateLabel);
            this.OrdersGB.Controls.Add(this.ORD_ServicesLabel);
            this.OrdersGB.Controls.Add(this.ORD_PhotographersLabel);
            this.OrdersGB.Controls.Add(this.ORD_CustomersLabe);
            this.OrdersGB.Controls.Add(this.ORD_DateMTB);
            this.OrdersGB.Controls.Add(this.ORD_AddRecordBTN);
            this.OrdersGB.Controls.Add(this.ORD_ExecCB);
            this.OrdersGB.Controls.Add(this.ORD_ServicesCB);
            this.OrdersGB.Controls.Add(this.ORD_PhotographersCB);
            this.OrdersGB.Controls.Add(this.ORD_CustomersCB);
            this.OrdersGB.Location = new System.Drawing.Point(12, 12);
            this.OrdersGB.Name = "OrdersGB";
            this.OrdersGB.Size = new System.Drawing.Size(489, 352);
            this.OrdersGB.TabIndex = 0;
            this.OrdersGB.TabStop = false;
            this.OrdersGB.Text = "Таблица: Заказы";
            this.OrdersGB.Visible = false;
            // 
            // ORD_DateLabel
            // 
            this.ORD_DateLabel.AutoSize = true;
            this.ORD_DateLabel.Location = new System.Drawing.Point(6, 136);
            this.ORD_DateLabel.Name = "ORD_DateLabel";
            this.ORD_DateLabel.Size = new System.Drawing.Size(74, 13);
            this.ORD_DateLabel.TabIndex = 11;
            this.ORD_DateLabel.Text = "Введите дату";
            // 
            // ORD_ServicesLabel
            // 
            this.ORD_ServicesLabel.AutoSize = true;
            this.ORD_ServicesLabel.Location = new System.Drawing.Point(6, 96);
            this.ORD_ServicesLabel.Name = "ORD_ServicesLabel";
            this.ORD_ServicesLabel.Size = new System.Drawing.Size(92, 13);
            this.ORD_ServicesLabel.TabIndex = 10;
            this.ORD_ServicesLabel.Text = "Выберите услугу";
            // 
            // ORD_PhotographersLabel
            // 
            this.ORD_PhotographersLabel.AutoSize = true;
            this.ORD_PhotographersLabel.Location = new System.Drawing.Point(6, 56);
            this.ORD_PhotographersLabel.Name = "ORD_PhotographersLabel";
            this.ORD_PhotographersLabel.Size = new System.Drawing.Size(116, 13);
            this.ORD_PhotographersLabel.TabIndex = 9;
            this.ORD_PhotographersLabel.Text = "Выберите фотографа";
            // 
            // ORD_CustomersLabe
            // 
            this.ORD_CustomersLabe.AutoSize = true;
            this.ORD_CustomersLabe.Location = new System.Drawing.Point(6, 16);
            this.ORD_CustomersLabe.Name = "ORD_CustomersLabe";
            this.ORD_CustomersLabe.Size = new System.Drawing.Size(113, 13);
            this.ORD_CustomersLabe.TabIndex = 8;
            this.ORD_CustomersLabe.Text = "Выберите заказчика";
            // 
            // ORD_DateMTB
            // 
            this.ORD_DateMTB.Location = new System.Drawing.Point(21, 152);
            this.ORD_DateMTB.Mask = "00/00/0000";
            this.ORD_DateMTB.Name = "ORD_DateMTB";
            this.ORD_DateMTB.Size = new System.Drawing.Size(100, 20);
            this.ORD_DateMTB.TabIndex = 7;
            this.ORD_DateMTB.ValidatingType = typeof(System.DateTime);
            // 
            // ORD_AddRecordBTN
            // 
            this.ORD_AddRecordBTN.Location = new System.Drawing.Point(6, 323);
            this.ORD_AddRecordBTN.Name = "ORD_AddRecordBTN";
            this.ORD_AddRecordBTN.Size = new System.Drawing.Size(129, 23);
            this.ORD_AddRecordBTN.TabIndex = 5;
            this.ORD_AddRecordBTN.Text = "Добавить запись";
            this.ORD_AddRecordBTN.UseVisualStyleBackColor = true;
            this.ORD_AddRecordBTN.Click += new System.EventHandler(this.ORD_AddRecordBTN_Click);
            // 
            // ORD_ExecCB
            // 
            this.ORD_ExecCB.AutoSize = true;
            this.ORD_ExecCB.Location = new System.Drawing.Point(21, 178);
            this.ORD_ExecCB.Name = "ORD_ExecCB";
            this.ORD_ExecCB.Size = new System.Drawing.Size(114, 17);
            this.ORD_ExecCB.TabIndex = 4;
            this.ORD_ExecCB.Text = "Заказ исполнен?";
            this.ORD_ExecCB.UseVisualStyleBackColor = true;
            // 
            // ORD_ServicesCB
            // 
            this.ORD_ServicesCB.FormattingEnabled = true;
            this.ORD_ServicesCB.Location = new System.Drawing.Point(21, 112);
            this.ORD_ServicesCB.Name = "ORD_ServicesCB";
            this.ORD_ServicesCB.Size = new System.Drawing.Size(237, 21);
            this.ORD_ServicesCB.TabIndex = 2;
            // 
            // ORD_PhotographersCB
            // 
            this.ORD_PhotographersCB.FormattingEnabled = true;
            this.ORD_PhotographersCB.Location = new System.Drawing.Point(21, 72);
            this.ORD_PhotographersCB.Name = "ORD_PhotographersCB";
            this.ORD_PhotographersCB.Size = new System.Drawing.Size(237, 21);
            this.ORD_PhotographersCB.TabIndex = 1;
            // 
            // ORD_CustomersCB
            // 
            this.ORD_CustomersCB.FormattingEnabled = true;
            this.ORD_CustomersCB.Location = new System.Drawing.Point(21, 32);
            this.ORD_CustomersCB.Name = "ORD_CustomersCB";
            this.ORD_CustomersCB.Size = new System.Drawing.Size(237, 21);
            this.ORD_CustomersCB.TabIndex = 0;
            // 
            // PhotographersGB
            // 
            this.PhotographersGB.Location = new System.Drawing.Point(12, 12);
            this.PhotographersGB.Name = "PhotographersGB";
            this.PhotographersGB.Size = new System.Drawing.Size(489, 352);
            this.PhotographersGB.TabIndex = 1;
            this.PhotographersGB.TabStop = false;
            this.PhotographersGB.Text = "Таблица: Фотографы";
            this.PhotographersGB.Visible = false;
            // 
            // AssistantsGB
            // 
            this.AssistantsGB.Controls.Add(this.ASS_AddRecordBTN);
            this.AssistantsGB.Controls.Add(this.ASS_PhoneMTB);
            this.AssistantsGB.Controls.Add(this.ASS_FullnameTB);
            this.AssistantsGB.Controls.Add(this.ASS_PhoneLabel);
            this.AssistantsGB.Controls.Add(this.ASS_FullnameLabel);
            this.AssistantsGB.Location = new System.Drawing.Point(12, 12);
            this.AssistantsGB.Name = "AssistantsGB";
            this.AssistantsGB.Size = new System.Drawing.Size(489, 352);
            this.AssistantsGB.TabIndex = 2;
            this.AssistantsGB.TabStop = false;
            this.AssistantsGB.Text = "Таблица: Ассистенты";
            this.AssistantsGB.Visible = false;
            // 
            // CustomersGB
            // 
            this.CustomersGB.Controls.Add(this.CUS_AddRecordBTN);
            this.CustomersGB.Controls.Add(this.CUS_PhoneLabel);
            this.CustomersGB.Controls.Add(this.CUS_AddressLabel);
            this.CustomersGB.Controls.Add(this.CUS_FullnameLabel);
            this.CustomersGB.Controls.Add(this.CUS_PhoneMTB);
            this.CustomersGB.Controls.Add(this.CUS_AdressTB);
            this.CustomersGB.Controls.Add(this.CUS_FullnameTB);
            this.CustomersGB.Location = new System.Drawing.Point(12, 12);
            this.CustomersGB.Name = "CustomersGB";
            this.CustomersGB.Size = new System.Drawing.Size(489, 352);
            this.CustomersGB.TabIndex = 3;
            this.CustomersGB.TabStop = false;
            this.CustomersGB.Text = "Таблица: Заказчики";
            this.CustomersGB.Visible = false;
            // 
            // CUS_AddRecordBTN
            // 
            this.CUS_AddRecordBTN.Location = new System.Drawing.Point(7, 322);
            this.CUS_AddRecordBTN.Name = "CUS_AddRecordBTN";
            this.CUS_AddRecordBTN.Size = new System.Drawing.Size(112, 23);
            this.CUS_AddRecordBTN.TabIndex = 6;
            this.CUS_AddRecordBTN.Text = "Добавить запись";
            this.CUS_AddRecordBTN.UseVisualStyleBackColor = true;
            this.CUS_AddRecordBTN.Click += new System.EventHandler(this.CUS_AddRecordBTN_Click);
            // 
            // CUS_PhoneLabel
            // 
            this.CUS_PhoneLabel.AutoSize = true;
            this.CUS_PhoneLabel.Location = new System.Drawing.Point(6, 97);
            this.CUS_PhoneLabel.Name = "CUS_PhoneLabel";
            this.CUS_PhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.CUS_PhoneLabel.TabIndex = 5;
            this.CUS_PhoneLabel.Text = "Телефон";
            // 
            // CUS_AddressLabel
            // 
            this.CUS_AddressLabel.AutoSize = true;
            this.CUS_AddressLabel.Location = new System.Drawing.Point(6, 56);
            this.CUS_AddressLabel.Name = "CUS_AddressLabel";
            this.CUS_AddressLabel.Size = new System.Drawing.Size(38, 13);
            this.CUS_AddressLabel.TabIndex = 4;
            this.CUS_AddressLabel.Text = "Адрес";
            // 
            // CUS_FullnameLabel
            // 
            this.CUS_FullnameLabel.AutoSize = true;
            this.CUS_FullnameLabel.Location = new System.Drawing.Point(6, 16);
            this.CUS_FullnameLabel.Name = "CUS_FullnameLabel";
            this.CUS_FullnameLabel.Size = new System.Drawing.Size(34, 13);
            this.CUS_FullnameLabel.TabIndex = 3;
            this.CUS_FullnameLabel.Text = "ФИО";
            // 
            // CUS_PhoneMTB
            // 
            this.CUS_PhoneMTB.Location = new System.Drawing.Point(19, 113);
            this.CUS_PhoneMTB.Mask = "0-000-000-00-00";
            this.CUS_PhoneMTB.Name = "CUS_PhoneMTB";
            this.CUS_PhoneMTB.Size = new System.Drawing.Size(178, 20);
            this.CUS_PhoneMTB.TabIndex = 2;
            this.CUS_PhoneMTB.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // CUS_AdressTB
            // 
            this.CUS_AdressTB.Location = new System.Drawing.Point(19, 73);
            this.CUS_AdressTB.Name = "CUS_AdressTB";
            this.CUS_AdressTB.Size = new System.Drawing.Size(178, 20);
            this.CUS_AdressTB.TabIndex = 1;
            // 
            // CUS_FullnameTB
            // 
            this.CUS_FullnameTB.Location = new System.Drawing.Point(19, 32);
            this.CUS_FullnameTB.Name = "CUS_FullnameTB";
            this.CUS_FullnameTB.Size = new System.Drawing.Size(178, 20);
            this.CUS_FullnameTB.TabIndex = 0;
            // 
            // ServicesGB
            // 
            this.ServicesGB.Controls.Add(this.SER_AddRecordBTN);
            this.ServicesGB.Controls.Add(this.SER_PriceLabel);
            this.ServicesGB.Controls.Add(this.SER_DescriptionLabel);
            this.ServicesGB.Controls.Add(this.SER_PriceTB);
            this.ServicesGB.Controls.Add(this.SER_DescriptionTB);
            this.ServicesGB.Location = new System.Drawing.Point(12, 12);
            this.ServicesGB.Name = "ServicesGB";
            this.ServicesGB.Size = new System.Drawing.Size(489, 352);
            this.ServicesGB.TabIndex = 4;
            this.ServicesGB.TabStop = false;
            this.ServicesGB.Text = "Таблица: Услуги";
            this.ServicesGB.Visible = false;
            // 
            // AssistanceGB
            // 
            this.AssistanceGB.Controls.Add(this.ASCE_AddRecordBTN);
            this.AssistanceGB.Controls.Add(this.ASCE_PhotographerLabel);
            this.AssistanceGB.Controls.Add(this.ASCE_AssistantLabel);
            this.AssistanceGB.Controls.Add(this.ASCE_OrderCB);
            this.AssistanceGB.Controls.Add(this.ASCE_AssistantCB);
            this.AssistanceGB.Location = new System.Drawing.Point(12, 12);
            this.AssistanceGB.Name = "AssistanceGB";
            this.AssistanceGB.Size = new System.Drawing.Size(489, 352);
            this.AssistanceGB.TabIndex = 4;
            this.AssistanceGB.TabStop = false;
            this.AssistanceGB.Text = "Таблица: Помощь";
            this.AssistanceGB.Visible = false;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(525, 21);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(666, 322);
            this.dataGrid.TabIndex = 5;
            // 
            // SER_DescriptionTB
            // 
            this.SER_DescriptionTB.Location = new System.Drawing.Point(19, 33);
            this.SER_DescriptionTB.Name = "SER_DescriptionTB";
            this.SER_DescriptionTB.Size = new System.Drawing.Size(178, 20);
            this.SER_DescriptionTB.TabIndex = 0;
            // 
            // SER_PriceTB
            // 
            this.SER_PriceTB.Location = new System.Drawing.Point(19, 74);
            this.SER_PriceTB.Name = "SER_PriceTB";
            this.SER_PriceTB.Size = new System.Drawing.Size(178, 20);
            this.SER_PriceTB.TabIndex = 1;
            // 
            // SER_DescriptionLabel
            // 
            this.SER_DescriptionLabel.AutoSize = true;
            this.SER_DescriptionLabel.Location = new System.Drawing.Point(6, 16);
            this.SER_DescriptionLabel.Name = "SER_DescriptionLabel";
            this.SER_DescriptionLabel.Size = new System.Drawing.Size(93, 13);
            this.SER_DescriptionLabel.TabIndex = 2;
            this.SER_DescriptionLabel.Text = "Название услуги";
            // 
            // SER_PriceLabel
            // 
            this.SER_PriceLabel.AutoSize = true;
            this.SER_PriceLabel.Location = new System.Drawing.Point(6, 56);
            this.SER_PriceLabel.Name = "SER_PriceLabel";
            this.SER_PriceLabel.Size = new System.Drawing.Size(33, 13);
            this.SER_PriceLabel.TabIndex = 3;
            this.SER_PriceLabel.Text = "Цена";
            // 
            // SER_AddRecordBTN
            // 
            this.SER_AddRecordBTN.Location = new System.Drawing.Point(7, 323);
            this.SER_AddRecordBTN.Name = "SER_AddRecordBTN";
            this.SER_AddRecordBTN.Size = new System.Drawing.Size(115, 23);
            this.SER_AddRecordBTN.TabIndex = 4;
            this.SER_AddRecordBTN.Text = "Добавить запись";
            this.SER_AddRecordBTN.UseVisualStyleBackColor = true;
            this.SER_AddRecordBTN.Click += new System.EventHandler(this.SER_AddRecordBTN_Click);
            // 
            // ASS_FullnameLabel
            // 
            this.ASS_FullnameLabel.AutoSize = true;
            this.ASS_FullnameLabel.Location = new System.Drawing.Point(9, 20);
            this.ASS_FullnameLabel.Name = "ASS_FullnameLabel";
            this.ASS_FullnameLabel.Size = new System.Drawing.Size(34, 13);
            this.ASS_FullnameLabel.TabIndex = 0;
            this.ASS_FullnameLabel.Text = "ФИО";
            // 
            // ASS_PhoneLabel
            // 
            this.ASS_PhoneLabel.AutoSize = true;
            this.ASS_PhoneLabel.Location = new System.Drawing.Point(9, 59);
            this.ASS_PhoneLabel.Name = "ASS_PhoneLabel";
            this.ASS_PhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.ASS_PhoneLabel.TabIndex = 1;
            this.ASS_PhoneLabel.Text = "Телефон";
            // 
            // ASS_FullnameTB
            // 
            this.ASS_FullnameTB.Location = new System.Drawing.Point(22, 36);
            this.ASS_FullnameTB.Name = "ASS_FullnameTB";
            this.ASS_FullnameTB.Size = new System.Drawing.Size(160, 20);
            this.ASS_FullnameTB.TabIndex = 2;
            // 
            // ASS_PhoneMTB
            // 
            this.ASS_PhoneMTB.Location = new System.Drawing.Point(22, 73);
            this.ASS_PhoneMTB.Mask = "0-000-000-00-00";
            this.ASS_PhoneMTB.Name = "ASS_PhoneMTB";
            this.ASS_PhoneMTB.Size = new System.Drawing.Size(97, 20);
            this.ASS_PhoneMTB.TabIndex = 3;
            this.ASS_PhoneMTB.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // ASS_AddRecordBTN
            // 
            this.ASS_AddRecordBTN.Location = new System.Drawing.Point(9, 322);
            this.ASS_AddRecordBTN.Name = "ASS_AddRecordBTN";
            this.ASS_AddRecordBTN.Size = new System.Drawing.Size(126, 23);
            this.ASS_AddRecordBTN.TabIndex = 4;
            this.ASS_AddRecordBTN.Text = "Добавить запись";
            this.ASS_AddRecordBTN.UseVisualStyleBackColor = true;
            this.ASS_AddRecordBTN.Click += new System.EventHandler(this.ASS_AddRecordBTN_Click);
            // 
            // ASCE_AssistantCB
            // 
            this.ASCE_AssistantCB.FormattingEnabled = true;
            this.ASCE_AssistantCB.Location = new System.Drawing.Point(32, 33);
            this.ASCE_AssistantCB.Name = "ASCE_AssistantCB";
            this.ASCE_AssistantCB.Size = new System.Drawing.Size(185, 21);
            this.ASCE_AssistantCB.TabIndex = 0;
            // 
            // ASCE_OrderCB
            // 
            this.ASCE_OrderCB.FormattingEnabled = true;
            this.ASCE_OrderCB.Location = new System.Drawing.Point(32, 75);
            this.ASCE_OrderCB.Name = "ASCE_OrderCB";
            this.ASCE_OrderCB.Size = new System.Drawing.Size(183, 21);
            this.ASCE_OrderCB.TabIndex = 1;
            // 
            // ASCE_AssistantLabel
            // 
            this.ASCE_AssistantLabel.AutoSize = true;
            this.ASCE_AssistantLabel.Location = new System.Drawing.Point(9, 16);
            this.ASCE_AssistantLabel.Name = "ASCE_AssistantLabel";
            this.ASCE_AssistantLabel.Size = new System.Drawing.Size(95, 13);
            this.ASCE_AssistantLabel.TabIndex = 2;
            this.ASCE_AssistantLabel.Text = "ФИО ассистента";
            // 
            // ASCE_PhotographerLabel
            // 
            this.ASCE_PhotographerLabel.AutoSize = true;
            this.ASCE_PhotographerLabel.Location = new System.Drawing.Point(11, 59);
            this.ASCE_PhotographerLabel.Name = "ASCE_PhotographerLabel";
            this.ASCE_PhotographerLabel.Size = new System.Drawing.Size(93, 13);
            this.ASCE_PhotographerLabel.TabIndex = 3;
            this.ASCE_PhotographerLabel.Text = "ФИО фотографа";
            // 
            // ASCE_AddRecordBTN
            // 
            this.ASCE_AddRecordBTN.Location = new System.Drawing.Point(9, 321);
            this.ASCE_AddRecordBTN.Name = "ASCE_AddRecordBTN";
            this.ASCE_AddRecordBTN.Size = new System.Drawing.Size(142, 23);
            this.ASCE_AddRecordBTN.TabIndex = 4;
            this.ASCE_AddRecordBTN.Text = "Добавить запись";
            this.ASCE_AddRecordBTN.UseVisualStyleBackColor = true;
            this.ASCE_AddRecordBTN.Click += new System.EventHandler(this.ASCE_AddRecordBTN_Click);
            // 
            // AddRecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 428);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.AssistanceGB);
            this.Controls.Add(this.PhotographersGB);
            this.Controls.Add(this.OrdersGB);
            this.Controls.Add(this.CustomersGB);
            this.Controls.Add(this.ServicesGB);
            this.Controls.Add(this.AssistantsGB);
            this.Name = "AddRecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить запись";
            this.OrdersGB.ResumeLayout(false);
            this.OrdersGB.PerformLayout();
            this.AssistantsGB.ResumeLayout(false);
            this.AssistantsGB.PerformLayout();
            this.CustomersGB.ResumeLayout(false);
            this.CustomersGB.PerformLayout();
            this.ServicesGB.ResumeLayout(false);
            this.ServicesGB.PerformLayout();
            this.AssistanceGB.ResumeLayout(false);
            this.AssistanceGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox OrdersGB;
        private System.Windows.Forms.GroupBox PhotographersGB;
        private System.Windows.Forms.GroupBox AssistantsGB;
        private System.Windows.Forms.GroupBox CustomersGB;
        private System.Windows.Forms.GroupBox ServicesGB;
        private System.Windows.Forms.GroupBox AssistanceGB;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button ORD_AddRecordBTN;
        private System.Windows.Forms.CheckBox ORD_ExecCB;
        private System.Windows.Forms.ComboBox ORD_ServicesCB;
        private System.Windows.Forms.ComboBox ORD_PhotographersCB;
        private System.Windows.Forms.ComboBox ORD_CustomersCB;
        private System.Windows.Forms.MaskedTextBox ORD_DateMTB;
        private System.Windows.Forms.Label ORD_DateLabel;
        private System.Windows.Forms.Label ORD_ServicesLabel;
        private System.Windows.Forms.Label ORD_PhotographersLabel;
        private System.Windows.Forms.Label ORD_CustomersLabe;
        private System.Windows.Forms.Label CUS_PhoneLabel;
        private System.Windows.Forms.Label CUS_AddressLabel;
        private System.Windows.Forms.Label CUS_FullnameLabel;
        private System.Windows.Forms.MaskedTextBox CUS_PhoneMTB;
        private System.Windows.Forms.TextBox CUS_AdressTB;
        private System.Windows.Forms.TextBox CUS_FullnameTB;
        private System.Windows.Forms.Button CUS_AddRecordBTN;
        private System.Windows.Forms.Label SER_PriceLabel;
        private System.Windows.Forms.Label SER_DescriptionLabel;
        private System.Windows.Forms.TextBox SER_PriceTB;
        private System.Windows.Forms.TextBox SER_DescriptionTB;
        private System.Windows.Forms.Button SER_AddRecordBTN;
        private System.Windows.Forms.Button ASS_AddRecordBTN;
        private System.Windows.Forms.MaskedTextBox ASS_PhoneMTB;
        private System.Windows.Forms.TextBox ASS_FullnameTB;
        private System.Windows.Forms.Label ASS_PhoneLabel;
        private System.Windows.Forms.Label ASS_FullnameLabel;
        private System.Windows.Forms.Label ASCE_PhotographerLabel;
        private System.Windows.Forms.Label ASCE_AssistantLabel;
        private System.Windows.Forms.ComboBox ASCE_OrderCB;
        private System.Windows.Forms.ComboBox ASCE_AssistantCB;
        private System.Windows.Forms.Button ASCE_AddRecordBTN;
    }
}