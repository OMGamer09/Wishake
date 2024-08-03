namespace Wishake
{
    partial class DrinkHistory
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
            this.lblTitle_OrderHistory = new System.Windows.Forms.Label();
            this.lbPastDrinks = new System.Windows.Forms.ListBox();
            this.btnBack_Fruits = new System.Windows.Forms.Button();
            this.btnNext_OrderFeel = new System.Windows.Forms.Button();
            this.pb_PastOrder = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PastOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle_OrderHistory
            // 
            this.lblTitle_OrderHistory.AutoSize = true;
            this.lblTitle_OrderHistory.Font = new System.Drawing.Font("Segoe Print", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_OrderHistory.Location = new System.Drawing.Point(65, 40);
            this.lblTitle_OrderHistory.Name = "lblTitle_OrderHistory";
            this.lblTitle_OrderHistory.Size = new System.Drawing.Size(323, 71);
            this.lblTitle_OrderHistory.TabIndex = 13;
            this.lblTitle_OrderHistory.Text = "Order History:";
            // 
            // lbPastDrinks
            // 
            this.lbPastDrinks.BackColor = System.Drawing.Color.Plum;
            this.lbPastDrinks.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPastDrinks.FormattingEnabled = true;
            this.lbPastDrinks.ItemHeight = 43;
            this.lbPastDrinks.Items.AddRange(new object[] {
            "Sunrise Surge",
            "Vitality Vibe",
            "Serenity Smoothie",
            "Dreamy Delight",
            "Lean Green",
            "Joyful Juice",
            "Focus Fusion"});
            this.lbPastDrinks.Location = new System.Drawing.Point(140, 151);
            this.lbPastDrinks.Name = "lbPastDrinks";
            this.lbPastDrinks.Size = new System.Drawing.Size(248, 305);
            this.lbPastDrinks.TabIndex = 14;
            // 
            // btnBack_Fruits
            // 
            this.btnBack_Fruits.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_Fruits.Location = new System.Drawing.Point(29, 535);
            this.btnBack_Fruits.Name = "btnBack_Fruits";
            this.btnBack_Fruits.Size = new System.Drawing.Size(149, 49);
            this.btnBack_Fruits.TabIndex = 15;
            this.btnBack_Fruits.Text = "Back";
            this.btnBack_Fruits.UseVisualStyleBackColor = true;
            // 
            // btnNext_OrderFeel
            // 
            this.btnNext_OrderFeel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext_OrderFeel.Location = new System.Drawing.Point(740, 535);
            this.btnNext_OrderFeel.Name = "btnNext_OrderFeel";
            this.btnNext_OrderFeel.Size = new System.Drawing.Size(149, 49);
            this.btnNext_OrderFeel.TabIndex = 19;
            this.btnNext_OrderFeel.Text = "Next";
            this.btnNext_OrderFeel.UseVisualStyleBackColor = true;
            // 
            // pb_PastOrder
            // 
            this.pb_PastOrder.Location = new System.Drawing.Point(559, 151);
            this.pb_PastOrder.Name = "pb_PastOrder";
            this.pb_PastOrder.Size = new System.Drawing.Size(234, 305);
            this.pb_PastOrder.TabIndex = 20;
            this.pb_PastOrder.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(564, 544);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(170, 35);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Price: ";
            // 
            // DrinkHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(919, 606);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pb_PastOrder);
            this.Controls.Add(this.btnNext_OrderFeel);
            this.Controls.Add(this.btnBack_Fruits);
            this.Controls.Add(this.lbPastDrinks);
            this.Controls.Add(this.lblTitle_OrderHistory);
            this.Name = "DrinkHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order History";
            ((System.ComponentModel.ISupportInitialize)(this.pb_PastOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle_OrderHistory;
        private System.Windows.Forms.ListBox lbPastDrinks;
        private System.Windows.Forms.Button btnBack_Fruits;
        private System.Windows.Forms.Button btnNext_OrderFeel;
        private System.Windows.Forms.PictureBox pb_PastOrder;
        private System.Windows.Forms.Label lblPrice;
    }
}