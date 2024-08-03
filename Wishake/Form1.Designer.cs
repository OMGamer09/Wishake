namespace Wishake
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGetStarted = new System.Windows.Forms.Button();
            this.btnQuickOrder = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSlogan1 = new System.Windows.Forms.Label();
            this.lblSlogan2 = new System.Windows.Forms.Label();
            this.msWelcome = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msStaffLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.staffStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msLogout_Staff = new System.Windows.Forms.ToolStripMenuItem();
            this.msMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.msMemberLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.msLogout_Member = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.msWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStarted.Location = new System.Drawing.Point(428, 293);
            this.btnGetStarted.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Size = new System.Drawing.Size(151, 45);
            this.btnGetStarted.TabIndex = 0;
            this.btnGetStarted.Text = "Get Started";
            this.btnGetStarted.UseVisualStyleBackColor = true;
            this.btnGetStarted.Click += new System.EventHandler(this.btnGetStarted_Click);
            // 
            // btnQuickOrder
            // 
            this.btnQuickOrder.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickOrder.Location = new System.Drawing.Point(234, 293);
            this.btnQuickOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuickOrder.Name = "btnQuickOrder";
            this.btnQuickOrder.Size = new System.Drawing.Size(151, 45);
            this.btnQuickOrder.TabIndex = 2;
            this.btnQuickOrder.Text = "Quick Order";
            this.btnQuickOrder.UseVisualStyleBackColor = true;
            this.btnQuickOrder.Click += new System.EventHandler(this.btnQuickOrder_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.Location = new System.Drawing.Point(509, 37);
            this.btnAboutUs.Margin = new System.Windows.Forms.Padding(2);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(93, 27);
            this.btnAboutUs.TabIndex = 4;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe Print", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(99, 106);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(415, 47);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome to WiShake";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSlogan1
            // 
            this.lblSlogan1.AutoSize = true;
            this.lblSlogan1.BackColor = System.Drawing.Color.White;
            this.lblSlogan1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan1.Location = new System.Drawing.Point(160, 167);
            this.lblSlogan1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSlogan1.Name = "lblSlogan1";
            this.lblSlogan1.Size = new System.Drawing.Size(273, 23);
            this.lblSlogan1.TabIndex = 6;
            this.lblSlogan1.Text = "\"Taste the Difference, Feel the Benefits\"";
            // 
            // lblSlogan2
            // 
            this.lblSlogan2.AutoSize = true;
            this.lblSlogan2.BackColor = System.Drawing.Color.White;
            this.lblSlogan2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan2.Location = new System.Drawing.Point(168, 203);
            this.lblSlogan2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSlogan2.Name = "lblSlogan2";
            this.lblSlogan2.Size = new System.Drawing.Size(265, 23);
            this.lblSlogan2.TabIndex = 7;
            this.lblSlogan2.Text = "\"Nourish Your Body, Uplift Your Mind\"";
            // 
            // msWelcome
            // 
            this.msWelcome.BackColor = System.Drawing.Color.MediumAquamarine;
            this.msWelcome.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msWelcome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.msMembers});
            this.msWelcome.Location = new System.Drawing.Point(0, 0);
            this.msWelcome.Name = "msWelcome";
            this.msWelcome.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.msWelcome.Size = new System.Drawing.Size(613, 24);
            this.msWelcome.TabIndex = 9;
            this.msWelcome.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingredientsToolStripMenuItem,
            this.orderHistoryToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.loginToolStripMenuItem.Text = "Menu";
            // 
            // ingredientsToolStripMenuItem
            // 
            this.ingredientsToolStripMenuItem.Name = "ingredientsToolStripMenuItem";
            this.ingredientsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.ingredientsToolStripMenuItem.Text = "Ingredients";
            this.ingredientsToolStripMenuItem.Click += new System.EventHandler(this.ingredientsToolStripMenuItem_Click);
            // 
            // orderHistoryToolStripMenuItem
            // 
            this.orderHistoryToolStripMenuItem.Name = "orderHistoryToolStripMenuItem";
            this.orderHistoryToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.orderHistoryToolStripMenuItem.Text = "Order History";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msStaffLogin,
            this.staffStatisticsToolStripMenuItem,
            this.msLogout_Staff});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // msStaffLogin
            // 
            this.msStaffLogin.Name = "msStaffLogin";
            this.msStaffLogin.Size = new System.Drawing.Size(147, 22);
            this.msStaffLogin.Text = "Login";
            this.msStaffLogin.Click += new System.EventHandler(this.msStaffLogin_Click);
            // 
            // staffStatisticsToolStripMenuItem
            // 
            this.staffStatisticsToolStripMenuItem.Name = "staffStatisticsToolStripMenuItem";
            this.staffStatisticsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.staffStatisticsToolStripMenuItem.Text = "Staff Statistics";
            this.staffStatisticsToolStripMenuItem.Visible = false;
            this.staffStatisticsToolStripMenuItem.Click += new System.EventHandler(this.staffStatisticsToolStripMenuItem_Click);
            // 
            // msLogout_Staff
            // 
            this.msLogout_Staff.Name = "msLogout_Staff";
            this.msLogout_Staff.Size = new System.Drawing.Size(147, 22);
            this.msLogout_Staff.Text = "Logout";
            this.msLogout_Staff.Visible = false;
            this.msLogout_Staff.Click += new System.EventHandler(this.msLogout_Staff_Click);
            // 
            // msMembers
            // 
            this.msMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMemberLogin,
            this.msLogout_Member});
            this.msMembers.Name = "msMembers";
            this.msMembers.Size = new System.Drawing.Size(69, 22);
            this.msMembers.Text = "Members";
            // 
            // msMemberLogin
            // 
            this.msMemberLogin.Name = "msMemberLogin";
            this.msMemberLogin.Size = new System.Drawing.Size(112, 22);
            this.msMemberLogin.Text = "Login";
            this.msMemberLogin.Click += new System.EventHandler(this.msMemberLogin_Click);
            // 
            // msLogout_Member
            // 
            this.msLogout_Member.Name = "msLogout_Member";
            this.msLogout_Member.Size = new System.Drawing.Size(112, 22);
            this.msLogout_Member.Text = "Logout";
            this.msLogout_Member.Visible = false;
            this.msLogout_Member.Click += new System.EventHandler(this.msLogout_Member_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(32, 293);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Wishake.Properties.Resources.brightt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 394);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSlogan2);
            this.Controls.Add(this.lblSlogan1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.btnQuickOrder);
            this.Controls.Add(this.btnGetStarted);
            this.Controls.Add(this.msWelcome);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msWelcome;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WiShake";
            this.msWelcome.ResumeLayout(false);
            this.msWelcome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetStarted;
        private System.Windows.Forms.Button btnQuickOrder;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSlogan1;
        private System.Windows.Forms.Label lblSlogan2;
        private System.Windows.Forms.MenuStrip msWelcome;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderHistoryToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msStaffLogin;
        private System.Windows.Forms.ToolStripMenuItem msMembers;
        private System.Windows.Forms.ToolStripMenuItem msMemberLogin;
        private System.Windows.Forms.ToolStripMenuItem staffStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msLogout_Staff;
        private System.Windows.Forms.ToolStripMenuItem msLogout_Member;
    }
}

