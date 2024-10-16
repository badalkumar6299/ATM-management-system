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
    public partial class ChangePin : Form
    {
        private object hOME;

        public ChangePin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e, hOME);
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\badal\source\repos\ATM Managment System\ATM.mdf"";Integrated Security=True");
        String Acc = Login.AccNumber;
        private void button1_Click(object sender, EventArgs e, object hOME)
        {
            if (Pin1.Text == "" || Pin2.Text == "")
            {
                MessageBox.Show("Enter And Confirm The New Pin");
            }
            else if (Pin2.Text != Pin1.Text)
            {
                MessageBox.Show("Pin1 And Pin2 are Diffrent");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update Account set PIN=" + Pin1.Text + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Successfully Updated");
                    con.Close();
                    Login home = new Login();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
    }
}
