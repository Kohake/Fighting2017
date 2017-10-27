using FightingEngine2017;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame2017
{
    public class Box : GameObject
    {
        protected Transform transform;
        protected Vector2<float> dimensions;

        public Box()
        {
            transform = GetComponent<Transform>();
            if (transform == null)
            {
                transform = AddComponent<Transform>();
            }
        }

        public Box(Vector2<float> position, Vector2<float> dimensions)
        {
            SetPosition(position);
            this.dimensions = dimensions;
        }

        public void SetPosition(Vector2<float> position)
        {
           transform.Position = position;
        }

        public void SetPosition(Transform transform)
        {
            this.transform.Position = transform.Position;
        }
    }
}
