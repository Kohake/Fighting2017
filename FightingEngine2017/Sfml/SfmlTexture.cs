using System;
using SFML.Graphics;

namespace FightingEngine2017
{
    internal class SfmlTexture : TextureImplementation
    {
        private SFML.Graphics.Texture texture;

        public SfmlTexture(string filename)
        {
            texture = new SFML.Graphics.Texture(filename);
        }

        public override SFML.Graphics.Texture GetInternal()
        {
            return texture;
        }
    }
}