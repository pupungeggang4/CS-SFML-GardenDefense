using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class TextureButton
    {
        public Sprite Sp;
        public Texture Tex;

        public TextureButton(Vector2f pos, Texture tex)
        {
            Tex = tex;
            Sp = new Sprite(Tex);
            Sp.Position = new Vector2f(pos.X, pos.Y);
        }

        public void Render(Game game)
        {
            game.Window.Draw(Sp);
        }

        public bool IsMouseOver(Vector2f pos)
        {
            return Sp.GetGlobalBounds().Contains(pos);
        }
    }
}
