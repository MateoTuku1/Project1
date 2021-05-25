using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void User_Btn_Click(object sender, EventArgs e)
        {
            FrmUser obj = new FrmUser();
            obj.ShowDialog();
        }

        private void Products_Btn_Click(object sender, EventArgs e)
        {
            FrmProduct obj = new FrmProduct();
            obj.ShowDialog();
        }
    }
}
