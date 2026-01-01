namespace imb
{
    partial class Searchuser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.txtuserno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtadress);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtnic);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.txtuserno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 68);
            this.panel1.TabIndex = 0;
            // 
            // txtadress
            // 
            this.txtadress.Location = new System.Drawing.Point(693, 15);
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(155, 24);
            this.txtadress.TabIndex = 1;
            this.txtadress.TextChanged += new System.EventHandler(this.txtadress_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(294, 18);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(163, 24);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(505, 15);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(107, 24);
            this.txtnic.TabIndex = 1;
            this.txtnic.TextChanged += new System.EventHandler(this.txtnic_TextChanged);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(618, 21);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(69, 18);
            this.Address.TabIndex = 0;
            this.Address.Text = "Address";
            // 
            // txtuserno
            // 
            this.txtuserno.Location = new System.Drawing.Point(117, 18);
            this.txtuserno.Name = "txtuserno";
            this.txtuserno.Size = new System.Drawing.Size(119, 24);
            this.txtuserno.TabIndex = 1;
            this.txtuserno.TextChanged += new System.EventHandler(this.txtuserno_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "NIC";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(242, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(52, 18);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 244);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Searchuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Searchuser";
            this.Text = "Searchuser";
            this.Load += new System.EventHandler(this.Searchuser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtadress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox txtuserno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}