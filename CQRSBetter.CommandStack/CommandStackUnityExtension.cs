using CQRSBetter.CommandStack.Handlers;
using Microsoft.Practices.Unity;

namespace CQRSBetter.CommandStack
{
    public class CommandStackUnityContainerExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IProductCategoryCommandHandler, ProductCategoryCommandHandler>();
        }
    }
}
