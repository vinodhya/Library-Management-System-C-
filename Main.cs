using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imb
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnmember_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Member_reg().Show();
        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Bookreg().Show();

        }

        private void btninqry_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inquary().Show();

        }

        private void btnloan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Bookloan().Show();
        }

        private void btnretun_Click(object sender, EventArgs e)
        {
            this.Hide();
            new @return().Show();
        }
    }
}
