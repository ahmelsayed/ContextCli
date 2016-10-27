using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextCli.Actions
{
    class Fetch : AbstractAction
    {
        public Fetch(IContext context) : base(context)
        {
        }

        public override Task RunAsync()
        {
            throw new NotImplementedException();
        }
    }
}
