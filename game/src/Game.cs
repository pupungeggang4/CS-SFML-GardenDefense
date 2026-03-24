using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    class Game
    {
        public RenderWindow window;
        public void init()
        {
            var mode = new VideoMode((800, 600));
            window = new RenderWindow(mode, "Garden Defense");
            window.Closed += (_, _) => window.Close();
        }

        public void run()
        {
            loop();
        }

        public void loop()
        {
            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.White);
                window.Display();
            }
        }
    }
}

