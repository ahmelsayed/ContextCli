using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextCli.Actions
{
    class Create : AbstractAction
    {
        public Create(IContext context) : base(context)
        {
        }

        public override Task RunAsync()
        {
            throw new NotImplementedException();
        }
    }
}
