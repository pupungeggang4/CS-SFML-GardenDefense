using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class SceneBattle : Scene
    {
        public MenuWindow MenuWindowBattle;
        public RewardWindow RewardWindowBattle;
        public SimpleButton ButtonMenu = new SimpleButton(UI.Battle["ButtonMenu"], "");
        public BattleLower BattleLowerUI;

        public SceneBattle(Game game)
        {
            MenuWindowBattle = new MenuWindow();
            BattleLowerUI = new BattleLower();
        }

        public override void Update(Game game)
        {
            
        }

        public override void Render(Game game)
        {
            ButtonMenu.Render(game);
            BattleLowerUI.Render(game);

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
                    if (ButtonMenu.Contains(pos))
                    {
                        game.Menu = true;
                    }
                }
                else
                {
                    if (MenuWindowBattle.ButtonResume.Contains(pos))
                    {
                        game.Menu = false;
                    }
                    else if (MenuWindowBattle.ButtonExit.Contains(pos))
                    {
                        game.Menu = false;
                        game.Scene = new SceneTitle(game);
                    }
                    else if (MenuWindowBattle.ButtonQuit.Contains(pos))
                    {
                        game.Window.Close();
                    }
                }
            }
        }
    }
}
