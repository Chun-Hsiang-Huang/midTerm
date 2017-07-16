namespace 期中專題
{
    partial class 值日生
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
            this.cbDStudent = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnToCounter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCompanyName = new System.Windows.Forms.ComboBox();
            this.btnSure = new System.Windows.Forms.Button();
            this.lbCheck = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbDStudent
            // 
            this.cbDStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbDStudent.FormattingEnabled = true;
            this.cbDStudent.Location = new System.Drawing.Point(115, 19);
            this.cbDStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDStudent.Name = "cbDStudent";
            this.cbDStudent.Size = new System.Drawing.Size(144, 28);
            this.cbDStudent.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 32);
            this.label11.TabIndex = 35;
            this.label11.Text = "值日生";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheck.Location = new System.Drawing.Point(636, 12);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(116, 32);
            this.btnCheck.TabIndex = 37;
            this.btnCheck.Text = "查詢訂單";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnToCounter
            // 
            this.btnToCounter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnToCounter.Location = new System.Drawing.Point(612, 516);
            this.btnToCounter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToCounter.Name = "btnToCounter";
            this.btnToCounter.Size = new System.Drawing.Size(140, 36);
            this.btnToCounter.TabIndex = 38;
            this.btnToCounter.Text = "送至櫃台";
            this.btnToCounter.UseVisualStyleBackColor = true;
            this.btnToCounter.Click += new System.EventHandler(this.btnToCounter_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "店名";
            // 
            // cbCompanyName
            // 
            this.cbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompanyName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbCompanyName.FormattingEnabled = true;
            this.cbCompanyName.Location = new System.Drawing.Point(115, 68);
            this.cbCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCompanyName.Name = "cbCompanyName";
            this.cbCompanyName.Size = new System.Drawing.Size(173, 28);
            this.cbCompanyName.TabIndex = 40;
            // 
            // btnSure
            // 
            this.btnSure.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSure.Location = new System.Drawing.Point(398, 12);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(116, 32);
            this.btnSure.TabIndex = 41;
            this.btnSure.Text = "確定店家";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // lbCheck
            // 
            this.lbCheck.BackColor = System.Drawing.Color.Lavender;
            this.lbCheck.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCheck.FormattingEnabled = true;
            this.lbCheck.ItemHeight = 20;
            this.lbCheck.Location = new System.Drawing.Point(16, 120);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(736, 384);
            this.lbCheck.TabIndex = 42;
            // 
            // 值日生
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(764, 563);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCompanyName);
            this.Controls.Add(this.btnToCounter);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.cbDStudent);
            this.Controls.Add(this.label11);
            this.Name = "值日生";
            this.Text = "值日生";
            this.Load += new System.EventHandler(this.值日生_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDStudent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnToCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCompanyName;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.ListBox lbCheck;
    }
}