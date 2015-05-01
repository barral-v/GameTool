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

namespace GameTool
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = (args.Length == 0 ? @"..\..\Game.js" : args[0]);
            string text = System.IO.File.ReadAllText(file);
            SE = new V8ScriptEngine();
            Engine = new Engine(SE);
            SE.Execute(text);
        }
        
        private static V8ScriptEngine SE { get; set; }

        private static Engine Engine { get; set; }
    }
}
