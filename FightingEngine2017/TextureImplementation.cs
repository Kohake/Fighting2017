namespace FightingEngine2017
{
    public abstract class TextureImplementation
    {
        public Vector2<uint> Size { get; set; }
        public bool Repeated { get; set; }
        public bool Smooth { get; set; }

#if SFML_RENDERER
        public abstract SFML.Graphics.Texture GetInternal();
#else

#endif 
    }
}