using System;
using System.Collections.Generic;

namespace FightingEngine2017
{
    public class GameObject : IComparable
    {
        public int UpdateOrder { get { return 0; } }
        private List<Component> components = new List<Component>();

        public GameObject()
        {
        }

        public Component AddComponent(Component component)
        {
            components.Add(component);
            return component;
        }
        public void RemoveComponent(Component component)
        {
            components.Remove(component);
        }
        public Component GetComponent()
        {
            throw new NotImplementedException();
        }


        public virtual void Start()
        {
        }

        public virtual void Update()
        {

        }

        public virtual void Destroy()
        {

        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            GameObject gameObject = obj as GameObject;
            if (gameObject != null)
            {
                return UpdateOrder.CompareTo(gameObject.UpdateOrder);
            }

            throw new Exception("Error!");
        }

    }
}
