namespace imb
{
    partial class Serchbook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtpublisher = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtpub = new System.Windows.Forms.TextBox();
            this.txttilte = new System.Windows.Forms.TextBox();
            this.txtbookno = new System.Windows.Forms.TextBox();
            this.Publisher = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.txtpublisher.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 227);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtpublisher
            // 
            this.txtpublisher.Controls.Add(this.textBox3);
            this.txtpublisher.Controls.Add(this.txtpub);
            this.txtpublisher.Controls.Add(this.txttilte);
            this.txtpublisher.Controls.Add(this.txtbookno);
            this.txtpublisher.Controls.Add(this.Publisher);
            this.txtpublisher.Controls.Add(this.Title);
            this.txtpublisher.Controls.Add(this.label1);
            this.txtpublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpublisher.Location = new System.Drawing.Point(0, 14);
            this.txtpublisher.Margin = new System.Windows.Forms.Padding(5);
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.Size = new System.Drawing.Size(835, 71);
            this.txtpublisher.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(993, 15);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 26);
            this.textBox3.TabIndex = 3;
            // 
            // txtpub
            // 
            this.txtpub.Location = new System.Drawing.Point(661, 22);
            this.txtpub.Margin = new System.Windows.Forms.Padding(5);
            this.txtpub.Name = "txtpub";
            this.txtpub.Size = new System.Drawing.Size(164, 26);
            this.txtpub.TabIndex = 3;
            this.txtpub.TextChanged += new System.EventHandler(this.txtpub_TextChanged);
            // 
            // txttilte
            // 
            this.txttilte.Location = new System.Drawing.Point(391, 19);
            this.txttilte.Margin = new System.Windows.Forms.Padding(5);
            this.txttilte.Name = "txttilte";
            this.txttilte.Size = new System.Drawing.Size(164, 26);
            this.txttilte.TabIndex = 3;
            this.txttilte.TextChanged += new System.EventHandler(this.txttilte_TextChanged);
            // 
            // txtbookno
            // 
            this.txtbookno.Location = new System.Drawing.Point(162, 17);
            this.txtbookno.Margin = new System.Windows.Forms.Padding(5);
            this.txtbookno.Name = "txtbookno";
            this.txtbookno.Size = new System.Drawing.Size(164, 26);
            this.txtbookno.TabIndex = 3;
            this.txtbookno.TextChanged += new System.EventHandler(this.txtbookno_TextChanged);
            // 
            // Publisher
            // 
            this.Publisher.AutoSize = true;
            this.Publisher.Location = new System.Drawing.Point(567, 23);
            this.Publisher.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(83, 20);
            this.Publisher.TabIndex = 2;
            this.Publisher.Text = "Publisher";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(336, 22);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(43, 20);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Number";
            // 
            // Serchbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtpublisher);
            this.Name = "Serchbook";
            this.Text = "Serchbook";
            this.Load += new System.EventHandler(this.Serchbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.txtpublisher.ResumeLayout(false);
            this.txtpublisher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel txtpublisher;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtpub;
        private System.Windows.Forms.TextBox txttilte;
        private System.Windows.Forms.TextBox txtbookno;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
    }
}