using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine2017
{
    public class Texture
    {
        private TextureImplementation texture;

        public Texture(string filename)
        {
#if SFML_RENDERER
            texture = new SfmlTexture(filename);
#else

#endif
        }

        public static uint MaximumSize()
        {
            return SFML.Graphics.Texture.MaximumSize;
        }

        public bool Repeated()
        {
            return texture.Repeated;
        }

        public Vector2<uint> Size()
        {
            Vector2<uint> v = texture.Size;
            return new Vector2<uint>(v.x, v.y);
        }

        public bool Smooth()
        {
            return texture.Smooth;
        }

        public TextureImplementation GetTextureImplementation()
        {
            return texture;
        }
    }
}
