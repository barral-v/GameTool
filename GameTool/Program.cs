using Microsoft.ClearScript.V8;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ClearScript;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace GameTool
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = (args.Length == 0 ? @"..\..\Game.js" : args[0]);
            Game = new Game(file);
            Game.run();
        }

        public static Game Game { get; set; }
    }
}
