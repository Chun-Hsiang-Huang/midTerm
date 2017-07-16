using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 期中專題
{
    public partial class form1 : Form
    {
        int count = 0;
        SqlConnectionStringBuilder scsb;
        public string name;
        public string company;
        
        
        
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".\SQLEXPRESS";//Home:.\SQLEXPRESS
            scsb.InitialCatalog = "MyProject";
            scsb.IntegratedSecurity = true;


            DateTime Time = DateTime.Now;
            String StrToday = "";
            StrToday = Time.ToShortDateString().ToString();
            
           
            //MessageBox.Show("訂購前請先通知值日生或其代理人");
            textBox1.Text = name;
            tbCompany.Text = company;

            SqlConnection connection2 = new SqlConnection(scsb.ToString());
            connection2.Open();
            string stringSQL2 = "select * from Daily_Student where date like @date";
            SqlCommand command2 = new SqlCommand(stringSQL2, connection2);
            command2.Parameters.AddWithValue("@date",StrToday);
            //command2.Parameters.AddWithValue("@SearchName",cbDStudent.Text);
            //command.Parameters.AddWithValue("@Searchclass", cbClass.Text);

            SqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                textBox1.Text = reader2["DS_name"].ToString();
                //cbDStudent.Items.Add(reader2["DS_name"].ToString());
            }
            reader2.Close();
            connection2.Close();

            //-------------------------------------------------------------------------------------
            /*cbClass.Items.Clear();
            cbFood.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from  Daily_Student";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbDStudent.Items.Add(reader["DS_name"]);
            }
            
            con.Close();
            reader.Close();*/
            //cbCompanyName.Enabled = true;


            SqlConnection connection = new SqlConnection(scsb.ToString());
            connection.Open();
            string stringSQL = "select distinct stu_class from Student ";
            SqlCommand command = new SqlCommand(stringSQL, connection);
            //command.Parameters.AddWithValue("@Searchclass", cbClass.Text);

            SqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                cbClass.Items.Add(reader1["stu_class"].ToString());
            }
            reader1.Close();
            connection.Close();


            SqlConnection c = new SqlConnection(scsb.ToString());
            c.Open();
            string sSQL = "select c_Name from Company";
            SqlCommand com = new SqlCommand(sSQL, c);
            //com.Parameters.AddWithValue("@SearchCompany", cbCompanyName.Text);

            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                cbCompanyName.Items.Add(r["c_Name"].ToString());
            }
            r.Close();
            c.Close();

            btnConFirm.Enabled = true;
            btnCancle.Enabled = true;


        }

        private void btnStudrnt_Click(object sender, EventArgs e)
        {
            學生資料 Student = new 學生資料();
            Student.ShowDialog();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            店家資料 Store = new 店家資料();
            Store.ShowDialog();
        }

        
        private void btnOrderStudent_Click(object sender, EventArgs e)
        {
            /*cbClass.Items.Clear();
            cbFood.Items.Clear();
            //cbCompanyName.Enabled = true;
            cbFood.Enabled = true;
            cbOrderStudent.Enabled = true;
            cbClass.Enabled = true;
            btnConFirm.Enabled = true;
            btnCancle.Enabled = true;

            SqlConnection c = new SqlConnection(scsb.ToString());
            c.Open();
            string sSQL = "select c_Name from Company";
            SqlCommand com = new SqlCommand(sSQL, c);
            com.Parameters.AddWithValue("@SearchCompany", cbCompanyName.Text);

            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                cbCompanyName.Items.Add(r["c_Name"].ToString());
            }
            r.Close();
            c.Close();

            SqlConnection connection = new SqlConnection(scsb.ToString());
            connection.Open();
            string stringSQL = "select distinct stu_class from Student ";
            SqlCommand command = new SqlCommand(stringSQL, connection);
            command.Parameters.AddWithValue("@Searchclass", cbClass.Text);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbClass.Items.Add(reader["stu_class"].ToString());
            }
            reader.Close();
            connection.Close();*/

        }

        private void cbDStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*SqlConnection connection3 = new SqlConnection(scsb.ToString());
            connection3.Open();
            string stringSQL3 = "select distinct * from Daily_Student where DS_name like @SearchName";
            SqlCommand command3 = new SqlCommand(stringSQL3, connection3);
            command3.Parameters.AddWithValue("@SearchName", cbDStudent.Text);
            //command2.Parameters.AddWithValue("@SearchName",cbDStudent.Text);
            //command.Parameters.AddWithValue("@Searchclass", cbClass.Text);

            SqlDataReader reader3 = command3.ExecuteReader();
            if (reader3.Read())
            {
                tbCompany.Text = string.Format(reader3["Comoany"].ToString());


            }
            reader3.Close();
            connection3.Close();
            */
            //cbClass.Items.Clear();
            //cbFood.Items.Clear();
            //cbCompanyName.Enabled = false;
            //cbFood.Enabled = true;
            //cbOrderStudent.Enabled = true;
            //cbClass.Enabled = true;






            /*SqlConnection c = new SqlConnection(scsb.ToString());
            c.Open();
            string sSQL = "select c_Name from Company";
            SqlCommand com = new SqlCommand(sSQL, c);
            com.Parameters.AddWithValue("@SearchCompany", cbCompanyName.Text);

            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                cbCompanyName.Items.Add(r["c_Name"].ToString());
            }
            r.Close();
            c.Close();*/

            /*SqlConnection connection = new SqlConnection(scsb.ToString());
            connection.Open();
            string stringSQL = "select distinct stu_class from Student ";
            SqlCommand command = new SqlCommand(stringSQL, connection);
            command.Parameters.AddWithValue("@Searchclass", cbClass.Text);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbClass.Items.Add(reader["stu_class"].ToString());
            }
            reader.Close();
            connection.Close();*/



        }
        private void cbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*cbFood.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select c.c_Name,p.p_name from Company c inner join Product p on (c.c_id=p.company_id) where c.c_Name = @Name ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Name", cbCompanyName.Text);
            SqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                cbFood.Items.Add(reader1["p_Name"].ToString());
            }
            reader1.Close();
            con.Close();*/
            //cbCompanyName.Enabled = false;
        }
        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCount.Text = "";
            tbSubtotal.Text = "";
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select c.c_Name,p.p_name,p_UnitPrice from Company c inner join Product p on (c.c_id=p.company_id) where c.c_Name = @cName and p_Name=@pName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@cName", tbCompany.Text);
            cmd.Parameters.AddWithValue("@pName", cbFood.Text);
            SqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                tbPrice.Text=reader1["p_UnitPrice"].ToString();
            }
            reader1.Close();
            con.Close();
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbOrderStudent.Items.Clear();
            tbSeatNumber.Text = "";
            tbCellPhone.Text = "";

            
            SqlConnection con1 = new SqlConnection(scsb.ToString());
            con1.Open();
            string strSQL = "select  stu_Name from Student where stu_class = @Searchclass ";
            SqlCommand cmd = new SqlCommand(strSQL, con1);
            cmd.Parameters.AddWithValue("@Searchclass", cbClass.Text);
            SqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                cbOrderStudent.Items.Add(reader1["stu_Name"].ToString());
            }
            reader1.Close();
            con1.Close();
        }

        private void cbOrderStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select stu_id from Student where stu_Name = @StuName ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@StuName", cbOrderStudent.Text);
            SqlDataReader reader1 = cmd.ExecuteReader();

            if (reader1.Read())
            {
                tbSId.Text = reader1["stu_id"].ToString();
            }
            reader1.Close();
            con.Close();

           
        }

        private void tbSId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select stu_seatNumber from Student where stu_id = @id ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id", tbSId.Text);
            SqlDataReader reader1 = cmd.ExecuteReader();

            if (reader1.Read())
            {
                tbSeatNumber.Text = reader1["stu_seatNumber"].ToString();
            }
            reader1.Close();
            con.Close();
        }

        private void tbSeatNumber_TextChanged(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select stu_cellPhone from Student where stu_seatNumber = @Number ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Number", tbSeatNumber.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                tbCellPhone.Text = reader["stu_cellPhone"].ToString();
            }
            reader.Close();
            con.Close();
        }

        private void btnConFirm_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string time = date.ToShortDateString().ToString();
            lbShow.Items.Clear();
            DialogResult R;
            R = MessageBox.Show("確認新增?", "確定", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if ((cbClass.Text.Length > 0) && (cbOrderStudent.Text.Length > 0)
                && (tbSeatNumber.Text.Length > 0) && (tbCellPhone.Text.Length > 0) 
                && (tbCompany.Text.Length > 0)&& (cbFood.Text.Length > 0) 
                && (tbPrice.Text.Length > 0) && (tbCount.Text.Length > 0))
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into Orders values (@NewStudentID,@NewClass,@NewOrderStudent,@NewSeatNumber,@NewCellPhone,@NewCompany,@NewFood,@NewPrice,@NewCount,@subtotal,@date)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewStudentID", tbSId.Text);
                cmd.Parameters.AddWithValue("@NewClass", cbClass.Text);
                cmd.Parameters.AddWithValue("@NewOrderStudent", cbOrderStudent.Text);
                cmd.Parameters.AddWithValue("@NewSeatNumber", tbSeatNumber.Text);
                cmd.Parameters.AddWithValue("@NewCellPhone", tbCellPhone.Text);
                cmd.Parameters.AddWithValue("@NewCompany", tbCompany.Text);
                cmd.Parameters.AddWithValue("@NewFood", cbFood.Text);
                cmd.Parameters.AddWithValue("@NewPrice", tbPrice.Text);
                cmd.Parameters.AddWithValue("@NewCount", tbCount.Text);
                cmd.Parameters.AddWithValue("@subtotal", tbSubtotal.Text);
                cmd.Parameters.AddWithValue("@date",time );
                int rows = cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入完整訂購資料");
            }

            SqlConnection con1 = new SqlConnection(scsb.ToString());
            con1.Open();
            string sSQL = "select * from Orders";
            SqlCommand cmd1 = new SqlCommand(sSQL, con1);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                lbShow.Items.Add(reader1["orderdate"].ToString()+"  "+reader1["student_class"].ToString() + "    "+ reader1["student_Name"].ToString() + "  " 
                    + reader1["student_seatNumber"].ToString() + "    "+ reader1["student_cellPhone"].ToString() + "    " 
                    + reader1["company_Name"].ToString() +reader1["product_Name"].ToString() + "    " + reader1["product_Price"].ToString() + "   " +
                    reader1["count"].ToString()+"   "+ reader1["subtotal"].ToString());
            }
            con1.Close();
            reader1.Close();
            int subtotal = 0;
            subtotal = Int32.Parse(tbPrice.Text.ToString()) * Int32.Parse(tbCount.Text.ToString());

            tbSubtotal.Text = subtotal.ToString();
            tbSubtotal.Text = "";
            tbCount.Text = "";
            cbOrderStudent.Text = "";
            tbSeatNumber.Text = "";
            tbCellPhone.Text = "";
            cbFood.Text = "";
            tbPrice.Text ="";
            tbCount.Text = "";
            tbSId.Text = "";
            cbOrderStudent.Text = "";

            


        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = MessageBox.Show("確認取消?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (R == DialogResult.Yes)
            {
                if (cbClass.Text.Length > 0)
                {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string strSQL = "delete from Orders where student_class=@class and student_seatNumber = @Number ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.Parameters.AddWithValue("@class", cbClass.Text);
                    cmd.Parameters.AddWithValue("@Number", tbSeatNumber.Text);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    lbShow.Items.Clear();

                    //MessageBox.Show(string.Format("資料刪除成功，共影響{0}筆資料", rows));
                    //cbClass.Items.Clear();
                    cbOrderStudent.Items.Clear();
                    tbSeatNumber.Text = "";
                    tbCellPhone.Text = "";
                    cbCompanyName.Items.Clear();
                    cbFood.Items.Clear();
                    tbPrice.Text = "";
                    tbCount.Text = "";

                }
                /*else
                {
                    MessageBox.Show("請輸入姓名");
                }*/
            }
            else
            {
                MessageBox.Show("取消刪除");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            count += 1;
            btnMinus.Enabled = true;
            tbCount.Text = count.ToString();
            int subtotal = 0;
            subtotal = Int32.Parse(tbPrice.Text.ToString()) * Int32.Parse(tbCount.Text.ToString());
            tbSubtotal.Text = subtotal.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count -= 1;
            if (count < 0)
            {
                count = 0;
                btnMinus.Enabled = false;
                
            }
            tbCount.Text = count.ToString();
            int subtotal = 0;
            subtotal = Int32.Parse(tbPrice.Text.ToString()) * Int32.Parse(tbCount.Text.ToString());
            tbSubtotal.Text = subtotal.ToString();
        }

        private void tbCount_TextChanged(object sender, EventArgs e)
        {
            if (tbCount.Text.Length > 0)
            {
                bool ifNum = Int32.TryParse(tbCount.Text, out count);
                if (ifNum && count >= 0)
                {
                    //正確輸入
                    btnMinus.Enabled = true;
                }
                else
                {
                    //輸入錯誤
                    MessageBox.Show("輸入錯誤", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCount.Text = "0";
                    count = 0;
                }
            }
            else
            {
                count = 0;
            }
        
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult R;
            R = MessageBox.Show("即將關閉","關閉",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


            DateTime time = dateTimePicker1.Value;
            string date = time.ToShortDateString().ToString();
            SqlConnection con1 = new SqlConnection(scsb.ToString());
            con1.Open();
            string sSQL = "select * from Orders where orderdate like @date";
            SqlCommand cmd1 = new SqlCommand(sSQL, con1);
            cmd1.Parameters.AddWithValue("@date", "%"+ date+ "%");
            Console.WriteLine(dateTimePicker1.Text);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                lbShow.Items.Add(reader1["orderdate"].ToString() + "  " + reader1["student_class"].ToString() + "    " + reader1["student_Name"].ToString() + "  "
                    + reader1["student_seatNumber"].ToString() + "    " + reader1["student_cellPhone"].ToString() + "    "
                    + reader1["company_Name"].ToString() + reader1["product_Name"].ToString() + "    " + reader1["product_Price"].ToString() + "   " +
                    reader1["count"].ToString());
            }
            con1.Close();
            reader1.Close();
        }

        private void btnToCounter_Click(object sender, EventArgs e)
        {
           
            DateTime date = DateTime.Now;
            string time = date.ToShortDateString().ToString();
            
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "insert into Order_Detail(class,company,p_name,p_UnitPrice,od_Quantity,od_Total,datetime) select student_class,company_Name,product_Name,product_Price,count,subtotal,orderdate from Orders where student_class = @class";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@class", cbClass.Text);

            cmd.Parameters.AddWithValue("@NewClass", cbClass.Text);
            cmd.Parameters.AddWithValue("@NewCompany", cbCompanyName.Text);
            cmd.Parameters.AddWithValue("@NewFood", cbFood.Text);
            cmd.Parameters.AddWithValue("@NewPrice", tbPrice.Text);
            cmd.Parameters.AddWithValue("@NewTotalCount", tbCount.Text);
            cmd.Parameters.AddWithValue("@NewTotal", tbSubtotal.Text);
            cmd.Parameters.AddWithValue("@date", time);
            int rows = cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("已送至櫃台");
            
            
         }

        private void tbCompany_TextChanged(object sender, EventArgs e)
        {
            cbFood.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select c.c_Name,p.p_name from Company c inner join Product p on (c.c_id=p.company_id) where c.c_Name = @Name ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Name", tbCompany.Text);
            SqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                cbFood.Items.Add(reader1["p_Name"].ToString());
            }
            reader1.Close();
            con.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection3 = new SqlConnection(scsb.ToString());
            connection3.Open();
            string stringSQL3 = "select distinct * from Daily_Student where DS_name like @SearchName";
            SqlCommand command3 = new SqlCommand(stringSQL3, connection3);
            command3.Parameters.AddWithValue("@SearchName", textBox1.Text);
            //command2.Parameters.AddWithValue("@SearchName",cbDStudent.Text);
            //command.Parameters.AddWithValue("@Searchclass", cbClass.Text);

            SqlDataReader reader3 = command3.ExecuteReader();
            if (reader3.Read())
            {
                tbCompany.Text = string.Format(reader3["Comoany"].ToString());


            }
            reader3.Close();
            connection3.Close();
        }
    }
}
