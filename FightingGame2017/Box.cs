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
        protected Vector2 dimensions;

        public Box()
        {
            transform = GetComponent<Transform>();
            if (transform == null)
            {
                transform = AddComponent<Transform>();
            }
        }

        public Box(Vector2 position, Vector2 dimensions)
        {
            SetPosition(position);
            this.dimensions = dimensions;
        }

        public void SetPosition(Vector2 position)
        {
           transform.Position = position;
        }

        public void SetPosition(Transform transform)
        {
            this.transform.Position = transform.Position;
        }
    }
}
