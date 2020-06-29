﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Events
{
    public class InputPressedEventArgs : EventArgs
    {
        public DateTime TimeFired { get; }

        public InputPressedEventArgs()
        {
            TimeFired = DateTime.Now;
        }
    }
}
