using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class SimpleButton : Button
    {
        public RectangleShape Background;
        public Text Label;
        
        public SimpleButton(List<float> rect, String str) : base(rect)
        {
            Background = new RectangleShape((rect[2], rect[3]));
            Background.Position = new Vector2f(rect[0], rect[1]);
            Background.FillColor = Color.Cyan;

            Label = new Text(Asset.Neodgm, str, 32);
            // Left-Middle Align
            float baseOffset = -Label.GetLocalBounds().Position.Y;
            Label.Position = new Vector2f(rect[0] + 20.0f, rect[1] + rect[3] / 2.0f - Label.CharacterSize / 2.0f + baseOffset);
            Label.FillColor = Color.Black;
        }

        public override void Render(Game game)
        {
            game.Window.Draw(Background);
            game.Window.Draw(Label);
        }
    }
}
