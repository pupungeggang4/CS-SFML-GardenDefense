using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    class SceneTitle : Scene
    {
        public SceneTitle()
        {

        }

        public override void Render(Game game)
        {
            Text text = new Text(Asset.neodgm, "Hello", 32);
            text.FillColor = Color.Black;
            game.window.Draw(text);
        }
    }
}
