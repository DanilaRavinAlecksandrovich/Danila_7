using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danila_7.Model
{
    public class ProductDbContext : DbContext
    {
        #region Конструктор
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public свойства
        public DbSet<Product> Products { get; set; }
        #endregion

        #region Методы
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        private Product[] GetProducts() => new Product[]
        {
            new Product{ProductID = 1,
                        ProductName = "Видеокарта KFA2 GeForce RTX 3070 CORE",
                        ProductDescription = "(LHR) [37NSL6MD2KCK] [PCI-E 4.0, 8 ГБ GDDR6, 256 бит, DisplayPort x3, HDMI, GPU 1500 МГц]",
                        ProductPrice = 49499,
                        ProductUnit = 20},
            new Product{ProductID = 2,
                        ProductName = "Видеокарта GIGABYTE GeForce RTX 3090 IT GAMING",
                        ProductDescription = "[GV-N309TGAMING-24GD] [PCI-E, 24 ГБ GDDR6X, 384 бит, DisplayPort x3, HDMI, GPU 1560 МГц]",
                        ProductPrice = 99999,
                        ProductUnit = 18},
            new Product{ProductID = 3,
                        ProductName = "Видеокарта Palit GeForce RTX 3060 DUAL OC",
                        ProductDescription = "(LHR) [NE6060T19K9-190AD] [PCI-E 4.0, 12 ГБ GDDR6, 192 бит, DisplayPort x3, HDMI, GPU 1320 МГц]",
                        ProductPrice = 38999,
                        ProductUnit = 40},
            new Product{ProductID = 4,
                        ProductName = "Видеокарта GIGABYTE GeForce RTX 3070 IT GAMING OC",
                        ProductDescription = "[GV-N307TGAMING OC-8GD] [PCI-E 4.0, 8 ГБ GDDR6X, 256 бит, DisplayPort x3, HDMI, GPU 1500 МГц]",
                        ProductPrice = 70999,
                        ProductUnit = 52},
        };
    }
}
