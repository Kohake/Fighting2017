using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine2017
{
    internal class SfmlSprite : SpriteImplementation
    {
        SFML.Graphics.Sprite sprite;

        public SfmlSprite()
        {
            sprite = new SFML.Graphics.Sprite();
        }

        public SfmlSprite(Texture texture)
        {
            sprite = new SFML.Graphics.Sprite(texture.GetTextureImplementation().GetInternal());
        }
        
        public override void Draw(RenderContext context)
        {
            sprite.Draw(context.renderTarget, SFML.Graphics.RenderStates.Default);
        }
    }
}
