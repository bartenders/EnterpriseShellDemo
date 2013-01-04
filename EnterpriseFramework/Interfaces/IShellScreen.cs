namespace EnterpriseFramework.Interfaces
{
    using System.Collections.Generic;

    using Caliburn.Micro;

    public interface IShellScreen : IScreen
    {
        string LargeIcon { get; }
        string SmallIcon { get; }
        string Description { get; }

        IEnumerable<IShellScreen> Childs { get;  }
    }
}