namespace DeploymentTool
{
    public interface IApplicationInstance
    {
        ApplicationStatus Start();
        ApplicationStatus Stop();
        ApplicationStatus Install();
        ApplicationStatus Uninstall();
        ApplicationStatus GetStatus();
    }

    public class ApplicationStatus
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    public enum ApplicationStatusCode
    {
        Unknown,
        Started,
        Stopped,
        Failed,
        Installed,
        Uninstalled
    }
}
