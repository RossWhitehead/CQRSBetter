using CQRSBetter.CommandStack;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSBetter.Domain
{
    public class DomainUnityContainerExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.AddNewExtension<CommandStackUnityContainerExtension>();
        }
    }
}
