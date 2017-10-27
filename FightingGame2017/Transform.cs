using FightingEngine2017;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame2017
{
    public class Transform : Component
    {
        public Vector2<float> Position { get; set; }

        private Vector2<float> direction;
        public float Direction { get { return direction.x; } }
    }
}
