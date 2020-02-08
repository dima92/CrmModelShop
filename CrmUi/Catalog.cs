using CrmBl.Model;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class Catalog<T> : Form where T : class
    {
        public CrmContext Db { get; set; }
        public DbSet<T> Set { get; set; }

        public Catalog(DbSet<T> set, CrmContext db)
        {
            InitializeComponent();

            Db = db;
            Set = set;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (typeof(T) == typeof(Product))
            {
                if (!(Set.Find(id) is Product product)) return;
                var form = new ProductForm(product);
                if (form.ShowDialog() != DialogResult.OK) return;
                Db.SaveChanges();
                dataGridView.Update();
            }
            else if (typeof(T) == typeof(Seller))
            {
                if (!(Set.Find(id) is Seller seller)) return;
                var form = new SellerForm(seller);
                if (form.ShowDialog() != DialogResult.OK) return;
                Db.SaveChanges();
                dataGridView.Update();
            }
            else if (typeof(T) == typeof(Customer))
            {
                if (!(Set.Find(id) is Customer customer)) return;
                var form = new CustomerForm(customer);
                if (form.ShowDialog() != DialogResult.OK) return;
                Db.SaveChanges();
                dataGridView.Update();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}