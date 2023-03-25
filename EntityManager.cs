using System;
using System.Collections.Generic;
using System.Linq;

public class EntityManager
{
    private List<Entity> _entities;
    private int _nextEntityId;

    public EntityManager()
    {
        _entities = new List<Entity>();
    }

    public Entity CreateEntity()
    {
        Entity entity = new Entity();
        _entities.Add(entity);
        return entity;
    }

    public void RemoveEntity(Entity entity)
    {
        _entities.Remove(entity);
    }

    public IReadOnlyList<Entity> GetEntities()
    {
        return _entities.AsReadOnly();
    }

    public IReadOnlyList<Entity> GetEntitiesByComponent<T>() where T : IComponent
    {
        return _entities.Where(entity => entity.HasComponent<T>()).ToList().AsReadOnly();
    }

    public IReadOnlyList<Entity> GetEntitiesByComponents(params Type[] componentTypes)
    {
        return _entities.Where(entity => componentTypes.All(type => (bool)typeof(Entity).GetMethod("HasComponent").MakeGenericMethod(type).Invoke(entity, null))).ToList().AsReadOnly();
    }

 
}
