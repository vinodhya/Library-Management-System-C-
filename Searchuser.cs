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
    public partial class Searchuser : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M4MN12E\\SQLEXPRESS; Initial Catalog=imb; User ID=sa; Password=123;");

        public string SelectedUserNumber { get; private set; }

        public Searchuser()
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
                    SelectedUserNumber = dataGridView1.CurrentRow.Cells["Usernumber"].Value.ToString();
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

        private void txtadress_TextChanged(object sender, EventArgs e)
        {
            LoadDynamicData();
        }

        private void Searchuser_Load(object sender, EventArgs e)
        {
            User();
        }

        protected void User()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Member where status=10  ", con))
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
        private void LoadDynamicData()
        {
            try
            {
              
                string sqlQuery = "SELECT * FROM Member WHERE status=10 ";
                List<SqlParameter> parameters = new List<SqlParameter>();

           
                if (!string.IsNullOrEmpty(txtadress.Text))
                {
                    sqlQuery += " AND Address LIKE @Address";
                    parameters.Add(new SqlParameter("@Address", "%" + txtadress.Text + "%"));
                }
                if (!string.IsNullOrEmpty(txtname.Text)) 
                {
                    sqlQuery += " AND Name LIKE @Name";
                    parameters.Add(new SqlParameter("@Name", "%" + txtname.Text + "%"));
                }
                if (!string.IsNullOrEmpty(txtnic.Text))
                {
                    sqlQuery += " AND NIC LIKE @NIC";
                    parameters.Add(new SqlParameter("@NIC", "%" + txtnic.Text + "%"));
                }
                if (!string.IsNullOrEmpty(txtuserno.Text))
                {
                    sqlQuery += " AND Usernumber LIKE @Usernumber";
                    parameters.Add(new SqlParameter("@Usernumber", "%" + txtuserno.Text + "%"));
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

        private void txtuserno_TextChanged(object sender, EventArgs e)
        {
            LoadDynamicData();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            LoadDynamicData();
        }

        private void txtnic_TextChanged(object sender, EventArgs e)
        {
            LoadDynamicData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
