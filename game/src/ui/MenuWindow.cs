using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class MenuWindow : Window
    {
        public RectangleShape Background;
        public Text TextTitle;
        public SimpleButton ButtonResume, ButtonExit, ButtonQuit;

        public MenuWindow()
        {
            Background = new RectangleShape((UI.Menu["Size"][0], UI.Menu["Size"][1]));
            Background.Position = new Vector2f(UI.Menu["Pos"][0], UI.Menu["Pos"][1]);
            Background.FillColor = Color.Cyan;
            TextTitle = new Text(Asset.Neodgm, "Paused", 32);
            TextTitle.Position = new Vector2f(UI.Menu["TextTitle"][0], UI.Menu["TextTitle"][1]);
            TextTitle.FillColor = Color.Black;
            ButtonResume = new SimpleButton(UI.Menu["ButtonResume"], "Resume");
            ButtonResume.Background.FillColor = Color.Yellow;
            ButtonExit = new SimpleButton(UI.Menu["ButtonExit"], "Exit to Title");
            ButtonQuit = new SimpleButton(UI.Menu["ButtonQuit"], "Quit Game");
            ButtonQuit.Background.FillColor = Color.Yellow;
        }

        public void Render(Game game)
        {
            game.Window.Draw(Background);
            game.Window.Draw(TextTitle);
            ButtonResume.Render(game);
            ButtonExit.Render(game);
            ButtonQuit.Render(game);
        }
    }
}
