using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Collections
{
    public class Vector
    {
        public Vector(float x, float y)
        {
            if (x is float a)
                X = a; 
            if(y is float b)
                Y= b;
        }
        public float X { get; set; }
        public float Y { get; set; }

        public static Vector operator +(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X + vector2.X, vector1.Y + vector2.Y);       
        }
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X - vector2.X, vector1.Y - vector2.Y);
        }
        public static Vector operator *(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X * vector2.X, vector1.Y * vector2.Y);
        }
        public static Vector operator +(Vector vector1, float scalar)
        {
            return new Vector(vector1.X + scalar, vector1.Y + scalar);
        }
        public static Vector operator *(Vector vector1, float scalar)
        {
            return new Vector(vector1.X * scalar, vector1.Y * scalar);
        }
        public static Vector operator -(Vector vector1, float scalar)
        {
            return new Vector(vector1.X - scalar, vector1.Y - scalar);
        }
        public static bool operator ==(Vector vector1, Vector vector2)
        {
            return (vector1.X == vector2.X && vector2.Y == vector2.Y);       
        }
        public static bool operator !=(Vector vector1, Vector vector2)
        {
            return (vector1.X != vector2.X && vector2.X != vector2.Y);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"[{X}]\n[{Y}]";
        }
    }
}
