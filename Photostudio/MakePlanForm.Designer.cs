namespace Photostudio
{
    partial class MakePlanForm
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
            this.numOrdersLabel = new System.Windows.Forms.Label();
            this.numOrdersTB = new System.Windows.Forms.TextBox();
            this.incomeTB = new System.Windows.Forms.TextBox();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.consumptionTB = new System.Windows.Forms.TextBox();
            this.consumptionLabel = new System.Windows.Forms.Label();
            this.monthTB = new System.Windows.Forms.TextBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearTB = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.makePlanBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numOrdersLabel
            // 
            this.numOrdersLabel.AutoSize = true;
            this.numOrdersLabel.Location = new System.Drawing.Point(9, 63);
            this.numOrdersLabel.Name = "numOrdersLabel";
            this.numOrdersLabel.Size = new System.Drawing.Size(111, 13);
            this.numOrdersLabel.TabIndex = 0;
            this.numOrdersLabel.Text = "Количество заказов";
            // 
            // numOrdersTB
            // 
            this.numOrdersTB.Location = new System.Drawing.Point(12, 80);
            this.numOrdersTB.Name = "numOrdersTB";
            this.numOrdersTB.Size = new System.Drawing.Size(100, 20);
            this.numOrdersTB.TabIndex = 3;
            // 
            // incomeTB
            // 
            this.incomeTB.Location = new System.Drawing.Point(12, 123);
            this.incomeTB.Name = "incomeTB";
            this.incomeTB.Size = new System.Drawing.Size(100, 20);
            this.incomeTB.TabIndex = 4;
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Location = new System.Drawing.Point(9, 106);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(39, 13);
            this.incomeLabel.TabIndex = 2;
            this.incomeLabel.Text = "Доход";
            // 
            // consumptionTB
            // 
            this.consumptionTB.Location = new System.Drawing.Point(12, 172);
            this.consumptionTB.Name = "consumptionTB";
            this.consumptionTB.Size = new System.Drawing.Size(100, 20);
            this.consumptionTB.TabIndex = 5;
            // 
            // consumptionLabel
            // 
            this.consumptionLabel.AutoSize = true;
            this.consumptionLabel.Location = new System.Drawing.Point(9, 155);
            this.consumptionLabel.Name = "consumptionLabel";
            this.consumptionLabel.Size = new System.Drawing.Size(43, 13);
            this.consumptionLabel.TabIndex = 4;
            this.consumptionLabel.Text = "Расход";
            // 
            // monthTB
            // 
            this.monthTB.Location = new System.Drawing.Point(12, 25);
            this.monthTB.Name = "monthTB";
            this.monthTB.Size = new System.Drawing.Size(100, 20);
            this.monthTB.TabIndex = 1;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(9, 9);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 6;
            this.monthLabel.Text = "Месяц";
            // 
            // yearTB
            // 
            this.yearTB.Location = new System.Drawing.Point(138, 25);
            this.yearTB.Name = "yearTB";
            this.yearTB.Size = new System.Drawing.Size(100, 20);
            this.yearTB.TabIndex = 2;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(135, 9);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(25, 13);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "Год";
            // 
            // makePlanBTN
            // 
            this.makePlanBTN.Location = new System.Drawing.Point(155, 226);
            this.makePlanBTN.Name = "makePlanBTN";
            this.makePlanBTN.Size = new System.Drawing.Size(117, 23);
            this.makePlanBTN.TabIndex = 10;
            this.makePlanBTN.Text = "Создать план";
            this.makePlanBTN.UseVisualStyleBackColor = true;
            this.makePlanBTN.Click += new System.EventHandler(this.makePlanBTN_Click);
            // 
            // MakePlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.makePlanBTN);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearTB);
            this.Controls.Add(this.monthTB);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.consumptionTB);
            this.Controls.Add(this.consumptionLabel);
            this.Controls.Add(this.incomeTB);
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.numOrdersTB);
            this.Controls.Add(this.numOrdersLabel);
            this.Name = "MakePlanForm";
            this.Text = "Создание плана";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOrdersLabel;
        private System.Windows.Forms.TextBox numOrdersTB;
        private System.Windows.Forms.TextBox incomeTB;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.TextBox consumptionTB;
        private System.Windows.Forms.Label consumptionLabel;
        private System.Windows.Forms.TextBox monthTB;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.TextBox yearTB;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button makePlanBTN;
    }
}