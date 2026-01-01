namespace imb
{
    partial class Bookreg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.drpquan = new System.Windows.Forms.ComboBox();
            this.drptype = new System.Windows.Forms.ComboBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.txtpublisher = new System.Windows.Forms.TextBox();
            this.txttilte = new System.Windows.Forms.TextBox();
            this.txtbookno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Registation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Publisher";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.drpquan);
            this.panel1.Controls.Add(this.drptype);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btnreg);
            this.panel1.Controls.Add(this.txtpublisher);
            this.panel1.Controls.Add(this.txttilte);
            this.panel1.Controls.Add(this.txtbookno);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 308);
            this.panel1.TabIndex = 1;
            // 
            // drpquan
            // 
            this.drpquan.FormattingEnabled = true;
            this.drpquan.Location = new System.Drawing.Point(140, 197);
            this.drpquan.Name = "drpquan";
            this.drpquan.Size = new System.Drawing.Size(254, 28);
            this.drpquan.TabIndex = 3;
            this.drpquan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // drptype
            // 
            this.drptype.FormattingEnabled = true;
            this.drptype.Location = new System.Drawing.Point(140, 14);
            this.drptype.Name = "drptype";
            this.drptype.Size = new System.Drawing.Size(254, 28);
            this.drptype.TabIndex = 3;
            this.drptype.SelectedIndexChanged += new System.EventHandler(this.drptype_SelectedIndexChanged);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Gray;
            this.btnback.Location = new System.Drawing.Point(268, 242);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(99, 44);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Location = new System.Drawing.Point(156, 242);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(105, 44);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnreg
            // 
            this.btnreg.BackColor = System.Drawing.Color.Lime;
            this.btnreg.Location = new System.Drawing.Point(43, 242);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(109, 44);
            this.btnreg.TabIndex = 2;
            this.btnreg.Text = "Registar";
            this.btnreg.UseVisualStyleBackColor = false;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // txtpublisher
            // 
            this.txtpublisher.Location = new System.Drawing.Point(140, 149);
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.Size = new System.Drawing.Size(254, 26);
            this.txtpublisher.TabIndex = 1;
            // 
            // txttilte
            // 
            this.txttilte.Location = new System.Drawing.Point(140, 102);
            this.txttilte.Name = "txttilte";
            this.txttilte.Size = new System.Drawing.Size(254, 26);
            this.txttilte.TabIndex = 1;
            // 
            // txtbookno
            // 
            this.txtbookno.Location = new System.Drawing.Point(140, 54);
            this.txtbookno.Name = "txtbookno";
            this.txtbookno.Size = new System.Drawing.Size(254, 26);
            this.txtbookno.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantity";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Book Number";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // Bookreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 366);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Bookreg";
            this.Text = "Form2";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.TextBox txtpublisher;
        private System.Windows.Forms.TextBox txttilte;
        private System.Windows.Forms.TextBox txtbookno;
        private System.Windows.Forms.ComboBox drptype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox drpquan;
        private System.Windows.Forms.Label label6;
    }
}