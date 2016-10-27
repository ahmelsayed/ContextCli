using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextCli
{
    class AzureAccountContext : IContext
    {
        public IEnumerable<AbstractAction> Actions { get; private set; }

        public string Name { get; } = "account";

        public IEnumerable<IContext> SubContexts { get; private set; }

        public AzureAccountContext(AzureContext azureContext)
        {
            
        }

        public Task InitializeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
