namespace Photostudio
{
    partial class ViewPlanForm
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
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTB = new System.Windows.Forms.TextBox();
            this.monthTB = new System.Windows.Forms.TextBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.viewPlanBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(136, 14);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(25, 13);
            this.yearLabel.TabIndex = 13;
            this.yearLabel.Text = "Год";
            // 
            // yearTB
            // 
            this.yearTB.Location = new System.Drawing.Point(139, 30);
            this.yearTB.Name = "yearTB";
            this.yearTB.Size = new System.Drawing.Size(100, 20);
            this.yearTB.TabIndex = 11;
            // 
            // monthTB
            // 
            this.monthTB.Location = new System.Drawing.Point(13, 30);
            this.monthTB.Name = "monthTB";
            this.monthTB.Size = new System.Drawing.Size(100, 20);
            this.monthTB.TabIndex = 10;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(10, 14);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 12;
            this.monthLabel.Text = "Месяц";
            // 
            // viewPlanBTN
            // 
            this.viewPlanBTN.Location = new System.Drawing.Point(68, 67);
            this.viewPlanBTN.Name = "viewPlanBTN";
            this.viewPlanBTN.Size = new System.Drawing.Size(117, 23);
            this.viewPlanBTN.TabIndex = 14;
            this.viewPlanBTN.Text = "Просмотреть план";
            this.viewPlanBTN.UseVisualStyleBackColor = true;
            this.viewPlanBTN.Click += new System.EventHandler(this.viewPlanBTN_Click);
            // 
            // ViewPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 102);
            this.Controls.Add(this.viewPlanBTN);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearTB);
            this.Controls.Add(this.monthTB);
            this.Controls.Add(this.monthLabel);
            this.Name = "ViewPlanForm";
            this.Text = "Просмотр плана";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTB;
        private System.Windows.Forms.TextBox monthTB;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Button viewPlanBTN;
    }
}