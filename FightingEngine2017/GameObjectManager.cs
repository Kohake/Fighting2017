using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine2017
{
    // TODO: Add update order
    public class GameObjectManager
    {
        public enum UpdateOrder
        {
            Player = int.MinValue,
            Default = 0,
        }

        List<GameObject> NewelyAddedGameObjects;
        List<GameObject> GameObjects;
        List<GameObject> RemovedGameObjects;
        
        public GameObjectManager()
        {
            NewelyAddedGameObjects = new List<GameObject>();
            GameObjects = new List<GameObject>();
            RemovedGameObjects = new List<GameObject>();
        }

        public void Add(GameObject go)
        {
            NewelyAddedGameObjects.Add(go);
        }
        
        public void PendingRemoval(GameObject go)
        {
            RemovedGameObjects.Add(go);
        }

        private void SortByUpdateOrder()
        {
            GameObjects.Sort();
        }

        public void Update()
        {
            bool shouldSort = false;

            foreach (GameObject go in NewelyAddedGameObjects)
            {
                go.Start();
                shouldSort = true;
            }

            GameObjects.AddRange(NewelyAddedGameObjects);
            NewelyAddedGameObjects.Clear();

            if (shouldSort)
                SortByUpdateOrder();

            foreach (GameObject go in GameObjects)
            {
                go.Update();
            }

            foreach (GameObject go in RemovedGameObjects)
            {
                GameObjects.Remove(go);
                go.Destroy();
            }
            RemovedGameObjects.Clear();
        }
    }
}
