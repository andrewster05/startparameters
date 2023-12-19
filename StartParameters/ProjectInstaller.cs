using System.ComponentModel;

namespace StartParameters
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
            this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            serviceInstaller1.Description = "Log Start Parameters";
            serviceInstaller1.DisplayName = "StartParameters";
        }
    }
}
