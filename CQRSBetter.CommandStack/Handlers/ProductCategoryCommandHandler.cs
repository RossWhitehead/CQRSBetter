using AutoMapper;
using CQRSBetter.CommandData;
using CQRSBetter.CommandData.DataModel;
using CQRSBetter.CommandStack.Commands;
using CQRSBetter.Infrastructure.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSBetter.CommandStack.Handlers
{
    public class ProductCategoryCommandHandler : IProductCategoryCommandHandler
    {
        private CommandDbContext db;

        public ProductCategoryCommandHandler(CommandDbContext db)
        {
            this.db = db;
        }

        public async Task<CommandResult> HandleAsync(CreateProductCategoryCommand command)
        {
            throw new NotImplementedException();
        }

        public async Task<CommandResult> HandleAsync(DeleteProductCategoryCommand command)
        {
            throw new NotImplementedException();
        }

        public async Task<CommandResult> HandleAsync(AddOrUpdateProductCategoryCommand command)
        {
            CommandResult result = new CommandResult() { Success = true };

            using (CommandDbContext db = new CommandDbContext())
            {
                // If a new record, create a new entity, map the command to the domain object and add it to the context
                if (command.ProductCategoryId == 0)
                {
                    db.ProductCategories.Add(Mapper.Map<ProductCategory>(command));
                }
                else
                {
                    // If an updated record, retrieve it from the context and apply the updates
                    ProductCategory productCategory = await db.ProductCategories.FindAsync(command.ProductCategoryId);
                    if (productCategory != null)
                    {
                        Mapper.Map(command, productCategory);
                    }
                    else
                    {
                        result.Success = false;
                        result.Message = "Product Category not found.";
                    }
                }

                if (result.Success)
                {
                    // Commit data  changes
                    await db.SaveChangesAsync();
                }
            }

            return result;
        }
    }
}
