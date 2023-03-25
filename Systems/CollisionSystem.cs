using System.Collections.Generic;
using Raylib_cs;

public class CollisionSystem : ISystem
{
    public void Update(float deltaTime, List<Entity> entities)
    {
        for (int i = 0; i < entities.Count; i++)
        {
            Entity entityA = entities[i];
            ColliderComponent colliderA = entityA.GetComponent<ColliderComponent>();

            if (colliderA == null)
            {
                continue;
            }

            for (int j = i + 1; j < entities.Count; j++)
            {
                Entity entityB = entities[j];
                ColliderComponent colliderB = entityB.GetComponent<ColliderComponent>();

                if (colliderB == null)
                {
                    continue;
                }

                if (colliderA.Shape.CheckCollision(colliderB.Shape))
                {
                    // Collision detected between entityA and entityB
                    // Resolve the collision or trigger an event, as needed
                }
            }
        }
    }
}
