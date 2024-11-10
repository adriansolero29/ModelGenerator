﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGenerator.UI.Interface
{
    public interface IXMLService
    {
        void Write(string elementName, string elementValue);
        string GetValues(string condition = null);
    }
}
