using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFMyServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MyWCFLibService : IMyWCFLibService
    {
        public string GetData(int value)
        {
            float taxRate = 0.21f;
            var tax = value * taxRate;
            var total = value + tax;
            return string.Format("You have to pay a total of ${0}, of which ${1} in taxes.", total, tax);
        }
    }
}
