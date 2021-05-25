
namespace Project1
{
    partial class FrmProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Quantity_TB = new System.Windows.Forms.TextBox();
            this.Price_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Discard_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Desc_TB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Category_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(148, 100);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(125, 27);
            this.Name_TB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // Quantity_TB
            // 
            this.Quantity_TB.Location = new System.Drawing.Point(148, 192);
            this.Quantity_TB.Name = "Quantity_TB";
            this.Quantity_TB.Size = new System.Drawing.Size(125, 27);
            this.Quantity_TB.TabIndex = 6;
            // 
            // Price_TB
            // 
            this.Price_TB.Location = new System.Drawing.Point(551, 100);
            this.Price_TB.Name = "Price_TB";
            this.Price_TB.Size = new System.Drawing.Size(132, 27);
            this.Price_TB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // Discard_Btn
            // 
            this.Discard_Btn.Location = new System.Drawing.Point(32, 382);
            this.Discard_Btn.Name = "Discard_Btn";
            this.Discard_Btn.Size = new System.Drawing.Size(124, 39);
            this.Discard_Btn.TabIndex = 12;
            this.Discard_Btn.Text = "Discard";
            this.Discard_Btn.UseVisualStyleBackColor = true;
            this.Discard_Btn.Click += new System.EventHandler(this.Discard_Btn_Click);
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(626, 382);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(123, 39);
            this.Save_Btn.TabIndex = 13;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Products";
            // 
            // Desc_TB
            // 
            this.Desc_TB.Location = new System.Drawing.Point(551, 192);
            this.Desc_TB.Name = "Desc_TB";
            this.Desc_TB.Size = new System.Drawing.Size(198, 124);
            this.Desc_TB.TabIndex = 15;
            this.Desc_TB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Category";
            // 
            // Category_TB
            // 
            this.Category_TB.Location = new System.Drawing.Point(148, 281);
            this.Category_TB.Name = "Category_TB";
            this.Category_TB.Size = new System.Drawing.Size(125, 27);
            this.Category_TB.TabIndex = 17;
            this.Category_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Category_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Desc_TB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.Discard_Btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Price_TB);
            this.Controls.Add(this.Quantity_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.label2);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Quantity_TB;
        private System.Windows.Forms.TextBox Price_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Discard_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Desc_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Category_TB;
    }
}