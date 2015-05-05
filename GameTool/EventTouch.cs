using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;

namespace GameTool
{
    public class EventTouch
    {
        public int Finger;
        public int X;
        public int Y;

        public EventTouch(TouchEventArgs args)
        {
            this.Finger = (int)args.Finger;
            this.X = args.X;
            this.Y = args.Y;
        }
    }
}
