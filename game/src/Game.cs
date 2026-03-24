using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    class Game
    {
        public RenderWindow window;
        public uint width, height;
        public void init()
        {
            var monitor = VideoMode.DesktopMode;
            if (monitor.Size.X > 2560) {
                width = 1600; height = 1200;
            } else if (monitor.Size.X > 1920) {
                width = 1200; height = 900;
            } else {
                width = 800; height = 600;
            }
            var mode = new VideoMode((width, height));
            window = new RenderWindow(mode, "Garden Defense");
            window.Closed += (sender, e) => window.Close();
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

