namespace Wishake
{
    partial class CheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            this.lblTitle_CheckOut = new System.Windows.Forms.Label();
            this.btnBack_Fruits = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lbOrderList = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.pb_QuickOrder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuickOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle_CheckOut
            // 
            this.lblTitle_CheckOut.AutoSize = true;
            this.lblTitle_CheckOut.Font = new System.Drawing.Font("Segoe Print", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_CheckOut.Location = new System.Drawing.Point(119, 6);
            this.lblTitle_CheckOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle_CheckOut.Name = "lblTitle_CheckOut";
            this.lblTitle_CheckOut.Size = new System.Drawing.Size(349, 94);
            this.lblTitle_CheckOut.TabIndex = 13;
            this.lblTitle_CheckOut.Text = "Your very own drink,\r\nmade especially for you!\r\n";
            // 
            // btnBack_Fruits
            // 
            this.btnBack_Fruits.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_Fruits.Location = new System.Drawing.Point(19, 348);
            this.btnBack_Fruits.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack_Fruits.Name = "btnBack_Fruits";
            this.btnBack_Fruits.Size = new System.Drawing.Size(99, 32);
            this.btnBack_Fruits.TabIndex = 14;
            this.btnBack_Fruits.Text = "Back";
            this.btnBack_Fruits.UseVisualStyleBackColor = true;
            this.btnBack_Fruits.Click += new System.EventHandler(this.btnBack_Fruits_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(493, 348);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(99, 32);
            this.btnPayment.TabIndex = 18;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lbOrderList
            // 
            this.lbOrderList.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderList.FormattingEnabled = true;
            this.lbOrderList.ItemHeight = 19;
            this.lbOrderList.Location = new System.Drawing.Point(40, 111);
            this.lbOrderList.Margin = new System.Windows.Forms.Padding(2);
            this.lbOrderList.Name = "lbOrderList";
            this.lbOrderList.Size = new System.Drawing.Size(339, 213);
            this.lbOrderList.TabIndex = 22;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(127, 348);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 32);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(294, 353);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(174, 21);
            this.lblTotalPrice.TabIndex = 27;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // pb_QuickOrder
            // 
            this.pb_QuickOrder.Location = new System.Drawing.Point(396, 111);
            this.pb_QuickOrder.Margin = new System.Windows.Forms.Padding(2);
            this.pb_QuickOrder.Name = "pb_QuickOrder";
            this.pb_QuickOrder.Size = new System.Drawing.Size(164, 213);
            this.pb_QuickOrder.TabIndex = 15;
            this.pb_QuickOrder.TabStop = false;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(613, 394);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbOrderList);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnBack_Fruits);
            this.Controls.Add(this.pb_QuickOrder);
            this.Controls.Add(this.lblTitle_CheckOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check out";
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuickOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle_CheckOut;
        private System.Windows.Forms.PictureBox pb_QuickOrder;
        private System.Windows.Forms.Button btnBack_Fruits;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.ListBox lbOrderList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}