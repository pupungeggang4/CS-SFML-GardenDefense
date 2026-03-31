using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    static class UI {
        public static Dictionary<string, Vector2f> Title = new Dictionary<string, Vector2f>
        {
            {"TextTitle", (20, 20)}, {"TextStart", (180, 140)}, {"TextCollection", (180, 220)},
            {"TextErase", (180, 300)}, {"TextQuit", (180, 380)},
            {"ButtonStart", (160, 120)}, {"ButtonCollection", (160, 200)}, {"ButtonErase", (160, 280)}, {"ButtonQuit", (160, 360)}
        };
        public static Dictionary<string, Vector2f> CharacterSelect = new Dictionary<string, Vector2f>
        {
            {"TextTitle", (20, 20)}, {"ButtonBack", (700, 20)}
        };
        public static Vector2f TitleButtonSize = (480, 80);
        public static Vector2f ButtonLargeSize = (80, 80);
    }
}
