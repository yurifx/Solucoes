﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface ICommand
    {
        System.Windows.Forms.Control UI { get; set; }
        System.Drawing.Color Color { get; set; }
        void UpdateColor();
    }
}
