namespace 期中專題
{
    partial class 櫃台
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbCheck = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTOTAL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbComoany = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "教室";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.Enabled = false;
            this.cbClass.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(84, 30);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(100, 28);
            this.cbClass.TabIndex = 1;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheck.Location = new System.Drawing.Point(312, 15);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(116, 46);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "查詢訂單";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbCheck
            // 
            this.lbCheck.BackColor = System.Drawing.Color.Lavender;
            this.lbCheck.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCheck.FormattingEnabled = true;
            this.lbCheck.ItemHeight = 20;
            this.lbCheck.Location = new System.Drawing.Point(12, 187);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(435, 364);
            this.lbCheck.TabIndex = 3;
            this.lbCheck.SelectedIndexChanged += new System.EventHandler(this.lbCheck_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(273, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "總計";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbTOTAL
            // 
            this.tbTOTAL.BackColor = System.Drawing.Color.Lavender;
            this.tbTOTAL.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbTOTAL.Location = new System.Drawing.Point(367, 584);
            this.tbTOTAL.Name = "tbTOTAL";
            this.tbTOTAL.Size = new System.Drawing.Size(80, 43);
            this.tbTOTAL.TabIndex = 5;
            this.tbTOTAL.TextChanged += new System.EventHandler(this.tbTOTAL_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "訂購電話";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.Lavender;
            this.tbPhone.Enabled = false;
            this.tbPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPhone.Location = new System.Drawing.Point(113, 132);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(197, 29);
            this.tbPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "店家";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbComoany
            // 
            this.cbComoany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComoany.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbComoany.FormattingEnabled = true;
            this.cbComoany.Location = new System.Drawing.Point(84, 81);
            this.cbComoany.Name = "cbComoany";
            this.cbComoany.Size = new System.Drawing.Size(140, 28);
            this.cbComoany.TabIndex = 9;
            this.cbComoany.SelectedIndexChanged += new System.EventHandler(this.cbComoany_SelectedIndexChanged);
            // 
            // 櫃台
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(459, 639);
            this.Controls.Add(this.cbComoany);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTOTAL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "櫃台";
            this.Text = "櫃台";
            this.Load += new System.EventHandler(this.櫃台_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ListBox lbCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTOTAL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbComoany;
    }
}