using System;
using FightingEngine2017;
using System.Collections.Generic;

namespace FightingGame2017
{
    internal class BattleState : GameState
    {
        public override string Name { get { return "Battle State"; } }

        protected override void Start()
        {
            foreach (Player player in Game.Instance.Players)
            {
                // Create Character
                player.SpawnBattleAvatar();
            }
        }

        protected override void Update()
        {
            foreach (Player player in Game.Instance.Players)
            {
                MenuInputBinding binding = player.MenuBindings;
                List<InputManager.Key> selectKeys = binding.GetKeys(MenuInputBinding.Button.Select);

                if (InputManager.KeyPressed(selectKeys))
                    RequestStateChange(new MainMenuState());
            }
        }
    }
}