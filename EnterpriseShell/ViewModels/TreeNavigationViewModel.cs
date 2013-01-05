namespace EnterpriseShell.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;

    using Caliburn.Micro;

    using EnterpriseFramework.Interfaces;

    public class TreeNavigationViewModel : Screen
    {
        public TreeNavigationViewModel()
        {
            var list = IoC.GetAllInstances(typeof(IShellScreen));
            this.screens = list.Cast<IShellScreen>();
            this.NotifyOfPropertyChange(() => this.Screens);
        }

        private IEnumerable<IShellScreen> screens;

        public IEnumerable<IShellScreen> Screens
        {
            get
            {
                return this.screens;
            }
        }
    }
}