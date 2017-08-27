using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine2017
{
    // TODO: Add additional window behaviour
    public class WindowManager
    {
        private Window window;

        public WindowManager()
        {
#if SFML_RENDERER
            window = new SfmlWindow();
#else
            throw new Exception("No render engine is specified.");
#endif
        }

        public bool IsAlive()
        {
            return window.IsAlive();
        }

        public void CreateWindow(uint width, uint height, string title, bool fullscreen = false)
        {
            window.Create(width, height, title, fullscreen);
        }

        public void DispatchEvents()
        {
            window.DispatchEvents();
        }

        public void Update()
        {
            window.Update();
        }

        public void Close()
        {
            window.Close();
        }

        public RenderContext GetRenderContext()
        {
            return window.GetRenderContext();
        }
    }
}
