using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    class Program {
        private static void Main() {
            Game game = new Game();
            game.init();
            game.run();
        }
    }
}
