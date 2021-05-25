using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project1
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }
        Form1 obj = new Form1();
        private void Change_TB_Click(object sender, EventArgs e)
        {
            
            string TB_text = obj.username_TB.Text; 
            try
            {
                string connectionstring = @"Data Source=DESKTOP-26SC66O\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionstring);
                SqlCommand cmd = new SqlCommand("Select * from Users where Username=@username and Password=@password", con);
                SqlCommand cmd2 = new SqlCommand("Update Users Set Password=@Password where Username=@Username;",con);
                cmd.Parameters.AddWithValue("@username", TB_text);
                cmd.Parameters.AddWithValue("@password", Old_Pass_TB.Text);
                cmd2.Parameters.AddWithValue("@username", TB_text);
                cmd2.Parameters.AddWithValue("@password", New_Pass_TB.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count_tb = ds.Tables[0].Rows.Count;
                if (count_tb >=1)
                {
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Password Changed!");
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your old password was wrong!");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void New_Pass_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Change_TB_Click(this, new EventArgs());
            }
        }

        private void Old_Pass_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                New_Pass_TB.Focus();
            }
        }
    }
}
