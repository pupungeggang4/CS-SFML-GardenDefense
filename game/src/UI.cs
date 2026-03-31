using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    static class UI {
        public static Dictionary<string, Vector2f> Title = new Dictionary<string, Vector2f>
        {
            {"text_title", (20, 20)}, {"text_start", (180, 140)}, {"text_collection", (180, 220)},
            {"text_erase", (180, 300)}, {"text_quit", (180, 380)},
            {"button_start", (160, 120)}, {"button_collection", (160, 200)}, {"button_erase", (160, 280)}, {"button_quit", (160, 360)}
        };
        public static Vector2f TitleButtonSize = (480, 80);
    }
}
