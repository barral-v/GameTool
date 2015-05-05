using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;

namespace GameTool
{
    public class EventMouseMove
    {
        public int X;
        public int Y;

        public EventMouseMove(MouseMoveEventArgs args)
        {
            this.X = args.X;
            this.Y = args.Y;
        }
    }
}
