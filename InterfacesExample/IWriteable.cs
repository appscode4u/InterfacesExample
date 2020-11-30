﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    interface IWriteable
    {
        bool WriteData(File f, string content);
        bool DeleteContent(File f);
    }
}
