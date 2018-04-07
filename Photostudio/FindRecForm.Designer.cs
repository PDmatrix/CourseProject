namespace Photostudio
{
    partial class FindRecForm
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
            this.PhotographersGB = new System.Windows.Forms.GroupBox();
            this.PHO_FindRecordBTN = new System.Windows.Forms.Button();
            this.PHO_FullnameLabel = new System.Windows.Forms.Label();
            this.PHO_FullnameCB = new System.Windows.Forms.ComboBox();
            this.AssistantsGB = new System.Windows.Forms.GroupBox();
            this.ASS_FindRecordBTN = new System.Windows.Forms.Button();
            this.ASS_FullnameLabel = new System.Windows.Forms.Label();
            this.ASS_FullnameCB = new System.Windows.Forms.ComboBox();
            this.CustomersGB = new System.Windows.Forms.GroupBox();
            this.CUS_FindRecordBTN = new System.Windows.Forms.Button();
            this.CUS_FullnameLabel = new System.Windows.Forms.Label();
            this.CUS_FullnameCB = new System.Windows.Forms.ComboBox();
            this.ServicesGB = new System.Windows.Forms.GroupBox();
            this.SER_FindRecordBTN = new System.Windows.Forms.Button();
            this.SER_DescriptionLabel = new System.Windows.Forms.Label();
            this.SER_DescriptionCB = new System.Windows.Forms.ComboBox();
            this.AssistanceGB = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.PhotographersGB.SuspendLayout();
            this.AssistantsGB.SuspendLayout();
            this.CustomersGB.SuspendLayout();
            this.ServicesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGB
            // 
            this.OrdersGB.Location = new System.Drawing.Point(12, 12);
            this.OrdersGB.Name = "OrdersGB";
            this.OrdersGB.Size = new System.Drawing.Size(489, 352);
            this.OrdersGB.TabIndex = 0;
            this.OrdersGB.TabStop = false;
            this.OrdersGB.Text = "Таблица: Заказы";
            this.OrdersGB.Visible = false;
            // 
            // PhotographersGB
            // 
            this.PhotographersGB.Controls.Add(this.PHO_FindRecordBTN);
            this.PhotographersGB.Controls.Add(this.PHO_FullnameLabel);
            this.PhotographersGB.Controls.Add(this.PHO_FullnameCB);
            this.PhotographersGB.Location = new System.Drawing.Point(12, 12);
            this.PhotographersGB.Name = "PhotographersGB";
            this.PhotographersGB.Size = new System.Drawing.Size(489, 352);
            this.PhotographersGB.TabIndex = 1;
            this.PhotographersGB.TabStop = false;
            this.PhotographersGB.Text = "Таблица: Фотографы";
            this.PhotographersGB.Visible = false;
            // 
            // PHO_FindRecordBTN
            // 
            this.PHO_FindRecordBTN.Location = new System.Drawing.Point(9, 323);
            this.PHO_FindRecordBTN.Name = "PHO_FindRecordBTN";
            this.PHO_FindRecordBTN.Size = new System.Drawing.Size(140, 23);
            this.PHO_FindRecordBTN.TabIndex = 5;
            this.PHO_FindRecordBTN.Text = "Найти запись";
            this.PHO_FindRecordBTN.UseVisualStyleBackColor = true;
            this.PHO_FindRecordBTN.Click += new System.EventHandler(this.PHO_FindRecordBTN_Click);
            // 
            // PHO_FullnameLabel
            // 
            this.PHO_FullnameLabel.AutoSize = true;
            this.PHO_FullnameLabel.Location = new System.Drawing.Point(6, 21);
            this.PHO_FullnameLabel.Name = "PHO_FullnameLabel";
            this.PHO_FullnameLabel.Size = new System.Drawing.Size(34, 13);
            this.PHO_FullnameLabel.TabIndex = 4;
            this.PHO_FullnameLabel.Text = "ФИО";
            // 
            // PHO_FullnameCB
            // 
            this.PHO_FullnameCB.FormattingEnabled = true;
            this.PHO_FullnameCB.Location = new System.Drawing.Point(20, 37);
            this.PHO_FullnameCB.Name = "PHO_FullnameCB";
            this.PHO_FullnameCB.Size = new System.Drawing.Size(218, 21);
            this.PHO_FullnameCB.TabIndex = 3;
            // 
            // AssistantsGB
            // 
            this.AssistantsGB.Controls.Add(this.ASS_FindRecordBTN);
            this.AssistantsGB.Controls.Add(this.ASS_FullnameLabel);
            this.AssistantsGB.Controls.Add(this.ASS_FullnameCB);
            this.AssistantsGB.Location = new System.Drawing.Point(12, 12);
            this.AssistantsGB.Name = "AssistantsGB";
            this.AssistantsGB.Size = new System.Drawing.Size(489, 352);
            this.AssistantsGB.TabIndex = 2;
            this.AssistantsGB.TabStop = false;
            this.AssistantsGB.Text = "Таблица: Ассистенты";
            this.AssistantsGB.Visible = false;
            // 
            // ASS_FindRecordBTN
            // 
            this.ASS_FindRecordBTN.Location = new System.Drawing.Point(9, 323);
            this.ASS_FindRecordBTN.Name = "ASS_FindRecordBTN";
            this.ASS_FindRecordBTN.Size = new System.Drawing.Size(140, 23);
            this.ASS_FindRecordBTN.TabIndex = 2;
            this.ASS_FindRecordBTN.Text = "Найти запись";
            this.ASS_FindRecordBTN.UseVisualStyleBackColor = true;
            this.ASS_FindRecordBTN.Click += new System.EventHandler(this.ASS_FindRecordBTN_Click);
            // 
            // ASS_FullnameLabel
            // 
            this.ASS_FullnameLabel.AutoSize = true;
            this.ASS_FullnameLabel.Location = new System.Drawing.Point(6, 21);
            this.ASS_FullnameLabel.Name = "ASS_FullnameLabel";
            this.ASS_FullnameLabel.Size = new System.Drawing.Size(34, 13);
            this.ASS_FullnameLabel.TabIndex = 1;
            this.ASS_FullnameLabel.Text = "ФИО";
            // 
            // ASS_FullnameCB
            // 
            this.ASS_FullnameCB.FormattingEnabled = true;
            this.ASS_FullnameCB.Location = new System.Drawing.Point(20, 37);
            this.ASS_FullnameCB.Name = "ASS_FullnameCB";
            this.ASS_FullnameCB.Size = new System.Drawing.Size(218, 21);
            this.ASS_FullnameCB.TabIndex = 0;
            // 
            // CustomersGB
            // 
            this.CustomersGB.Controls.Add(this.CUS_FindRecordBTN);
            this.CustomersGB.Controls.Add(this.CUS_FullnameLabel);
            this.CustomersGB.Controls.Add(this.CUS_FullnameCB);
            this.CustomersGB.Location = new System.Drawing.Point(12, 12);
            this.CustomersGB.Name = "CustomersGB";
            this.CustomersGB.Size = new System.Drawing.Size(489, 352);
            this.CustomersGB.TabIndex = 3;
            this.CustomersGB.TabStop = false;
            this.CustomersGB.Text = "Таблица: Заказчики";
            this.CustomersGB.Visible = false;
            // 
            // CUS_FindRecordBTN
            // 
            this.CUS_FindRecordBTN.Location = new System.Drawing.Point(9, 323);
            this.CUS_FindRecordBTN.Name = "CUS_FindRecordBTN";
            this.CUS_FindRecordBTN.Size = new System.Drawing.Size(140, 23);
            this.CUS_FindRecordBTN.TabIndex = 5;
            this.CUS_FindRecordBTN.Text = "Найти запись";
            this.CUS_FindRecordBTN.UseVisualStyleBackColor = true;
            this.CUS_FindRecordBTN.Click += new System.EventHandler(this.CUS_FindRecordBTN_Click);
            // 
            // CUS_FullnameLabel
            // 
            this.CUS_FullnameLabel.AutoSize = true;
            this.CUS_FullnameLabel.Location = new System.Drawing.Point(6, 21);
            this.CUS_FullnameLabel.Name = "CUS_FullnameLabel";
            this.CUS_FullnameLabel.Size = new System.Drawing.Size(34, 13);
            this.CUS_FullnameLabel.TabIndex = 4;
            this.CUS_FullnameLabel.Text = "ФИО";
            // 
            // CUS_FullnameCB
            // 
            this.CUS_FullnameCB.FormattingEnabled = true;
            this.CUS_FullnameCB.Location = new System.Drawing.Point(20, 37);
            this.CUS_FullnameCB.Name = "CUS_FullnameCB";
            this.CUS_FullnameCB.Size = new System.Drawing.Size(218, 21);
            this.CUS_FullnameCB.TabIndex = 3;
            // 
            // ServicesGB
            // 
            this.ServicesGB.Controls.Add(this.SER_FindRecordBTN);
            this.ServicesGB.Controls.Add(this.SER_DescriptionLabel);
            this.ServicesGB.Controls.Add(this.SER_DescriptionCB);
            this.ServicesGB.Location = new System.Drawing.Point(12, 12);
            this.ServicesGB.Name = "ServicesGB";
            this.ServicesGB.Size = new System.Drawing.Size(489, 352);
            this.ServicesGB.TabIndex = 4;
            this.ServicesGB.TabStop = false;
            this.ServicesGB.Text = "Таблица: Услуги";
            this.ServicesGB.Visible = false;
            // 
            // SER_FindRecordBTN
            // 
            this.SER_FindRecordBTN.Location = new System.Drawing.Point(9, 314);
            this.SER_FindRecordBTN.Name = "SER_FindRecordBTN";
            this.SER_FindRecordBTN.Size = new System.Drawing.Size(140, 23);
            this.SER_FindRecordBTN.TabIndex = 5;
            this.SER_FindRecordBTN.Text = "Найти запись";
            this.SER_FindRecordBTN.UseVisualStyleBackColor = true;
            this.SER_FindRecordBTN.Click += new System.EventHandler(this.SER_FindRecordBTN_Click);
            // 
            // SER_DescriptionLabel
            // 
            this.SER_DescriptionLabel.AutoSize = true;
            this.SER_DescriptionLabel.Location = new System.Drawing.Point(6, 21);
            this.SER_DescriptionLabel.Name = "SER_DescriptionLabel";
            this.SER_DescriptionLabel.Size = new System.Drawing.Size(43, 13);
            this.SER_DescriptionLabel.TabIndex = 4;
            this.SER_DescriptionLabel.Text = "Услуга";
            // 
            // SER_DescriptionCB
            // 
            this.SER_DescriptionCB.FormattingEnabled = true;
            this.SER_DescriptionCB.Location = new System.Drawing.Point(20, 37);
            this.SER_DescriptionCB.Name = "SER_DescriptionCB";
            this.SER_DescriptionCB.Size = new System.Drawing.Size(218, 21);
            this.SER_DescriptionCB.TabIndex = 3;
            // 
            // AssistanceGB
            // 
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
            this.dataGrid.Location = new System.Drawing.Point(523, 13);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(656, 367);
            this.dataGrid.TabIndex = 5;
            // 
            // FindRecForm
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
            this.Name = "FindRecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Найти запись";
            this.PhotographersGB.ResumeLayout(false);
            this.PhotographersGB.PerformLayout();
            this.AssistantsGB.ResumeLayout(false);
            this.AssistantsGB.PerformLayout();
            this.CustomersGB.ResumeLayout(false);
            this.CustomersGB.PerformLayout();
            this.ServicesGB.ResumeLayout(false);
            this.ServicesGB.PerformLayout();
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
        private System.Windows.Forms.Button ASS_FindRecordBTN;
        private System.Windows.Forms.Label ASS_FullnameLabel;
        private System.Windows.Forms.ComboBox ASS_FullnameCB;
        private System.Windows.Forms.Button PHO_FindRecordBTN;
        private System.Windows.Forms.Label PHO_FullnameLabel;
        private System.Windows.Forms.ComboBox PHO_FullnameCB;
        private System.Windows.Forms.Button CUS_FindRecordBTN;
        private System.Windows.Forms.Label CUS_FullnameLabel;
        private System.Windows.Forms.ComboBox CUS_FullnameCB;
        private System.Windows.Forms.Button SER_FindRecordBTN;
        private System.Windows.Forms.Label SER_DescriptionLabel;
        private System.Windows.Forms.ComboBox SER_DescriptionCB;
    }
}