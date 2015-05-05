using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;

namespace GameTool
{
    public class EventJoystickMove
    {
        public int JoystickId;
        public float Position;
        public string Axis;

        public EventJoystickMove(JoystickMoveEventArgs args)
        {
            this.Position = args.Position;
            this.JoystickId = (int)args.JoystickId;
            this.Axis = args.Axis.ToString();
        }
    }
}
