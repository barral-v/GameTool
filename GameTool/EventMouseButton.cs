using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;

namespace GameTool
{
    public class EventMouseButton
    {
        public int X;
        public int Y;
        public string Button;

        public EventMouseButton(MouseButtonEventArgs args)
        {
            this.Button = args.Button.ToString();
            this.X = args.X;
            this.Y = args.Y;
        }
    }
}
