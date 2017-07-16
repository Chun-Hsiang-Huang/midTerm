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
    public partial class Form2 : Form
    {
        SqlConnectionStringBuilder scsb;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            form1 form = new form1();
            form.ShowDialog();
        }

        

        private void btnCounter_Click(object sender, EventArgs e)
        {
            櫃台 Counter = new 櫃台();
            Counter.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDaily_Student_Click(object sender, EventArgs e)
        {
            值日生 D_student = new 值日生();
            D_student.ShowDialog();
            /*scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".\SQLEXPRESS";//Home:.\SQLEXPRESS;//資料來源.DataBase的名稱 @".\MSQL"  @表示忽略""內的特殊符號
            scsb.InitialCatalog = "MyProject";
            scsb.IntegratedSecurity = true;*/

           


        }
    }
}
