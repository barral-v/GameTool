using Microsoft.ClearScript.V8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.System;

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
                MainWindow.Clear();
                this.Engine.eventLoop();
                foreach (Entity ent in this.EntityList)
                {
                    ent.draw(MainWindow);
                }
                MainWindow.Display();
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
                MainWindow = new RenderWindow(new SFML.Window.VideoMode(ScriptWindow.Width, ScriptWindow.Height), ScriptWindow.Name);
            }
            return ScriptWindow;
        }

        public Entity createNewEntity(dynamic opts)
        {
            Entity ent = new Entity(this, opts);
            if (this.EntityList == null)
                this.EntityList = new List<Entity>();
            this.EntityList.Add(ent);
            return ent;
        }

        public void deleteEntity(Entity ent)
        {
            this.EntityList.Remove(ent);
        }

        public V8ScriptEngine SE { get; internal set; }
        public Engine Engine { get; internal set; }
        public RenderWindow MainWindow { get; internal set; }
        public Window ScriptWindow { get; internal set; }
        public List<Entity> EntityList { get; internal set; }
    }
}
