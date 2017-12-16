using System;
using SFML.Window;
using SFML.Graphics;

namespace FightingEngine2017
{
    internal class SfmlWindow : Window
    {
        RenderWindow window;

        public override void Create(uint width, uint height, string title, bool fullscreen)
        {
            Styles style = Styles.Default;
            if (fullscreen)
                style = Styles.Fullscreen;

            window = new RenderWindow(new VideoMode(width, height), title, style);

            // TODO: Replace SFML input system with a proper input system that can handle multiple devices and controllers, and stuff and shit and things... and bös
            window.KeyPressed += InputStream.Window_KeyPressed;
            window.KeyReleased += InputStream.Window_KeyReleased;
            window.Closed += (object sender, EventArgs e) => { window.Close(); Engine.Shutdown(); };
        }

        public override bool IsAlive()
        {
            return window.IsOpen;
        }

        public override void DispatchEvents()
        {
            window.DispatchEvents();

            // TODO: Don't clear the screen in here
            window.Clear(SFML.Graphics.Color.Blue);
        }

        public override void Update()
        {
            // TODO: Clear the sceen here instead.

            // TODO:: Add function call to rendermanager to draw everything here.
            window.Display();
        }

        public override void Close()
        {
            window.Close();
            Engine.Shutdown();
        }

        public override RenderContext GetRenderContext()
        {
            RenderContext renderContext = new RenderContext();
            renderContext.renderTarget = window;

            return renderContext;
        }
    }
    
}
