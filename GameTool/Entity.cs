using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTool
{
    public class Entity
    {
        public Entity(Game game, dynamic opts)
        {
            this.Game = game;
            this.Name = (string)opts.name;
            Console.WriteLine(this.Name);
        }

        internal Game Game { get; set; }
        public string Name { get; internal set; }
    }
}
