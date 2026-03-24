using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    class Game
    {
        public RenderWindow window;
        public View viewUI;
        public uint width, height;

        public Scene scene;
        public string state;

        public void Init()
        {
            var monitor = VideoMode.DesktopMode;
            if (monitor.Size.X > 2560)
            {
                width = 1600; height = 1200;
            }
            else if (monitor.Size.X > 1920)
            {
                width = 1200; height = 900;
            }
            else
            {
                width = 800; height = 600;
            }
            var mode = new VideoMode((width, height));
            viewUI = new View(new FloatRect((0, 0), (800, 600)));
            window = new RenderWindow(mode, "Garden Defense");
            window.SetView(viewUI);
            window.Closed += (sender, e) => window.Close();
        }

        public void Run()
        {
            scene = new SceneTitle();
            Loop();
        }

        public void Loop()
        {
            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.White);
                Render();
                window.Display();
            }
        }

        public void Render()
        {
            scene.Render(this);
        }
    }
}

