using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine2017
{
    public abstract class Game
    {
        // TODO: Make todo's
        public Game()
        {
        }

        public abstract void Start();
        public abstract void Update();
        public abstract void Shutdown();
    }
}
