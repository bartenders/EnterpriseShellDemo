namespace EnterpriseShell.ViewModels
{
    using System.Collections.Generic;

    using Caliburn.Micro;

    using EnterpriseFramework.Interfaces;

    public class Stammdaten : Screen, IShellScreen
    {
        private List<IShellScreen> children;

        public List<IShellScreen> Children
        {
            get
            {
                return this.children;
            }
        }

        public string LargeIcon { get; private set; }

        public Stammdaten()
        {
            this.children = new List<IShellScreen>();
        }

        public string SmallIcon { get; private set; }

        public string Description
        {
            get
            {
                return "Hier StaMMDATEN";
            }
        }

        public IShellScreen AddChild(IShellScreen child)
        {
            this.children.Add(child);
            this.NotifyOfPropertyChange(() => Children);
            return this;
        }


    }
}