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

        // TODO: Make this shit private, dude. Also, probably make it work as well...
        public void SortByUpdateOrder()
        {
            GameObjects.Sort();
        }

        public void Update()
        {
            foreach(GameObject go in NewelyAddedGameObjects)
            {
                go.Start();
            }

            GameObjects.AddRange(NewelyAddedGameObjects);
            NewelyAddedGameObjects.Clear();

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
