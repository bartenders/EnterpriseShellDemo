namespace EnterpriseShell.Framework
{
    using Interfaces;

    using Caliburn.Micro;

    public class ShellScreenBase : Screen, IShellScreen
    {
        public string LargeIcon { get; set; }
        public string SmallIcon { get; set; }
        public string Description { get; set; }
    }
}