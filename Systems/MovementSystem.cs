using System.Collections.Generic;
using Raylib_cs;

public class MovementSystem : ISystem
{
    public void Update(float deltaTime, List<Entity> entities)
    {
        foreach (Entity entity in entities)
        {
            TransformComponent transform = entity.GetComponent<TransformComponent>();
            VelocityComponent velocity = entity.GetComponent<VelocityComponent>();

            if (transform != null && velocity != null)
            {
                transform.Position += velocity.Velocity * deltaTime;
            }
        }
    }
}
