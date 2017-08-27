using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightingEngine2017;

namespace FightingGame2017
{
    public class Fireball : GameObject, IRenderable//, IPhysicsable
    {
        Sprite sprite;

        public Fireball()
        {
            sprite = new Sprite(new Texture(@"Fireball.png"));
        }

        public void OnRender(RenderContext renderContext)
        {
            //RenderContext.Draw(sprite);
        }

        /*
        void OnPhysicsUpdate(Time deltaTime)
        {
            transform.position.x += 100 * deltaTime;
        }
        */
    }
}
