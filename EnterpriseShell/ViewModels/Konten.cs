namespace EnterpriseShell.ViewModels
{
    using System.Collections.Generic;

    using Caliburn.Micro;

    using EnterpriseFramework.Interfaces;

    public class Konten : Screen, IShellScreen
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

        public Konten()
        {
            this.children = new List<IShellScreen>();
        }

        public string SmallIcon { get; private set; }

        public string Description
        {
            get
            {
                return "Hier Konten";
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