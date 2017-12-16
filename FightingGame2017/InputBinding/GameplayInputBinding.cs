using System;
using System.Collections.Generic;
using FightingEngine2017;

namespace FightingGame2017
{
    public class GameplayInputBinding
    {
        public enum Button
        {
            A,
            B,
            C,
            D,
            Left,
            Up,
            Right,
            Down,
            Start,
            Select,

            Size
        }

        public GameplayInputBinding()
        {
            buttons.Add(Button.A, InputManager.Key.A);
            buttons.Add(Button.B, InputManager.Key.B);
            buttons.Add(Button.C, InputManager.Key.C);
            buttons.Add(Button.D, InputManager.Key.D);
            buttons.Add(Button.Left, InputManager.Key.A);
            buttons.Add(Button.Up, InputManager.Key.A);
            buttons.Add(Button.Right, InputManager.Key.A);
            buttons.Add(Button.Down, InputManager.Key.A);
            buttons.Add(Button.Start, InputManager.Key.A);
            buttons.Add(Button.Select, InputManager.Key.A);
        }

        private Dictionary<Button, InputManager.Key> buttons = new Dictionary<Button, InputManager.Key>();
        
        public void ChangeKeyBinding(Button b, InputManager.Key newKey)
        {
            if (buttons.ContainsKey(b))
            {
                buttons[b] = newKey;
            }
            else
            {
                buttons.Add(b, newKey);
            }
        }

        public void ClearKeyBinding(Button b)
        {
            if (buttons.ContainsKey(b))
            {
                buttons.Remove(b);
            }
        }
    }

}
