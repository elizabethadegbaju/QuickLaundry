namespace quicklaundry
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.forgot = new System.Windows.Forms.LinkLabel();
            this.username_ = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.signup = new System.Windows.Forms.LinkLabel();
            this.password = new System.Windows.Forms.Label();
            this.log_in = new System.Windows.Forms.Button();
            this.password_ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Remachine Script Personal Use", 76F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(3, 195);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(441, 109);
            this.title.TabIndex = 6;
            this.title.Text = "Quick Laundry";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.forgot);
            this.panel1.Controls.Add(this.username_);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.signup);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.log_in);
            this.panel1.Controls.Add(this.password_);
            this.panel1.Location = new System.Drawing.Point(425, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 267);
            this.panel1.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(62, 125);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(118, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // forgot
            // 
            this.forgot.AutoSize = true;
            this.forgot.BackColor = System.Drawing.Color.Transparent;
            this.forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot.Location = new System.Drawing.Point(202, 125);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(156, 16);
            this.forgot.TabIndex = 5;
            this.forgot.TabStop = true;
            this.forgot.Text = "Forgot Password? Reset";
            this.forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot_LinkClicked);
            // 
            // username_
            // 
            this.username_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_.ForeColor = System.Drawing.Color.Black;
            this.username_.Location = new System.Drawing.Point(134, 38);
            this.username_.Name = "username_";
            this.username_.Size = new System.Drawing.Size(210, 26);
            this.username_.TabIndex = 2;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Remachine Script Personal Use", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(30, 35);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(88, 29);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // signup
            // 
            this.signup.ActiveLinkColor = System.Drawing.Color.Olive;
            this.signup.AutoSize = true;
            this.signup.BackColor = System.Drawing.Color.Transparent;
            this.signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup.Font = new System.Drawing.Font("Remachine Script Personal Use", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.Black;
            this.signup.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.signup.LinkColor = System.Drawing.Color.DimGray;
            this.signup.Location = new System.Drawing.Point(141, 197);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(126, 29);
            this.signup.TabIndex = 7;
            this.signup.TabStop = true;
            this.signup.Text = "Create Account";
            this.signup.VisitedLinkColor = System.Drawing.Color.Sienna;
            this.signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Remachine Script Personal Use", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(30, 83);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(93, 29);
            this.password.TabIndex = 1;
            this.password.Text = "Password:";
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.LightGray;
            this.log_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_in.FlatAppearance.BorderSize = 0;
            this.log_in.Font = new System.Drawing.Font("Remachine Script Personal Use", 20F);
            this.log_in.ForeColor = System.Drawing.Color.Black;
            this.log_in.Location = new System.Drawing.Point(151, 150);
            this.log_in.Name = "log_in";
            this.log_in.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.log_in.Size = new System.Drawing.Size(104, 42);
            this.log_in.TabIndex = 6;
            this.log_in.Text = "Login";
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.button1_Click);
            // 
            // password_
            // 
            this.password_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_.ForeColor = System.Drawing.Color.Black;
            this.password_.Location = new System.Drawing.Point(134, 86);
            this.password_.Name = "password_";
            this.password_.PasswordChar = '*';
            this.password_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password_.Size = new System.Drawing.Size(210, 26);
            this.password_.TabIndex = 3;
            this.password_.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(437, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Save yourself  the stress and create an account";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 424);
            this.panel2.TabIndex = 9;
            // 
            // login
            // 
            this.AcceptButton = this.log_in;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::quicklaundry.Properties.Resources.stress;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(843, 424);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "Quick Laundry";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox username_;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.LinkLabel signup;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.TextBox password_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel forgot;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

