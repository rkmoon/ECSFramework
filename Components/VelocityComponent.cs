using System.Numerics;

public class VelocityComponent : IComponent
{
    public Vector2 Velocity;

    public VelocityComponent(Vector2 velocity)
    {
        Velocity = velocity;
    }
}