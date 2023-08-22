using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object___Strings___Price_Jacob
{
    /// <summary>
    /// This is the IBootUp Interface used for objects that can be turned on and off
    /// </summary>
    internal interface IBootUp
    {
       bool IsOn { get; set; }

        void PowerOnOff()
        {

        }
    }
}
