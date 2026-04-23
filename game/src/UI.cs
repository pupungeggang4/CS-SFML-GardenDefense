using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public static class UI {
        public static Dictionary<string, Vector2f> Title = new Dictionary<string, Vector2f>
        {
            {"TextTitle", (20, 20)}, {"TextStart", (180, 140)}, {"TextCollection", (180, 220)},
            {"TextErase", (180, 300)}, {"TextQuit", (180, 380)},
            {"ButtonStart", (160, 120)}, {"ButtonCollection", (160, 200)}, {"ButtonErase", (160, 280)}, {"ButtonQuit", (160, 360)}
        };
        public static Dictionary<string, Vector2f> CharacterSelect = new Dictionary<string, Vector2f>
        {
            {"TextTitle", (20, 20)}, 
            {"ButtonCharacterStart", (20, 120)}, {"ButtonCharacterSize", (120, 120)}, {"ButtonCharacterInterval", (140, 140)},
            {"ButtonBack", (700, 20)}, {"ButtonStart", (620, 500)}
        };
        public static Dictionary<string, Vector2f> Battle = new Dictionary<string, Vector2f>
        {
            {"ButtonMenu", (700, 20)},
            {"LevelText", (20, 466)}, {"EnergyText", (120, 466)}, {"EnergyBar", (200, 470)}, {"EnergyBarSize", (200, 20)}
        };
        public static Dictionary<string, Vector2f> Collection = new Dictionary<string, Vector2f>
        {
            {"ButtonBack", (700, 20)}
        };
        public static Dictionary<string, Vector2f> Menu = new Dictionary<string, Vector2f>
        {
            {"Pos", (160, 120)}, {"Size", (480, 320)}, {"TextTitle", (180, 140)},
            {"ButtonResume", (160, 200)}, {"ButtonExit", (160, 280)}, {"ButtonQuit", (160, 360)}
        };

        public static Vector2f TitleButtonSize = (480, 80);
        public static Vector2f MenuButtonSize = (480, 80);
        public static Vector2f ButtonLargeSize = (80, 80);
        public static Vector2f ButtonLargeWideSize = (160, 80);
    }
}
