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

namespace imb
{
    public partial class Serchbook : Form
    {
        public string selectbooknumber { get; private set; }
        public int uid { get; private set; }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M4MN12E\\SQLEXPRESS; Initial Catalog=imb; User ID=sa; Password=123;");

        public Serchbook()
        {
            InitializeComponent();
            dataGridView1.KeyDown += dataGridView1_KeyDown; 
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    selectbooknumber = dataGridView1.CurrentRow.Cells["booknumber"].Value?.ToString();

                    var uidCellValue = dataGridView1.CurrentRow.Cells["uid"].Value;
                    if (uidCellValue != null && int.TryParse(uidCellValue.ToString(), out int uidValue))
                    {
                        uid = uidValue; 
                    }
                    else
                    {
                        uid = 0; 
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                e.SuppressKeyPress = true; 
            }
        }

    

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_KeyDown(sender, new KeyEventArgs(Keys.Enter)); 
        }

        private void txtbookno_TextChanged(object sender, EventArgs e)
        {
            LoadDynamicData();
        }

        private void Serchbook_Load(object sender, EventArgs e)
        {
            book();
        }
      
        private void LoadDynamicData()
        {
            try
            {
                string sqlQuery = "SELECT uid,booknumber, title, publisher FROM book WHERE status = 10 ";
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
                using (SqlCommand cmd = new SqlCommand("SELECT uid, booknumber, title, publisher FROM book WHERE status = 10 ", con))
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

    
    }
}

