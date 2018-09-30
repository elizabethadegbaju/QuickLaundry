namespace quicklaundry
{
    partial class profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.order = new System.Windows.Forms.Button();
            this.logout_ = new System.Windows.Forms.Button();
            this.addnew = new System.Windows.Forms.Button();
            this.address_ = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.time_ = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.Laundry = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 505);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.order);
            this.panel1.Controls.Add(this.logout_);
            this.panel1.Controls.Add(this.addnew);
            this.panel1.Controls.Add(this.address_);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.time_);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.Laundry);
            this.panel1.Controls.Add(this.balance);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.name);
            this.panel1.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-6, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 384);
            this.panel1.TabIndex = 27;
            // 
            // order
            // 
            this.order.BackColor = System.Drawing.Color.Black;
            this.order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order.ForeColor = System.Drawing.Color.White;
            this.order.Location = new System.Drawing.Point(463, 271);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(102, 33);
            this.order.TabIndex = 26;
            this.order.Text = "Order Drop-off";
            this.order.UseVisualStyleBackColor = false;
            this.order.Click += new System.EventHandler(this.order_Click_1);
            // 
            // logout_
            // 
            this.logout_.BackColor = System.Drawing.Color.Black;
            this.logout_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_.ForeColor = System.Drawing.Color.White;
            this.logout_.Location = new System.Drawing.Point(39, 271);
            this.logout_.Name = "logout_";
            this.logout_.Size = new System.Drawing.Size(93, 33);
            this.logout_.TabIndex = 25;
            this.logout_.Text = "Log Out";
            this.logout_.UseVisualStyleBackColor = false;
            this.logout_.Click += new System.EventHandler(this.logout__Click_1);
            // 
            // addnew
            // 
            this.addnew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addnew.BackColor = System.Drawing.Color.Black;
            this.addnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addnew.Font = new System.Drawing.Font("High Tower Text", 14F);
            this.addnew.ForeColor = System.Drawing.Color.White;
            this.addnew.Location = new System.Drawing.Point(461, 97);
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(107, 33);
            this.addnew.TabIndex = 24;
            this.addnew.Text = "Add New Laundry";
            this.addnew.UseVisualStyleBackColor = false;
            this.addnew.Click += new System.EventHandler(this.addnew_Click_1);
            // 
            // address_
            // 
            this.address_.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.address_.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.address_.Location = new System.Drawing.Point(519, 169);
            this.address_.Multiline = true;
            this.address_.Name = "address_";
            this.address_.Size = new System.Drawing.Size(195, 85);
            this.address_.TabIndex = 23;
            // 
            // address
            // 
            this.address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(324, 165);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(189, 25);
            this.address.TabIndex = 22;
            this.address.Text = "Address for drop-off";
            // 
            // time_
            // 
            this.time_.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time_.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.time_.Location = new System.Drawing.Point(519, 137);
            this.time_.Name = "time_";
            this.time_.Size = new System.Drawing.Size(195, 25);
            this.time_.TabIndex = 21;
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(324, 136);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(168, 25);
            this.time.TabIndex = 20;
            this.time.Text = "Time for drop-off";
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.status.AutoEllipsis = true;
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(483, 73);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(63, 25);
            this.status.TabIndex = 19;
            this.status.Text = "status";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Laundry
            // 
            this.Laundry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Laundry.AutoEllipsis = true;
            this.Laundry.AutoSize = true;
            this.Laundry.BackColor = System.Drawing.Color.Transparent;
            this.Laundry.Font = new System.Drawing.Font("Tempus Sans ITC", 20F, System.Drawing.FontStyle.Bold);
            this.Laundry.Location = new System.Drawing.Point(457, 29);
            this.Laundry.Name = "Laundry";
            this.Laundry.Size = new System.Drawing.Size(114, 35);
            this.Laundry.TabIndex = 18;
            this.Laundry.Text = "Laundry";
            this.Laundry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balance
            // 
            this.balance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.balance.AutoEllipsis = true;
            this.balance.AutoSize = true;
            this.balance.BackColor = System.Drawing.Color.Transparent;
            this.balance.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(476, 103);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(77, 25);
            this.balance.TabIndex = 17;
            this.balance.Text = "balance";
            this.balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.AutoEllipsis = true;
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Black;
            this.username.Font = new System.Drawing.Font("Gloria Hallelujah", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.username.Location = new System.Drawing.Point(39, 116);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(153, 50);
            this.username.TabIndex = 16;
            this.username.Text = "username";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.AutoEllipsis = true;
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(34, 70);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(60, 25);
            this.email.TabIndex = 15;
            this.email.Text = "email";
            this.email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.AutoEllipsis = true;
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(34, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(74, 28);
            this.name.TabIndex = 14;
            this.name.Text = "Name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quicklaundry.Properties.Resources.folded;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(721, 505);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "profile";
            this.Text = "My Profile";
            this.Load += new System.EventHandler(this.profile_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button logout_;
        private System.Windows.Forms.Button addnew;
        private System.Windows.Forms.TextBox address_;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.DateTimePicker time_;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label Laundry;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label name;
    }
}