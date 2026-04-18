using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class SceneTitle : Scene
    {
        public Text TextTitle = new Text(Asset.Neodgm, "Garden Defense", 32);
        public Button ButtonStart = new Button(new FloatRect((160.0f, 120.0f), (480.0f, 80.0f)), "Start Game");
        public Button ButtonCollection = new Button(new FloatRect((160.0f, 200.0f), (480.0f, 80.0f)), "Collection");
        public Button ButtonErase = new Button(new FloatRect((160.0f, 280.0f), (480.0f, 80.0f)), "Erase Data");
        public Button ButtonQuit = new Button(new FloatRect((160.0f, 360.0f), (480.0f, 80.0f)), "Quit Game");

        public SceneTitle(Game game)
        {
            TextTitle.Position = UI.Title["TextTitle"];
            TextTitle.FillColor = Color.Black;
            ButtonCollection.Rect.FillColor = Color.Yellow;
            ButtonQuit.Rect.FillColor = Color.Yellow;
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
                if (ButtonStart.IsMouseOver(pos))
                {
                    game.Scene = new SceneCharacterSelect(game);
                }
                if (ButtonCollection.IsMouseOver(pos))
                {
                    game.Scene = new SceneCollection(game);
                }
                else if (ButtonQuit.IsMouseOver(pos))
                {
                    game.Window.Close();
                }
            }
        }
    }
}
