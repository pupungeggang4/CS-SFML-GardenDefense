using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class SceneCollection : Scene
    {
        public SimpleButton ButtonBack;

        public SceneCollection(Game game)
        {
            ButtonBack = new SimpleButton(UI.Collection["ButtonBack"], "");
        }

        public override void Update(Game game)
        {
            
        }

        public override void Render(Game game)
        {
            ButtonBack.Render(game);
        }

        public override void MouseUp(Game game, Vector2f pos, Mouse.Button button)
        {
            if (button == Mouse.Button.Left)
            {
                if (ButtonBack.Contains(pos))
                {
                    game.Scene = new SceneTitle(game);
                }
            }
        }
    }
}
