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
        public Button ButtonResume, ButtonExit, ButtonQuit;

        public MenuWindow()
        {
            Background = new RectangleShape(UI.Menu["Size"]);
            Background.Position = new Vector2f(UI.Menu["Pos"].X, UI.Menu["Pos"].Y);
            Background.FillColor = Color.Cyan;
            TextTitle = new Text(Asset.Neodgm, "Paused", 32);
            TextTitle.Position = new Vector2f(UI.Menu["TextTitle"].X, UI.Menu["TextTitle"].Y);
            TextTitle.FillColor = Color.Black;
            ButtonResume = new Button(new FloatRect(UI.Menu["ButtonResume"], UI.MenuButtonSize), "Resume");
            ButtonResume.Rect.FillColor = Color.Yellow;
            ButtonExit = new Button(new FloatRect(UI.Menu["ButtonExit"], UI.MenuButtonSize), "Exit to Title");
            ButtonQuit = new Button(new FloatRect(UI.Menu["ButtonQuit"], UI.MenuButtonSize), "Quit Game");
            ButtonQuit.Rect.FillColor = Color.Yellow;
        }

        public void Render(Game game)
        {
            game.Window.Draw(Background);
            game.Window.Draw(TextTitle);
            RenderFunc.RenderButton(game, ButtonResume);
            RenderFunc.RenderButton(game, ButtonExit);
            RenderFunc.RenderButton(game, ButtonQuit);
        }
    }
}