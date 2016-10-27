using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ContextCli.Actions;

namespace ContextCli
{
    class AzureContext : IContext
    {
        public IEnumerable<AbstractAction> Actions { get; private set; }

        public string Name { get; } = "azure";

        public IEnumerable<IContext> SubContexts { get; private set; }

        public bool IsAzure { get; set; }

        AzureContext()
        {
            Actions = new AbstractAction[]
            {
                new Login(this),
                new Logout(this),
                new Portal(this)
            };

            SubContexts = new IContext[]
            {
                new AzureFunctionAppContext(),
                new AzureAccountContext()
            };
        }

        public Task InitializeAsync()
        {
            throw new NotImplementedException();
        }
    }
}