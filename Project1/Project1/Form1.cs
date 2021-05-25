using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        public string userText;
        private void Login_Click(object sender, EventArgs e)
        {
            
            try 
            { 
                string connectionstring = @"Data Source=DESKTOP-26SC66O\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionstring);
                SqlCommand cmd = new SqlCommand("Select * from Users where Username=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", username_TB.Text);
                cmd.Parameters.AddWithValue("@password", password_TB.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count_tb = ds.Tables[0].Rows.Count;
                    if (count_tb == 1)
                {
                    userText = username_TB.Text;
                    this.Hide();
                    FrmMain obj = new FrmMain();
                    obj.Show();
                }
                else
                {
                    count++;
                    MessageBox.Show("Login Failed!");
                    
                }
                if(count==3)
                {
                    MessageBox.Show("You tried too many times!");
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void username_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_TB.Focus();
            }
        }

        private void password_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click(this, new EventArgs());
            }
        }
    }
}
