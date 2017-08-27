namespace FightingEngine2017
{
    internal abstract class Window
    {
        public abstract void Create(uint width, uint height, string title, bool fullscreen);
        public abstract bool IsAlive();
        public abstract void DispatchEvents();
        public abstract void Update();
        public abstract void Close();

        public abstract RenderContext GetRenderContext();
    }
}