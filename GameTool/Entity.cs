using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GameTool
{
    public class Entity
    {
        public Entity(Game game, dynamic opts)
        {
            this.Game = game;
            this.Name = (string)opts.name;
            this.Sprite = new Sprite();
            this.Visible = true;
        }

        public void setPosition(float posX, float posY)
        {
            this.PosX = posX;
            this.PosY = posY;
            this.Sprite.Position = new Vector2f(posX, posY);
        }

        public void setScale(float scaleX, float scaleY)
        {
            this.Sprite.Scale = new Vector2f(scaleX, scaleY);
        }


        public void setTexture(string textureName)
        {
            this.Sprite.Texture = new Texture(@"..\..\Textures\" + textureName);
        }

        public void move(float movX, float movY)
        {
            this.PosX += movX;
            this.PosY += movY;
            this.Sprite.Position = new SFML.System.Vector2f(this.PosX, this.PosY);
        }

        public void setVisible(bool vis)
        {
            this.Visible = vis;
        }

        public void draw(RenderWindow win)
        {
            if (this.Visible)
                this.Sprite.Draw(win, RenderStates.Default);
        }

        public FloatRect getGlobalBound()
        {
            return this.Sprite.GetGlobalBounds();
        }


        public bool checkCollision(Entity ent)
        {
            FloatRect rect1 = this.Sprite.GetGlobalBounds();
            FloatRect rect2 = ent.getGlobalBound();
            return (rect1.Intersects(rect2));
        }

        internal Game Game { get; set; }
        private Sprite Sprite { get; set; }
        public string Name { get; internal set; }
        public bool Visible { get; private set; }
        public float PosX { get; internal set; }
        public float PosY { get; internal set; }
    }
}
