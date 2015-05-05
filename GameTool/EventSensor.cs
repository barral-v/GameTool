using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;

namespace GameTool
{
    public class EventSensor
    {
        public string Type;
        public float X;
        public float Y;
        public float Z;

        public EventSensor(SensorEventArgs args)
        {
            this.Type = args.Type.ToString();
            this.X = args.X;
            this.Y = args.Y;
            this.Z = args.Z;
        }
    }
}
