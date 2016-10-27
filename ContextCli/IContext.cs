using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContextCli
{
    interface IContext
    {
        string Name { get; }

        IEnumerable<IContext> SubContexts { get; }

        IEnumerable<AbstractAction> Actions { get; }

        Task InitializeAsync();
    }
}
