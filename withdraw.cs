using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Managment_System
{
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\badal\source\repos\ATM Managment System\ATM.mdf"";Integrated Security=True");
        String Acc = Login.AccNumber;
        int bal;
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from Account where AccNum='" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balance.Text = "Balance Rs " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void addTransaction()
        {
            string TrType = "WithDraw";
            try
            {
                con.Open();
                string query = "insert into Transaction1 values('" + Acc + "','" + TrType + "'," + wdamt.Text + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void withdraw_Load(object sender, EventArgs e)
        {
            getbalance();

        }
        int oldbalance, newbalance;
        private void button1_Click(object sender, EventArgs e)
        {
            if (wdamt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Convert.ToInt32(wdamt.Text) <= 0)
            {
                MessageBox.Show("Enter a Valid Amount");
            }
            else if (Convert.ToUInt32(wdamt.Text) > bal)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(wdamt.Text);
                    try
                    {
                        con.Open();
                        string query = "update Account set Balance=" + newbalance + "where AccNum='" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success Withdraw");
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
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOME home = new HOME();
            home.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
