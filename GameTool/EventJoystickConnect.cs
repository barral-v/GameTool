using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;

namespace GameTool
{
    public class EventJoystickConnect
    {
        public int JoystickId;

        public EventJoystickConnect(JoystickConnectEventArgs args)
        {
            this.JoystickId = (int)args.JoystickId;
        }
    }
}
