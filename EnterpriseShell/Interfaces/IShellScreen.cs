using System.Collections.Generic;
using Caliburn.Micro;

namespace EnterpriseShell.Interfaces
{
    public interface IShellScreen : IScreen
    {
        string LargeIcon { get; set; }
        string SmallIcon { get; set; }
        string Description { get; set; }

        IEnumerable<IShellScreen> Childs { get; set; }
    }
}