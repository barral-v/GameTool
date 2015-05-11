using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;

namespace GameTool
{
    public class EventSize
    {
        public int Height;
        public int Width;

        public EventSize(SizeEventArgs args)
        {
            this.Height = (int)args.Height;
            this.Width = (int)args.Width;
        }
    }
}
