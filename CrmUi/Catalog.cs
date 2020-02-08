using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class Catalog<T> : Form where T : class
    {
        public Catalog(DbSet<T> set)
        {
            InitializeComponent();
            dataGridView.DataSource = set.Local.ToBindingList();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }
    }
}
