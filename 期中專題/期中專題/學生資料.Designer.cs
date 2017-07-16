namespace 期中專題
{
    partial class 學生資料
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
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.btnDelStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbCellPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSID = new System.Windows.Forms.ComboBox();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.tbUpdatePhone = new System.Windows.Forms.TextBox();
            this.tbUpdateName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearchStudent.Location = new System.Drawing.Point(12, 26);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(111, 44);
            this.btnSearchStudent.TabIndex = 0;
            this.btnSearchStudent.Text = "搜尋學生";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewStudent.Location = new System.Drawing.Point(213, 26);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(111, 44);
            this.btnNewStudent.TabIndex = 1;
            this.btnNewStudent.Text = "新增學生";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnDelStudent
            // 
            this.btnDelStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelStudent.Location = new System.Drawing.Point(424, 26);
            this.btnDelStudent.Name = "btnDelStudent";
            this.btnDelStudent.Size = new System.Drawing.Size(111, 44);
            this.btnDelStudent.TabIndex = 2;
            this.btnDelStudent.Text = "刪除學生";
            this.btnDelStudent.UseVisualStyleBackColor = true;
            this.btnDelStudent.Click += new System.EventHandler(this.btnDelStudent_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(139, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "期別";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(272, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "教室";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(304, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "電話";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(419, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "座號";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Lavender;
            this.tbName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbName.Location = new System.Drawing.Point(71, 187);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 29);
            this.tbName.TabIndex = 9;
            // 
            // tbGrade
            // 
            this.tbGrade.BackColor = System.Drawing.Color.Lavender;
            this.tbGrade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbGrade.Location = new System.Drawing.Point(197, 121);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(53, 29);
            this.tbGrade.TabIndex = 10;
            this.tbGrade.TextChanged += new System.EventHandler(this.tbGrade_TextChanged);
            // 
            // tbClass
            // 
            this.tbClass.BackColor = System.Drawing.Color.Lavender;
            this.tbClass.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbClass.Location = new System.Drawing.Point(330, 121);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(53, 29);
            this.tbClass.TabIndex = 11;
            // 
            // tbNumber
            // 
            this.tbNumber.BackColor = System.Drawing.Color.Lavender;
            this.tbNumber.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbNumber.Location = new System.Drawing.Point(477, 121);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(53, 29);
            this.tbNumber.TabIndex = 12;
            // 
            // tbCellPhone
            // 
            this.tbCellPhone.BackColor = System.Drawing.Color.Lavender;
            this.tbCellPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCellPhone.Location = new System.Drawing.Point(362, 187);
            this.tbCellPhone.Name = "tbCellPhone";
            this.tbCellPhone.Size = new System.Drawing.Size(170, 29);
            this.tbCellPhone.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(13, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "SID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSID
            // 
            this.cbSID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbSID.FormattingEnabled = true;
            this.cbSID.Location = new System.Drawing.Point(71, 119);
            this.cbSID.Margin = new System.Windows.Forms.Padding(4);
            this.cbSID.Name = "cbSID";
            this.cbSID.Size = new System.Drawing.Size(52, 28);
            this.cbSID.TabIndex = 26;
            this.cbSID.SelectedIndexChanged += new System.EventHandler(this.cbSID_SelectedIndexChanged);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdateStudent.Location = new System.Drawing.Point(27, 26);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(146, 44);
            this.btnUpdateStudent.TabIndex = 27;
            this.btnUpdateStudent.Text = "修改學生";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // tbUpdatePhone
            // 
            this.tbUpdatePhone.BackColor = System.Drawing.Color.Lavender;
            this.tbUpdatePhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbUpdatePhone.Location = new System.Drawing.Point(342, 135);
            this.tbUpdatePhone.Name = "tbUpdatePhone";
            this.tbUpdatePhone.Size = new System.Drawing.Size(170, 29);
            this.tbUpdatePhone.TabIndex = 31;
            // 
            // tbUpdateName
            // 
            this.tbUpdateName.BackColor = System.Drawing.Color.Lavender;
            this.tbUpdateName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbUpdateName.Location = new System.Drawing.Point(64, 136);
            this.tbUpdateName.Name = "tbUpdateName";
            this.tbUpdateName.Size = new System.Drawing.Size(170, 29);
            this.tbUpdateName.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(271, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "電話";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(6, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 28);
            this.label8.TabIndex = 28;
            this.label8.Text = "姓名";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnUpdateStudent);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbUpdatePhone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbUpdateName);
            this.groupBox1.Location = new System.Drawing.Point(18, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 184);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // tbSID
            // 
            this.tbSID.BackColor = System.Drawing.Color.Lavender;
            this.tbSID.Enabled = false;
            this.tbSID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbSID.Location = new System.Drawing.Point(64, 87);
            this.tbSID.Name = "tbSID";
            this.tbSID.Size = new System.Drawing.Size(53, 29);
            this.tbSID.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(6, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 28);
            this.label9.TabIndex = 32;
            this.label9.Text = "SID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchStudent);
            this.groupBox2.Controls.Add(this.btnNewStudent);
            this.groupBox2.Controls.Add(this.cbSID);
            this.groupBox2.Controls.Add(this.btnDelStudent);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbCellPhone);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbNumber);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbClass);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbGrade);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Location = new System.Drawing.Point(18, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 256);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // 學生資料
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(597, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "學生資料";
            this.Text = "學生資料";
            this.Load += new System.EventHandler(this.學生資料_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnDelStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbCellPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSID;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.TextBox tbUpdatePhone;
        private System.Windows.Forms.TextBox tbUpdateName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}