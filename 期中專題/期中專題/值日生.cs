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
    public partial class 值日生 : Form
    {
        SqlConnectionStringBuilder scsb;
        public 值日生()
        {
            InitializeComponent();
        }

        
        private void 值日生_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".\SQLEXPRESS";//Home:.\SQLEXPRESS;//資料來源.DataBase的名稱 @".\MSQL"  @表示忽略""內的特殊符號
            scsb.InitialCatalog = "MyProject";
            scsb.IntegratedSecurity = true;

            /*選出值日生*/
            //cbClass.Items.Clear();
            //cbFood.Items.Clear();
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
            reader.Close();

            /*值日生選店家*/
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

        }

        private void btnSure_Click(object sender, EventArgs e)
        {
                DateTime Time = DateTime.Now;
                String StrToday = "";
                StrToday = Time.ToShortDateString().ToString();

            if ((cbDStudent.Text.Length > 0) && (cbCompanyName.Text.Length > 0))
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update Daily_Student set date=@StrToday,Comoany=@NewCompany where DS_name like @NewClass";
                SqlCommand cmd = new SqlCommand(strSQL, con);





                cmd.Parameters.AddWithValue("@NewClass", cbDStudent.Text);
                cmd.Parameters.AddWithValue("@StrToday", StrToday);
                cmd.Parameters.AddWithValue("@NewCompany", cbCompanyName.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("已確定值日生");


                form1 form = new form1();
                form.name = cbDStudent.Text;
                form.company = cbCompanyName.Text;

                //form.ShowDialog();
            }
            else
            {
                MessageBox.Show("兩者不可為空");
            }

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(scsb.ToString());
            con1.Open();
            string sSQL = "select * from Orders";
            SqlCommand cmd1 = new SqlCommand(sSQL, con1);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                lbCheck.Items.Add(reader1["orderdate"].ToString() + "  " + reader1["student_class"].ToString() + "    " + reader1["student_Name"].ToString() + "  "
                    + reader1["student_seatNumber"].ToString() + "    " + "    " + reader1["company_Name"].ToString() + reader1["product_Name"].ToString() + "    " + reader1["product_Price"].ToString() + "   " +
                    reader1["count"].ToString() +"      "+ reader1["subtotal"].ToString());
            }
            con1.Close();
            reader1.Close();
        }

        private void btnToCounter_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(scsb.ToString());
            con1.Open();
            string sSQL = "select orderdate, company_Name ,product_Name, product_Price,sum(count) as a,sum(subtotal) as b from Orders group by  orderdate, company_Name, product_Name, product_Price,count,subtotal  ";
            SqlCommand cmd1 = new SqlCommand(sSQL, con1);
        }
    }
}
