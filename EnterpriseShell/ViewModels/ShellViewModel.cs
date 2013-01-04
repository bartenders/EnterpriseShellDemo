namespace EnterpriseShell.ViewModels
{
    using System;

    using Caliburn.Micro;

    public class ShellViewModel : Screen
    {
        public ShellViewModel(TreeNavigationViewModel treeNavigationModel)
        {
            if (treeNavigationModel == null)
            {
                throw new ArgumentNullException("treeNavigationModel");
            }

            this.TreeNavigationModel = treeNavigationModel;
        }

        public TreeNavigationViewModel TreeNavigationModel { get; private set; }
    }
}