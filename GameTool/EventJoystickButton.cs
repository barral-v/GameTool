using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;

namespace GameTool
{
    public class EventJoystickButton
    {
        public int Button;
        public int JoystickId;

        public EventJoystickButton(JoystickButtonEventArgs args) 
        {
            this.Button = (int)args.Button;
            this.JoystickId = (int)args.JoystickId;
        }
    }
}
