namespace EnterpriseFramework.Interfaces
{
    using System.Collections.Generic;

    using Caliburn.Micro;

    public interface IShellScreen : IScreen
    {
        string LargeIcon { get; }
        string SmallIcon { get; }
        string Description { get; }

        IShellScreen AddChild(IShellScreen child);

        List<IShellScreen> Children { get;  }
    }
}