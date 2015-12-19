using CQRSBetter.CommandStack.Commands;
using CQRSBetter.Infrastructure.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSBetter.CommandStack.Handlers
{
    public interface IProductCategoryCommandHandler : ICommandHandler<AddOrUpdateProductCategoryCommand>,
                                                      ICommandHandler<CreateProductCategoryCommand>,
                                                      ICommandHandler<DeleteProductCategoryCommand>
    {
    }
}
