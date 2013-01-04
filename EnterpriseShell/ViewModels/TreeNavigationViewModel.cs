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
            this.NotifyOfPropertyChange(() => this.ScreenNames);
        }

        private IEnumerable<IShellScreen> screens;

        public IEnumerable<string> ScreenNames
        {
            get
            {
                var enumerable = this.screens;

                if (enumerable != null)
                {
                    foreach (var screen in enumerable)
                    {
                        yield return screen.Description;
                    }
                }
            }
        }
    }
}