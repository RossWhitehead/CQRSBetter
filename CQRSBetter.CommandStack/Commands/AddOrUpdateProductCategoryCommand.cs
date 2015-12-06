using CQRSBetter.Infrastructure.Command;

namespace CQRSBetter.CommandStack.Commands
{
    public class AddOrUpdateProductCategoryCommand : ICommand
    {
        public AddOrUpdateProductCategoryCommand(int productCatgoryId, string productCategoryName)
        {
            this.ProductCategoryId = productCatgoryId;
            this.ProductCategoryName = productCategoryName;
        }

        public int ProductCategoryId { get; set; }

        
        public string ProductCategoryName { get; set; }
    }
}