using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;

namespace GameTool
{
    public class EventKey
    {
        public bool Alt;
        public bool Control;
        public bool Shift;
        public bool System;
        public string Code;

        public EventKey(KeyEventArgs args)
        {
            this.Alt = args.Alt;
            this.Control = args.Control;
            this.Shift = args.Shift;
            this.System = args.System;
            this.Code = args.Code.ToString();
        }
    }
}
