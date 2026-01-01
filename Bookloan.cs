using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imb
{
    public partial class Bookloan : Form
    {
        public int book1uid = 0;
        public int book2uid = 0;
        public int book3uid = 0;
        public int book4uid = 0;
        public int book5uid = 0;


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M4MN12E\\SQLEXPRESS; Initial Catalog=imb; User ID=sa; Password=123;");

        public Bookloan()
        {
            InitializeComponent();
        }

        private void Bookloan_Load(object sender, EventArgs e)
        {

        }

        private void btnserchuser_Click(object sender, EventArgs e)
        {
            using (Searchuser searchUserForm = new Searchuser())
            {
                if (searchUserForm.ShowDialog() == DialogResult.OK)
                {
                    string userNumber = searchUserForm.SelectedUserNumber;

                    txtuserno.Text = userNumber; 
                }
            }
        }

        private void btnbook1_Click(object sender, EventArgs e)
        {
            using (Serchbook searchbookForm = new Serchbook())
            {
                if (searchbookForm.ShowDialog() == DialogResult.OK)
                {
                   
                    string booknumber = searchbookForm.selectbooknumber;
                    book1uid = searchbookForm.uid;

                    txtbook1.Text = booknumber; 
                }
            }
        }

        private void btnseach2_Click(object sender, EventArgs e)
        {

            using (Serchbook searchbookForm = new Serchbook())
            {
                if (searchbookForm.ShowDialog() == DialogResult.OK)
                {
                    string booknumber = searchbookForm.selectbooknumber;
                    book2uid = searchbookForm.uid;

                    txtbook2.Text = booknumber; 
                }
            }
        }

        private void btnsech3_Click(object sender, EventArgs e)
        {

            using (Serchbook searchbookForm = new Serchbook())
            {
                if (searchbookForm.ShowDialog() == DialogResult.OK)
                {
                    
                    string booknumber = searchbookForm.selectbooknumber;
                    book3uid = searchbookForm.uid;

                    
                    txtbook3.Text = booknumber; 
                }
            }
        }

        private void btnsech4_Click(object sender, EventArgs e)
        {

            using (Serchbook searchbookForm = new Serchbook())
            {
                if (searchbookForm.ShowDialog() == DialogResult.OK)
                {
                    string booknumber = searchbookForm.selectbooknumber;
                    book4uid = searchbookForm.uid;

                    txtbook4.Text = booknumber; 
                }
            }
        }

        private void btnserch5_Click(object sender, EventArgs e)
        {
            using (Serchbook searchbookForm = new Serchbook())
            {
                if (searchbookForm.ShowDialog() == DialogResult.OK)
                {
                    string booknumber = searchbookForm.selectbooknumber;
                    book5uid= searchbookForm.uid;

                    txtbook5.Text = booknumber; 
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
        protected void clear()
        {
            txtbook1.Text = "";
            txtbook2.Text = "";
            txtbook3.Text = "";
            txtbook4.Text = "";
            txtbook5.Text = "";
            txtuserno.Text = "";
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Main().Show();
        }

        private void btnisuu_Click(object sender, EventArgs e)
        {
            string book1=txtbook1.Text;
            string book2=txtbook2.Text;
            string book3=txtbook3.Text;
            string book4=txtbook4.Text;
            string book5=txtbook5.Text;
            string issuedate =dateissu.Text;
            string retuntdate =daterutant.Text;
            string userno = txtuserno.Text;

            if (string.IsNullOrWhiteSpace(issuedate) ||
              string.IsNullOrWhiteSpace(userno) ||
              string.IsNullOrWhiteSpace(retuntdate) 
             )
            {
                MessageBox.Show("Please fill the required fields");
                return;
            }

            try
            {
                string bookid = book1 + "," + book2 +","+book3+","+book4+","+book5;
                string bookuid = book1uid + "," + book2uid + "," + book3uid + "," + book4uid + "," + book5uid;

                con.Open();


               

                    string query = "insert into bookloan( memberid, book_id, loan_date, return_date, status,bookuid )values ('" + userno + "','" + bookid + "','"+issuedate+"','" + retuntdate + "',' 10 ','"+bookuid+"')";

                    SqlCommand cm = new SqlCommand(query, con);
                    int result = cm.ExecuteNonQuery();

                    if (result <= 0)
                    {
                        MessageBox.Show("Book issue failed. Please try again.");
                        return;
                    }


                string updatequery = "Update book set status=20 where uid in('"+book1uid+ "','"+book2uid+ "','"+book3uid+ "','"+book4uid+ "','"+book5uid+"')";
                SqlCommand cmd = new SqlCommand(updatequery, con);
                 cmd.ExecuteNonQuery();


                string updatemember = "update Member set status=20 where Usernumber='"+userno+"'";
                  SqlCommand member = new SqlCommand(updatemember, con);
                member.ExecuteNonQuery();

                MessageBox.Show("Successfully Book Isued!");
                clear();



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

        private void txtuserno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

