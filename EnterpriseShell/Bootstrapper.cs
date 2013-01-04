namespace EnterpriseShell
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Caliburn.Micro;

    using EnterpriseShell.ViewModels;
    using Ninject;

    public class Bootstrapper : Bootstrapper<ShellViewModel>
    {
        private IKernel kernel;

        protected override void Configure()
        {
            this.kernel = new StandardKernel();
            this.kernel.Load(Assembly.GetExecutingAssembly());

            // Add additional assemblies here:
            // this.kernel.Load("MainShell.dll");

            // This is needed for Caliburn View-Discovery
            var assemblies = kernel.GetModules().Select(m => m.GetType().Assembly).Distinct().ToList();
            AssemblySource.Instance.AddRange(assemblies);
        }

        protected override object GetInstance(System.Type service, string key)
        {
            return this.kernel.Get(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(System.Type service)
        {
            return this.kernel.GetAll(service);
        }
    }
}
