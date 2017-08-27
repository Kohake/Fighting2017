using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightingEngine2017;

namespace FightingGame2017
{
    class MainMenuState : GameState
    {
        public override string Name { get { return "Main Menu State"; } }

        protected override void Start()
        {
            Console.WriteLine(Name);
        }

        protected override void Update()
        {


            if (InputManager.IsKeyDown(InputManager.Key.Space))
                RequestStateChange(new BattleState());
        }
    }
}
