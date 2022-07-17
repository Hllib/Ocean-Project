﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanWinForms.View
{
    public interface IView
    {
        event EventHandler NextIteration;
        event EventHandler InitOcean;

        StringBuilder sb { get; set; }
    }
}
