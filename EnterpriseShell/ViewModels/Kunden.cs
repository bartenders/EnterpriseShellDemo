namespace EnterpriseShell.ViewModels
{
    using Caliburn.Micro;
    using EnterpriseFramework;
    using EnterpriseFramework.Interfaces;

    public class Kunden : Screen, IShellScreen
    {
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

        public System.Collections.Generic.IEnumerable<IShellScreen> Childs
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}