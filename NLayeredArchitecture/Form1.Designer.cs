namespace NLayeredArchitecture
{
    partial class Form1
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
            this.DataPanel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DutyBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ListBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // DataPanel
            // 
            this.DataPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPanel.Location = new System.Drawing.Point(12, 12);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(638, 166);
            this.DataPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(166, 211);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(133, 27);
            this.IDBox.TabIndex = 2;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(166, 244);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(133, 27);
            this.NameBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(166, 277);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(133, 27);
            this.SurnameBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname:";
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(405, 211);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(133, 27);
            this.CityBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "City:";
            // 
            // DutyBox
            // 
            this.DutyBox.Location = new System.Drawing.Point(405, 244);
            this.DutyBox.Name = "DutyBox";
            this.DutyBox.Size = new System.Drawing.Size(133, 27);
            this.DutyBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Duty:";
            // 
            // SalaryBox
            // 
            this.SalaryBox.Location = new System.Drawing.Point(405, 280);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(133, 27);
            this.SalaryBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Salary:";
            // 
            // ListBtn
            // 
            this.ListBtn.Location = new System.Drawing.Point(166, 328);
            this.ListBtn.Name = "ListBtn";
            this.ListBtn.Size = new System.Drawing.Size(133, 32);
            this.ListBtn.TabIndex = 13;
            this.ListBtn.Text = "List";
            this.ListBtn.UseVisualStyleBackColor = true;
            this.ListBtn.Click += new System.EventHandler(this.ListBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(405, 328);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(133, 32);
            this.DelBtn.TabIndex = 14;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 372);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.ListBtn);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DutyBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataPanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DutyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SalaryBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ListBtn;
        private System.Windows.Forms.Button DelBtn;
    }
}

