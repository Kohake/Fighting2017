using System;
using System.Collections.Generic;

namespace FightingEngine2017
{
    public abstract class GameObject : IComparable
    {
        public Transform transform = new Transform();

        public virtual GameObjectManager.UpdateOrder GetUpdateOrder() { return GameObjectManager.UpdateOrder.Default; }
        private List<Component> components = new List<Component>();

        private GameObject parent = null;
        public GameObject Parent
        {
            get
            {
                return parent;
            }
            set
            {
                if (value == this)
                {
                    Debug.Warning("A GameObject can't be parent to itself.");
                    return;
                }

                if (parent != null)
                    parent.Children.Remove(this);

                parent = value;

                if (parent != null)
                    parent.Children.Add(this);
            }
        }

        private List<GameObject> children = null;
        public List<GameObject> Children { get { if (children == null) { children = new List<GameObject>(); } return children; } }

        public GameObject()
        {
            Engine.GameObjectManager.Add(this);
            AddComponent(transform);
        }
        /*
        public Component AddComponent(Component component)
        {
            components.Add(component);
            return component;
        }
        */

        // NOTE: We require T to inherit from Component, and be newable
        public T AddComponent<T>() where T : Component, new()
        {
            T t = new T();
            t.ThisObject = this;
            components.Add(t);
            return t;
        }

        public T AddComponent<T>(T comp) where T : Component
        {
            components.Add(comp);
            comp.ThisObject = this;
            return comp;
        }

        public void RemoveComponent(Component component)
        {
            components.Remove(component);
        }

        public T GetComponent<T>() where T : Component
        {
            Type t = typeof(T);
            foreach (Component c in components)
            {
                if (t == c.GetType())
                {
                    return c as T;
                }
            }

            return null;
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
                return GetUpdateOrder().CompareTo(gameObject.GetUpdateOrder());
            }

            throw new Exception("Error!");
        }

    }
}
