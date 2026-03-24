using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    class Asset
    {
        public static Font neodgm;
        public static void LoadAsset()
        {
            neodgm = new Font("asset/font/neodgm.ttf");
            neodgm.SetSmooth(false);
        }
    }
}
