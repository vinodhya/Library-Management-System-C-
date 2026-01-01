namespace imb
{
    partial class Member_reg
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreg = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.drpgendar = new System.Windows.Forms.ComboBox();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtuseno = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gendar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnreg);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.drpgendar);
            this.panel1.Controls.Add(this.txtadress);
            this.panel1.Controls.Add(this.txtnic);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtuseno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(22, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 347);
            this.panel1.TabIndex = 5;
            // 
            // btnreg
            // 
            this.btnreg.BackColor = System.Drawing.Color.Lime;
            this.btnreg.Location = new System.Drawing.Point(15, 262);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(101, 41);
            this.btnreg.TabIndex = 8;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = false;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Gray;
            this.btnback.Location = new System.Drawing.Point(247, 262);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(109, 41);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Location = new System.Drawing.Point(129, 262);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(109, 41);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // drpgendar
            // 
            this.drpgendar.FormattingEnabled = true;
            this.drpgendar.Location = new System.Drawing.Point(147, 204);
            this.drpgendar.Name = "drpgendar";
            this.drpgendar.Size = new System.Drawing.Size(162, 28);
            this.drpgendar.TabIndex = 6;
            // 
            // txtadress
            // 
            this.txtadress.Location = new System.Drawing.Point(147, 159);
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(162, 26);
            this.txtadress.TabIndex = 5;
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(147, 114);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(162, 26);
            this.txtnic.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(147, 72);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(162, 26);
            this.txtname.TabIndex = 5;
            // 
            // txtuseno
            // 
            this.txtuseno.Location = new System.Drawing.Point(147, 33);
            this.txtuseno.Name = "txtuseno";
            this.txtuseno.Size = new System.Drawing.Size(162, 26);
            this.txtuseno.TabIndex = 5;
            // 
            // Member_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 424);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Member_reg";
            this.Text = "Member_reg";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ComboBox drpgendar;
        private System.Windows.Forms.TextBox txtadress;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtuseno;
        private System.Windows.Forms.Button btnback;
    }
}