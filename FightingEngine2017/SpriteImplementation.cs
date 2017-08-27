using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine2017
{
    internal abstract class SpriteImplementation
    {
        public Color Color { get; set; }

        public abstract void Draw(RenderContext context);
    }
}
