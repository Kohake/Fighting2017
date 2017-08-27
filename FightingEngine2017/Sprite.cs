using System;

namespace FightingEngine2017
{
    public class Sprite
    {
        public Color Color { get; set; }
        public Texture Texture { get; set; }
        public Rect<int> TextureRect { get; set; }
        private SpriteImplementation sprite;

        public Sprite()
        {

#if SFML_RENDERER
            sprite = new SfmlSprite();
#else
            throw new Exception("No render engine is specified.");
#endif
        }

        public Sprite(Texture texture)
        {
            Color = Color.White;
            Texture = texture;

            sprite = new SfmlSprite(Texture);
            sprite.Color = Color;
        }

        public Sprite(Sprite copy)
        {
            Color = copy.Color;
            Texture = copy.Texture;
            TextureRect = copy.TextureRect;

            sprite = new SfmlSprite(Texture);
            sprite.Color = Color;
        }

        public Sprite(Texture texture, Rect<int> rectangle)
        {
            Color = Color.White;
            Texture = texture;
            TextureRect = rectangle;

            sprite = new SfmlSprite(Texture);
            sprite.Color = Color;
        }

        public void Draw(RenderContext context)
        {
            sprite.Draw(context);
        }

        public Rect<float> GetGlobalBounds()
        {
            throw new NotImplementedException();
            return new Rect<float>(0.0f, 0.0f, 0.0f, 0.0f);
        }
        public Rect<float> GetLocalBounds()
        {
            throw new NotImplementedException();
            return new Rect<float>(0.0f, 0.0f, 0.0f, 0.0f);
        }

        public override System.String ToString()
        {
            return "";
        }
    }
}
