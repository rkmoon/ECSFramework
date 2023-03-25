using System.Collections.Generic;

public interface ISystem
{
    void Update(float deltaTime, List<Entity> entities);
}