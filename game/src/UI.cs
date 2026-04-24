using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public static class UI {
        public static Dictionary<string, List<float>> Title = new Dictionary<string, List<float>>
        {
            {"TextTitle", [20, 20]},
            {"ButtonStart", [160, 120, 480, 80]}, {"ButtonCollection", [160, 200, 480, 80]},
            {"ButtonErase", [160, 280, 480, 80]}, {"ButtonQuit", [160, 360, 480, 80]}
        };
        public static Dictionary<string, List<float>> CharacterSelect = new Dictionary<string, List<float>>
        {
            {"TextTitle", [20, 20]}, 
            {"ButtonCharacterStart", [20, 120]}, {"ButtonCharacterSize", [120, 120]},
            {"ButtonCharacterInterval", [140, 140]},
            {"ButtonBack", [700, 20, 80, 80]}, {"ButtonStart", [620, 500, 160, 80]}
        };
        public static Dictionary<string, List<float>> Battle = new Dictionary<string, List<float>>
        {
            {"ButtonMenu", [700, 20, 80, 80]},
            {"LevelText", [20, 466]}, {"EnergyText", [120, 466]}, {"EnergyBar", [200, 470]}, {"EnergyBarSize", [200, 20]}
        };
        public static Dictionary<string, List<float>> Collection = new Dictionary<string, List<float>>
        {
            {"ButtonBack", [700, 20]}
        };
        public static Dictionary<string, List<float>> Menu = new Dictionary<string, List<float>>
        {
            {"Pos", [160, 120]}, {"Size", [480, 320]}, {"TextTitle", [180, 140]},
            {"ButtonResume", [160, 200, 480, 80]}, {"ButtonExit", [160, 280, 480, 80]}, {"ButtonQuit", [160, 360, 480, 80]}
        };
    }
}
