using System.Threading.Tasks;
using ContextCli.Actions;

namespace ContextCli
{
    abstract class AbstractAction
    {
        public IContext Context { get; private set; }

        public AbstractAction(IContext context)
        {
            Context = context;
        }

        public abstract Task RunAsync();
    }
}
