using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class Asset
    {
        public static Font Neodgm;
        public static void LoadAsset()
        {
            Neodgm = new Font("asset/font/neodgm.ttf");
            Neodgm.SetSmooth(false);
        }
    }
}
