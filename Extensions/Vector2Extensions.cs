using Raylib_cs;
using System.Numerics;

public static class Vector2Extensions
{
    public static float x(this Vector2 vector)
    {
        return vector.X;
    }

    public static float y(this Vector2 vector)
    {
        return vector.Y;
    }

    public static void x(this Vector2 vector, float value)
    {
        vector.X = value;
    }

    public static void y(this Vector2 vector, float value)
    {
        vector.Y = value;
    }
}
