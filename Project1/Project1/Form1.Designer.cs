
namespace Project1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username_TB = new System.Windows.Forms.TextBox();
            this.password_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_TB
            // 
            this.username_TB.Location = new System.Drawing.Point(360, 133);
            this.username_TB.Name = "username_TB";
            this.username_TB.Size = new System.Drawing.Size(162, 27);
            this.username_TB.TabIndex = 0;
            this.username_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_TB_KeyDown);
            // 
            // password_TB
            // 
            this.password_TB.Location = new System.Drawing.Point(360, 222);
            this.password_TB.Name = "password_TB";
            this.password_TB.Size = new System.Drawing.Size(162, 27);
            this.password_TB.TabIndex = 1;
            this.password_TB.TextChanged += new System.EventHandler(this.password_TB_TextChanged);
            this.password_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_TB_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(375, 313);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(123, 40);
            this.Login.TabIndex = 4;
            this.Login.Text = "Log In";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, -69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_TB);
            this.Controls.Add(this.username_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox username_TB;
    }
}

