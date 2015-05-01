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

        public void log(dynamic message)
        {
            Console.WriteLine(message);
        }

        public void quit()
        {
            this.Game.quit();
        }

        internal Game Game { get; set; }
    }
}
