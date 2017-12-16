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
            foreach (Player player in Game.Instance.Players)
            {
                MenuInputBinding binding = player.MenuBindings;
                List<InputManager.Key> selectKeys = binding.GetKeys(MenuInputBinding.Button.Select);

                if(InputManager.KeyPressed(selectKeys))
                {
                    RequestStateChange(new BattleState());
                    return;
                }
            }
        }
    }
}
