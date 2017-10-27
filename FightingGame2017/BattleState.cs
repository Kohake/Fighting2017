using System;
using FightingEngine2017;

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
            }
        }

        protected override void Update()
        {
            if (InputManager.IsKeyDown(InputManager.Key.Space))
                RequestStateChange(new MainMenuState());

            if (InputManager.IsKeyDown(InputManager.Key.A))
                RequestStateChange(new BattleState());
        }
    }
}