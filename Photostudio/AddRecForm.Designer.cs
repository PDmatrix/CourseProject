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
            this.PHO_AddRecordBTN = new System.Windows.Forms.Button();
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
            this.AssistantsGB = new System.Windows.Forms.GroupBox();
            this.ASS_AddRecordBTN = new System.Windows.Forms.Button();
            this.ASS_PhoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.ASS_FullnameTB = new System.Windows.Forms.TextBox();
            this.ASS_PhoneLabel = new System.Windows.Forms.Label();
            this.ASS_FullnameLabel = new System.Windows.Forms.Label();
            this.CustomersGB = new System.Windows.Forms.GroupBox();
            this.CUS_AddRecordBTN = new System.Windows.Forms.Button();
            this.CUS_PhoneLabel = new System.Windows.Forms.Label();
            this.CUS_AddressLabel = new System.Windows.Forms.Label();
            this.CUS_FullnameLabel = new System.Windows.Forms.Label();
            this.CUS_PhoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.CUS_AdressTB = new System.Windows.Forms.TextBox();
            this.CUS_FullnameTB = new System.Windows.Forms.TextBox();
            this.ServicesGB = new System.Windows.Forms.GroupBox();
            this.SER_AddRecordBTN = new System.Windows.Forms.Button();
            this.SER_PriceLabel = new System.Windows.Forms.Label();
            this.SER_DescriptionLabel = new System.Windows.Forms.Label();
            this.SER_PriceTB = new System.Windows.Forms.TextBox();
            this.SER_DescriptionTB = new System.Windows.Forms.TextBox();
            this.AssistanceGB = new System.Windows.Forms.GroupBox();
            this.ASCE_AddRecordBTN = new System.Windows.Forms.Button();
            this.ASCE_OrderLabel = new System.Windows.Forms.Label();
            this.ASCE_AssistantLabel = new System.Windows.Forms.Label();
            this.ASCE_OrderCB = new System.Windows.Forms.ComboBox();
            this.ASCE_AssistantCB = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
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
            this.ORD_DateLabel.Size = new System.Drawing.Size(33, 13);
            this.ORD_DateLabel.TabIndex = 11;
            this.ORD_DateLabel.Text = "Дата";
            // 
            // ORD_ServicesLabel
            // 
            this.ORD_ServicesLabel.AutoSize = true;
            this.ORD_ServicesLabel.Location = new System.Drawing.Point(6, 96);
            this.ORD_ServicesLabel.Name = "ORD_ServicesLabel";
            this.ORD_ServicesLabel.Size = new System.Drawing.Size(43, 13);
            this.ORD_ServicesLabel.TabIndex = 10;
            this.ORD_ServicesLabel.Text = "Услуга";
            // 
            // ORD_PhotographersLabel
            // 
            this.ORD_PhotographersLabel.AutoSize = true;
            this.ORD_PhotographersLabel.Location = new System.Drawing.Point(6, 56);
            this.ORD_PhotographersLabel.Name = "ORD_PhotographersLabel";
            this.ORD_PhotographersLabel.Size = new System.Drawing.Size(60, 13);
            this.ORD_PhotographersLabel.TabIndex = 9;
            this.ORD_PhotographersLabel.Text = "Фотограф";
            // 
            // ORD_CustomersLabe
            // 
            this.ORD_CustomersLabe.AutoSize = true;
            this.ORD_CustomersLabe.Location = new System.Drawing.Point(6, 16);
            this.ORD_CustomersLabe.Name = "ORD_CustomersLabe";
            this.ORD_CustomersLabe.Size = new System.Drawing.Size(55, 13);
            this.ORD_CustomersLabe.TabIndex = 8;
            this.ORD_CustomersLabe.Text = "Заказчик";
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
            this.PhotographersGB.Controls.Add(this.PHO_AddRecordBTN);
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
            this.PhotographersGB.Location = new System.Drawing.Point(12, 12);
            this.PhotographersGB.Name = "PhotographersGB";
            this.PhotographersGB.Size = new System.Drawing.Size(489, 352);
            this.PhotographersGB.TabIndex = 1;
            this.PhotographersGB.TabStop = false;
            this.PhotographersGB.Text = "Таблица: Фотографы";
            this.PhotographersGB.Visible = false;
            // 
            // PHO_AddRecordBTN
            // 
            this.PHO_AddRecordBTN.Location = new System.Drawing.Point(14, 321);
            this.PHO_AddRecordBTN.Name = "PHO_AddRecordBTN";
            this.PHO_AddRecordBTN.Size = new System.Drawing.Size(129, 23);
            this.PHO_AddRecordBTN.TabIndex = 10;
            this.PHO_AddRecordBTN.Text = "Добавить запись";
            this.PHO_AddRecordBTN.UseVisualStyleBackColor = true;
            this.PHO_AddRecordBTN.Click += new System.EventHandler(this.PHO_AddRecordBTN_Click);
            // 
            // PHO_AdressLabel
            // 
            this.PHO_AdressLabel.AutoSize = true;
            this.PHO_AdressLabel.Location = new System.Drawing.Point(11, 175);
            this.PHO_AdressLabel.Name = "PHO_AdressLabel";
            this.PHO_AdressLabel.Size = new System.Drawing.Size(38, 13);
            this.PHO_AdressLabel.TabIndex = 9;
            this.PHO_AdressLabel.Text = "Адрес";
            // 
            // PHO_PhoneLabel
            // 
            this.PHO_PhoneLabel.AutoSize = true;
            this.PHO_PhoneLabel.Location = new System.Drawing.Point(11, 136);
            this.PHO_PhoneLabel.Name = "PHO_PhoneLabel";
            this.PHO_PhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.PHO_PhoneLabel.TabIndex = 8;
            this.PHO_PhoneLabel.Text = "Телефон";
            // 
            // PHO_DateLabel
            // 
            this.PHO_DateLabel.AutoSize = true;
            this.PHO_DateLabel.Location = new System.Drawing.Point(9, 95);
            this.PHO_DateLabel.Name = "PHO_DateLabel";
            this.PHO_DateLabel.Size = new System.Drawing.Size(86, 13);
            this.PHO_DateLabel.TabIndex = 7;
            this.PHO_DateLabel.Text = "Дата рождения";
            // 
            // PHO_ExperienceLabel
            // 
            this.PHO_ExperienceLabel.AutoSize = true;
            this.PHO_ExperienceLabel.Location = new System.Drawing.Point(11, 56);
            this.PHO_ExperienceLabel.Name = "PHO_ExperienceLabel";
            this.PHO_ExperienceLabel.Size = new System.Drawing.Size(73, 13);
            this.PHO_ExperienceLabel.TabIndex = 6;
            this.PHO_ExperienceLabel.Text = "Стаж работы";
            // 
            // PHO_FullnameLabel
            // 
            this.PHO_FullnameLabel.AutoSize = true;
            this.PHO_FullnameLabel.Location = new System.Drawing.Point(11, 17);
            this.PHO_FullnameLabel.Name = "PHO_FullnameLabel";
            this.PHO_FullnameLabel.Size = new System.Drawing.Size(34, 13);
            this.PHO_FullnameLabel.TabIndex = 5;
            this.PHO_FullnameLabel.Text = "ФИО";
            // 
            // PHO_AdressTB
            // 
            this.PHO_AdressTB.Location = new System.Drawing.Point(32, 191);
            this.PHO_AdressTB.Name = "PHO_AdressTB";
            this.PHO_AdressTB.Size = new System.Drawing.Size(150, 20);
            this.PHO_AdressTB.TabIndex = 4;
            // 
            // PHO_PhoneMTB
            // 
            this.PHO_PhoneMTB.Location = new System.Drawing.Point(32, 152);
            this.PHO_PhoneMTB.Mask = "0-000-000-00-00";
            this.PHO_PhoneMTB.Name = "PHO_PhoneMTB";
            this.PHO_PhoneMTB.Size = new System.Drawing.Size(150, 20);
            this.PHO_PhoneMTB.TabIndex = 3;
            this.PHO_PhoneMTB.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // PHO_DateMTB
            // 
            this.PHO_DateMTB.Location = new System.Drawing.Point(32, 111);
            this.PHO_DateMTB.Mask = "00/00/0000";
            this.PHO_DateMTB.Name = "PHO_DateMTB";
            this.PHO_DateMTB.Size = new System.Drawing.Size(150, 20);
            this.PHO_DateMTB.TabIndex = 2;
            this.PHO_DateMTB.ValidatingType = typeof(System.DateTime);
            // 
            // PHO_ExperienceTB
            // 
            this.PHO_ExperienceTB.Location = new System.Drawing.Point(32, 72);
            this.PHO_ExperienceTB.Name = "PHO_ExperienceTB";
            this.PHO_ExperienceTB.Size = new System.Drawing.Size(150, 20);
            this.PHO_ExperienceTB.TabIndex = 1;
            // 
            // PHO_FullnameTB
            // 
            this.PHO_FullnameTB.Location = new System.Drawing.Point(32, 32);
            this.PHO_FullnameTB.Name = "PHO_FullnameTB";
            this.PHO_FullnameTB.Size = new System.Drawing.Size(150, 20);
            this.PHO_FullnameTB.TabIndex = 0;
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
            // ASS_PhoneMTB
            // 
            this.ASS_PhoneMTB.Location = new System.Drawing.Point(22, 73);
            this.ASS_PhoneMTB.Mask = "0-000-000-00-00";
            this.ASS_PhoneMTB.Name = "ASS_PhoneMTB";
            this.ASS_PhoneMTB.Size = new System.Drawing.Size(97, 20);
            this.ASS_PhoneMTB.TabIndex = 3;
            this.ASS_PhoneMTB.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // ASS_FullnameTB
            // 
            this.ASS_FullnameTB.Location = new System.Drawing.Point(22, 36);
            this.ASS_FullnameTB.Name = "ASS_FullnameTB";
            this.ASS_FullnameTB.Size = new System.Drawing.Size(160, 20);
            this.ASS_FullnameTB.TabIndex = 2;
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
            // ASS_FullnameLabel
            // 
            this.ASS_FullnameLabel.AutoSize = true;
            this.ASS_FullnameLabel.Location = new System.Drawing.Point(9, 20);
            this.ASS_FullnameLabel.Name = "ASS_FullnameLabel";
            this.ASS_FullnameLabel.Size = new System.Drawing.Size(34, 13);
            this.ASS_FullnameLabel.TabIndex = 0;
            this.ASS_FullnameLabel.Text = "ФИО";
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
            // SER_PriceLabel
            // 
            this.SER_PriceLabel.AutoSize = true;
            this.SER_PriceLabel.Location = new System.Drawing.Point(6, 56);
            this.SER_PriceLabel.Name = "SER_PriceLabel";
            this.SER_PriceLabel.Size = new System.Drawing.Size(33, 13);
            this.SER_PriceLabel.TabIndex = 3;
            this.SER_PriceLabel.Text = "Цена";
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
            // SER_PriceTB
            // 
            this.SER_PriceTB.Location = new System.Drawing.Point(19, 74);
            this.SER_PriceTB.Name = "SER_PriceTB";
            this.SER_PriceTB.Size = new System.Drawing.Size(178, 20);
            this.SER_PriceTB.TabIndex = 1;
            // 
            // SER_DescriptionTB
            // 
            this.SER_DescriptionTB.Location = new System.Drawing.Point(19, 33);
            this.SER_DescriptionTB.Name = "SER_DescriptionTB";
            this.SER_DescriptionTB.Size = new System.Drawing.Size(178, 20);
            this.SER_DescriptionTB.TabIndex = 0;
            // 
            // AssistanceGB
            // 
            this.AssistanceGB.Controls.Add(this.ASCE_AddRecordBTN);
            this.AssistanceGB.Controls.Add(this.ASCE_OrderLabel);
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
            // ASCE_OrderLabel
            // 
            this.ASCE_OrderLabel.AutoSize = true;
            this.ASCE_OrderLabel.Location = new System.Drawing.Point(11, 59);
            this.ASCE_OrderLabel.Name = "ASCE_OrderLabel";
            this.ASCE_OrderLabel.Size = new System.Drawing.Size(38, 13);
            this.ASCE_OrderLabel.TabIndex = 3;
            this.ASCE_OrderLabel.Text = "Заказ";
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
            // ASCE_OrderCB
            // 
            this.ASCE_OrderCB.FormattingEnabled = true;
            this.ASCE_OrderCB.Location = new System.Drawing.Point(32, 75);
            this.ASCE_OrderCB.Name = "ASCE_OrderCB";
            this.ASCE_OrderCB.Size = new System.Drawing.Size(451, 21);
            this.ASCE_OrderCB.TabIndex = 1;
            this.ASCE_OrderCB.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ASCE_OrderCB_Format);
            // 
            // ASCE_AssistantCB
            // 
            this.ASCE_AssistantCB.FormattingEnabled = true;
            this.ASCE_AssistantCB.Location = new System.Drawing.Point(32, 33);
            this.ASCE_AssistantCB.Name = "ASCE_AssistantCB";
            this.ASCE_AssistantCB.Size = new System.Drawing.Size(185, 21);
            this.ASCE_AssistantCB.TabIndex = 0;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(525, 21);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(666, 322);
            this.dataGrid.TabIndex = 5;
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
        private System.Windows.Forms.Label ASCE_OrderLabel;
        private System.Windows.Forms.Label ASCE_AssistantLabel;
        private System.Windows.Forms.ComboBox ASCE_OrderCB;
        private System.Windows.Forms.ComboBox ASCE_AssistantCB;
        private System.Windows.Forms.Button ASCE_AddRecordBTN;
        private System.Windows.Forms.Button PHO_AddRecordBTN;
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
    }
}