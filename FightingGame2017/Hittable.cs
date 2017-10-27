using FightingEngine2017;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame2017
{
    abstract class Hittable : Component
    {
        private List<Hitbox> hurtboxes;
        Hittable()
        {

        }

        abstract public void TakeDamage();
        // Not sure if it should be abstract or if I should just desing this function to call other functions on other components.

        public void Clear()
        {
            hurtboxes.Clear();
        }

        public void Add(Hitbox box)
        {
            hurtboxes.Add(box);
        }

        public void Add(Vector2<float> offset, Vector2<float> dimonsions)
        {
            // TODO: Fixit!
            //Transform holderTransform = parent.transform
            Vector2<float> holderPosition = new Vector2<float>(0, 0); // holderTransform.Position;
            float dir = 1.0f; //holderTransform.Direction;

            Hitbox box = new Hitbox(new Vector2<float>(0, 0), new Vector2<float>(0, 0)); // new Hitbox(holderPosition + dir * offset, dimonsions);
            hurtboxes.Add(box);
        }
    }
}
