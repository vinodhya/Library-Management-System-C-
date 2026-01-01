namespace imb
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnmember = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btninqry = new System.Windows.Forms.Button();
            this.btnloan = new System.Windows.Forms.Button();
            this.btnretun = new System.Windows.Forms.Button();
            this.btnregis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnmember
            // 
            this.btnmember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmember.BackgroundImage")));
            this.btnmember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmember.ForeColor = System.Drawing.Color.Black;
            this.btnmember.Location = new System.Drawing.Point(19, 18);
            this.btnmember.Name = "btnmember";
            this.btnmember.Size = new System.Drawing.Size(186, 161);
            this.btnmember.TabIndex = 0;
            this.btnmember.Text = "Member Registratoin";
            this.btnmember.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnmember.UseVisualStyleBackColor = true;
            this.btnmember.Click += new System.EventHandler(this.btnmember_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btninqry);
            this.panel1.Controls.Add(this.btnloan);
            this.panel1.Controls.Add(this.btnretun);
            this.panel1.Controls.Add(this.btnregis);
            this.panel1.Controls.Add(this.btnmember);
            this.panel1.Location = new System.Drawing.Point(22, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 378);
            this.panel1.TabIndex = 1;
            // 
            // btninqry
            // 
            this.btninqry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninqry.BackgroundImage")));
            this.btninqry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninqry.Location = new System.Drawing.Point(334, 199);
            this.btninqry.Name = "btninqry";
            this.btninqry.Size = new System.Drawing.Size(181, 157);
            this.btninqry.TabIndex = 0;
            this.btninqry.Text = "Inquiry";
            this.btninqry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninqry.UseVisualStyleBackColor = true;
            this.btninqry.Click += new System.EventHandler(this.btninqry_Click);
            // 
            // btnloan
            // 
            this.btnloan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnloan.BackgroundImage")));
            this.btnloan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnloan.Location = new System.Drawing.Point(465, 18);
            this.btnloan.Name = "btnloan";
            this.btnloan.Size = new System.Drawing.Size(182, 161);
            this.btnloan.TabIndex = 0;
            this.btnloan.Text = "Book Loan";
            this.btnloan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnloan.UseVisualStyleBackColor = true;
            this.btnloan.Click += new System.EventHandler(this.btnloan_Click);
            // 
            // btnretun
            // 
            this.btnretun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnretun.BackgroundImage")));
            this.btnretun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnretun.Location = new System.Drawing.Point(110, 199);
            this.btnretun.Name = "btnretun";
            this.btnretun.Size = new System.Drawing.Size(186, 157);
            this.btnretun.TabIndex = 0;
            this.btnretun.Text = "Book Return";
            this.btnretun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnretun.UseVisualStyleBackColor = true;
            this.btnretun.Click += new System.EventHandler(this.btnretun_Click);
            // 
            // btnregis
            // 
            this.btnregis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregis.BackgroundImage")));
            this.btnregis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnregis.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnregis.Location = new System.Drawing.Point(243, 18);
            this.btnregis.Name = "btnregis";
            this.btnregis.Size = new System.Drawing.Size(179, 161);
            this.btnregis.TabIndex = 0;
            this.btnregis.Text = "Book Registration";
            this.btnregis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnregis.UseVisualStyleBackColor = true;
            this.btnregis.Click += new System.EventHandler(this.btnregis_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btninqry;
        private System.Windows.Forms.Button btnloan;
        private System.Windows.Forms.Button btnretun;
        private System.Windows.Forms.Button btnregis;
    }
}