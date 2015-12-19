using System;

namespace CQRSBetter.Domain.DomainModel
{
    public class Product
    {
        public int ProductId { get; }
        public string ProductName { get; }
        public ProductCategory ProductCategory { get; set; }

        public Product(string productName, ProductCategory productCategory) : this(0, productName, productCategory)
        {
        }

        public Product(int productId, string productName, ProductCategory productCategory)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.ProductCategory = productCategory;
        }
    }
}
