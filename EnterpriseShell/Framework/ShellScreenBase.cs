﻿namespace EnterpriseShell.Framework
{
    using System.Collections.Generic;

    using Caliburn.Micro;

    using EnterpriseShell.Interfaces;

    public class ShellScreenBase : Screen, IShellScreen
    {
        public string LargeIcon { get; set; }
        public string SmallIcon { get; set; }
        public string Description { get; set; }


        public IEnumerable<IShellScreen> Childs
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
                throw new System.NotImplementedException();
            }
        }
    }
}