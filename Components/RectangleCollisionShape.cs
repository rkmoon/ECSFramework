using Raylib_cs;

public class RectangleCollisionShape : ICollisionShape
{
    public Rectangle Bounds;

    public RectangleCollisionShape(Rectangle bounds)
    {
        Bounds = bounds;
    }

    public bool CheckCollision(ICollisionShape other)
    {
        if (other is RectangleCollisionShape otherRectangle)
        {
            return Raylib.CheckCollisionRecs(Bounds, otherRectangle.Bounds);
        }

        if (other is CircleCollisionShape otherCircle)
        {
            return Raylib.CheckCollisionCircleRec(otherCircle.Center, otherCircle.Radius, Bounds);
        }

        return false;
    }
}