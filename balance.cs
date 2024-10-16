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
namespace ATM_Managment_System
{
    public partial class balance : Form
    {
        public balance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\badal\source\repos\ATM Managment System\ATM.mdf"";Integrated Security=True");
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from Account where AccNum='"+AccNumber.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balance1.Text = "Rs "+dt.Rows[0][0].ToString();
            con.Close();
        }
        private void balance_Load(object sender, EventArgs e)
        {
            AccNumber.Text = HOME.AccNumber;
            getbalance();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }
    }
}
