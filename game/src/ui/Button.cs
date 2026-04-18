using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class Button
    {
        public RectangleShape Rect;
        public Text Label;

        public Button(FloatRect rect, string str)
        {
            Rect = new RectangleShape((rect.Size.X, rect.Size.Y));
            Rect.Position = new Vector2f(rect.Position.X, rect.Position.Y);
            Rect.FillColor = Color.Cyan;
            Label = new Text(Asset.Neodgm, str, 32);
            // Left-Middle Align
            float baseOffset = -Label.GetLocalBounds().Position.Y;
            Label.Position = new Vector2f(rect.Position.X + 20.0f, rect.Position.Y + rect.Size.Y / 2.0f - Label.CharacterSize / 2.0f + baseOffset);
            Label.FillColor = Color.Black;
        }

        public void Render(Game game)
        {
            game.Window.Draw(Rect);
            game.Window.Draw(Label);
        }

        public bool IsMouseOver(Vector2f pos)
        {
            return Rect.GetGlobalBounds().Contains(pos);
        }
    }
}
