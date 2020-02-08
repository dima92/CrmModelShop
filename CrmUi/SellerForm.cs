using System;
using System.Windows.Forms;
using CrmBl.Model;

namespace CrmUi
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }

        public SellerForm()
        {
            InitializeComponent();
        }

        private void SellerForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seller = new Seller()
            {
                Name = textBox2.Text
            };

            Close();
        }
    }
}
