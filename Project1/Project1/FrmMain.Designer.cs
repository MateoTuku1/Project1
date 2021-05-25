
namespace Project1
{
    partial class FrmMain
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
            this.Products_Btn = new System.Windows.Forms.Button();
            this.Clients_Btn = new System.Windows.Forms.Button();
            this.Sales_Btn = new System.Windows.Forms.Button();
            this.Raports_Btn = new System.Windows.Forms.Button();
            this.User_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Products_Btn
            // 
            this.Products_Btn.Location = new System.Drawing.Point(12, 46);
            this.Products_Btn.Name = "Products_Btn";
            this.Products_Btn.Size = new System.Drawing.Size(363, 182);
            this.Products_Btn.TabIndex = 0;
            this.Products_Btn.Text = "Products";
            this.Products_Btn.UseVisualStyleBackColor = true;
            this.Products_Btn.Click += new System.EventHandler(this.Products_Btn_Click);
            // 
            // Clients_Btn
            // 
            this.Clients_Btn.Location = new System.Drawing.Point(408, 46);
            this.Clients_Btn.Name = "Clients_Btn";
            this.Clients_Btn.Size = new System.Drawing.Size(363, 182);
            this.Clients_Btn.TabIndex = 1;
            this.Clients_Btn.Text = "Clients";
            this.Clients_Btn.UseVisualStyleBackColor = true;
            // 
            // Sales_Btn
            // 
            this.Sales_Btn.Location = new System.Drawing.Point(12, 255);
            this.Sales_Btn.Name = "Sales_Btn";
            this.Sales_Btn.Size = new System.Drawing.Size(363, 183);
            this.Sales_Btn.TabIndex = 2;
            this.Sales_Btn.Text = "Sales";
            this.Sales_Btn.UseVisualStyleBackColor = true;
            // 
            // Raports_Btn
            // 
            this.Raports_Btn.Location = new System.Drawing.Point(408, 255);
            this.Raports_Btn.Name = "Raports_Btn";
            this.Raports_Btn.Size = new System.Drawing.Size(363, 183);
            this.Raports_Btn.TabIndex = 3;
            this.Raports_Btn.Text = "Raports";
            this.Raports_Btn.UseVisualStyleBackColor = true;
            // 
            // User_Btn
            // 
            this.User_Btn.Location = new System.Drawing.Point(12, 11);
            this.User_Btn.Name = "User_Btn";
            this.User_Btn.Size = new System.Drawing.Size(123, 29);
            this.User_Btn.TabIndex = 4;
            this.User_Btn.Text = "User";
            this.User_Btn.UseVisualStyleBackColor = true;
            this.User_Btn.Click += new System.EventHandler(this.User_Btn_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.User_Btn);
            this.Controls.Add(this.Raports_Btn);
            this.Controls.Add(this.Sales_Btn);
            this.Controls.Add(this.Clients_Btn);
            this.Controls.Add(this.Products_Btn);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Products_Btn;
        private System.Windows.Forms.Button Clients_Btn;
        private System.Windows.Forms.Button Sales_Btn;
        private System.Windows.Forms.Button Raports_Btn;
        private System.Windows.Forms.Button User_Btn;
    }
}