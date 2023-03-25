using Raylib_cs;
using System.Numerics;

public class CircleCollisionShape : ICollisionShape
{
    public Vector2 Center;
    public float Radius;

    public CircleCollisionShape(Vector2 center, float radius)
    {
        Center = center;
        Radius = radius;
    }

    public bool CheckCollision(ICollisionShape other)
    {
        if (other is RectangleCollisionShape otherRectangle)
        {
            return Raylib.CheckCollisionCircleRec(Center, Radius, otherRectangle.Bounds);
        }

        if (other is CircleCollisionShape otherCircle)
        {
            return Raylib.CheckCollisionCircles(Center, Radius, otherCircle.Center, otherCircle.Radius);
        }

        return false;
    }
}