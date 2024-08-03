namespace Wishake
{
    partial class Fruits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fruits));
            this.lbFruits = new System.Windows.Forms.ListBox();
            this.btnBack_Fruits = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblBenefits = new System.Windows.Forms.Label();
            this.lblBenefits_Title = new System.Windows.Forms.Label();
            this.lblDesc_Title = new System.Windows.Forms.Label();
            this.lblNutrit = new System.Windows.Forms.Label();
            this.pb_Fruit = new System.Windows.Forms.PictureBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblFruitName = new System.Windows.Forms.Label();
            this.lblTitle_Fruits = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Fruit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFruits
            // 
            this.lbFruits.BackColor = System.Drawing.Color.BurlyWood;
            this.lbFruits.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFruits.FormattingEnabled = true;
            this.lbFruits.ItemHeight = 23;
            this.lbFruits.Items.AddRange(new object[] {
            "Blueberries",
            "Bananas",
            "Strawberries",
            "Kiwi",
            "Mango",
            "Pineapple",
            "Avocado",
            "Cherries",
            "Grapefruit",
            "Apples"});
            this.lbFruits.Location = new System.Drawing.Point(18, 90);
            this.lbFruits.Margin = new System.Windows.Forms.Padding(2);
            this.lbFruits.Name = "lbFruits";
            this.lbFruits.Size = new System.Drawing.Size(110, 234);
            this.lbFruits.TabIndex = 0;
            this.lbFruits.SelectedIndexChanged += new System.EventHandler(this.lbFruits_SelectedIndexChanged);
            // 
            // btnBack_Fruits
            // 
            this.btnBack_Fruits.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBack_Fruits.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_Fruits.Location = new System.Drawing.Point(18, 348);
            this.btnBack_Fruits.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack_Fruits.Name = "btnBack_Fruits";
            this.btnBack_Fruits.Size = new System.Drawing.Size(98, 32);
            this.btnBack_Fruits.TabIndex = 6;
            this.btnBack_Fruits.Text = "Back";
            this.btnBack_Fruits.UseVisualStyleBackColor = false;
            this.btnBack_Fruits.Click += new System.EventHandler(this.btnBack_Fruits_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbInfo.Controls.Add(this.lblBenefits);
            this.gbInfo.Controls.Add(this.lblBenefits_Title);
            this.gbInfo.Controls.Add(this.lblDesc_Title);
            this.gbInfo.Controls.Add(this.lblNutrit);
            this.gbInfo.Controls.Add(this.pb_Fruit);
            this.gbInfo.Controls.Add(this.lblDesc);
            this.gbInfo.Controls.Add(this.lblFruitName);
            this.gbInfo.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(158, 78);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbInfo.Size = new System.Drawing.Size(434, 300);
            this.gbInfo.TabIndex = 7;
            this.gbInfo.TabStop = false;
            // 
            // lblBenefits
            // 
            this.lblBenefits.Location = new System.Drawing.Point(4, 178);
            this.lblBenefits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBenefits.Name = "lblBenefits";
            this.lblBenefits.Size = new System.Drawing.Size(274, 114);
            this.lblBenefits.TabIndex = 6;
            // 
            // lblBenefits_Title
            // 
            this.lblBenefits_Title.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblBenefits_Title.Location = new System.Drawing.Point(4, 156);
            this.lblBenefits_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBenefits_Title.Name = "lblBenefits_Title";
            this.lblBenefits_Title.Size = new System.Drawing.Size(112, 22);
            this.lblBenefits_Title.TabIndex = 5;
            this.lblBenefits_Title.Text = "Benefits:";
            // 
            // lblDesc_Title
            // 
            this.lblDesc_Title.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDesc_Title.Location = new System.Drawing.Point(4, 44);
            this.lblDesc_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc_Title.Name = "lblDesc_Title";
            this.lblDesc_Title.Size = new System.Drawing.Size(112, 22);
            this.lblDesc_Title.TabIndex = 4;
            this.lblDesc_Title.Text = "Description:";
            // 
            // lblNutrit
            // 
            this.lblNutrit.BackColor = System.Drawing.Color.Transparent;
            this.lblNutrit.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNutrit.Location = new System.Drawing.Point(282, 22);
            this.lblNutrit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNutrit.Name = "lblNutrit";
            this.lblNutrit.Size = new System.Drawing.Size(140, 132);
            this.lblNutrit.TabIndex = 3;
            this.lblNutrit.Text = "Nutritional Info:";
            // 
            // pb_Fruit
            // 
            this.pb_Fruit.Location = new System.Drawing.Point(282, 156);
            this.pb_Fruit.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Fruit.Name = "pb_Fruit";
            this.pb_Fruit.Size = new System.Drawing.Size(140, 136);
            this.pb_Fruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Fruit.TabIndex = 2;
            this.pb_Fruit.TabStop = false;
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(4, 66);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(274, 90);
            this.lblDesc.TabIndex = 1;
            // 
            // lblFruitName
            // 
            this.lblFruitName.Location = new System.Drawing.Point(4, 22);
            this.lblFruitName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFruitName.Name = "lblFruitName";
            this.lblFruitName.Size = new System.Drawing.Size(274, 22);
            this.lblFruitName.TabIndex = 0;
            this.lblFruitName.Text = "Fruit Name:";
            // 
            // lblTitle_Fruits
            // 
            this.lblTitle_Fruits.AutoSize = true;
            this.lblTitle_Fruits.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle_Fruits.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_Fruits.Location = new System.Drawing.Point(19, 19);
            this.lblTitle_Fruits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle_Fruits.Name = "lblTitle_Fruits";
            this.lblTitle_Fruits.Size = new System.Drawing.Size(417, 57);
            this.lblTitle_Fruits.TabIndex = 11;
            this.lblTitle_Fruits.Text = "Ingredients Information:";
            // 
            // Fruits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Wishake.Properties.Resources.front_view_fresh_tangerines_with_juice_light_background_140725_132587;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 394);
            this.Controls.Add(this.lblTitle_Fruits);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnBack_Fruits);
            this.Controls.Add(this.lbFruits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Fruits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredients Information";
            this.gbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Fruit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFruits;
        private System.Windows.Forms.Button btnBack_Fruits;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblTitle_Fruits;
        private System.Windows.Forms.Label lblFruitName;
        private System.Windows.Forms.PictureBox pb_Fruit;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblNutrit;
        private System.Windows.Forms.Label lblDesc_Title;
        private System.Windows.Forms.Label lblBenefits;
        private System.Windows.Forms.Label lblBenefits_Title;
    }
}