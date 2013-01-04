namespace EnterpriseShell.ViewModels
{
    using System.Collections.Generic;

    using Caliburn.Micro;

    using EnterpriseFramework;
    using EnterpriseFramework.Interfaces;

    public class Konten : Screen, IShellScreen
    {
        public string LargeIcon { get; private set; }

        public string SmallIcon { get; private set; }

        public string Description
        {
            get
            {
                return "Edit Accounts here";
            }
        }

        public IEnumerable<IShellScreen> Childs { get; private set; }
    }
}