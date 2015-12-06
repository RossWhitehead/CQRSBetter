using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CQRSBetter.Domain.DomainModel;
using CQRSBetter.Infrastructure.Domain;
using CQRSBetter.CommandStack.Handlers;
using CQRSBetter.CommandStack.Commands;
using AutoMapper;
using CQRSBetter.CommandData;
using CQRSBetter.Infrastructure.Command;

namespace CQRSBetter.Domain.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        public ProductCategoryService()
        {
        }

        public async Task<DomainResult> AddOrUpdateProductCategory(ProductCategory productCategory)
        {
            using (CommandDbContext db = new CommandDbContext())
            {
                ProductCategoryCommandHandler handler = new ProductCategoryCommandHandler(db);
                AddOrUpdateProductCategoryCommand command = Mapper.Map<AddOrUpdateProductCategoryCommand>(productCategory);
                CommandResult commandResult = await handler.HandleAsync(command);
                return Mapper.Map<DomainResult>(commandResult);
            }
        }

        public async Task<DomainResult> CreateProductCategory(ProductCategory productCategory)
        {
            using (CommandDbContext db = new CommandDbContext())
            {
                ProductCategoryCommandHandler handler = new ProductCategoryCommandHandler(db);
                CreateProductCategoryCommand command = Mapper.Map<CreateProductCategoryCommand>(productCategory);
                CommandResult commandResult = await handler.HandleAsync(command);
                return Mapper.Map<DomainResult>(commandResult);
            }
        }

        public async Task<DomainResult> DeleteProductCategory(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductCategory>> GetProductCategories()
        {
            throw new NotImplementedException();
        }

        Task<DomainResult> IProductCategoryService.CreateProductCategory(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }
    }
}
