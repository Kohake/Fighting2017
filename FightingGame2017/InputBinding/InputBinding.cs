using FightingEngine2017;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FightingGame2017
{
    class PlayerInputBinding
    {
        private uint controllerId;
        private GameplayInputBinding gameplayBindings = new GameplayInputBinding();
        private MenuInputBinding menuBindings = new MenuInputBinding();
    }
}
