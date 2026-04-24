using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class SceneCharacterSelect : Scene
    {
        public Text TextTitle = new Text(Asset.Neodgm, "Select character", 32);
        public SimpleButton ButtonBack = new SimpleButton(UI.CharacterSelect["ButtonBack"], "");
        public SimpleButton ButtonStart = new SimpleButton(UI.CharacterSelect["ButtonStart"], "Start");
        public SimpleButton[] ButtonCharacter = new SimpleButton[6];

        public int SelectedCharacter = -1;

        public SceneCharacterSelect(Game game)
        {
            TextTitle.Position = new Vector2f(UI.CharacterSelect["TextTitle"][0], UI.CharacterSelect["TextTitle"][1]);
            TextTitle.FillColor = Color.Black;

            for (int i = 0; i < 6; i++)
            {
                int row = i / 3;
                int col = i % 3;
                List<float> rect = [
                    UI.CharacterSelect["ButtonCharacterStart"][0] + UI.CharacterSelect["ButtonCharacterInterval"][0] * col,
                    UI.CharacterSelect["ButtonCharacterStart"][1] + UI.CharacterSelect["ButtonCharacterInterval"][1] * row,
                    UI.CharacterSelect["ButtonCharacterSize"][0], UI.CharacterSelect["ButtonCharacterSize"][1]
                ];
                ButtonCharacter[i] = new SimpleButton(rect, "");
            }
        }

        public override void Update(Game game)
        {
        }

        public override void Render(Game game)
        {
            game.Window.Draw(TextTitle);
            ButtonBack.Render(game);
            ButtonStart.Render(game);

            for (int i = 0; i < 6; i++)
            {
                ButtonCharacter[i].Render(game);
            }
        }

        public override void MouseUp(Game game, Vector2f pos, Mouse.Button button)
        {
            if (button == Mouse.Button.Left)
            {
                if (ButtonBack.Contains(pos))
                {
                    game.Scene = new SceneTitle(game);
                }

                for (int i = 0; i < 6; i++)
                {
                    if (ButtonCharacter[i].Contains(pos))
                    {
                        SelectedCharacter = i;
                    }
                }

                if (ButtonStart.Contains(pos))
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
