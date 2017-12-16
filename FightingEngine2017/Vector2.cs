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
        public static Vector2<T> operator +(Vector2<T> x, Vector2<T> y)
        {
            return x + y;
        }

        public T x, y;
    }

    public class Vector2
    {
        public static Vector2 Zero = new Vector2(0, 0);
        public static Vector2 UnitX = new Vector2(1, 0);
        public static Vector2 UnitY = new Vector2(0, 1);
        public float x, y;

        #region Constructor
        public Vector2()
        {
        }
        public Vector2(Vector2 other)
        {
            x = other.x;
            y = other.y;
        }
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion

        #region Math
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }
        public static Vector2 operator *(Vector2 vector, float number)
        {
            return new Vector2(vector.x * number, vector.y * number);
        }

        public static float Dot(Vector2 a, Vector2 b)
        {
            // TODO: test if this works
            return (a.x * b.x) + (a.y * b.y);
        }
        public float Dot(Vector2 other)
        {
            // TODO: test if this works
            return (this.x * other.x) + (this.y * other.y);
        }

        public float Length()
        {
            return (float)Math.Sqrt(this.x * this.x + this.y * this.y);
        }
        public float LengthSquared()
        {
            return (this.x * this.x + this.y * this.y);
        }
        #endregion
    }
}
