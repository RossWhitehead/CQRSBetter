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
using NodaTime;

namespace CQRSBetter.Domain.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        IClock clock;
        IProductCategoryCommandHandler handler;
        CommandDbContext db;

        public ProductCategoryService(IClock clock, IProductCategoryCommandHandler handler, CommandDbContext db)
        {
            this.clock = clock;
            this.handler = handler;
            this.db = db;
        }

        public async Task<DomainResult> AddOrUpdateProductCategory(ProductCategory productCategory)
        {
            AddOrUpdateProductCategoryCommand command = Mapper.Map<AddOrUpdateProductCategoryCommand>(productCategory);
            productCategory.LastUpdatedOn = clock.Now.ToDateTimeUtc();
            CommandResult commandResult = await handler.HandleAsync(command);
            return Mapper.Map<DomainResult>(commandResult);
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
