namespace Wishake
{
    partial class FeelOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeelOrder));
            this.btnBack_OrderFeel = new System.Windows.Forms.Button();
            this.cblPhysical = new System.Windows.Forms.CheckedListBox();
            this.cblMental = new System.Windows.Forms.CheckedListBox();
            this.lblPhysical = new System.Windows.Forms.Label();
            this.lblMental = new System.Windows.Forms.Label();
            this.lblTitle_OrderFeel = new System.Windows.Forms.Label();
            this.gbDrinkSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.btnCart_OrderFeel = new System.Windows.Forms.Button();
            this.btnFruitsInfo = new System.Windows.Forms.Button();
            this.gbBase = new System.Windows.Forms.GroupBox();
            this.rbAlmond = new System.Windows.Forms.RadioButton();
            this.rbMilk = new System.Windows.Forms.RadioButton();
            this.rbWater = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbFruits = new System.Windows.Forms.ListBox();
            this.lblFruits = new System.Windows.Forms.Label();
            this.gbDrinkSize.SuspendLayout();
            this.gbBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack_OrderFeel
            // 
            this.btnBack_OrderFeel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_OrderFeel.Location = new System.Drawing.Point(19, 348);
            this.btnBack_OrderFeel.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack_OrderFeel.Name = "btnBack_OrderFeel";
            this.btnBack_OrderFeel.Size = new System.Drawing.Size(99, 33);
            this.btnBack_OrderFeel.TabIndex = 5;
            this.btnBack_OrderFeel.Text = "Back";
            this.btnBack_OrderFeel.UseVisualStyleBackColor = true;
            this.btnBack_OrderFeel.Click += new System.EventHandler(this.btnBack_OrderFeel_Click);
            // 
            // cblPhysical
            // 
            this.cblPhysical.BackColor = System.Drawing.Color.White;
            this.cblPhysical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblPhysical.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblPhysical.FormattingEnabled = true;
            this.cblPhysical.Items.AddRange(new object[] {
            "Energy Boost",
            "Muscle Recovery",
            "Immune Support",
            "Digestive Health",
            "Weight Management"});
            this.cblPhysical.Location = new System.Drawing.Point(19, 118);
            this.cblPhysical.Margin = new System.Windows.Forms.Padding(2);
            this.cblPhysical.Name = "cblPhysical";
            this.cblPhysical.Size = new System.Drawing.Size(177, 120);
            this.cblPhysical.TabIndex = 6;
            // 
            // cblMental
            // 
            this.cblMental.BackColor = System.Drawing.Color.White;
            this.cblMental.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblMental.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblMental.FormattingEnabled = true;
            this.cblMental.Items.AddRange(new object[] {
            "Stress Relief",
            "Focus Enhancement",
            "Mood Elevation",
            "Sleep Immprovement",
            "Memory Boost"});
            this.cblMental.Location = new System.Drawing.Point(228, 118);
            this.cblMental.Margin = new System.Windows.Forms.Padding(2);
            this.cblMental.Name = "cblMental";
            this.cblMental.Size = new System.Drawing.Size(177, 120);
            this.cblMental.TabIndex = 7;
            // 
            // lblPhysical
            // 
            this.lblPhysical.AutoSize = true;
            this.lblPhysical.BackColor = System.Drawing.Color.White;
            this.lblPhysical.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhysical.Location = new System.Drawing.Point(13, 80);
            this.lblPhysical.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhysical.Name = "lblPhysical";
            this.lblPhysical.Size = new System.Drawing.Size(173, 28);
            this.lblPhysical.TabIndex = 8;
            this.lblPhysical.Text = "Physical Conditions:";
            // 
            // lblMental
            // 
            this.lblMental.AutoSize = true;
            this.lblMental.BackColor = System.Drawing.Color.White;
            this.lblMental.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMental.Location = new System.Drawing.Point(221, 80);
            this.lblMental.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMental.Name = "lblMental";
            this.lblMental.Size = new System.Drawing.Size(164, 28);
            this.lblMental.TabIndex = 9;
            this.lblMental.Text = "Mental Conditions:";
            // 
            // lblTitle_OrderFeel
            // 
            this.lblTitle_OrderFeel.AutoSize = true;
            this.lblTitle_OrderFeel.BackColor = System.Drawing.Color.White;
            this.lblTitle_OrderFeel.Font = new System.Drawing.Font("Segoe Print", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_OrderFeel.Location = new System.Drawing.Point(79, 21);
            this.lblTitle_OrderFeel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle_OrderFeel.Name = "lblTitle_OrderFeel";
            this.lblTitle_OrderFeel.Size = new System.Drawing.Size(457, 47);
            this.lblTitle_OrderFeel.TabIndex = 10;
            this.lblTitle_OrderFeel.Text = "Tell us how you ~Wish~ to feel?";
            // 
            // gbDrinkSize
            // 
            this.gbDrinkSize.BackColor = System.Drawing.Color.White;
            this.gbDrinkSize.Controls.Add(this.rbLarge);
            this.gbDrinkSize.Controls.Add(this.rbMedium);
            this.gbDrinkSize.Controls.Add(this.rbSmall);
            this.gbDrinkSize.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDrinkSize.Location = new System.Drawing.Point(444, 117);
            this.gbDrinkSize.Margin = new System.Windows.Forms.Padding(2);
            this.gbDrinkSize.Name = "gbDrinkSize";
            this.gbDrinkSize.Padding = new System.Windows.Forms.Padding(2);
            this.gbDrinkSize.Size = new System.Drawing.Size(149, 110);
            this.gbDrinkSize.TabIndex = 11;
            this.gbDrinkSize.TabStop = false;
            this.gbDrinkSize.Text = "Drink Size:";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(6, 83);
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
            this.rbMedium.Location = new System.Drawing.Point(6, 53);
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
            this.rbSmall.Location = new System.Drawing.Point(6, 23);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(2);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(114, 23);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small (3 Fruits)";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // btnCart_OrderFeel
            // 
            this.btnCart_OrderFeel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart_OrderFeel.Location = new System.Drawing.Point(484, 348);
            this.btnCart_OrderFeel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCart_OrderFeel.Name = "btnCart_OrderFeel";
            this.btnCart_OrderFeel.Size = new System.Drawing.Size(111, 32);
            this.btnCart_OrderFeel.TabIndex = 12;
            this.btnCart_OrderFeel.Text = "to Cart";
            this.btnCart_OrderFeel.UseVisualStyleBackColor = true;
            this.btnCart_OrderFeel.Click += new System.EventHandler(this.btnCart_OrderFeel_Click);
            // 
            // btnFruitsInfo
            // 
            this.btnFruitsInfo.BackColor = System.Drawing.Color.White;
            this.btnFruitsInfo.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFruitsInfo.Location = new System.Drawing.Point(443, 80);
            this.btnFruitsInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnFruitsInfo.Name = "btnFruitsInfo";
            this.btnFruitsInfo.Size = new System.Drawing.Size(149, 33);
            this.btnFruitsInfo.TabIndex = 13;
            this.btnFruitsInfo.Text = "Fruits Information";
            this.btnFruitsInfo.UseVisualStyleBackColor = false;
            this.btnFruitsInfo.Click += new System.EventHandler(this.btnFruitsInfo_Click);
            // 
            // gbBase
            // 
            this.gbBase.BackColor = System.Drawing.Color.White;
            this.gbBase.Controls.Add(this.rbAlmond);
            this.gbBase.Controls.Add(this.rbMilk);
            this.gbBase.Controls.Add(this.rbWater);
            this.gbBase.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBase.Location = new System.Drawing.Point(444, 231);
            this.gbBase.Margin = new System.Windows.Forms.Padding(2);
            this.gbBase.Name = "gbBase";
            this.gbBase.Padding = new System.Windows.Forms.Padding(2);
            this.gbBase.Size = new System.Drawing.Size(149, 110);
            this.gbBase.TabIndex = 12;
            this.gbBase.TabStop = false;
            this.gbBase.Text = "Drink Base:";
            // 
            // rbAlmond
            // 
            this.rbAlmond.AutoSize = true;
            this.rbAlmond.Location = new System.Drawing.Point(4, 76);
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
            this.rbMilk.Location = new System.Drawing.Point(4, 49);
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
            this.rbWater.Location = new System.Drawing.Point(4, 22);
            this.rbWater.Margin = new System.Windows.Forms.Padding(2);
            this.rbWater.Name = "rbWater";
            this.rbWater.Size = new System.Drawing.Size(97, 23);
            this.rbWater.TabIndex = 0;
            this.rbWater.TabStop = true;
            this.rbWater.Text = "Water Based";
            this.rbWater.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(371, 348);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 33);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbFruits
            // 
            this.lbFruits.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFruits.FormattingEnabled = true;
            this.lbFruits.ItemHeight = 19;
            this.lbFruits.Location = new System.Drawing.Point(226, 262);
            this.lbFruits.Name = "lbFruits";
            this.lbFruits.Size = new System.Drawing.Size(126, 118);
            this.lbFruits.TabIndex = 16;
            this.lbFruits.SelectedIndexChanged += new System.EventHandler(this.lbFruits_SelectedIndexChanged);
            // 
            // lblFruits
            // 
            this.lblFruits.BackColor = System.Drawing.Color.White;
            this.lblFruits.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFruits.Location = new System.Drawing.Point(60, 262);
            this.lblFruits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFruits.Name = "lblFruits";
            this.lblFruits.Size = new System.Drawing.Size(152, 68);
            this.lblFruits.TabIndex = 17;
            this.lblFruits.Text = "Fruits specially picked for you:";
            this.lblFruits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FeelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Salmon;
            this.BackgroundImage = global::Wishake.Properties.Resources.top_view_organic_pineapple_with_grapefruit_kiwi_23_2148473599;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 394);
            this.Controls.Add(this.lblFruits);
            this.Controls.Add(this.lbFruits);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbBase);
            this.Controls.Add(this.btnFruitsInfo);
            this.Controls.Add(this.btnCart_OrderFeel);
            this.Controls.Add(this.gbDrinkSize);
            this.Controls.Add(this.lblTitle_OrderFeel);
            this.Controls.Add(this.lblMental);
            this.Controls.Add(this.lblPhysical);
            this.Controls.Add(this.cblMental);
            this.Controls.Add(this.cblPhysical);
            this.Controls.Add(this.btnBack_OrderFeel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FeelOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WiShake Order";
            this.gbDrinkSize.ResumeLayout(false);
            this.gbDrinkSize.PerformLayout();
            this.gbBase.ResumeLayout(false);
            this.gbBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack_OrderFeel;
        private System.Windows.Forms.CheckedListBox cblPhysical;
        private System.Windows.Forms.CheckedListBox cblMental;
        private System.Windows.Forms.Label lblPhysical;
        private System.Windows.Forms.Label lblMental;
        private System.Windows.Forms.Label lblTitle_OrderFeel;
        private System.Windows.Forms.GroupBox gbDrinkSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Button btnCart_OrderFeel;
        private System.Windows.Forms.Button btnFruitsInfo;
        private System.Windows.Forms.GroupBox gbBase;
        private System.Windows.Forms.RadioButton rbAlmond;
        private System.Windows.Forms.RadioButton rbMilk;
        private System.Windows.Forms.RadioButton rbWater;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbFruits;
        private System.Windows.Forms.Label lblFruits;
    }
}