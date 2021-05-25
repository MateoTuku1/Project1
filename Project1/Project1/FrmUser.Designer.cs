
namespace Project1
{
    partial class FrmUser
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
            this.Old_Pass_TB = new System.Windows.Forms.TextBox();
            this.New_Pass_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Change_TB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Old_Pass_TB
            // 
            this.Old_Pass_TB.Location = new System.Drawing.Point(260, 27);
            this.Old_Pass_TB.Name = "Old_Pass_TB";
            this.Old_Pass_TB.Size = new System.Drawing.Size(125, 27);
            this.Old_Pass_TB.TabIndex = 0;
            this.Old_Pass_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Old_Pass_TB_KeyDown);
            // 
            // New_Pass_TB
            // 
            this.New_Pass_TB.Location = new System.Drawing.Point(260, 98);
            this.New_Pass_TB.Name = "New_Pass_TB";
            this.New_Pass_TB.Size = new System.Drawing.Size(125, 27);
            this.New_Pass_TB.TabIndex = 1;
            this.New_Pass_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.New_Pass_TB_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password";
            // 
            // Change_TB
            // 
            this.Change_TB.Location = new System.Drawing.Point(489, 49);
            this.Change_TB.Name = "Change_TB";
            this.Change_TB.Size = new System.Drawing.Size(120, 57);
            this.Change_TB.TabIndex = 4;
            this.Change_TB.Text = "Change Password";
            this.Change_TB.UseVisualStyleBackColor = true;
            this.Change_TB.Click += new System.EventHandler(this.Change_TB_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 194);
            this.Controls.Add(this.Change_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.New_Pass_TB);
            this.Controls.Add(this.Old_Pass_TB);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Old_Pass_TB;
        private System.Windows.Forms.TextBox New_Pass_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Change_TB;
    }
}