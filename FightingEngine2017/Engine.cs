using System;
using System.Collections.Generic;

namespace FightingEngine2017
{
    public static class Engine
    {
        public static GameObjectManager GameObjectManager = new GameObjectManager();
        public static PhysicsManager PhysicsManager = new PhysicsManager();
        //public static PlayerManager PlayerManager = new PlayerManager();
        public static RenderManager RenderManager = new RenderManager();
        public static WindowManager WindowManager = new WindowManager();
        public static InputManager InputManager = new InputManager();
        private static Game Game;

        private static bool isRunning = false;
        public static void Start(Game game)
        {
            if (isRunning)
                throw new InvalidOperationException("The engine is already running.");

            isRunning = true;
            Game = game;
            Game.Start();

            Update();
            // Start main loop
           //WindowManager.OnKeyDown += (WindowManager.InputEvent e) => {   }
        }

        public static void Update()
        {
            while (isRunning)
            {
                WindowManager.DispatchEvents(); // Events include registering inputs from Windows
                GameObjectManager.Update(); // Since I can't remeber this without a note, this is wherer the game objects do their state stuff among other things.
                //PhysicsManager.FunctionThatDoesNotExist();
                Game.Update(); // Combat collision and maybe some other stuff???
                //RenderManager.FunctionThatDoesNotExist();
                WindowManager.Update();
            }
        }

        public static void Shutdown()
        {
            if (WindowManager.IsAlive())
                WindowManager.Close();

            isRunning = false;
        }
    }
}
