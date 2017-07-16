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
    public partial class 學生資料 : Form
    {
        SqlConnectionStringBuilder scsb;//所有物件都可以使用到scsb之設定連線的物件
        public 學生資料()
        {
            InitializeComponent();
        }

        private void 學生資料_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".\SQLEXPRESS";//Home:.\SQLEXPRESS;//資料來源.DataBase的名稱 @".\MSQL"  @表示忽略""內的特殊符號
            scsb.InitialCatalog = "MyProject";
            scsb.IntegratedSecurity = true;
            MessageBox.Show("如要修改刪除，請從搜尋下手，謝謝您的配合");
        }
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            cbSID.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from Student ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", cbSID.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
              {
                cbSID.Items.Add(reader["stu_id"].ToString());

            }
            
            reader.Close();
            con.Close();
            
        }
        private void cbSID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select stu_grade,stu_class,stu_seatNumber,stu_Name,stu_cellPhone from Student where stu_id=@ID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", cbSID.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tbGrade.Text = reader["stu_grade"].ToString();
                tbClass.Text = reader["stu_class"].ToString();
                tbNumber.Text = reader["stu_seatNumber"].ToString();
                tbName.Text = reader["stu_Name"].ToString();
                tbCellPhone.Text = reader["stu_cellPhone"].ToString();
            }
            tbSID.Text = cbSID.Text;
            reader.Close();
            con.Close();
        }
        private void tbGrade_TextChanged(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select stu_class from Student where stu_id=@ID and stu_grade=@grade";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", cbSID.Text);
            cmd.Parameters.AddWithValue("@grade", tbGrade.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tbClass.Text = reader["stu_class"].ToString();
            }

            reader.Close();
            con.Close();*/
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = MessageBox.Show("確認新增?", "確定", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if ((tbName.Text.Length > 0) && (tbCellPhone.Text.Length > 0)
                && (tbGrade.Text.Length > 0) && (tbClass.Text.Length > 0) && (tbNumber.Text.Length > 0))
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into Student values (@NewGrade,@NewClass,@NewNumber,@NewName,@NewCelPhone)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewGrade", tbGrade.Text);
                cmd.Parameters.AddWithValue("@NewClass", tbClass.Text);
                cmd.Parameters.AddWithValue("@NewNumber", tbNumber.Text);
                cmd.Parameters.AddWithValue("@NewName", tbName.Text);
                cmd.Parameters.AddWithValue("@NewCelPhone", tbCellPhone.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(string.Format("資料新增完畢，共影響{0}筆資料", rows));
                tbName.Text = "";
                tbCellPhone.Text = "";
                tbGrade.Text = "";
                tbClass.Text = "";
                tbNumber.Text = "";
            }
            else
            {
                MessageBox.Show("請輸入姓名");
            }
        }

        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = MessageBox.Show("確認刪除資料?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (R == DialogResult.Yes)
            {
                if (tbName.Text.Length > 0)
                {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string strSQL = "delete from Student where stu_Name=@OldName ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.Parameters.AddWithValue("@OldName", tbName.Text);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(string.Format("資料刪除成功，共影響{0}筆資料", rows));
                    cbSID.Text = "";
                    tbName.Text = "";
                    tbCellPhone.Text = "";
                    tbGrade.Text = "";
                    tbClass.Text = "";
                    tbNumber.Text = "";

                }
                else
                {
                    MessageBox.Show("請輸入姓名");
                }
            }
            else
            {
                MessageBox.Show("取消刪除");
            }
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from Student";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbStudent.Items.Add(reader["stu_grade"].ToString()+"    "+ reader["stu_class"].ToString()+"   "+ reader["stu_seatNumber"].ToString()+"    "+ reader["stu_Name"].ToString()+"  "+ reader["stu_cellPhone"].ToString());
            }
            con.Close();*/
        }

        

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "update Student set stu_Name = @Name , stu_cellPhone=@Phone where stu_Name= @SearchName and stu_id=@Searchid";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", tbName.Text);
            cmd.Parameters.AddWithValue("@Searchid", tbSID.Text);
            cmd.Parameters.AddWithValue("@Name", tbUpdateName.Text);
            cmd.Parameters.AddWithValue("@Phone", tbUpdatePhone.Text);



            int rows = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(string.Format("資料更新完畢，共影響{0}筆資料", rows));
            cbSID.Text = "";
            tbCellPhone.Text = "";
            tbClass.Text = "";
            tbGrade.Text = "";
            tbName.Text = "";
            tbNumber.Text = "";
            tbSID.Text = "";
            tbUpdateName.Text = "";
            tbUpdatePhone.Text = "";
            
        }
    }
}
