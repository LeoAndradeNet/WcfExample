﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceExample.Library
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceExample" in both code and config file together.
    public class ServiceExample : IServiceExample
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
