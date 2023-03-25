public class ColliderComponent : IComponent
{
    public ICollisionShape Shape;

    public ColliderComponent(ICollisionShape shape)
    {
        Shape = shape;
    }
}
