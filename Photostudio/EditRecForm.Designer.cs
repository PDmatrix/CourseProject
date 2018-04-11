namespace Photostudio
{
    partial class EditRecForm
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
            this.ORD_EditRecordBTN = new System.Windows.Forms.Button();
            this.ORD_OrderLabel = new System.Windows.Forms.Label();
            this.ORD_OrderCB = new System.Windows.Forms.ComboBox();
            this.PhotographersGB = new System.Windows.Forms.GroupBox();
            this.PHO_AdressLabel = new System.Windows.Forms.Label();
            this.PHO_PhoneLabel = new System.Windows.Forms.Label();
            this.PHO_DateLabel = new System.Windows.Forms.Label();
            this.PHO_ExperienceLabel = new System.Windows.Forms.Label();
            this.PHO_FullnameLabel = new System.Windows.Forms.Label();
            this.PHO_AdressTB = new System.Windows.Forms.TextBox();
            this.PHO_PhoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.PHO_DateMTB = new System.Windows.Forms.MaskedTextBox();
            this.PHO_ExperienceTB = new System.Windows.Forms.TextBox();
            this.PHO_FullnameTB = new System.Windows.Forms.TextBox();
            this.PHO_EditRecordBTN = new System.Windows.Forms.Button();
            this.PHO_FullnameFindLabel = new System.Windows.Forms.Label();
            this.PHO_FullnameCB = new System.Windows.Forms.ComboBox();
            this.AssistantsGB = new System.Windows.Forms.GroupBox();
            this.ASS_EditRecordBTN = new System.Windows.Forms.Button();
            this.ASS_FullnameFindLabel = new System.Windows.Forms.Label();
            this.ASS_FullnameCB = new System.Windows.Forms.ComboBox();
            this.CustomersGB = new System.Windows.Forms.GroupBox();
            this.CUS_EditRecordBTN = new System.Windows.Forms.Button();
            this.CUS_FullnameFindLabel = new System.Windows.Forms.Label();
            this.CUS_FullnameCB = new System.Windows.Forms.ComboBox();
            this.ServicesGB = new System.Windows.Forms.GroupBox();
            this.SER_EditRecordBTN = new System.Windows.Forms.Button();
            this.SER_DescriptionFindLabel = new System.Windows.Forms.Label();
            this.SER_DescriptionCB = new System.Windows.Forms.ComboBox();
            this.AssistanceGB = new System.Windows.Forms.GroupBox();
            this.ASCE_EditRecordBTN = new System.Windows.Forms.Button();
            this.ASCE_HelpLabel = new System.Windows.Forms.Label();
            this.ASCE_HelpCB = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.CUS_PhoneLabel = new System.Windows.Forms.Label();
            this.CUS_AddressLabel = new System.Windows.Forms.Label();
            this.CUS_FullnameLabel = new System.Windows.Forms.Label();
            this.CUS_PhoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.CUS_AdressTB = new System.Windows.Forms.TextBox();
            this.CUS_FullnameTB = new System.Windows.Forms.TextBox();
            this.SER_PriceLabel = new System.Windows.Forms.Label();
            this.SER_DescriptionLabel = new System.Windows.Forms.Label();
            this.SER_PriceTB = new System.Windows.Forms.TextBox();
            this.SER_DescriptionTB = new System.Windows.Forms.TextBox();
            this.ASS_PhoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.ASS_FullnameTB = new System.Windows.Forms.TextBox();
            this.ASS_PhoneLabel = new System.Windows.Forms.Label();
            this.ASS_FullnameLabel = new System.Windows.Forms.Label();
            this.OrdersGB.SuspendLayout();
            this.PhotographersGB.SuspendLayout();
            this.AssistantsGB.SuspendLayout();
            this.CustomersGB.SuspendLayout();
            this.ServicesGB.SuspendLayout();
            this.AssistanceGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGB
            // 
            this.OrdersGB.Controls.Add(this.ORD_EditRecordBTN);
            this.OrdersGB.Controls.Add(this.ORD_OrderLabel);
            this.OrdersGB.Controls.Add(this.ORD_OrderCB);
            this.OrdersGB.Location = new System.Drawing.Point(12, 12);
            this.OrdersGB.Name = "OrdersGB";
            this.OrdersGB.Size = new System.Drawing.Size(489, 352);
            this.OrdersGB.TabIndex = 0;
            this.OrdersGB.TabStop = false;
            this.OrdersGB.Text = "Таблица: Заказы";
            this.OrdersGB.Visible = false;
            // 
            // ORD_EditRecordBTN
            // 
            this.ORD_EditRecordBTN.Location = new System.Drawing.Point(9, 323);
            this.ORD_EditRecordBTN.Name = "ORD_EditRecordBTN";
            this.ORD_EditRecordBTN.Size = new System.Drawing.Size(140, 23);
            this.ORD_EditRecordBTN.TabIndex = 8;
            this.ORD_EditRecordBTN.Text = "Редактировать запись";
            this.ORD_EditRecordBTN.UseVisualStyleBackColor = true;
            // 
            // ORD_OrderLabel
            // 
            this.ORD_OrderLabel.AutoSize = true;
            this.ORD_OrderLabel.Location = new System.Drawing.Point(6, 21);
            this.ORD_OrderLabel.Name = "ORD_OrderLabel";
            this.ORD_OrderLabel.Size = new System.Drawing.Size(38, 13);
            this.ORD_OrderLabel.TabIndex = 7;
            this.ORD_OrderLabel.Text = "Заказ";
            // 
            // ORD_OrderCB
            // 
            this.ORD_OrderCB.FormattingEnabled = true;
            this.ORD_OrderCB.Location = new System.Drawing.Point(20, 37);
            this.ORD_OrderCB.Name = "ORD_OrderCB";
            this.ORD_OrderCB.Size = new System.Drawing.Size(387, 21);
            this.ORD_OrderCB.TabIndex = 6;
            this.ORD_OrderCB.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ORD_OrderCB_Format);
            // 
            // PhotographersGB
            // 
            this.PhotographersGB.Controls.Add(this.PHO_AdressLabel);
            this.PhotographersGB.Controls.Add(this.PHO_PhoneLabel);
            this.PhotographersGB.Controls.Add(this.PHO_DateLabel);
            this.PhotographersGB.Controls.Add(this.PHO_ExperienceLabel);
            this.PhotographersGB.Controls.Add(this.PHO_FullnameLabel);
            this.PhotographersGB.Controls.Add(this.PHO_AdressTB);
            this.PhotographersGB.Controls.Add(this.PHO_PhoneMTB);
            this.PhotographersGB.Controls.Add(this.PHO_DateMTB);
            this.PhotographersGB.Controls.Add(this.PHO_ExperienceTB);
            this.PhotographersGB.Controls.Add(this.PHO_FullnameTB);
            this.PhotographersGB.Controls.Add(this.PHO_EditRecordBTN);
            this.PhotographersGB.Controls.Add(this.PHO_FullnameFindLabel);
            this.PhotographersGB.Controls.Add(this.PHO_FullnameCB);
            this.PhotographersGB.Location = new System.Drawing.Point(12, 12);
            this.PhotographersGB.Name = "PhotographersGB";
            this.PhotographersGB.Size = new System.Drawing.Size(489, 352);
            this.PhotographersGB.TabIndex = 1;
            this.PhotographersGB.TabStop = false;
            this.PhotographersGB.Text = "Таблица: Фотографы";
            this.PhotographersGB.Visible = false;
            // 
            // PHO_AdressLabel
            // 
            this.PHO_AdressLabel.AutoSize = true;
            this.PHO_AdressLabel.Location = new System.Drawing.Point(10, 222);
            this.PHO_AdressLabel.Name = "PHO_AdressLabel";
            this.PHO_AdressLabel.Size = new System.Drawing.Size(38, 13);
            this.PHO_AdressLabel.TabIndex = 19;
            this.PHO_AdressLabel.Text = "Адрес";
            // 
            // PHO_PhoneLabel
            // 
            this.PHO_PhoneLabel.AutoSize = true;
            this.PHO_PhoneLabel.Location = new System.Drawing.Point(10, 183);
            this.PHO_PhoneLabel.Name = "PHO_PhoneLabel";
            this.PHO_PhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.PHO_PhoneLabel.TabIndex = 18;
            this.PHO_PhoneLabel.Text = "Телефон";
            // 
            // PHO_DateLabel
            // 
            this.PHO_DateLabel.AutoSize = true;
            this.PHO_DateLabel.Location = new System.Drawing.Point(8, 142);
            this.PHO_DateLabel.Name = "PHO_DateLabel";
            this.PHO_DateLabel.Size = new System.Drawing.Size(86, 13);
            this.PHO_DateLabel.TabIndex = 17;
            this.PHO_DateLabel.Text = "Дата рождения";
            // 
            // PHO_ExperienceLabel
            // 
            this.PHO_ExperienceLabel.AutoSize = true;
            this.PHO_ExperienceLabel.Location = new System.Drawing.Point(17, 103);
            this.PHO_ExperienceLabel.Name = "PHO_ExperienceLabel";
            this.PHO_ExperienceLabel.Size = new System.Drawing.Size(73, 13);
            this.PHO_ExperienceLabel.TabIndex = 16;
            this.PHO_ExperienceLabel.Text = "Стаж работы";
            // 
            // PHO_FullnameLabel
            // 
            this.PHO_FullnameLabel.AutoSize = true;
            this.PHO_FullnameLabel.Location = new System.Drawing.Point(10, 64);
            this.PHO_FullnameLabel.Name = "PHO_FullnameLabel";
            this.PHO_FullnameLabel.Size = new System.Drawing.Size(34, 13);
            this.PHO_FullnameLabel.TabIndex = 15;
            this.PHO_FullnameLabel.Text = "ФИО";
            // 
            // PHO_AdressTB
            // 
            this.PHO_AdressTB.Location = new System.Drawing.Point(31, 238);
            this.PHO_AdressTB.Name = "PHO_AdressTB";
            this.PHO_AdressTB.Size = new System.Drawing.Size(150, 20);
            this.PHO_AdressTB.TabIndex = 14;
            // 
            // PHO_PhoneMTB
            // 
            this.PHO_PhoneMTB.Location = new System.Drawing.Point(31, 199);
            this.PHO_PhoneMTB.Mask = "0-000-000-00-00";
            this.PHO_PhoneMTB.Name = "PHO_PhoneMTB";
            this.PHO_PhoneMTB.Size = new System.Drawing.Size(150, 20);
            this.PHO_PhoneMTB.TabIndex = 13;
            this.PHO_PhoneMTB.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // PHO_DateMTB
            // 
            this.PHO_DateMTB.Location = new System.Drawing.Point(31, 158);
            this.PHO_DateMTB.Mask = "00/00/0000";
            this.PHO_DateMTB.Name = "PHO_DateMTB";
            this.PHO_DateMTB.Size = new System.Drawing.Size(150, 20);
            this.PHO_DateMTB.TabIndex = 12;
            this.PHO_DateMTB.ValidatingType = typeof(System.DateTime);
            // 
            // PHO_ExperienceTB
            // 
            this.PHO_ExperienceTB.Location = new System.Drawing.Point(31, 119);
            this.PHO_ExperienceTB.Name = "PHO_ExperienceTB";
            this.PHO_ExperienceTB.Size = new System.Drawing.Size(150, 20);
            this.PHO_ExperienceTB.TabIndex = 11;
            // 
            // PHO_FullnameTB
            // 
            this.PHO_FullnameTB.Location = new System.Drawing.Point(31, 79);
            this.PHO_FullnameTB.Name = "PHO_FullnameTB";
            this.PHO_FullnameTB.Size = new System.Drawing.Size(150, 20);
            this.PHO_FullnameTB.TabIndex = 10;
            // 
            // PHO_EditRecordBTN
            // 
            this.PHO_EditRecordBTN.Location = new System.Drawing.Point(9, 314);
            this.PHO_EditRecordBTN.Name = "PHO_EditRecordBTN";
            this.PHO_EditRecordBTN.Size = new System.Drawing.Size(134, 23);
            this.PHO_EditRecordBTN.TabIndex = 5;
            this.PHO_EditRecordBTN.Text = "Редактировать запись";
            this.PHO_EditRecordBTN.UseVisualStyleBackColor = true;
            this.PHO_EditRecordBTN.Click += new System.EventHandler(this.PHO_EditRecordBTN_Click);
            // 
            // PHO_FullnameFindLabel
            // 
            this.PHO_FullnameFindLabel.AutoSize = true;
            this.PHO_FullnameFindLabel.Location = new System.Drawing.Point(10, 21);
            this.PHO_FullnameFindLabel.Name = "PHO_FullnameFindLabel";
            this.PHO_FullnameFindLabel.Size = new System.Drawing.Size(34, 13);
            this.PHO_FullnameFindLabel.TabIndex = 4;
            this.PHO_FullnameFindLabel.Text = "ФИО";
            // 
            // PHO_FullnameCB
            // 
            this.PHO_FullnameCB.FormattingEnabled = true;
            this.PHO_FullnameCB.Location = new System.Drawing.Point(31, 37);
            this.PHO_FullnameCB.Name = "PHO_FullnameCB";
            this.PHO_FullnameCB.Size = new System.Drawing.Size(218, 21);
            this.PHO_FullnameCB.TabIndex = 3;
            this.PHO_FullnameCB.SelectionChangeCommitted += new System.EventHandler(this.PHO_FullnameCB_SelectionChangeCommitted);
            // 
            // AssistantsGB
            // 
            this.AssistantsGB.Controls.Add(this.ASS_PhoneMTB);
            this.AssistantsGB.Controls.Add(this.ASS_FullnameTB);
            this.AssistantsGB.Controls.Add(this.ASS_PhoneLabel);
            this.AssistantsGB.Controls.Add(this.ASS_FullnameLabel);
            this.AssistantsGB.Controls.Add(this.ASS_EditRecordBTN);
            this.AssistantsGB.Controls.Add(this.ASS_FullnameFindLabel);
            this.AssistantsGB.Controls.Add(this.ASS_FullnameCB);
            this.AssistantsGB.Location = new System.Drawing.Point(12, 12);
            this.AssistantsGB.Name = "AssistantsGB";
            this.AssistantsGB.Size = new System.Drawing.Size(489, 352);
            this.AssistantsGB.TabIndex = 2;
            this.AssistantsGB.TabStop = false;
            this.AssistantsGB.Text = "Таблица: Ассистенты";
            this.AssistantsGB.Visible = false;
            // 
            // ASS_EditRecordBTN
            // 
            this.ASS_EditRecordBTN.Location = new System.Drawing.Point(9, 323);
            this.ASS_EditRecordBTN.Name = "ASS_EditRecordBTN";
            this.ASS_EditRecordBTN.Size = new System.Drawing.Size(140, 23);
            this.ASS_EditRecordBTN.TabIndex = 2;
            this.ASS_EditRecordBTN.Text = "Редактировать запись";
            this.ASS_EditRecordBTN.UseVisualStyleBackColor = true;
            this.ASS_EditRecordBTN.Click += new System.EventHandler(this.ASS_EditRecordBTN_Click);
            // 
            // ASS_FullnameFindLabel
            // 
            this.ASS_FullnameFindLabel.AutoSize = true;
            this.ASS_FullnameFindLabel.Location = new System.Drawing.Point(6, 21);
            this.ASS_FullnameFindLabel.Name = "ASS_FullnameFindLabel";
            this.ASS_FullnameFindLabel.Size = new System.Drawing.Size(34, 13);
            this.ASS_FullnameFindLabel.TabIndex = 1;
            this.ASS_FullnameFindLabel.Text = "ФИО";
            // 
            // ASS_FullnameCB
            // 
            this.ASS_FullnameCB.FormattingEnabled = true;
            this.ASS_FullnameCB.Location = new System.Drawing.Point(20, 37);
            this.ASS_FullnameCB.Name = "ASS_FullnameCB";
            this.ASS_FullnameCB.Size = new System.Drawing.Size(218, 21);
            this.ASS_FullnameCB.TabIndex = 0;
            this.ASS_FullnameCB.SelectionChangeCommitted += new System.EventHandler(this.ASS_FullnameCB_SelectionChangeCommitted);
            // 
            // CustomersGB
            // 
            this.CustomersGB.Controls.Add(this.CUS_PhoneLabel);
            this.CustomersGB.Controls.Add(this.CUS_AddressLabel);
            this.CustomersGB.Controls.Add(this.CUS_FullnameLabel);
            this.CustomersGB.Controls.Add(this.CUS_PhoneMTB);
            this.CustomersGB.Controls.Add(this.CUS_AdressTB);
            this.CustomersGB.Controls.Add(this.CUS_FullnameTB);
            this.CustomersGB.Controls.Add(this.CUS_EditRecordBTN);
            this.CustomersGB.Controls.Add(this.CUS_FullnameFindLabel);
            this.CustomersGB.Controls.Add(this.CUS_FullnameCB);
            this.CustomersGB.Location = new System.Drawing.Point(12, 12);
            this.CustomersGB.Name = "CustomersGB";
            this.CustomersGB.Size = new System.Drawing.Size(489, 352);
            this.CustomersGB.TabIndex = 3;
            this.CustomersGB.TabStop = false;
            this.CustomersGB.Text = "Таблица: Заказчики";
            this.CustomersGB.Visible = false;
            // 
            // CUS_EditRecordBTN
            // 
            this.CUS_EditRecordBTN.Location = new System.Drawing.Point(9, 323);
            this.CUS_EditRecordBTN.Name = "CUS_EditRecordBTN";
            this.CUS_EditRecordBTN.Size = new System.Drawing.Size(140, 23);
            this.CUS_EditRecordBTN.TabIndex = 5;
            this.CUS_EditRecordBTN.Text = "Редактировать запись";
            this.CUS_EditRecordBTN.UseVisualStyleBackColor = true;
            this.CUS_EditRecordBTN.Click += new System.EventHandler(this.CUS_EditRecordBTN_Click);
            // 
            // CUS_FullnameFindLabel
            // 
            this.CUS_FullnameFindLabel.AutoSize = true;
            this.CUS_FullnameFindLabel.Location = new System.Drawing.Point(6, 21);
            this.CUS_FullnameFindLabel.Name = "CUS_FullnameFindLabel";
            this.CUS_FullnameFindLabel.Size = new System.Drawing.Size(34, 13);
            this.CUS_FullnameFindLabel.TabIndex = 4;
            this.CUS_FullnameFindLabel.Text = "ФИО";
            // 
            // CUS_FullnameCB
            // 
            this.CUS_FullnameCB.FormattingEnabled = true;
            this.CUS_FullnameCB.Location = new System.Drawing.Point(20, 37);
            this.CUS_FullnameCB.Name = "CUS_FullnameCB";
            this.CUS_FullnameCB.Size = new System.Drawing.Size(218, 21);
            this.CUS_FullnameCB.TabIndex = 3;
            this.CUS_FullnameCB.SelectionChangeCommitted += new System.EventHandler(this.CUS_FullnameCB_SelectionChangeCommitted);
            // 
            // ServicesGB
            // 
            this.ServicesGB.Controls.Add(this.SER_PriceLabel);
            this.ServicesGB.Controls.Add(this.SER_DescriptionLabel);
            this.ServicesGB.Controls.Add(this.SER_PriceTB);
            this.ServicesGB.Controls.Add(this.SER_DescriptionTB);
            this.ServicesGB.Controls.Add(this.SER_EditRecordBTN);
            this.ServicesGB.Controls.Add(this.SER_DescriptionFindLabel);
            this.ServicesGB.Controls.Add(this.SER_DescriptionCB);
            this.ServicesGB.Location = new System.Drawing.Point(12, 12);
            this.ServicesGB.Name = "ServicesGB";
            this.ServicesGB.Size = new System.Drawing.Size(489, 352);
            this.ServicesGB.TabIndex = 4;
            this.ServicesGB.TabStop = false;
            this.ServicesGB.Text = "Таблица: Услуги";
            this.ServicesGB.Visible = false;
            // 
            // SER_EditRecordBTN
            // 
            this.SER_EditRecordBTN.Location = new System.Drawing.Point(9, 314);
            this.SER_EditRecordBTN.Name = "SER_EditRecordBTN";
            this.SER_EditRecordBTN.Size = new System.Drawing.Size(140, 23);
            this.SER_EditRecordBTN.TabIndex = 5;
            this.SER_EditRecordBTN.Text = "Редактировать запись";
            this.SER_EditRecordBTN.UseVisualStyleBackColor = true;
            this.SER_EditRecordBTN.Click += new System.EventHandler(this.SER_EditRecordBTN_Click);
            // 
            // SER_DescriptionFindLabel
            // 
            this.SER_DescriptionFindLabel.AutoSize = true;
            this.SER_DescriptionFindLabel.Location = new System.Drawing.Point(6, 21);
            this.SER_DescriptionFindLabel.Name = "SER_DescriptionFindLabel";
            this.SER_DescriptionFindLabel.Size = new System.Drawing.Size(43, 13);
            this.SER_DescriptionFindLabel.TabIndex = 4;
            this.SER_DescriptionFindLabel.Text = "Услуга";
            // 
            // SER_DescriptionCB
            // 
            this.SER_DescriptionCB.FormattingEnabled = true;
            this.SER_DescriptionCB.Location = new System.Drawing.Point(20, 37);
            this.SER_DescriptionCB.Name = "SER_DescriptionCB";
            this.SER_DescriptionCB.Size = new System.Drawing.Size(218, 21);
            this.SER_DescriptionCB.TabIndex = 3;
            this.SER_DescriptionCB.SelectionChangeCommitted += new System.EventHandler(this.SER_DescriptionCB_SelectionChangeCommitted);
            // 
            // AssistanceGB
            // 
            this.AssistanceGB.Controls.Add(this.ASCE_EditRecordBTN);
            this.AssistanceGB.Controls.Add(this.ASCE_HelpLabel);
            this.AssistanceGB.Controls.Add(this.ASCE_HelpCB);
            this.AssistanceGB.Location = new System.Drawing.Point(12, 12);
            this.AssistanceGB.Name = "AssistanceGB";
            this.AssistanceGB.Size = new System.Drawing.Size(489, 352);
            this.AssistanceGB.TabIndex = 4;
            this.AssistanceGB.TabStop = false;
            this.AssistanceGB.Text = "Таблица: Помощь";
            this.AssistanceGB.Visible = false;
            // 
            // ASCE_EditRecordBTN
            // 
            this.ASCE_EditRecordBTN.Location = new System.Drawing.Point(9, 323);
            this.ASCE_EditRecordBTN.Name = "ASCE_EditRecordBTN";
            this.ASCE_EditRecordBTN.Size = new System.Drawing.Size(140, 23);
            this.ASCE_EditRecordBTN.TabIndex = 8;
            this.ASCE_EditRecordBTN.Text = "Редактировать запись";
            this.ASCE_EditRecordBTN.UseVisualStyleBackColor = true;
            // 
            // ASCE_HelpLabel
            // 
            this.ASCE_HelpLabel.AutoSize = true;
            this.ASCE_HelpLabel.Location = new System.Drawing.Point(6, 21);
            this.ASCE_HelpLabel.Name = "ASCE_HelpLabel";
            this.ASCE_HelpLabel.Size = new System.Drawing.Size(50, 13);
            this.ASCE_HelpLabel.TabIndex = 7;
            this.ASCE_HelpLabel.Text = "Помощь";
            // 
            // ASCE_HelpCB
            // 
            this.ASCE_HelpCB.FormattingEnabled = true;
            this.ASCE_HelpCB.Location = new System.Drawing.Point(20, 37);
            this.ASCE_HelpCB.Name = "ASCE_HelpCB";
            this.ASCE_HelpCB.Size = new System.Drawing.Size(463, 21);
            this.ASCE_HelpCB.TabIndex = 6;
            this.ASCE_HelpCB.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ASCE_HelpCB_Format);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(523, 13);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(656, 367);
            this.dataGrid.TabIndex = 5;
            // 
            // CUS_PhoneLabel
            // 
            this.CUS_PhoneLabel.AutoSize = true;
            this.CUS_PhoneLabel.Location = new System.Drawing.Point(7, 144);
            this.CUS_PhoneLabel.Name = "CUS_PhoneLabel";
            this.CUS_PhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.CUS_PhoneLabel.TabIndex = 11;
            this.CUS_PhoneLabel.Text = "Телефон";
            // 
            // CUS_AddressLabel
            // 
            this.CUS_AddressLabel.AutoSize = true;
            this.CUS_AddressLabel.Location = new System.Drawing.Point(7, 103);
            this.CUS_AddressLabel.Name = "CUS_AddressLabel";
            this.CUS_AddressLabel.Size = new System.Drawing.Size(38, 13);
            this.CUS_AddressLabel.TabIndex = 10;
            this.CUS_AddressLabel.Text = "Адрес";
            // 
            // CUS_FullnameLabel
            // 
            this.CUS_FullnameLabel.AutoSize = true;
            this.CUS_FullnameLabel.Location = new System.Drawing.Point(7, 63);
            this.CUS_FullnameLabel.Name = "CUS_FullnameLabel";
            this.CUS_FullnameLabel.Size = new System.Drawing.Size(34, 13);
            this.CUS_FullnameLabel.TabIndex = 9;
            this.CUS_FullnameLabel.Text = "ФИО";
            // 
            // CUS_PhoneMTB
            // 
            this.CUS_PhoneMTB.Location = new System.Drawing.Point(20, 160);
            this.CUS_PhoneMTB.Mask = "0-000-000-00-00";
            this.CUS_PhoneMTB.Name = "CUS_PhoneMTB";
            this.CUS_PhoneMTB.Size = new System.Drawing.Size(178, 20);
            this.CUS_PhoneMTB.TabIndex = 8;
            this.CUS_PhoneMTB.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // CUS_AdressTB
            // 
            this.CUS_AdressTB.Location = new System.Drawing.Point(20, 120);
            this.CUS_AdressTB.Name = "CUS_AdressTB";
            this.CUS_AdressTB.Size = new System.Drawing.Size(178, 20);
            this.CUS_AdressTB.TabIndex = 7;
            // 
            // CUS_FullnameTB
            // 
            this.CUS_FullnameTB.Location = new System.Drawing.Point(20, 79);
            this.CUS_FullnameTB.Name = "CUS_FullnameTB";
            this.CUS_FullnameTB.Size = new System.Drawing.Size(178, 20);
            this.CUS_FullnameTB.TabIndex = 6;
            // 
            // SER_PriceLabel
            // 
            this.SER_PriceLabel.AutoSize = true;
            this.SER_PriceLabel.Location = new System.Drawing.Point(7, 103);
            this.SER_PriceLabel.Name = "SER_PriceLabel";
            this.SER_PriceLabel.Size = new System.Drawing.Size(33, 13);
            this.SER_PriceLabel.TabIndex = 9;
            this.SER_PriceLabel.Text = "Цена";
            // 
            // SER_DescriptionLabel
            // 
            this.SER_DescriptionLabel.AutoSize = true;
            this.SER_DescriptionLabel.Location = new System.Drawing.Point(7, 63);
            this.SER_DescriptionLabel.Name = "SER_DescriptionLabel";
            this.SER_DescriptionLabel.Size = new System.Drawing.Size(93, 13);
            this.SER_DescriptionLabel.TabIndex = 8;
            this.SER_DescriptionLabel.Text = "Название услуги";
            // 
            // SER_PriceTB
            // 
            this.SER_PriceTB.Location = new System.Drawing.Point(20, 121);
            this.SER_PriceTB.Name = "SER_PriceTB";
            this.SER_PriceTB.Size = new System.Drawing.Size(178, 20);
            this.SER_PriceTB.TabIndex = 7;
            // 
            // SER_DescriptionTB
            // 
            this.SER_DescriptionTB.Location = new System.Drawing.Point(20, 80);
            this.SER_DescriptionTB.Name = "SER_DescriptionTB";
            this.SER_DescriptionTB.Size = new System.Drawing.Size(178, 20);
            this.SER_DescriptionTB.TabIndex = 6;
            // 
            // ASS_PhoneMTB
            // 
            this.ASS_PhoneMTB.Location = new System.Drawing.Point(21, 116);
            this.ASS_PhoneMTB.Mask = "0-000-000-00-00";
            this.ASS_PhoneMTB.Name = "ASS_PhoneMTB";
            this.ASS_PhoneMTB.Size = new System.Drawing.Size(97, 20);
            this.ASS_PhoneMTB.TabIndex = 7;
            this.ASS_PhoneMTB.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // ASS_FullnameTB
            // 
            this.ASS_FullnameTB.Location = new System.Drawing.Point(21, 79);
            this.ASS_FullnameTB.Name = "ASS_FullnameTB";
            this.ASS_FullnameTB.Size = new System.Drawing.Size(160, 20);
            this.ASS_FullnameTB.TabIndex = 6;
            // 
            // ASS_PhoneLabel
            // 
            this.ASS_PhoneLabel.AutoSize = true;
            this.ASS_PhoneLabel.Location = new System.Drawing.Point(8, 102);
            this.ASS_PhoneLabel.Name = "ASS_PhoneLabel";
            this.ASS_PhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.ASS_PhoneLabel.TabIndex = 5;
            this.ASS_PhoneLabel.Text = "Телефон";
            // 
            // ASS_FullnameLabel
            // 
            this.ASS_FullnameLabel.AutoSize = true;
            this.ASS_FullnameLabel.Location = new System.Drawing.Point(8, 63);
            this.ASS_FullnameLabel.Name = "ASS_FullnameLabel";
            this.ASS_FullnameLabel.Size = new System.Drawing.Size(34, 13);
            this.ASS_FullnameLabel.TabIndex = 4;
            this.ASS_FullnameLabel.Text = "ФИО";
            // 
            // EditRecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 428);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.AssistantsGB);
            this.Controls.Add(this.AssistanceGB);
            this.Controls.Add(this.PhotographersGB);
            this.Controls.Add(this.OrdersGB);
            this.Controls.Add(this.CustomersGB);
            this.Controls.Add(this.ServicesGB);
            this.Name = "EditRecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать запись";
            this.OrdersGB.ResumeLayout(false);
            this.OrdersGB.PerformLayout();
            this.PhotographersGB.ResumeLayout(false);
            this.PhotographersGB.PerformLayout();
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
        private System.Windows.Forms.Button ASS_EditRecordBTN;
        private System.Windows.Forms.Label ASS_FullnameFindLabel;
        private System.Windows.Forms.ComboBox ASS_FullnameCB;
        private System.Windows.Forms.Button PHO_EditRecordBTN;
        private System.Windows.Forms.Label PHO_FullnameFindLabel;
        private System.Windows.Forms.ComboBox PHO_FullnameCB;
        private System.Windows.Forms.Button CUS_EditRecordBTN;
        private System.Windows.Forms.Label CUS_FullnameFindLabel;
        private System.Windows.Forms.ComboBox CUS_FullnameCB;
        private System.Windows.Forms.Button SER_EditRecordBTN;
        private System.Windows.Forms.Label SER_DescriptionFindLabel;
        private System.Windows.Forms.ComboBox SER_DescriptionCB;
        private System.Windows.Forms.Button ORD_EditRecordBTN;
        private System.Windows.Forms.Label ORD_OrderLabel;
        private System.Windows.Forms.ComboBox ORD_OrderCB;
        private System.Windows.Forms.Button ASCE_EditRecordBTN;
        private System.Windows.Forms.Label ASCE_HelpLabel;
        private System.Windows.Forms.ComboBox ASCE_HelpCB;
        private System.Windows.Forms.Label PHO_AdressLabel;
        private System.Windows.Forms.Label PHO_PhoneLabel;
        private System.Windows.Forms.Label PHO_DateLabel;
        private System.Windows.Forms.Label PHO_ExperienceLabel;
        private System.Windows.Forms.Label PHO_FullnameLabel;
        private System.Windows.Forms.TextBox PHO_AdressTB;
        private System.Windows.Forms.MaskedTextBox PHO_PhoneMTB;
        private System.Windows.Forms.MaskedTextBox PHO_DateMTB;
        private System.Windows.Forms.TextBox PHO_ExperienceTB;
        private System.Windows.Forms.TextBox PHO_FullnameTB;
        private System.Windows.Forms.Label CUS_PhoneLabel;
        private System.Windows.Forms.Label CUS_AddressLabel;
        private System.Windows.Forms.Label CUS_FullnameLabel;
        private System.Windows.Forms.MaskedTextBox CUS_PhoneMTB;
        private System.Windows.Forms.TextBox CUS_AdressTB;
        private System.Windows.Forms.TextBox CUS_FullnameTB;
        private System.Windows.Forms.Label SER_PriceLabel;
        private System.Windows.Forms.Label SER_DescriptionLabel;
        private System.Windows.Forms.TextBox SER_PriceTB;
        private System.Windows.Forms.TextBox SER_DescriptionTB;
        private System.Windows.Forms.MaskedTextBox ASS_PhoneMTB;
        private System.Windows.Forms.TextBox ASS_FullnameTB;
        private System.Windows.Forms.Label ASS_PhoneLabel;
        private System.Windows.Forms.Label ASS_FullnameLabel;
    }
}