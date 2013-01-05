namespace EnterpriseShell
{
    using Caliburn.Micro;

    using EnterpriseFramework.Interfaces;

    using EnterpriseShell.ViewModels;
    using Ninject;
    using System.Linq;
    using Ninject.Modules;

    public class NinjectModule : INinjectModule
    {
        public IKernel Kernel { get; private set; }

        public void OnLoad(IKernel kernel)
        {
            // Engine Components...
            kernel.Bind<IWindowManager>().To<WindowManager>().InSingletonScope();
            kernel.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope();

            // Shell Components...
            kernel.Bind<TreeNavigationViewModel>().ToSelf().InSingletonScope();
            kernel.Bind<ShellViewModel>().ToSelf().InSingletonScope();

            // Business Components...
            //kernel.Bind<IShellScreen>().To<Konten>().InSingletonScope();
            kernel.Bind<IShellScreen>().To<Kunden>().InSingletonScope();
            kernel.Bind<IShellScreen>().To<Stammdaten>().InSingletonScope();

            // HAck! How to set up?
            var iShellScreens = kernel.GetAll<IShellScreen>();

            foreach (var iShellScreen in iShellScreens)
            {
                var stamm = iShellScreen as Stammdaten;

                if (stamm != null)
                {
                    stamm.AddChild(new Konten());
                }
            }
        }

        public void OnUnload(IKernel kernel)
        {
        }

        public void OnVerifyRequiredModules()
        {
        }

        public string Name
        {
            get
            {
                return "MainShellModule";
            }
        }
    }
}
