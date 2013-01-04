namespace EnterpriseShell
{
    using Caliburn.Micro;

    using Ninject;
    using Ninject.Modules;

    public class NinjectModule : INinjectModule
    {
        public IKernel Kernel { get; private set; }

        public void OnLoad(IKernel kernel)
        {
            kernel.Bind<IWindowManager>().To<WindowManager>().InSingletonScope();
            kernel.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope();
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
