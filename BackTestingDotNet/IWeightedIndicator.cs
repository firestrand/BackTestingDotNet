using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackTestingDotNet
{
    public interface IWeighted
    {
        double Weight
        {
            get;
            set;
        }
    }
}
