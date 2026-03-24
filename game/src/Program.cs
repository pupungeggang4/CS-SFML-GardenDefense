using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    class Program
    {
        private static void Main()
        {
            Asset.LoadAsset();
            Game game = new Game();
            game.Init();
            game.Run();
        }
    }
}
