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

namespace imb
{
    public partial class @return : Form
    {
        public int uid = 0;
        public string bookuuid;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M4MN12E\\SQLEXPRESS; Initial Catalog=imb; User ID=sa; Password=123;");
        public @return()
        {
            InitializeComponent();
        }
        private List<int> bookUidList = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            string usrnumber = txtmemberno.Text;

            if (string.IsNullOrWhiteSpace(usrnumber))
            {
                MessageBox.Show("Please enter Member Registration Number");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT  m.Name,b.book_id,b.bookuid,b.loan_date,b.return_date  FROM Member AS m INNER JOIN bookloan AS b ON b.memberid = m.Usernumber WHERE m.Usernumber = @Usernumber AND b.status = 10", con))
                {
                    cmd.Parameters.AddWithValue("@Usernumber", usrnumber);

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            txtname.Text = dt.Rows[0]["Name"].ToString();
                            txtissedbook.Text = dt.Rows[0]["book_id"].ToString();
                            txtissuedate.Text = dt.Rows[0]["loan_date"].ToString();
                            txtretundate.Text = dt.Rows[0]["return_date"].ToString();
                            bookuuid = dt.Rows[0]["bookuid"].ToString();
                            if (dt.Rows[0]["bookuid"] != DBNull.Value)
                            {
                                string bookuidStr = dt.Rows[0]["bookuid"].ToString();
                                string[] bookuids = bookuidStr.Split(',');

                                List<int> bookUidList = new List<int>();
                                foreach (string uid in bookuids)
                                {
                                    if (int.TryParse(uid.Trim(), out int parsedUid))
                                    {
                                        bookUidList.Add(parsedUid);
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Invalid Book UID format: {uid}");
                                        return;
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Book UID is not available.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No member found with the provided registration number.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnreturnd_Click(object sender, EventArgs e)
        {
            string userno = txtmemberno.Text;
            string name = txtname.Text;
            string book = txtissedbook.Text;

            string issuedte = txtissuedate.Text;
            string retuendate = txtretundate.Text;

            if (string.IsNullOrWhiteSpace(userno) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(book)
                || string.IsNullOrWhiteSpace(issuedte) || string.IsNullOrWhiteSpace(retuendate))
            {
                MessageBox.Show("Please enter Member Number");
                return;
            }

            try
            {
                con.Open();

                string updatebookloan = "update bookloan set status=20 where memberid='"+userno+"' and status=10";
                SqlCommand bookloan = new SqlCommand(updatebookloan, con);
                bookloan.ExecuteNonQuery();




                //string updateQuery = "UPDATE book SET status = 10 WHERE uid IN (select bookuid from bookloan where memberid='"+userno+"')";

                string bookUidList = bookuuid;
                string[] bookUids = bookUidList.Split(',');

                string updateQuery = "UPDATE book SET status = 10 WHERE uid IN (" + string.Join(",", bookUids.Select((uid, index) => "@BookUid" + index)) + ")";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    for (int i = 0; i < bookUids.Length; i++)
                    {
                        cmd.Parameters.AddWithValue("@BookUid" + i, int.Parse(bookUids[i]));
                    }

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                    }
                }



                string updatemember = "update Member set status=10 where Usernumber='" + userno + "'";
                SqlCommand member = new SqlCommand(updatemember, con);
                member.ExecuteNonQuery();

                MessageBox.Show("Successfully Book Isued!");
                clean();



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

        private void btnclear_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().Show();

        }
        protected void clean()
        {
            txtname.Text = "";
            txtissedbook.Text = "";
            txtmemberno.Text = "";
            txtissuedate.Text = "";
            txtretundate.Text = "";
        }
    }
}

