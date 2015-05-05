using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;

namespace GameTool
{
    public class EventMouseWheel
    {
        public int Delta;
        public int X;
        public int Y;

        public EventMouseWheel(MouseWheelEventArgs args)
        {
            this.Delta = args.Delta;
            this.X = args.X;
            this.Y = args.Y;
        }
    }
}
