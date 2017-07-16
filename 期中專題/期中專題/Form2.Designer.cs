namespace 期中專題
{
    partial class Form2
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
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnCounter = new System.Windows.Forms.Button();
            this.btnDaily_Student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.AliceBlue;
            this.btnStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStudent.Location = new System.Drawing.Point(72, 111);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(116, 48);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "學生往這走";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnCounter
            // 
            this.btnCounter.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCounter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCounter.Location = new System.Drawing.Point(71, 195);
            this.btnCounter.Margin = new System.Windows.Forms.Padding(2);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(117, 44);
            this.btnCounter.TabIndex = 1;
            this.btnCounter.Text = "櫃台往這走";
            this.btnCounter.UseVisualStyleBackColor = false;
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // btnDaily_Student
            // 
            this.btnDaily_Student.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDaily_Student.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDaily_Student.Location = new System.Drawing.Point(71, 36);
            this.btnDaily_Student.Margin = new System.Windows.Forms.Padding(2);
            this.btnDaily_Student.Name = "btnDaily_Student";
            this.btnDaily_Student.Size = new System.Drawing.Size(117, 49);
            this.btnDaily_Student.TabIndex = 2;
            this.btnDaily_Student.Text = "值日生往這走";
            this.btnDaily_Student.UseVisualStyleBackColor = false;
            this.btnDaily_Student.Click += new System.EventHandler(this.btnDaily_Student_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::期中專題.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(243, 280);
            this.Controls.Add(this.btnDaily_Student);
            this.Controls.Add(this.btnCounter);
            this.Controls.Add(this.btnStudent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "吃不飽餓不死";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.Button btnDaily_Student;
    }
}