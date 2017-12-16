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

        BattleAvatar battleAvatar;
        MenuAvatar menuAvatar;

        public Player()
        {
            MenuBindings = new MenuInputBinding();
            menuAvatar = new MenuAvatar();
            //menuAvatar = AddComponent<MenuAvatar>(); // Menu avatar is no longer a component
        }

        public override void Update()
        {
        }

        public void SpawnBattleAvatar()
        {
            Character.CharacterIndex markedCharacter = menuAvatar.markedCharacter;
            battleAvatar = Character.CreateBattleAvatar(markedCharacter);
        }
    }
}