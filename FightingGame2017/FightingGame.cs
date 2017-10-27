using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightingEngine2017;

namespace FightingGame2017
{
    public class Game : FightingEngine2017.Game
    {
        public static Game Instance { get; private set; }

        List<Player> players = new List<Player>();
        public List<Player> Players { get { return players; } }

        public Game()
        {
            Instance = this;
        }

        public void Start()
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

        public void Update()
        {
            //TODO: Make some update code
            // Run state code stuff?

            GameState.UpdateCurrent();
            GameState.SwitchToNextState();
        }

        public void Shutdown()
        {

        }
    }
}
