using FightingEngine2017;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame2017
{
    public class Hitbox : Box
    {
        //public int Priority { get; } // TODO: Decide if we want this.

        public delegate void HitResponse(Hitbox other);
        private HitResponse OnHit;

        public Hitbox(GameObject parent, Vector2<float> position, Vector2<float> dimensions, HitResponse onHit = null)
        {
            Parent = parent;

            SetPosition(position);
            this.dimensions = dimensions;
            OnHit = onHit;

            // Priority = 0;
        }
    }
}
