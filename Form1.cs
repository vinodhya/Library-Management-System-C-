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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace imb
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M4MN12E\\SQLEXPRESS; Initial Catalog=imb; User ID=sa; Password=123;");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username= txtusename.Text;
            string password= txtpassword.Text;  

            if (username=="" ||password==""||username==null||password==null)
            {
                MessageBox.Show("Please Enter Username & Password");
                return;
            }
            else
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Userlog WHERE username='" + username + "' AND password='" + password + "'", con);
              
                DataTable dt = new DataTable(); 
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    
                    this.Hide();
                  new Main().Show();

                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void txtusename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

