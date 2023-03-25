using Raylib_cs;
using System.Numerics;

public class TransformComponent : IComponent
{
    public Vector2 Position;
    public float Rotation;
    public Vector2 Scale;

    public TransformComponent(Vector2 position) : this(position, 0.0f, new Vector2(1, 1)) { }

    public TransformComponent(Vector2 position, float rotation) : this(position, rotation, new Vector2(1, 1)) { }

    public TransformComponent(Vector2 position, float rotation, Vector2 scale)
    {
        Position = position;
        Rotation = rotation;
        Scale = scale;
    }
}
