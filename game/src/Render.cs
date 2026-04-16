using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class RenderFunc
    {
        public static void RenderButton(Game game, Button button)
        {
            RenderWindow window = game.Window;
            window.Draw(button.Rect);
            window.Draw(button.Label);
        }
    }
}