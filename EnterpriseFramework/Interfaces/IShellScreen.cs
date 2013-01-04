namespace EnterpriseFramework.Interfaces
{
    using System.Collections.Generic;

    using Caliburn.Micro;

    public interface IShellScreen : IScreen
    {
        string LargeIcon { get; set; }
        string SmallIcon { get; set; }
        string Description { get; set; }

        IEnumerable<IShellScreen> Childs { get; set; }
    }
}