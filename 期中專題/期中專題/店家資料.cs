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
    public partial class 店家資料 : Form
    {
        SqlConnectionStringBuilder scsb;
        public 店家資料()
        {
            InitializeComponent();
        }

        private void 店家資料_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".\SQLEXPRESS";//Home:.\SQLEXPRESS;//資料來源.DataBase的名稱 @".\MSQL"  @表示忽略""內的特殊符號
            scsb.InitialCatalog = "MyProject";
            scsb.IntegratedSecurity = true;
            MessageBox.Show("如要修改刪除，請從搜尋店家下手，謝謝您的配合");
        }

        private void btnSearchStore_Click(object sender, EventArgs e)
        {
            cbCID.Items.Clear();
            //tbPrice.Text = ""; 
            cbCID.Enabled = true;  
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from Company";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchCID", cbCID.Text);
               
                
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbCID.Items.Add(reader["c_id"].ToString());
            }
            con.Close();
            reader.Close();
               
        }
        private void cbCID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            tbPrice.Text = "";
            cbFood.Text = "";
            cbFood.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select c_Name from Company where c_id =@id";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id", cbCID.Text);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tbComName.Text = reader["c_Name"].ToString();
            }
            tbCID.Text = cbCID.Text;
            tbNewCID.Text = cbCID.Text;
            tbDeleteCID.Text = cbCID.Text;
            tbUpdateCID.Text = cbCID.Text;
            
            con.Close();
            reader.Close();
        }
        private void tbComName_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select c_TelPhone from Company where c_Name = @Name";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Name", tbComName.Text);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tbTelPhone.Text = reader["c_TelPhone"].ToString();
            }
            con.Close();
            reader.Close();
        }
        private void tbTelPhone_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select c_Address from Company where c_TelPhone = @TelPhone";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@TelPhone", tbTelPhone.Text);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tbAddress.Text = reader["c_Address"].ToString();
            }
            con.Close();
            reader.Close();
        }
        private void tbCID_TextChanged(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select p_Name from Product where company_id= @id";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@id", cbCID.Text);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbFood.Items.Add(reader["p_Name"].ToString());
            }
            con.Close();
            reader.Close();
        }
        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select p_UnitPrice from Product where p_Name= @pName and company_id = @CID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@pName", cbFood.Text);
            cmd.Parameters.AddWithValue("@CID", tbCID.Text);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tbPrice.Text = reader["p_UnitPrice"].ToString();
            }
            con.Close();
            reader.Close();
        }

        private void btnNewStore_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = MessageBox.Show("確認新增?", "確定", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


            if ((tbComName.Text.Length > 0) && (tbTelPhone.Text.Length > 0) && (tbAddress.Text.Length > 0))
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into Company values (@NewStoName,@NewTelPhone,@NewAddress)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewStoName", tbComName.Text);
                cmd.Parameters.AddWithValue("@NewTelPhone", tbTelPhone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", tbAddress.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(string.Format("資料新增完畢，共新增{0}筆資料", rows));
                cbCID.Text = "";
                tbComName.Text = "";
                tbTelPhone.Text = "";
                tbAddress.Text = "";
            }
            else
            {
                MessageBox.Show("請輸入完整店家資料");
            }
        }
        
        

        private void btnDelStore_Click(object sender, EventArgs e)
        {
            
            DialogResult R;
            R = MessageBox.Show("確定不留戀此店家", "店家哭哭", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (R == DialogResult.Yes)
            {
                if (cbCID.Text.Length > 0)
                {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string strSQL = "delete from Company where c_id = @Oldid ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.Parameters.AddWithValue("@Oldid", cbCID.Text);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(string.Format("資料刪除成功，共影響{0}筆資料", rows));
                    tbComName.Text = "";
                    tbTelPhone.Text = "";
                    tbAddress.Text = "";
                    cbCID.Text = "";
                    tbCID.Text = "";
                    tbNewCID.Text = "";

                }
                else
                {
                    MessageBox.Show("請選擇店家編號(CID)");
                }
            }
            else
            {
                MessageBox.Show("取消刪除");
            }
        }

        private void btnNewFood_Click(object sender, EventArgs e)
        {
            if ((tbNewCID.Text.Length > 0) && (tbNewFood.Text.Length > 0) && (tbNewPrice.Text.Length > 0))
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into Product values(@NewCID,@NewFood,@NewPrice)";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@NewCID", tbNewCID.Text);
                cmd.Parameters.AddWithValue("@NewFood", tbNewFood.Text);
                cmd.Parameters.AddWithValue("@NewPrice", tbNewPrice.Text);

                int row = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(string.Format("菜色新增成功，共新增{0}筆菜色", row));
                tbNewFood.Text = "";
                tbNewPrice.Text = "";
            }
            else
            {
                MessageBox.Show("請輸入完整菜色資料");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (tbDeleteCID.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from Product where company_id=@OldCompanyID and p_Name = @OldProductName ";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@OldCompanyID", tbDeleteCID.Text);
                cmd.Parameters.AddWithValue("@OldProductName", cbDeleteFood.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(string.Format("資料刪除成功，共影響{0}筆資料", rows));
                tbDeletePrice.Text = "";
                cbDeleteFood.Text = "";

            }
            else
            {
                MessageBox.Show("請輸入菜色名稱");
            }
        }

        private void tbDeleteCID_TextChanged(object sender, EventArgs e)
        {
            cbDeleteFood.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select p_Name from Product where company_id = @Cid ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@Pid", tbDeleteCID.Text);
            cmd.Parameters.AddWithValue("@Cid", tbDeleteCID.Text);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbDeleteFood.Items.Add(reader["p_Name"].ToString());
            }
            con.Close();
            reader.Close();
        }

        private void cbDeleteFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select p_UnitPrice from Product where p_Name = @pName ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@Pid", tbDeleteCID.Text);
            cmd.Parameters.AddWithValue("@pName", cbDeleteFood.Text);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tbDeletePrice.Text = reader["p_UnitPrice"].ToString();
            }
            con.Close();
            reader.Close();
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "update Product set p_Name = @UpdateFoodName , p_UnitPrice=@UpdatePrice where p_Name= @SearchName and company_id=@Searchid";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", cbFood.Text);
            cmd.Parameters.AddWithValue("@Searchid", tbUpdateCID.Text);
            cmd.Parameters.AddWithValue("@UpdateFoodName", tbUpdateFood.Text);
            cmd.Parameters.AddWithValue("@UpdatePrice", tbUpdatePrice.Text);
            


            int rows = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(string.Format("資料更新完畢，共影響{0}筆資料", rows));
            tbUpdateFood.Text = "";
            tbUpdatePrice.Text = "";
            cbFood.Text = "";
            tbPrice.Text = "";

            /*SqlConnection con1 = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL1 = "select p_Name from Product where company_id= @id";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
            cmd1.Parameters.AddWithValue("@id", tbUpdateCID.Text);


            SqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                cbFood.Items.Add(reader1["p_Name"].ToString());
            }
            con.Close();
            reader1.Close();*/



        }
    }
}
