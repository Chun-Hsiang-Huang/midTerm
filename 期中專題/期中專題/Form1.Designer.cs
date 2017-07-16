namespace 期中專題
{
    partial class form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStudrnt = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnOrderStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCompanyName = new System.Windows.Forms.ComboBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOrderStudent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCellPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSeatNumber = new System.Windows.Forms.TextBox();
            this.lbShow = new System.Windows.Forms.ListBox();
            this.btnConFirm = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.SID = new System.Windows.Forms.Label();
            this.tbSId = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnToCounter = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbDStudent = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStudrnt
            // 
            this.btnStudrnt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStudrnt.Location = new System.Drawing.Point(9, 9);
            this.btnStudrnt.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudrnt.Name = "btnStudrnt";
            this.btnStudrnt.Size = new System.Drawing.Size(118, 31);
            this.btnStudrnt.TabIndex = 0;
            this.btnStudrnt.Text = "學生資料維護";
            this.btnStudrnt.UseMnemonic = false;
            this.btnStudrnt.UseVisualStyleBackColor = true;
            this.btnStudrnt.Click += new System.EventHandler(this.btnStudrnt_Click);
            // 
            // btnStore
            // 
            this.btnStore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStore.Location = new System.Drawing.Point(156, 9);
            this.btnStore.Margin = new System.Windows.Forms.Padding(2);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(119, 31);
            this.btnStore.TabIndex = 1;
            this.btnStore.Text = "店家資料維護";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnOrderStudent
            // 
            this.btnOrderStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderStudent.Location = new System.Drawing.Point(303, 53);
            this.btnOrderStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderStudent.Name = "btnOrderStudent";
            this.btnOrderStudent.Size = new System.Drawing.Size(109, 31);
            this.btnOrderStudent.TabIndex = 2;
            this.btnOrderStudent.Text = "我是值日生";
            this.btnOrderStudent.UseVisualStyleBackColor = true;
            this.btnOrderStudent.Visible = false;
            this.btnOrderStudent.Click += new System.EventHandler(this.btnOrderStudent_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "店名";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "便當種類";
            // 
            // cbCompanyName
            // 
            this.cbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompanyName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbCompanyName.FormattingEnabled = true;
            this.cbCompanyName.Location = new System.Drawing.Point(156, 53);
            this.cbCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.cbCompanyName.Name = "cbCompanyName";
            this.cbCompanyName.Size = new System.Drawing.Size(131, 28);
            this.cbCompanyName.TabIndex = 5;
            this.cbCompanyName.Visible = false;
            this.cbCompanyName.SelectedIndexChanged += new System.EventHandler(this.cbCompanyName_SelectedIndexChanged);
            // 
            // cbFood
            // 
            this.cbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFood.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(110, 85);
            this.cbFood.Margin = new System.Windows.Forms.Padding(2);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(140, 28);
            this.cbFood.TabIndex = 6;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "訂購學生";
            // 
            // cbOrderStudent
            // 
            this.cbOrderStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbOrderStudent.FormattingEnabled = true;
            this.cbOrderStudent.Location = new System.Drawing.Point(104, 66);
            this.cbOrderStudent.Margin = new System.Windows.Forms.Padding(2);
            this.cbOrderStudent.Name = "cbOrderStudent";
            this.cbOrderStudent.Size = new System.Drawing.Size(92, 28);
            this.cbOrderStudent.TabIndex = 8;
            this.cbOrderStudent.SelectedIndexChanged += new System.EventHandler(this.cbOrderStudent_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(19, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "單價";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(19, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "份數";
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.Lavender;
            this.tbPrice.Enabled = false;
            this.tbPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPrice.Location = new System.Drawing.Point(74, 142);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(38, 29);
            this.tbPrice.TabIndex = 11;
            // 
            // tbCount
            // 
            this.tbCount.BackColor = System.Drawing.Color.Lavender;
            this.tbCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCount.Location = new System.Drawing.Point(104, 190);
            this.tbCount.Margin = new System.Windows.Forms.Padding(2);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(38, 29);
            this.tbCount.TabIndex = 12;
            this.tbCount.TextChanged += new System.EventHandler(this.tbCount_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(20, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "教室";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(75, 26);
            this.cbClass.Margin = new System.Windows.Forms.Padding(2);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(42, 28);
            this.cbClass.TabIndex = 14;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(20, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "學生電話";
            // 
            // tbCellPhone
            // 
            this.tbCellPhone.BackColor = System.Drawing.Color.Lavender;
            this.tbCellPhone.Enabled = false;
            this.tbCellPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCellPhone.Location = new System.Drawing.Point(105, 199);
            this.tbCellPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tbCellPhone.Name = "tbCellPhone";
            this.tbCellPhone.Size = new System.Drawing.Size(100, 29);
            this.tbCellPhone.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(20, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "座號";
            // 
            // tbSeatNumber
            // 
            this.tbSeatNumber.BackColor = System.Drawing.Color.Lavender;
            this.tbSeatNumber.Enabled = false;
            this.tbSeatNumber.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbSeatNumber.Location = new System.Drawing.Point(75, 158);
            this.tbSeatNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbSeatNumber.Name = "tbSeatNumber";
            this.tbSeatNumber.Size = new System.Drawing.Size(42, 29);
            this.tbSeatNumber.TabIndex = 18;
            this.tbSeatNumber.TextChanged += new System.EventHandler(this.tbSeatNumber_TextChanged);
            // 
            // lbShow
            // 
            this.lbShow.BackColor = System.Drawing.Color.Lavender;
            this.lbShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbShow.FormattingEnabled = true;
            this.lbShow.ItemHeight = 20;
            this.lbShow.Location = new System.Drawing.Point(286, 101);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(656, 604);
            this.lbShow.TabIndex = 19;
            // 
            // btnConFirm
            // 
            this.btnConFirm.Enabled = false;
            this.btnConFirm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConFirm.Location = new System.Drawing.Point(6, 693);
            this.btnConFirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConFirm.Name = "btnConFirm";
            this.btnConFirm.Size = new System.Drawing.Size(105, 31);
            this.btnConFirm.TabIndex = 20;
            this.btnConFirm.Text = "確認訂購";
            this.btnConFirm.UseVisualStyleBackColor = true;
            this.btnConFirm.Click += new System.EventHandler(this.btnConFirm_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Enabled = false;
            this.btnCancle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancle.Location = new System.Drawing.Point(136, 693);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(105, 31);
            this.btnCancle.TabIndex = 21;
            this.btnCancle.Text = "取消訂購";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Visible = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(64, 191);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 25);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinus.Location = new System.Drawing.Point(145, 190);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(34, 26);
            this.btnMinus.TabIndex = 23;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(19, 250);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "小計";
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.BackColor = System.Drawing.Color.Lavender;
            this.tbSubtotal.Enabled = false;
            this.tbSubtotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbSubtotal.Location = new System.Drawing.Point(68, 248);
            this.tbSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(38, 29);
            this.tbSubtotal.TabIndex = 25;
            // 
            // SID
            // 
            this.SID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SID.Location = new System.Drawing.Point(20, 116);
            this.SID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(44, 18);
            this.SID.TabIndex = 26;
            this.SID.Text = "SID";
            // 
            // tbSId
            // 
            this.tbSId.BackColor = System.Drawing.Color.Lavender;
            this.tbSId.Enabled = false;
            this.tbSId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbSId.Location = new System.Drawing.Point(69, 114);
            this.tbSId.Margin = new System.Windows.Forms.Padding(2);
            this.tbSId.Name = "tbSId";
            this.tbSId.Size = new System.Drawing.Size(42, 29);
            this.tbSId.TabIndex = 27;
            this.tbSId.TextChanged += new System.EventHandler(this.tbSId_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.dateTimePicker1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(779, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 29);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnToCounter
            // 
            this.btnToCounter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnToCounter.Location = new System.Drawing.Point(416, 53);
            this.btnToCounter.Margin = new System.Windows.Forms.Padding(2);
            this.btnToCounter.Name = "btnToCounter";
            this.btnToCounter.Size = new System.Drawing.Size(105, 31);
            this.btnToCounter.TabIndex = 29;
            this.btnToCounter.Text = "送至櫃台";
            this.btnToCounter.UseVisualStyleBackColor = true;
            this.btnToCounter.Visible = false;
            this.btnToCounter.Click += new System.EventHandler(this.btnToCounter_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(634, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = "選擇日期查詢歷史資料";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbOrderStudent);
            this.groupBox1.Controls.Add(this.cbClass);
            this.groupBox1.Controls.Add(this.tbSId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SID);
            this.groupBox1.Controls.Add(this.tbCellPhone);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbSeatNumber);
            this.groupBox1.Location = new System.Drawing.Point(13, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(244, 256);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCompany);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbFood);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbSubtotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbPrice);
            this.groupBox2.Controls.Add(this.btnMinus);
            this.groupBox2.Controls.Add(this.tbCount);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(9, 363);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(250, 309);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // tbCompany
            // 
            this.tbCompany.BackColor = System.Drawing.Color.Lavender;
            this.tbCompany.Enabled = false;
            this.tbCompany.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbCompany.Location = new System.Drawing.Point(74, 31);
            this.tbCompany.Margin = new System.Windows.Forms.Padding(2);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(116, 29);
            this.tbCompany.TabIndex = 36;
            this.tbCompany.TextChanged += new System.EventHandler(this.tbCompany_TextChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(406, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 26);
            this.label11.TabIndex = 33;
            this.label11.Text = "值日生";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDStudent
            // 
            this.cbDStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbDStudent.FormattingEnabled = true;
            this.cbDStudent.Location = new System.Drawing.Point(9, 53);
            this.cbDStudent.Margin = new System.Windows.Forms.Padding(2);
            this.cbDStudent.Name = "cbDStudent";
            this.cbDStudent.Size = new System.Drawing.Size(109, 28);
            this.cbDStudent.TabIndex = 34;
            this.cbDStudent.Visible = false;
            this.cbDStudent.SelectedIndexChanged += new System.EventHandler(this.cbDStudent_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lavender;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(474, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 29);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(966, 730);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbCompanyName);
            this.Controls.Add(this.cbDStudent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnToCounter);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConFirm);
            this.Controls.Add(this.lbShow);
            this.Controls.Add(this.btnOrderStudent);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnStudrnt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form1";
            this.Text = "吃飯啦";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudrnt;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnOrderStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCompanyName;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOrderStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCellPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSeatNumber;
        private System.Windows.Forms.ListBox lbShow;
        private System.Windows.Forms.Button btnConFirm;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.Label SID;
        private System.Windows.Forms.TextBox tbSId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnToCounter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbDStudent;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.TextBox textBox1;
    }
}

