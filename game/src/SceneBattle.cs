using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class SceneBattle : Scene
    {
        public MenuWindow MenuWindowBattle;
        public Button ButtonMenu = new Button(new FloatRect(UI.Battle["ButtonMenu"], UI.ButtonLargeSize), "");

        public SceneBattle(Game game)
        {
            MenuWindowBattle = new MenuWindow();   
        }

        public override void Update(Game game)
        {
            
        }

        public override void Render(Game game)
        {
            RenderFunc.RenderButton(game, ButtonMenu);

            if (game.Menu == true)
            {
                MenuWindowBattle.Render(game);
            }
        }

        public override void MouseUp(Game game, Vector2f pos, Mouse.Button button)
        {
            if (button == Mouse.Button.Left)
            {
                if (game.Menu == false)
                {
                    if (ButtonMenu.IsMouseOver(pos))
                    {
                        game.Menu = true;
                    }
                }
                else
                {
                    if (MenuWindowBattle.ButtonResume.IsMouseOver(pos))
                    {
                        game.Menu = false;
                    }
                    else if (MenuWindowBattle.ButtonExit.IsMouseOver(pos))
                    {
                        game.Menu = false;
                        game.Scene = new SceneTitle(game);
                    }
                    else if (MenuWindowBattle.ButtonQuit.IsMouseOver(pos))
                    {
                        game.Window.Close();
                    }
                }
            }
        }
    }
}
