﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;

namespace FightingEngine2017
{
    public class InputManager
    {
        public enum Key
        {
            Unknown = -1,
            A = 0,
            B = 1,
            C = 2,
            D = 3,
            E = 4,
            F = 5,
            G = 6,
            H = 7,
            I = 8,
            J = 9,
            K = 10,
            L = 11,
            M = 12,
            N = 13,
            O = 14,
            P = 15,
            Q = 16,
            R = 17,
            S = 18,
            T = 19,
            U = 20,
            V = 21,
            W = 22,
            X = 23,
            Y = 24,
            Z = 25,
            Num0 = 26,
            Num1 = 27,
            Num2 = 28,
            Num3 = 29,
            Num4 = 30,
            Num5 = 31,
            Num6 = 32,
            Num7 = 33,
            Num8 = 34,
            Num9 = 35,
            Escape = 36,
            LControl = 37,
            LShift = 38,
            LAlt = 39,
            LSystem = 40,
            RControl = 41,
            RShift = 42,
            RAlt = 43,
            RSystem = 44,
            Menu = 45,
            LBracket = 46,
            RBracket = 47,
            SemiColon = 48,
            Comma = 49,
            Period = 50,
            Quote = 51,
            Slash = 52,
            BackSlash = 53,
            Tilde = 54,
            Equal = 55,
            Dash = 56,
            Space = 57,
            Return = 58,
            BackSpace = 59,
            Tab = 60,
            PageUp = 61,
            PageDown = 62,
            End = 63,
            Home = 64,
            Insert = 65,
            Delete = 66,
            Add = 67,
            Subtract = 68,
            Multiply = 69,
            Divide = 70,
            Left = 71,
            Right = 72,
            Up = 73,
            Down = 74,
            Numpad0 = 75,
            Numpad1 = 76,
            Numpad2 = 77,
            Numpad3 = 78,
            Numpad4 = 79,
            Numpad5 = 80,
            Numpad6 = 81,
            Numpad7 = 82,
            Numpad8 = 83,
            Numpad9 = 84,
            F1 = 85,
            F2 = 86,
            F3 = 87,
            F4 = 88,
            F5 = 89,
            F6 = 90,
            F7 = 91,
            F8 = 92,
            F9 = 93,
            F10 = 94,
            F11 = 95,
            F12 = 96,
            F13 = 97,
            F14 = 98,
            F15 = 99,
            Pause = 100,
            KeyCount = 101
        }

        private static bool[] internalBuffer = new bool[(int)Key.KeyCount];
        private static bool[] previousInternalBuffer = new bool[(int)Key.KeyCount];

        public InputManager()
        {
            // TODO: Create input buffer object for each connected device
            InputStream.OnKeyDown += OnKeyDown;
            InputStream.OnKeyUp += OnKeyUp;

            for (int i = 0; i < internalBuffer.Length; i++)
            {
                internalBuffer[i] = false;
            }
        }

        public void SavePreviousInputs()
        {
            internalBuffer.CopyTo(previousInternalBuffer, 0);
        }

        private void OnKeyUp(object sender, InputStream.InputEvent e)
        {
            if (e.key == Key.Unknown)
            {
                Debug.Warning("Reacting to unkown key being released!");
                return;
            }

            internalBuffer[(int)e.key] = false;
        }

        private void OnKeyDown(object sender, InputStream.InputEvent e)
        {
            if (e.key == Key.Unknown)
            {
                Debug.Warning("Reacting to unkown key being pressed!");
                return;
            }

            internalBuffer[(int)e.key] = true;
        }

        public static bool KeyDown(List<InputManager.Key> keyList)
        {
            foreach (InputManager.Key key in keyList)
            {
                if (internalBuffer[(int)key])
                    return true;
            }

            return false;
        }

        public static bool KeyPressed(List<InputManager.Key> keyList)
        {
            foreach (InputManager.Key key in keyList)
            {
                if (internalBuffer[(int)key] && previousInternalBuffer[(int)key] == false)
                    return true;
            }

            return false;
        }

        public static bool KeyReleased(List<InputManager.Key> keyList)
        {
            foreach (InputManager.Key key in keyList)
            {
                if (internalBuffer[(int)key] == false && previousInternalBuffer[(int)key])
                    return true;
            }

            return false;
        }

        [Obsolete("Please refrain from checking for specific key down")]
        public static bool KeyDown(Key keycode)
        {
            if (internalBuffer[(int)keycode])
                return true;

            return false;
        }

        [Obsolete("Please refrain from checking for specific key press")]
        public static bool KeyPressed(Key keycode)
        {
            if (internalBuffer[(int)keycode] && previousInternalBuffer[(int)keycode] == false)
                return true;

            return false;
        }

        [Obsolete("Please refrain from checking for specific key release")]
        public static bool KeyReleased(Key keycode)
        {
            if (internalBuffer[(int)keycode] == false && previousInternalBuffer[(int)keycode])
                return true;

            return false;
        }

        private void OnDeviceChanged()
        {
            // Add or remove device
        }
    }
}
