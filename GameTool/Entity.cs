using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;

namespace GameTool
{
    public class Entity
    {
        public Entity(Game game, dynamic opts)
        {
            this.Game = game;
            this.Name = (string)opts.name;
            this.Shape = new RectangleShape();
        }

        public void setPosition(float posX, float posY)
        {
            this.PosX = posX;
            this.PosY = posY;
            this.Shape.Position = new SFML.System.Vector2f(posX, posY);
        }

        public void setSize(float sizeX, float sizeY)
        {
            this.SizeX = sizeX;
            this.SizeY = sizeY;
            this.Shape.Size = new SFML.System.Vector2f(sizeX, sizeY);
        }

        public void setColor(int red, int green, int blue) 
        {
            this.Shape.FillColor = new Color((byte)red, (byte)green, (byte)blue);
        }

        public void draw(RenderWindow win)
        {
            this.Shape.Draw(win, RenderStates.Default);
        }

        internal Game Game { get; set; }
        private RectangleShape Shape { get; set; }
        public string Name { get; internal set; }
        public float PosX { get; internal set; }
        public float PosY { get; internal set; }
        public float SizeX { get; internal set; }
        public float SizeY { get; internal set; }
    }
}
