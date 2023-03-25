using System;
using System.Collections.Generic;
using System.Numerics;
using Raylib_cs;

public class RenderSystem : ISystem
{
    public void Update(float deltaTime, List<Entity> entities)
    {
        foreach (Entity entity in entities)
        {
            TransformComponent transform = entity.GetComponent<TransformComponent>();
            RenderComponent render = entity.GetComponent<RenderComponent>();

            if (transform != null && render != null)
            {
                ColliderComponent collider = entity.GetComponent<ColliderComponent>();

                if (collider != null)
                {
                    ICollisionShape shape = collider.Shape;

                    if (shape is RectangleCollisionShape rectangleShape)
                    {
                        Rectangle originalRectangle = rectangleShape.Bounds;
                        Rectangle scaledRectangle = new Rectangle(
                            transform.Position.X + originalRectangle.x * transform.Scale.X,
                            transform.Position.Y + originalRectangle.y * transform.Scale.Y,
                            originalRectangle.width * transform.Scale.X,
                            originalRectangle.height * transform.Scale.Y
                        );
                        Raylib.DrawRectangleRec(scaledRectangle, render.Color);
                    }
                    else if (shape is CircleCollisionShape circleShape)
                    {
                        Vector2 position = transform.Position + new Vector2(circleShape.Center.X * transform.Scale.X, circleShape.Center.Y * transform.Scale.Y);
                        float radius = circleShape.Radius * Math.Max(transform.Scale.X, transform.Scale.Y);
                        Raylib.DrawCircleV(position, radius, render.Color);
                    }
                    // Add other shape rendering logic if needed
                }
            }
        }
    }
}
