using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTool
{
    class Engine
    {
        private Microsoft.ClearScript.V8.V8ScriptEngine SE;

        public delegate void onKeyPressDel();

        public Engine(Microsoft.ClearScript.V8.V8ScriptEngine SE)
        {
            this.SE = SE;
            SE.AddHostObject("engine", this);
        }

        public Window createWindow(int width, int height)
        {
            return new Window(this, width, height);
        }

        public void onKeyPress(onKeyPressDel callback)
        {

        }
    }
}
