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
using System.Xml.Linq;

namespace imb
{
    public partial class Bookreg : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M4MN12E\\SQLEXPRESS; Initial Catalog=imb; User ID=sa; Password=123;");

        public Bookreg()
        {
            InitializeComponent();
            type();
         
            Quantity();
        }

        public class ComboBoxItem
        {
            public string Display { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string display, string value)
            {
                Display = display;
                Value = value;
            }

            public override string ToString() => Display; 
        }


        public class ComboBoxItem1
        {
            public string Display { get; set; }
            public string Value { get; set; }

            public ComboBoxItem1(string display, string value)
            {
                Display = display;
                Value = value;
            }

            public override string ToString() => Display;
        }


        protected void clear()
        {
            txtbookno.Text="";
            txtpublisher.Text = "";
            txttilte.Text = "";
            drptype.Items.Clear();
            drpquan.Items.Clear();
        }



        private void type()
        {
            drptype.Items.Clear();

            drptype.Items.Add(new ComboBoxItem("Fiction", "F"));
            drptype.Items.Add(new ComboBoxItem("Non-Fiction", "N"));

            drptype.Items.Add(new ComboBoxItem("Children’s and Young Adult", "C"));
            drptype.Items.Add(new ComboBoxItem("Poetry", "P"));

            drptype.Items.Add(new ComboBoxItem("Textbooks", "T"));
            drptype.Items.Add(new ComboBoxItem("Religious/Spiritual Texts", "R"));

            drptype.Items.Add(new ComboBoxItem("Periodicals", "E"));
            drptype.Items.Add(new ComboBoxItem("Graphic Novels and Comics", "G"));

            drptype.Items.Add(new ComboBoxItem("Special Collections", "S"));
            drptype.Items.Add(new ComboBoxItem("Reference Books", "B"));
        }

        private void Quantity()
        {
            drpquan.Items.Clear();

            drpquan.Items.Add(new ComboBoxItem1("1", "1"));
            drpquan.Items.Add(new ComboBoxItem1("2", "2"));

            drpquan.Items.Add(new ComboBoxItem1("3", "3"));
            drpquan.Items.Add(new ComboBoxItem1("4", "4"));

            drpquan.Items.Add(new ComboBoxItem1("5", "5"));
            drpquan.Items.Add(new ComboBoxItem1("6", "6"));

            drpquan.Items.Add(new ComboBoxItem1("7", "7"));
            drpquan.Items.Add(new ComboBoxItem1("8", "8"));

            drpquan.Items.Add(new ComboBoxItem1("9", "9"));
            drpquan.Items.Add(new ComboBoxItem1("10", "10"));
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            string bookno = txtbookno.Text;
            string title = txttilte.Text;
            string publisher = txtpublisher.Text;
        

            ComboBoxItem selectedItem = drptype.SelectedItem as ComboBoxItem;
            string type = selectedItem?.Value;

            ComboBoxItem1 selectedItem1 = drpquan.SelectedItem as ComboBoxItem1;
            string quantityString = selectedItem1?.Value;

           
            if (string.IsNullOrWhiteSpace(bookno) ||
                string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(publisher) ||
                string.IsNullOrWhiteSpace(quantityString) ||
                string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Please fill the required fields");
                return;
            }

            if (!int.TryParse(quantityString, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            try
            {
                string newbookno = type + bookno;

                con.Open(); 

                
                for (int i = 0; i < quantity; i++)
                {

                    string query = "insert into book( booknumber, title, publisher, status )values ('" + newbookno + "','" + title + "','" + publisher + "',' 10 ')";

                    SqlCommand cm = new SqlCommand(query, con);
                    int result = cm.ExecuteNonQuery();

                    if (result <= 0)
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                        return;
                    }


                }
                        MessageBox.Show("Successfully '" + quantityString + "'Book registered!");
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
      


            private void btnback_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Main().Show();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void drptype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

