using Microsoft.ClearScript.V8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTool
{
    public class Game
    {
        public Game(string fileName)
        {
            this.MainWindow = null;
            this.ScriptWindow = null;
            this.Engine = new Engine(this);
            string text = System.IO.File.ReadAllText(fileName);
            this.SE = new V8ScriptEngine(V8ScriptEngineFlags.EnableDebugging);
            this.SE.AddHostObject("engine", this.Engine);
            this.SE.Execute(text);
            this.EntityList = new List<Entity>();
        }

        public void run()
        {
            if (MainWindow == null)
            {
                Console.WriteLine("Error: no window created !");
                return;
            }
            while (MainWindow.IsOpen)
            {
                MainWindow.WaitAndDispatchEvents();
            }
        }

        public void quit()
        {
            MainWindow.Close();
        }

        public Window createMainWindow(dynamic opts)
        {
            if (MainWindow != null)
            {
                Console.WriteLine("Warning: MainWindow is already created !");
            }
            else
            {
                ScriptWindow = new Window(this, opts);
                MainWindow = new SFML.Window.Window(new SFML.Window.VideoMode(ScriptWindow.Width, ScriptWindow.Height), ScriptWindow.Name);
            }
            return ScriptWindow;
        }

        public Entity createNewEntity(dynamic opts)
        {
            this.EntityList.Add(new Entity(this, opts));
            return this.EntityList.Last();
        }

        public V8ScriptEngine SE { get; internal set; }
        public Engine Engine { get; internal set; }
        public SFML.Window.Window MainWindow { get; internal set; }
        public Window ScriptWindow { get; internal set; }
        public List<Entity> EntityList { get; internal set; }
    }
}
