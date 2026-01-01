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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace imb
{

    public partial class Inquary : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M4MN12E\\SQLEXPRESS; Initial Catalog=imb; User ID=sa; Password=123;");

        public Inquary()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Inquary_Load(object sender, EventArgs e)
        {
            book();
        }

        private void txtbookno_TextChanged(object sender, EventArgs e)
        {
            LoadDynamicData();
        }

        private void LoadDynamicData()
        {
            try
            {
                string sqlQuery = "SELECT booknumber, title, publisher, COUNT(uid) AS Avalable  FROM book WHERE status = 10 ";
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(txtbookno.Text))
                {
                    sqlQuery += " AND booknumber LIKE @booknumber";
                    parameters.Add(new SqlParameter("@booknumber", "%" + txtbookno.Text + "%"));
                }
                if (!string.IsNullOrEmpty(txttilte.Text)) 
                {
                    sqlQuery += " AND title LIKE @title";
                    parameters.Add(new SqlParameter("@title", "%" + txttilte.Text + "%"));
                }
                if (!string.IsNullOrEmpty(txtpub.Text))
                {
                    sqlQuery += " AND publisher LIKE @publisher";
                    parameters.Add(new SqlParameter("@publisher", "%" + txtpub.Text + "%"));
                }

                sqlQuery += " GROUP BY booknumber, title, publisher";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        protected void book()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT booknumber, title, publisher,COUNT(uid) AS Avalable FROM book where status = 10 GROUP BY booknumber, title, publisher", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void txttilte_TextChanged(object sender, EventArgs e)
        {
            LoadDynamicData();
        }

        private void txtpub_TextChanged(object sender, EventArgs e)
        {
            LoadDynamicData();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().Show();

        }
    }


}

