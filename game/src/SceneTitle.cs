using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class SceneTitle : Scene
    {
        public Text TextTitle = new Text(Asset.Neodgm, "Garden Defense", 32);
        public SimpleButton ButtonStart = new SimpleButton(UI.Title["ButtonStart"], "Start Game");
        public SimpleButton ButtonCollection = new SimpleButton(UI.Title["ButtonCollection"], "Collection");
        public SimpleButton ButtonErase = new SimpleButton(UI.Title["ButtonErase"], "Erase Data");
        public SimpleButton ButtonQuit = new SimpleButton(UI.Title["ButtonQuit"], "Quit Game");

        public SceneTitle(Game game)
        {
            TextTitle.Position = new Vector2f(UI.Title["TextTitle"][0], UI.Title["TextTitle"][1]);
            TextTitle.FillColor = Color.Black;
            ButtonCollection.Background.FillColor = Color.Yellow;
            ButtonQuit.Background.FillColor = Color.Yellow;
        }

        public override void Update(Game game)
        {

        }

        public override void Render(Game game)
        {
            game.Window.Draw(TextTitle);
            ButtonStart.Render(game);
            ButtonCollection.Render(game);
            ButtonErase.Render(game);
            ButtonQuit.Render(game);
        }

        public override void MouseUp(Game game, Vector2f pos, Mouse.Button button)
        {
            if (button == Mouse.Button.Left)
            {
                if (ButtonStart.Contains(pos))
                {
                    game.Scene = new SceneCharacterSelect(game);
                }
                if (ButtonCollection.Contains(pos))
                {
                    game.Scene = new SceneCollection(game);
                }
                else if (ButtonQuit.Contains(pos))
                {
                    game.Window.Close();
                }
            }
        }
    }
}
