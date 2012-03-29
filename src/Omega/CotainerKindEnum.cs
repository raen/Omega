using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel;

namespace Omega
{
    public enum ContainerKindEnum
    {
        [Description("Beczka (211l)")]
        Barrel = 0,

        [Description("Prostopadłościan")]
        Cuboid = 1,

        [Description("Walec stojący")]
        CylinderS = 2,

        [Description("Walec leżący")]
        CylinderL = 3,

        [Description("Kula")]
        Sphere = 4,

        [Description("Inny")]
        Other = 5
    }
}
