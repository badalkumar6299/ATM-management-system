using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ATM_Managment_System
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\badal\source\repos\ATM Managment System\ATM.mdf"";Integrated Security=True");
        String Acc = Login.AccNumber;
        private void addTransaction()
        {
            string TrType = "Deposit";
            try
            {
                con.Open();
                string query = "insert into Transaction1 values('" + Acc + "','" + TrType + "'," + DepoAmt.Text + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Account Created Successfully");
                con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (DepoAmt.Text == "" || Convert.ToInt32(DepoAmt.Text) <= 0)
            {
                MessageBox.Show("Enter The Amount To Deposite");
            }
            else
            {
                
                newbalance = oldbalance+ Convert.ToInt32(DepoAmt.Text);
                try
                {
                    con.Open();
                    string query = "update Account set Balance=" + newbalance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Deposite");
                    con.Close();
                    addTransaction();                                                                                               
                    HOME hOME = new HOME();
                    hOME.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DepoAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
        int oldbalance,newbalance;
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from Account where AccNum='" +Acc +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void Deposit_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}
