using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Window;

namespace FightingEngine2017
{
    public static class InputStream
    {
        public class InputEvent
        {
            public InputEvent(InputManager.Key key)
            {
                this.key = key;
            }

            public InputEvent(int code)
            {
                this.key = (InputManager.Key)code;
            }

            public InputManager.Key key;
        }
        
        public static void Window_KeyPressed(object sender, KeyEventArgs e)
        {
            
            OnKeyDown(sender, new InputEvent((int)e.Code));
        }
        public static void Window_KeyReleased(object sender, KeyEventArgs e)
        {
            OnKeyUp(sender, new InputEvent((int)e.Code));
        }

        public static event EventHandler<InputEvent> OnKeyUp;
        public static event EventHandler<InputEvent> OnKeyDown;
    }
}
