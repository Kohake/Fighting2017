using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine2017
{
    public class Rect<T>
    {
        public Rect(T x, T y, T width, T height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public T x, y, width, height;
    }
}
