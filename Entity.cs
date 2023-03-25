using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Entity
{       public int Id { get; private set; }
        private static int NextId = 0;
        private Dictionary<Type, IComponent> _components;

        public Entity()
        {
            Id = NextId++;
            _components = new Dictionary<Type, IComponent>();
        }

        public T GetComponent<T>() where T : IComponent
    {
        if (_components.TryGetValue(typeof(T), out IComponent component))
        {
            return (T)component;
        }

        return default(T);
    }

    public void AddComponent<T>(T component) where T : IComponent
    {
        _components[typeof(T)] = component;
    }
}
