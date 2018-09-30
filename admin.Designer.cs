namespace quicklaundry
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.dataGridlaundry = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bill = new System.Windows.Forms.TextBox();
            this.orderno = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paid = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlaundry)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridlaundry
            // 
            this.dataGridlaundry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridlaundry.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridlaundry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridlaundry.Location = new System.Drawing.Point(12, 111);
            this.dataGridlaundry.Name = "dataGridlaundry";
            this.dataGridlaundry.Size = new System.Drawing.Size(637, 341);
            this.dataGridlaundry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("FFF Tusj", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Admin Panel";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(246, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Details of Laundry";
            // 
            // logout
            // 
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logout.BackColor = System.Drawing.Color.Olive;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("MicroSquare", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(208, 469);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(237, 36);
            this.logout.TabIndex = 3;
            this.logout.Text = "Commit to Database and log out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.dataGridlaundry);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 517);
            this.panel1.TabIndex = 4;
            // 
            // bill
            // 
            this.bill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bill.Font = new System.Drawing.Font("MicroSquare", 11F, System.Drawing.FontStyle.Bold);
            this.bill.Location = new System.Drawing.Point(33, 234);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(166, 23);
            this.bill.TabIndex = 4;
            // 
            // orderno
            // 
            this.orderno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderno.AutoSize = true;
            this.orderno.Font = new System.Drawing.Font("MicroSquare", 14F, System.Drawing.FontStyle.Bold);
            this.orderno.ForeColor = System.Drawing.Color.Olive;
            this.orderno.Location = new System.Drawing.Point(163, 88);
            this.orderno.Name = "orderno";
            this.orderno.Size = new System.Drawing.Size(81, 21);
            this.orderno.TabIndex = 5;
            this.orderno.Text = "orderNo";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.status);
            this.panel2.Controls.Add(this.paid);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.orderno);
            this.panel2.Controls.Add(this.bill);
            this.panel2.Location = new System.Drawing.Point(655, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 517);
            this.panel2.TabIndex = 6;
            // 
            // paid
            // 
            this.paid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paid.Font = new System.Drawing.Font("MicroSquare", 11F, System.Drawing.FontStyle.Bold);
            this.paid.FormattingEnabled = true;
            this.paid.Items.AddRange(new object[] {
            "True",
            "False"});
            this.paid.Location = new System.Drawing.Point(33, 309);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(166, 26);
            this.paid.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MicroSquare", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Paid";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MicroSquare", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bill";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MicroSquare", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status";
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update.BackColor = System.Drawing.Color.Olive;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("MicroSquare", 11F, System.Drawing.FontStyle.Bold);
            this.update.Location = new System.Drawing.Point(71, 355);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(90, 33);
            this.update.TabIndex = 6;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MicroSquare", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(29, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Order Number:";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("MicroSquare", 11F, System.Drawing.FontStyle.Bold);
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "pending",
            "ongoing",
            "completed",
            "dropoff",
            "delivered"});
            this.status.Location = new System.Drawing.Point(33, 159);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(166, 26);
            this.status.TabIndex = 9;
            // 
            // admin
            // 
            this.AcceptButton = this.logout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(888, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlaundry)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridlaundry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox bill;
        private System.Windows.Forms.Label orderno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox paid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox status;
    }
}