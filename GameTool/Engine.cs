using Microsoft.ClearScript.V8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTool
{
    public class Engine
    {
        public Engine(Game game)
        {
            this.Game = game;
        }

        public Window createWindow(dynamic opts)
        {
            return Game.createMainWindow(opts);
        }
        
        public Entity createNewEntity(dynamic opts)
        {
            return Game.createNewEntity(opts);
        }

        public void setEventLoop(dynamic call)
        {
            this.callback = call;
        }

        public void eventLoop()
        {
            this.callback();
        }

        public void log(dynamic message)
        {
            Console.WriteLine(message);
        }

        public void quit()
        {
            this.Game.quit();
        }

        internal dynamic callback { get; set; }
        internal Game Game { get; set; }
    }
}
