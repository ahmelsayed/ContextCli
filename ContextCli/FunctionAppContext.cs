using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContextCli.Actions;

namespace ContextCli
{
    class FunctionAppContext : IContext
    {
        public IEnumerable<AbstractAction> Actions { get; private set; }

        public string Name { get; } = "functionapp";

        public IEnumerable<IContext> SubContexts { get; }

        public FunctionAppContext(AzureContext azureContext)
        {
            Actions = new AbstractAction[]
            {
                new List(this),
                new Fetch(this),
                new Create(this),
                new GetPublishUserName(this),
                new SetPublishPassword(this)
            };
            SubContexts = Enumerable.Empty<IContext>();
        }

        public FunctionAppContext()
        {
            Actions = new AbstractAction[]
            {
                new Create(this),
                new AddStorageAccount(this)
            };
            SubContexts = new IContext[]
            {
                new SettingsContext(this)
            };
        }

        public Task InitializeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
