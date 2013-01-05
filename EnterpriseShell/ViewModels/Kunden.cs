namespace EnterpriseShell.ViewModels
{
    using System.Collections.Generic;

    using Caliburn.Micro;

    using EnterpriseFramework.Interfaces;

    public class Kunden : Screen, IShellScreen
    {
        private List<IShellScreen> children;

        public Kunden()
        {
          this.children = new List<IShellScreen>();
        }

        public string LargeIcon
        {
            get { throw new System.NotImplementedException(); }
        }

        public string SmallIcon
        {
            get { throw new System.NotImplementedException(); }
        }

        public string Description
        {
            get
            {
                return "Edit Customers here!";
            }
        }

        public IShellScreen AddChild(IShellScreen child)
        {
            this.children.Add(child);
            return this;
        }

        public List<IShellScreen> Children
        {
            get
            {
                return children;
            }
        }
    }
}