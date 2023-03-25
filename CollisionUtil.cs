public static class CollisionUtil
{
    public static bool CheckEntityCollision(Entity entityA, Entity entityB)
    {
        ColliderComponent colliderA = entityA.GetComponent<ColliderComponent>();
        ColliderComponent colliderB = entityB.GetComponent<ColliderComponent>();

        if (colliderA == null || colliderB == null)
        {
            return false;
        }

        return colliderA.Shape.CheckCollision(colliderB.Shape);
    }
}
