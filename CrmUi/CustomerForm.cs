﻿using System;
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
            Customer = customer;
            textBox1.Text = customer.Name;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var c = Customer ?? new Customer();
            c.Name = textBox1.Text;
            Close();
        }
    }
}
