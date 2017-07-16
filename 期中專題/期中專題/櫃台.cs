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
    public partial class 櫃台 : Form
    {
        SqlConnectionStringBuilder scsb;
        public 櫃台()
        {
            InitializeComponent();
        }

        private void 櫃台_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".\SQLEXPRESS";//Home:.\SQLEXPRESS;//資料來源.DataBase的名稱 @".\MSQL"  @表示忽略""內的特殊符號
            scsb.InitialCatalog = "MyProject";
            scsb.IntegratedSecurity = true;
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbCheck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            cbClass.Items.Clear();
            cbClass.Enabled = true;
            /*SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select distinct class from Order_Detail ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@class", cbClass.Text);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbClass.Items.Add(reader["class"]);
            }

            con.Close();
            reader.Close();*/
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select distinct student_class from Orders ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@class", cbClass.Text);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbClass.Items.Add(reader["student_class"]);
            }

            con.Close();
            reader.Close();

        }



        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*SqlConnection con1 = new SqlConnection(scsb.ToString());
            con1.Open();
            string strSQL1 = "select distinct company from Order_Detail where class like @class";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
            cmd1.Parameters.AddWithValue("@class", cbClass.Text);

            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                cbComoany.Items.Add(reader1["company"].ToString());
                cbComoany.SelectedIndex = 0;
            }
            con1.Close();
            reader1.Close();*/


            SqlConnection con1 = new SqlConnection(scsb.ToString());
            con1.Open();
            string strSQL1 = "select distinct company_Name from Orders where student_class like @class";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
            cmd1.Parameters.AddWithValue("@class", cbClass.Text);

            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                cbComoany.Items.Add(reader1["company_Name"].ToString());
                cbComoany.SelectedIndex = 0;
            }
            con1.Close();
            reader1.Close();


            SqlConnection con3 = new SqlConnection(scsb.ToString());
            con3.Open();
            string strSQL3 = "select c_TelPhone from Company where c_Name=@Name1";
            SqlCommand cmd3 = new SqlCommand(strSQL3, con3);
            cmd3.Parameters.AddWithValue("@Name1", cbComoany.Text);

            SqlDataReader reader3 = cmd3.ExecuteReader();

            if (reader3.Read())
            {
                tbPhone.Text = reader3["c_TelPhone"].ToString();
            }
            con3.Close();
            reader3.Close();



            SqlConnection con2 = new SqlConnection(scsb.ToString());
            con2.Open();
            string sSQL = "select orderdate, company_Name ,product_Name,sum(count) as a,sum(subtotal) as b from Orders group by  orderdate, company_Name, product_Name ";
            SqlCommand cmd2 = new SqlCommand(sSQL, con2);
            cmd2.Parameters.AddWithValue("@class", cbClass.Text);

            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                lbCheck.Items.Add(reader["orderdate"].ToString() + "    " + reader["company_Name"].ToString() + "  " +  reader["a"].ToString()+"    " +reader["product_Name"].ToString() + "    "
                    + "   " + reader["b"].ToString());
            }





            /*SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select datetime,class, company,p_name,sum(od_Quantity) as a ,sum(od_total) as b from Order_Detail where class=@class group by datetime,class,company,p_name";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@class", cbClass.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbCheck.Items.Add(reader["datetime"].ToString() + "    " + reader["class"].ToString() + "  " + reader["company"].ToString() + "    "
                    + reader["p_name"].ToString() + "   " + "   " + reader["a"].ToString() + "  " + reader["b"].ToString());
            }


            con.Close();
            reader.Close();


           SqlConnection con4 = new SqlConnection(scsb.ToString());
           con4.Open();
           string strSQL4 = "select sum(od_Total) as 總計 from Order_Detail";
           SqlCommand cmd4 = new SqlCommand(strSQL4, con4);
           cmd4.Parameters.AddWithValue("@Name", cbComoany.Text);

           SqlDataReader reader4 = cmd4.ExecuteReader();

           if (reader4.Read())
           {
               tbTOTAL.Text = reader4["總計"].ToString();
           }

            reader4.Close();*/

            SqlConnection con4 = new SqlConnection(scsb.ToString());
            con4.Open();
            string strSQL4 = "select sum(subtotal) as 總計 from Orders";
            SqlCommand cmd4 = new SqlCommand(strSQL4, con4);
            cmd4.Parameters.AddWithValue("@Name", cbComoany.Text);

            SqlDataReader reader4 = cmd4.ExecuteReader();

            if (reader4.Read())
            {
                tbTOTAL.Text = reader4["總計"].ToString();
            }

            reader4.Close();

        }

        private void cbComoany_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*SqlConnection con1 = new SqlConnection(scsb.ToString());
            con1.Open();
            string strSQL1 = "select c_TelPhone from Company where c_Name=@Name";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
            cmd1.Parameters.AddWithValue("@Name", cbComoany.Text);

            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                tbPhone.Text = reader1["c_TelPhone"].ToString();
            }*/
        }

        private void tbTOTAL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
