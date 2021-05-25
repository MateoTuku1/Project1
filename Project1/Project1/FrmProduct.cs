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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void Discard_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = @"Data Source=DESKTOP-26SC66O\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionstring);
                SqlCommand cmd = new SqlCommand("Insert into Product Values(@ID,'@name',@quantity,@price,'@desc');", con);
                SqlCommand check = new SqlCommand("Select * from Product where Product_Name=@name;",con);
                SqlCommand update = new SqlCommand("Update Product Set Product_Id=@ID,Product_Name=@name,Quantity=@quantity,Price=@price,Description=@desc where Product_Name=@name;",con);
                check.Parameters.AddWithValue("@name", Name_TB.Text);
                cmd.Parameters.AddWithValue("@name", Name_TB.Text);
                cmd.Parameters.AddWithValue("@quantity", Quantity_TB.Text);
                cmd.Parameters.AddWithValue("@price", Price_TB.Text);
                cmd.Parameters.AddWithValue("@desc", Desc_TB.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    cmd.ExecuteNonQuery();
                }
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
