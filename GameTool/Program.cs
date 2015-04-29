using Microsoft.ClearScript.V8;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ClearScript;

namespace GameTool
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string file = (args.Length == 0 ? (Directory.GetFiles(@".", "Game.js"))[0] : args[0]);
                string text = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
                Console.WriteLine(text);
                using (var engine = new V8ScriptEngine())
                {
                    engine.Execute(text);
                    Console.WriteLine(engine.Script.window.name);
                    Console.WriteLine(engine.Script.window.width);
                    Console.WriteLine(engine.Script.window.height);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
        }
    }
}
