using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    class SceneTitle : Scene
    {
        public Text TextTitle = new Text(Asset.Neodgm, "Garden Defense", 32);
        public Text TextStart = new Text(Asset.Neodgm, "Start Game", 32);
        public Text TextCollection = new Text(Asset.Neodgm, "Collection", 32);
        public Text TextErase = new Text(Asset.Neodgm, "Erase Data", 32);
        public Text TextQuit = new Text(Asset.Neodgm, "Quit Game", 32);
        public RectangleShape ButtonStart = new RectangleShape(UI.TitleButtonSize);
        public RectangleShape ButtonCollection = new RectangleShape(UI.TitleButtonSize);
        public RectangleShape ButtonErase = new RectangleShape(UI.TitleButtonSize);
        public RectangleShape ButtonQuit = new RectangleShape(UI.TitleButtonSize);

        public SceneTitle()
        {
            TextTitle.Position = UI.Title["text_title"];
            TextTitle.FillColor = Color.Black;
            TextStart.Position = UI.Title["text_start"];
            TextStart.FillColor = Color.Black;
            TextCollection.Position = UI.Title["text_collection"];
            TextCollection.FillColor = Color.Black;
            TextErase.Position = UI.Title["text_erase"];
            TextErase.FillColor = Color.Black;
            TextQuit.Position = UI.Title["text_quit"];
            TextQuit.FillColor = Color.Black;
            ButtonStart.Position = UI.Title["button_start"];
            ButtonStart.FillColor = Color.Yellow;
            ButtonCollection.Position = UI.Title["button_collection"];
            ButtonCollection.FillColor = Color.Cyan;
            ButtonErase.Position = UI.Title["button_erase"];
            ButtonErase.FillColor = Color.Yellow;
            ButtonQuit.Position = UI.Title["button_quit"];
            ButtonQuit.FillColor = Color.Cyan;
        }

        public override void Update(Game game)
        {

        }

        public override void Render(Game game)
        {
            game.Window.Draw(TextTitle);
            game.Window.Draw(ButtonStart);
            game.Window.Draw(TextStart);
            game.Window.Draw(ButtonCollection);
            game.Window.Draw(TextCollection);
            game.Window.Draw(ButtonErase);
            game.Window.Draw(TextErase);
            game.Window.Draw(ButtonQuit);
            game.Window.Draw(TextQuit);
        }

        public override void MouseUp(Game game, Vector2f pos, Mouse.Button button)
        {
            if (button == Mouse.Button.Left)
            {
                if (ButtonStart.GetGlobalBounds().Contains(pos))
                {
                    game.Scene = new SceneCharacterSelect(game);
                }
                else if (ButtonQuit.GetGlobalBounds().Contains(pos))
                {
                    game.Window.Close();
                }
            }
        }
    }
}
