namespace EnterpriseShell.ViewModels
{
    using System.Collections.Generic;

    using Caliburn.Micro;

    using EnterpriseFramework;
    using EnterpriseFramework.Interfaces;

    public class Stammdaten : Screen, IShellScreen
    {
        public string LargeIcon { get; private set; }

        public string SmallIcon { get; private set; }

        public string Description
        {
            get
            {
                return "Hier StaMMDATEN";
            }
        }


        public IEnumerable<IShellScreen> Childs { get; private set; }
    }
}