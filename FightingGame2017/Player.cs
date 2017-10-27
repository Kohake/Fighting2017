using FightingEngine2017;
using System;

namespace FightingGame2017
{
    public class Player : GameObject // : PlayerBase
    {
        public override GameObjectManager.UpdateOrder GetUpdateOrder() { return GameObjectManager.UpdateOrder.Player; }
        uint id;
        GameplayInputBinding bindings;
        public MenuInputBinding MenuBindings { get; private set; }

        // Avatar ;
        BattleAvatar battleAvatar;
        MenuAvatar menuAvatar;

        public Player()
        {
            MenuBindings = new MenuInputBinding();

            menuAvatar = AddComponent<MenuAvatar>();
        }

        public override void Update()
        {
            
        }
    }
}