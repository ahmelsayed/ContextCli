using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextCli.Actions
{
    class AddStorageAccount : AbstractAction
    {
        public AddStorageAccount(IContext context) : base(context)
        {
        }

        public override Task RunAsync()
        {
            throw new NotImplementedException();
        }
    }
}
