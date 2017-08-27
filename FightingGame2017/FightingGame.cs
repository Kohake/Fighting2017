using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightingEngine2017;

namespace FightingGame2017
{
    public class FightingGame : Game
    {
        List<Player> players = new List<Player>();

        public FightingGame()
        {
        }

        public override void Start()
        {
            WindowManager wm = Engine.WindowManager;
            wm.CreateWindow(800, 600, "Coolest Game Ever!11!", false);

            GameState.RequestStateChange(new MainMenuState());
            GameState.SwitchToNextState();

            for (int i = 0; i < 4; i++) // TODO: Replace the magic number (based on devices connected).
            {
                players.Add(new Player());
            }

            //Engine.GameObjectManager.Add(new FightingState());
        }

        public override void Update()
        {
            //TODO: Make some update code
            // Run state code stuff?

            GameState.UpdateCurrent();
            GameState.SwitchToNextState();
        }
        
        public override void Shutdown()
        {

        }
    }
}
