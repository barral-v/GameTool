﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;

namespace GameTool
{
    public class EventText
    {
        public string Unicode;

        public EventText(TextEventArgs args)
        {
            this.Unicode = args.Unicode;
        }
    }
}
