using CQRSBetter.Domain.DomainModel;
using CQRSBetter.Infrastructure.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSBetter.Domain.Services
{
    public interface IProductCategoryService
    {
        Task<DomainResult> AddOrUpdateProductCategory(ProductCategory productCategory);
        Task<DomainResult> CreateProductCategory(ProductCategory productCategory);
        Task<DomainResult> DeleteProductCategory(ProductCategory productCategory);
        Task<IEnumerable<ProductCategory>> GetProductCategories();
    }
}
