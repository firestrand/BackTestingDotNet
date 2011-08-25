using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackTestingDotNet
{
    public interface IIndicator
    {
        string Name
        {
            get;
            set;
        }

        int Offset
        {
            get;
            set;
        }

        double At(int index);
    }
}
