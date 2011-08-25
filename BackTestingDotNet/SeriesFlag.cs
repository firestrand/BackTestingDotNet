using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackTestingDotNet
{
    [Flags]
    public enum SeriesFlag
    {
        None = 0x0,
        Open = 0x1,
        High = 0x2,
        Low  = 0x4,
        Close= 0x8,
        Spread = 0x10,
        Time = 0x20,
        TickVolume = 0x40,
        RealVolume = 0x80
    }
}
