﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ColorInvoker
    {
        public void Invoke(ICommand cmd)
        {
            cmd.UpdateColor();
        }
    }
}
