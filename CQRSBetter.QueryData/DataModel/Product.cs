using System.ComponentModel.DataAnnotations;

namespace CQRSBetter.QueryData.DataModel
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductCategoryId { get; set; }

        public string ProductCategoryName { get; set; }
    }
}
