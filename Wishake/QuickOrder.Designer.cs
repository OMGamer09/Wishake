namespace Wishake
{
    partial class QuickOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickOrder));
            this.lbDrinks = new System.Windows.Forms.ListBox();
            this.lblTitle_QuickOrder = new System.Windows.Forms.Label();
            this.btnBack_Fruits = new System.Windows.Forms.Button();
            this.pb_QuickOrder = new System.Windows.Forms.PictureBox();
            this.gbDrinkSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.lblGoodFor = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblGoodFor_desc = new System.Windows.Forms.Label();
            this.gbBase = new System.Windows.Forms.GroupBox();
            this.rbAlmond = new System.Windows.Forms.RadioButton();
            this.rbMilk = new System.Windows.Forms.RadioButton();
            this.rbWater = new System.Windows.Forms.RadioButton();
            this.lblFruits_Desc = new System.Windows.Forms.Label();
            this.lblFruitsInDrink = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuickOrder)).BeginInit();
            this.gbDrinkSize.SuspendLayout();
            this.gbBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDrinks
            // 
            this.lbDrinks.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbDrinks.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrinks.FormattingEnabled = true;
            this.lbDrinks.ItemHeight = 23;
            this.lbDrinks.Items.AddRange(new object[] {
            "Sunrise Surge",
            "Vitality Vibe",
            "Serenity Smoothie",
            "Dreamy Delight",
            "Lean Green",
            "Joyful Juice",
            "Focus Fusion"});
            this.lbDrinks.Location = new System.Drawing.Point(19, 87);
            this.lbDrinks.Margin = new System.Windows.Forms.Padding(2);
            this.lbDrinks.Name = "lbDrinks";
            this.lbDrinks.Size = new System.Drawing.Size(157, 234);
            this.lbDrinks.TabIndex = 0;
            // 
            // lblTitle_QuickOrder
            // 
            this.lblTitle_QuickOrder.AutoSize = true;
            this.lblTitle_QuickOrder.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblTitle_QuickOrder.Font = new System.Drawing.Font("Segoe Print", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_QuickOrder.Location = new System.Drawing.Point(79, 19);
            this.lblTitle_QuickOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle_QuickOrder.Name = "lblTitle_QuickOrder";
            this.lblTitle_QuickOrder.Size = new System.Drawing.Size(451, 47);
            this.lblTitle_QuickOrder.TabIndex = 12;
            this.lblTitle_QuickOrder.Text = "Choose your smoothie of choice:";
            // 
            // btnBack_Fruits
            // 
            this.btnBack_Fruits.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_Fruits.Location = new System.Drawing.Point(19, 348);
            this.btnBack_Fruits.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack_Fruits.Name = "btnBack_Fruits";
            this.btnBack_Fruits.Size = new System.Drawing.Size(99, 32);
            this.btnBack_Fruits.TabIndex = 13;
            this.btnBack_Fruits.Text = "Back";
            this.btnBack_Fruits.UseVisualStyleBackColor = true;
            this.btnBack_Fruits.Click += new System.EventHandler(this.btnBack_Fruits_Click);
            // 
            // pb_QuickOrder
            // 
            this.pb_QuickOrder.BackColor = System.Drawing.Color.Transparent;
            this.pb_QuickOrder.Location = new System.Drawing.Point(197, 133);
            this.pb_QuickOrder.Margin = new System.Windows.Forms.Padding(2);
            this.pb_QuickOrder.Name = "pb_QuickOrder";
            this.pb_QuickOrder.Size = new System.Drawing.Size(145, 161);
            this.pb_QuickOrder.TabIndex = 14;
            this.pb_QuickOrder.TabStop = false;
            // 
            // gbDrinkSize
            // 
            this.gbDrinkSize.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbDrinkSize.Controls.Add(this.rbLarge);
            this.gbDrinkSize.Controls.Add(this.rbMedium);
            this.gbDrinkSize.Controls.Add(this.rbSmall);
            this.gbDrinkSize.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDrinkSize.Location = new System.Drawing.Point(456, 87);
            this.gbDrinkSize.Margin = new System.Windows.Forms.Padding(2);
            this.gbDrinkSize.Name = "gbDrinkSize";
            this.gbDrinkSize.Padding = new System.Windows.Forms.Padding(2);
            this.gbDrinkSize.Size = new System.Drawing.Size(149, 107);
            this.gbDrinkSize.TabIndex = 15;
            this.gbDrinkSize.TabStop = false;
            this.gbDrinkSize.Text = "Drink Size:";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(4, 79);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(2);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(115, 23);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Text = "Large (5 Fruits)";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(4, 50);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(2);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(128, 23);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.Text = "Medium (4 Fruits)";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Location = new System.Drawing.Point(4, 21);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(2);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(114, 23);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small (3 Fruits)";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // lblGoodFor
            // 
            this.lblGoodFor.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblGoodFor.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodFor.Location = new System.Drawing.Point(346, 87);
            this.lblGoodFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoodFor.Name = "lblGoodFor";
            this.lblGoodFor.Size = new System.Drawing.Size(60, 21);
            this.lblGoodFor.TabIndex = 16;
            this.lblGoodFor.Text = "Good for:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(371, 348);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 32);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblGoodFor_desc
            // 
            this.lblGoodFor_desc.BackColor = System.Drawing.Color.Transparent;
            this.lblGoodFor_desc.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodFor_desc.Location = new System.Drawing.Point(346, 109);
            this.lblGoodFor_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoodFor_desc.Name = "lblGoodFor_desc";
            this.lblGoodFor_desc.Size = new System.Drawing.Size(97, 99);
            this.lblGoodFor_desc.TabIndex = 18;
            // 
            // gbBase
            // 
            this.gbBase.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbBase.Controls.Add(this.rbAlmond);
            this.gbBase.Controls.Add(this.rbMilk);
            this.gbBase.Controls.Add(this.rbWater);
            this.gbBase.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBase.Location = new System.Drawing.Point(456, 221);
            this.gbBase.Margin = new System.Windows.Forms.Padding(2);
            this.gbBase.Name = "gbBase";
            this.gbBase.Padding = new System.Windows.Forms.Padding(2);
            this.gbBase.Size = new System.Drawing.Size(149, 107);
            this.gbBase.TabIndex = 19;
            this.gbBase.TabStop = false;
            this.gbBase.Text = "Drink Base:";
            // 
            // rbAlmond
            // 
            this.rbAlmond.AutoSize = true;
            this.rbAlmond.Location = new System.Drawing.Point(7, 77);
            this.rbAlmond.Margin = new System.Windows.Forms.Padding(2);
            this.rbAlmond.Name = "rbAlmond";
            this.rbAlmond.Size = new System.Drawing.Size(132, 23);
            this.rbAlmond.TabIndex = 2;
            this.rbAlmond.Text = "Almond Milk Based";
            this.rbAlmond.UseVisualStyleBackColor = true;
            // 
            // rbMilk
            // 
            this.rbMilk.AutoSize = true;
            this.rbMilk.Location = new System.Drawing.Point(6, 50);
            this.rbMilk.Margin = new System.Windows.Forms.Padding(2);
            this.rbMilk.Name = "rbMilk";
            this.rbMilk.Size = new System.Drawing.Size(85, 23);
            this.rbMilk.TabIndex = 1;
            this.rbMilk.Text = "Milk Based";
            this.rbMilk.UseVisualStyleBackColor = true;
            // 
            // rbWater
            // 
            this.rbWater.AutoSize = true;
            this.rbWater.Checked = true;
            this.rbWater.Location = new System.Drawing.Point(6, 23);
            this.rbWater.Margin = new System.Windows.Forms.Padding(2);
            this.rbWater.Name = "rbWater";
            this.rbWater.Size = new System.Drawing.Size(97, 23);
            this.rbWater.TabIndex = 0;
            this.rbWater.TabStop = true;
            this.rbWater.Text = "Water Based";
            this.rbWater.UseVisualStyleBackColor = true;
            // 
            // lblFruits_Desc
            // 
            this.lblFruits_Desc.BackColor = System.Drawing.Color.Transparent;
            this.lblFruits_Desc.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFruits_Desc.Location = new System.Drawing.Point(349, 229);
            this.lblFruits_Desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFruits_Desc.Name = "lblFruits_Desc";
            this.lblFruits_Desc.Size = new System.Drawing.Size(97, 99);
            this.lblFruits_Desc.TabIndex = 23;
            // 
            // lblFruitsInDrink
            // 
            this.lblFruitsInDrink.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblFruitsInDrink.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFruitsInDrink.Location = new System.Drawing.Point(349, 209);
            this.lblFruitsInDrink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFruitsInDrink.Name = "lblFruitsInDrink";
            this.lblFruitsInDrink.Size = new System.Drawing.Size(47, 21);
            this.lblFruitsInDrink.TabIndex = 22;
            this.lblFruitsInDrink.Text = "Fruits:";
            // 
            // btnCart
            // 
            this.btnCart.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Location = new System.Drawing.Point(484, 348);
            this.btnCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(111, 32);
            this.btnCart.TabIndex = 27;
            this.btnCart.Text = "to Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // QuickOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = global::Wishake.Properties.Resources._1721872085497;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 394);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.lblFruits_Desc);
            this.Controls.Add(this.lblFruitsInDrink);
            this.Controls.Add(this.gbBase);
            this.Controls.Add(this.lblGoodFor_desc);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblGoodFor);
            this.Controls.Add(this.gbDrinkSize);
            this.Controls.Add(this.pb_QuickOrder);
            this.Controls.Add(this.btnBack_Fruits);
            this.Controls.Add(this.lblTitle_QuickOrder);
            this.Controls.Add(this.lbDrinks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuickOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickOrder";
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuickOrder)).EndInit();
            this.gbDrinkSize.ResumeLayout(false);
            this.gbDrinkSize.PerformLayout();
            this.gbBase.ResumeLayout(false);
            this.gbBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDrinks;
        private System.Windows.Forms.Label lblTitle_QuickOrder;
        private System.Windows.Forms.Button btnBack_Fruits;
        private System.Windows.Forms.PictureBox pb_QuickOrder;
        private System.Windows.Forms.GroupBox gbDrinkSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label lblGoodFor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblGoodFor_desc;
        private System.Windows.Forms.GroupBox gbBase;
        private System.Windows.Forms.RadioButton rbAlmond;
        private System.Windows.Forms.RadioButton rbMilk;
        private System.Windows.Forms.RadioButton rbWater;
        private System.Windows.Forms.Label lblFruits_Desc;
        private System.Windows.Forms.Label lblFruitsInDrink;
        private System.Windows.Forms.Button btnCart;
    }
}