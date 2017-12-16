using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame2017
{
    public abstract class GameState
    {
        public enum StatePriority
        {
            BOTTOM,
            LOW,
            DEFAULT,
            HIGH,
            TOP,
            GOD
        }

        private static GameState CurrentState { get; set; }
        private static GameState nextState;
        public abstract string Name { get; }
        
        /// <summary>
        /// Returns the priority of the current state.
        /// </summary>
        /// <returns>Priority of the state that is instanced.</returns>
        public StatePriority GetPriority()
        {
            return StatePriority.DEFAULT;
        }

        public static void RequestStateChange(GameState newState)
        {
            if (CurrentState != null && newState.Name == CurrentState.Name)
                return;

            if (nextState != null && newState.GetPriority() <= nextState.GetPriority())
                return;

            nextState = newState;
        }

        public static void SwitchToNextState()
        {
            if(nextState != null)
            {
                if(CurrentState != null)
                    CurrentState.End();
                
                CurrentState = nextState;
                CurrentState.Start();
            }

            nextState = null;
        }

        public static void UpdateCurrent()
        {
            CurrentState.Update();
        }

        protected virtual void Start() { }
        protected virtual void Update() { }
        protected virtual void End() { }
    }
}
