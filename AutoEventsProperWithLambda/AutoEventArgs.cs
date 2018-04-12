using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEventsProperWithLambda
{
    class AutoEventArgs : EventArgs
    {
        public string MyUzenet { get; set; }
        public AutoEventArgs(string s)
        {
            MyUzenet = s;
        }
    }
}
