using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class SceneCharacterSelect : Scene
    {
        public Text TextTitle = new Text(Asset.Neodgm, "Select character", 32);
        public Button ButtonBack = new Button(new FloatRect(UI.CharacterSelect["ButtonBack"], UI.ButtonLargeSize), "");
        public Button ButtonStart = new Button(new FloatRect(UI.CharacterSelect["ButtonStart"], UI.ButtonLargeWideSize), "Start");
        public Button[] ButtonCharacter = new Button[6];

        public int SelectedCharacter = -1;

        public SceneCharacterSelect(Game game)
        {
            TextTitle.Position = UI.CharacterSelect["TextTitle"];
            TextTitle.FillColor = Color.Black;

            for (int i = 0; i < 6; i++)
            {
                int row = i / 3;
                int col = i % 3;
                Vector2f pos = new Vector2f(UI.CharacterSelect["ButtonCharacterStart"].X, UI.CharacterSelect["ButtonCharacterStart"].Y);
                pos.X += UI.CharacterSelect["ButtonCharacterInterval"].X * col;
                pos.Y += UI.CharacterSelect["ButtonCharacterInterval"].Y * row;
                FloatRect rect = new FloatRect(pos, UI.CharacterSelect["ButtonCharacterSize"]);
                ButtonCharacter[i] = new Button(rect, "");
            }
        }

        public override void Update(Game game)
        {
        }

        public override void Render(Game game)
        {
            game.Window.Draw(TextTitle);
            RenderFunc.RenderButton(game, ButtonBack);
            RenderFunc.RenderButton(game, ButtonStart);

            for (int i = 0; i < 6; i++)
            {
                RenderFunc.RenderButton(game, ButtonCharacter[i]);
            }
        }

        public override void MouseUp(Game game, Vector2f pos, Mouse.Button button)
        {
            if (button == Mouse.Button.Left)
            {
                if (ButtonBack.IsMouseOver(pos))
                {
                    game.Scene = new SceneTitle(game);
                }

                for (int i = 0; i < 6; i++)
                {
                    if (ButtonCharacter[i].IsMouseOver(pos))
                    {
                        SelectedCharacter = i;
                    }
                }

                if (ButtonStart.IsMouseOver(pos))
                {
                    if (SelectedCharacter != -1)
                    {
                        game.Scene = new SceneBattle(game);
                    }
                }
            }
        }
    }
}
