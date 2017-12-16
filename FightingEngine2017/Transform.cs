using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine2017
{
    public class Transform : Component
    {
        public Vector2 Position { get; set; }

        private Vector2 direction;
        public float Facing { get { return direction.x; } }

        public Transform()
        {
            Position = Vector2.Zero;
            direction = Vector2.UnitX;
        }
    }
}
