using Raylib_cs;
using System.Numerics;

public class SpriteComponent : IComponent
{
    public Texture2D Texture;
    public Rectangle SourceRectangle;
    public Vector2 Origin;

    public SpriteComponent(Texture2D texture, Rectangle sourceRectangle, Vector2 origin)
    {
        Texture = texture;
        SourceRectangle = sourceRectangle;
        Origin = origin;
    }
}
