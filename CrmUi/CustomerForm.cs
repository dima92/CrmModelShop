using System;
using System.Windows.Forms;
using CrmBl.Model;

namespace CrmUi
{
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }

        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(Customer customer) : this()
        {
            Customer = customer ?? new Customer();
            textBox1.Text = customer.Name;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Customer = Customer ?? new Customer();
            Customer.Name = textBox1.Text;
            Close();
        }
    }
}
