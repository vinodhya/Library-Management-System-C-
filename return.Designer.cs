namespace imb
{
    partial class @return
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
            this.label1 = new System.Windows.Forms.Label();
            this.member = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnreturnd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtretundate = new System.Windows.Forms.TextBox();
            this.txtissuedate = new System.Windows.Forms.TextBox();
            this.txtissedbook = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtmemberno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Return";
            // 
            // member
            // 
            this.member.AutoSize = true;
            this.member.Location = new System.Drawing.Point(16, 20);
            this.member.Name = "member";
            this.member.Size = new System.Drawing.Size(189, 20);
            this.member.TabIndex = 1;
            this.member.Text = "Enter Member Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.btnreturnd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtretundate);
            this.panel1.Controls.Add(this.txtissuedate);
            this.panel1.Controls.Add(this.txtissedbook);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtmemberno);
            this.panel1.Controls.Add(this.member);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(39, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 280);
            this.panel1.TabIndex = 3;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.RosyBrown;
            this.btnclear.Location = new System.Drawing.Point(199, 217);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(158, 44);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.LimeGreen;
            this.btnback.Location = new System.Drawing.Point(368, 217);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(158, 44);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnreturnd
            // 
            this.btnreturnd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnreturnd.Location = new System.Drawing.Point(31, 217);
            this.btnreturnd.Name = "btnreturnd";
            this.btnreturnd.Size = new System.Drawing.Size(161, 44);
            this.btnreturnd.TabIndex = 5;
            this.btnreturnd.Text = "Update Returned ";
            this.btnreturnd.UseVisualStyleBackColor = false;
            this.btnreturnd.Click += new System.EventHandler(this.btnreturnd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(414, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtretundate
            // 
            this.txtretundate.Location = new System.Drawing.Point(211, 172);
            this.txtretundate.Name = "txtretundate";
            this.txtretundate.ReadOnly = true;
            this.txtretundate.Size = new System.Drawing.Size(315, 26);
            this.txtretundate.TabIndex = 4;
            // 
            // txtissuedate
            // 
            this.txtissuedate.Location = new System.Drawing.Point(211, 135);
            this.txtissuedate.Name = "txtissuedate";
            this.txtissuedate.ReadOnly = true;
            this.txtissuedate.Size = new System.Drawing.Size(315, 26);
            this.txtissuedate.TabIndex = 4;
            // 
            // txtissedbook
            // 
            this.txtissedbook.Location = new System.Drawing.Point(211, 101);
            this.txtissedbook.Name = "txtissedbook";
            this.txtissedbook.ReadOnly = true;
            this.txtissedbook.Size = new System.Drawing.Size(315, 26);
            this.txtissedbook.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtname.Location = new System.Drawing.Point(211, 62);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(315, 26);
            this.txtname.TabIndex = 4;
            // 
            // txtmemberno
            // 
            this.txtmemberno.Location = new System.Drawing.Point(211, 20);
            this.txtmemberno.Name = "txtmemberno";
            this.txtmemberno.Size = new System.Drawing.Size(184, 26);
            this.txtmemberno.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Issued Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Return Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Issued Book Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Member Name";
            // 
            // @return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "@return";
            this.Text = "return";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label member;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtmemberno;
        private System.Windows.Forms.TextBox txtretundate;
        private System.Windows.Forms.TextBox txtissuedate;
        private System.Windows.Forms.TextBox txtissedbook;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnreturnd;
    }
}