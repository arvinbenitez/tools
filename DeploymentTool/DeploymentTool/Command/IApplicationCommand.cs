using System.Collections.Generic;

namespace DeploymentTool.Command
{
    public interface IApplicationCommand
    {
        void Execute(IDictionary<CommandParameterKey, object> parameters);
    }
}