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
            try
            {
                string file = (args.Length == 0 ? @"Game.js" : args[0]);
                string text = System.IO.File.ReadAllText(file);
                using (var engine = new V8ScriptEngine())
                {
                    
                    using (Form form = new Form())
                    {
                        engine.Execute(text);
                        form.ShowDialog();
                    }
                }
            }
            catch (IOException e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
