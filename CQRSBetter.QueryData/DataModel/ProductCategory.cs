using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CQRSBetter.QueryData.DataModel
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryId { get; set; }

        [DisplayName("Product Category Name")]
        public string ProductCategoryName { get; set; }
    }
}
