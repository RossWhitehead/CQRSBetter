namespace CQRSBetter.Domain.DomainModel
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }

        public ProductCategory(string productCategoryName) : this(0, productCategoryName)
        {
        }

        public ProductCategory(int productCategoryId, string productCategoryName) 
        {
            this.ProductCategoryId = productCategoryId;
            this.ProductCategoryName = productCategoryName;
        }
    }
}
