using System;
using System.Threading.Tasks;

namespace ContextCli.Actions
{
    class Login : AbstractAction
    {
        public Login(AzureContext context) : base(context) { }

        public override Task RunAsync()
        {
            throw new NotImplementedException();
        }
    }
}
