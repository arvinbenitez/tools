namespace DeploymentTool
{
    public class ApplicationInstanceInstance: IApplicationInstance
    {
        public string Name { get; set; }
        public ApplicationType Type { get; set; }
        public ApplicationSource ApplicationSource { get; set; }

        public ApplicationStatus Start()
        {
            throw new System.NotImplementedException();
        }

        public ApplicationStatus Stop()
        {
            throw new System.NotImplementedException();
        }

        public ApplicationStatus Install()
        {
            throw new System.NotImplementedException();
        }

        public ApplicationStatus Uninstall()
        {
            throw new System.NotImplementedException();
        }

        public ApplicationStatus GetStatus()
        {
            throw new System.NotImplementedException();
        }
    }

    public enum ApplicationType
    {
        WebService,
        WebApplication,
        WindowsService,
        Console
    }

    public class ApplicationSource
    {
        public string Name { get; set; }
        public string SourceDirectory { get; set; }
        public ApplicationType Type { get; set; }
    }
}