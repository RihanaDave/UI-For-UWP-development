﻿using System;

namespace Telerik.UI.Xaml.Controls.Grid
{
    internal class RuntimePropertyInfo : IPropertyInfo
    {
        public RuntimePropertyInfo(Type type, string name)
        {
            this.PropertyType = type;
            this.Name = name;
        }

        public Type PropertyType
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }
    }
}
