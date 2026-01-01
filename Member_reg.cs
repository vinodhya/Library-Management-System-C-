using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace imb
{
    public partial class Member_reg : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M4MN12E\\SQLEXPRESS; Initial Catalog=imb; User ID=sa; Password=123;");

        public Member_reg()
        {
            InitializeComponent();
            gender();


        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            string usernumber = txtuseno.Text;
            string name = txtname.Text;
            string nic = txtnic.Text;
            string address = txtadress.Text;
            string gender = drpgendar.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(usernumber) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(nic) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please fill the required fields");
                return;
            }

            try
            {
                con.Open();



                string selectQuery = "SELECT COUNT(*) FROM Member WHERE Usernumber = @Usernumber";
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@Usernumber", usernumber);

                int result1 = (int)cmd.ExecuteScalar();  

                if (result1 == 0)
                {
                    string query = "INSERT INTO Member(Usernumber, Name, NIC, Address, Gendar, status) " +
                                   "VALUES (@Usernumber, @Name, @NIC, @Address, @Gendar, '10')";

                    SqlCommand cm = new SqlCommand(query, con);
                    cm.Parameters.AddWithValue("@Usernumber", usernumber);
                    cm.Parameters.AddWithValue("@Name", name);
                    cm.Parameters.AddWithValue("@NIC", nic);
                    cm.Parameters.AddWithValue("@Address", address);
                    cm.Parameters.AddWithValue("@Gendar", gender);

                    int result = cm.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Successfully registered!");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Registration failed. This member already registered.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void gender()
        {
            drpgendar.Items.Clear(); 

            drpgendar.Items.Add("Male");
            drpgendar.Items.Add("Female");


        }







        protected void clear() 
        {
            txtadress.Text = "";

            txtnic.Text = "";
            txtuseno.Text = "";
            txtname.Text = "";
            drpgendar.Items.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
          clear();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().Show();
        }
    }
}
