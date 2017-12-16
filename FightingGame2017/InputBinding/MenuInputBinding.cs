using System;
using System.Collections.Generic;
using FightingEngine2017;

namespace FightingGame2017
{
    public class MenuInputBinding
    {
        public enum Button
        {
            Up,
            Down,
            Left,
            Right,
            Select,
            Revert,

            Size
        }

        private readonly Dictionary<Button, List<InputManager.Key>> buttons = new Dictionary<Button, List<InputManager.Key>>();

        public List<InputManager.Key> GetKeys(Button button)
        {
            return buttons[button];
        }

        public MenuInputBinding()
        {
            buttons.Add(Button.Up, new List<InputManager.Key>() { InputManager.Key.Up });
            buttons.Add(Button.Down, new List<InputManager.Key>() { InputManager.Key.Down });
            buttons.Add(Button.Left, new List<InputManager.Key>() { InputManager.Key.Left });
            buttons.Add(Button.Right, new List<InputManager.Key>() { InputManager.Key.Right });
            buttons.Add(Button.Select, new List<InputManager.Key>() { InputManager.Key.Return, InputManager.Key.Space });
            buttons.Add(Button.Revert, new List<InputManager.Key>() { InputManager.Key.Escape });
        }
    }
}
