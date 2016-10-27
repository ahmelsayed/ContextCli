using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextCli.Actions
{
    class SetPublishPassword : AbstractAction
    {
        public SetPublishPassword(IContext context) : base(context)
        {
        }

        public override Task RunAsync()
        {
            throw new NotImplementedException();
        }
    }
}
