namespace CrmUi
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сущностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.сущностиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerAddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerAddToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сущностиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сущностиToolStripMenuItem
            // 
            this.сущностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарToolStripMenuItem,
            this.складToolStripMenuItem});
            this.сущностиToolStripMenuItem.Name = "сущностиToolStripMenuItem";
            this.сущностиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.сущностиToolStripMenuItem.Text = "Сущности";
            // 
            // товарToolStripMenuItem
            // 
            this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            this.товарToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.товарToolStripMenuItem.Text = "Товар";
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сущностиToolStripMenuItem1,
            this.моделированиеToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(880, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // сущностиToolStripMenuItem1
            // 
            this.сущностиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductStripMenuItem1,
            this.SellerToolStripMenuItem,
            this.CustomerToolStripMenuItem,
            this.CheckToolStripMenuItem});
            this.сущностиToolStripMenuItem1.Name = "сущностиToolStripMenuItem1";
            this.сущностиToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.сущностиToolStripMenuItem1.Text = "Сущности";
            // 
            // ProductStripMenuItem1
            // 
            this.ProductStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productAddToolStripMenuItem});
            this.ProductStripMenuItem1.Name = "ProductStripMenuItem1";
            this.ProductStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ProductStripMenuItem1.Text = "Товар";
            this.ProductStripMenuItem1.Click += new System.EventHandler(this.ProductToolStripMenuItem1_Click);
            // 
            // productAddToolStripMenuItem
            // 
            this.productAddToolStripMenuItem.Name = "productAddToolStripMenuItem";
            this.productAddToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.productAddToolStripMenuItem.Text = "Добавить";
            this.productAddToolStripMenuItem.Click += new System.EventHandler(this.ProductAddToolStripMenuItem_Click);
            // 
            // SellerToolStripMenuItem
            // 
            this.SellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellerAddToolStripMenuItem1});
            this.SellerToolStripMenuItem.Name = "SellerToolStripMenuItem";
            this.SellerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SellerToolStripMenuItem.Text = "Продавец";
            this.SellerToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // sellerAddToolStripMenuItem1
            // 
            this.sellerAddToolStripMenuItem1.Name = "sellerAddToolStripMenuItem1";
            this.sellerAddToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.sellerAddToolStripMenuItem1.Text = "Добавить";
            this.sellerAddToolStripMenuItem1.Click += new System.EventHandler(this.SellerAddToolStripMenuItem1_Click);
            // 
            // CustomerToolStripMenuItem
            // 
            this.CustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerAddToolStripMenuItem2});
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CustomerToolStripMenuItem.Text = "Покупатель";
            this.CustomerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // customerAddToolStripMenuItem2
            // 
            this.customerAddToolStripMenuItem2.Name = "customerAddToolStripMenuItem2";
            this.customerAddToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.customerAddToolStripMenuItem2.Text = "Добавить";
            this.customerAddToolStripMenuItem2.Click += new System.EventHandler(this.CustomerAddToolStripMenuItem2_Click);
            // 
            // CheckToolStripMenuItem
            // 
            this.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem";
            this.CheckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CheckToolStripMenuItem.Text = "Чек";
            this.CheckToolStripMenuItem.Click += new System.EventHandler(this.CheckToolStripMenuItem_Click);
            // 
            // моделированиеToolStripMenuItem
            // 
            this.моделированиеToolStripMenuItem.Name = "моделированиеToolStripMenuItem";
            this.моделированиеToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.моделированиеToolStripMenuItem.Text = "Моделирование";
            this.моделированиеToolStripMenuItem.Click += new System.EventHandler(this.modelToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 490);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сущностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem сущностиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ProductStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerAddToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerAddToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem моделированиеToolStripMenuItem;
    }
}

