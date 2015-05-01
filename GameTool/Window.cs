using Microsoft.ClearScript;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTool
{
    public class Window
    {
        public Window(Game game, dynamic opts)
        {
            this.Game = game;
            Width = 800;
            Height = 600;
            Name = "GameTool";

            if (opts != null)
            {
                Width = (uint)opts.width;
                Height = (uint)opts.height;
                Name = (string)opts.name;
            }
        }

        public void onKeyPress(dynamic callback)
        {
            Game.MainWindow.KeyPressed += new EventHandler<KeyEventArgs>(delegate(object sender, KeyEventArgs e) {
                Console.WriteLine(e.Code.ToString());
                callback(e);
            });
        }

        public void onClose(dynamic callback)
        {
            Game.MainWindow.Closed += new EventHandler(delegate(object sender, EventArgs e) {
                callback(e);
            });
        }

        internal Game Game { get; set; }

        public uint Width { get; internal set; }
        public uint Height { get; internal set; }
        public string Name { get; internal set; }
    }
}
