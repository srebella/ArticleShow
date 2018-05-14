using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FunnelBud.Enums
{
    public enum EnumCategory
    {
        [Description("Sport")]
        Sport = 1,
        [Description("Hemelektronik")]
        Hemelektronik = 2,
        [Description("Leksaker")]
        Leksaker = 3
    }
}