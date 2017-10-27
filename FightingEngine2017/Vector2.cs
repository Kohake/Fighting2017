using System;

namespace FightingEngine2017
{
    public class Vector2<T>
    {
        // Todo: decide how to make this work for Floats?
        public static Vector2<int> Zero = new Vector2<int>(0, 0);
        public static Vector2<int> UnitX = new Vector2<int>(1, 0);
        public static Vector2<int> UnitY = new Vector2<int>(0, 1);

        public Vector2()
        {

        }
        public Vector2(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public Vector2(Vector2<T> other)
        {
            x = other.x;
            y = other.y;
        }

        public T x, y;
    }
}
