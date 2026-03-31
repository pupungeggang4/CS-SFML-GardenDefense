using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    class Game
    {
        public RenderWindow Window;
        public View ViewUI;
        public uint Width, Height;

        public Scene Scene;
        public string State;

        public void Init()
        {
            var monitor = VideoMode.DesktopMode;
            if (monitor.Size.X * 3 / 4 > monitor.Size.Y) {
                Height = (uint)(monitor.Size.Y * 0.8);
                Width = Height * 4 / 3;
            } else {
                Width = (uint)(monitor.Size.X * 0.8);
                Height = Width * 3 / 4;
            }
            var mode = new VideoMode((Width, Height));
            ViewUI = new View(new FloatRect((0, 0), (800, 600)));
            Window = new RenderWindow(mode, "Garden Defense");
            Window.SetView(ViewUI);
            Window.Closed += (sender, e) => Window.Close();
            Window.MouseButtonReleased += (sender, e) => MouseUp(sender, e);
        }

        public void Run()
        {
            Scene = new SceneTitle(this);
            Loop();
        }

        public void Loop()
        {
            while (Window.IsOpen)
            {
                Window.DispatchEvents();
                Scene.Update(this);
                Window.Clear(Color.White);
                Scene.Render(this);
                Window.Display();
            }
        }

        public void MouseUp(object sender, MouseButtonEventArgs e)
        {
            Vector2f pos = new Vector2f(e.Position.X * 800 / Width, e.Position.Y * 600 / Height);
            Scene.MouseUp(this, pos, e.Button);
        }
    }
}

