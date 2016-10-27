using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextCli.Actions
{
    class Start : AbstractAction
    {
        public Start(IContext context) : base(context)
        {
        }

        public override Task RunAsync()
        {
            throw new NotImplementedException();
        }
    }
}
