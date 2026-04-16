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

        public SceneCharacterSelect(Game game)
        {
            TextTitle.Position = UI.CharacterSelect["TextTitle"];
            TextTitle.FillColor = Color.Black;
        }

        public override void Update(Game game)
        {
            
        }

        public override void Render(Game game)
        {
            game.Window.Draw(TextTitle);
            RenderFunc.RenderButton(game, ButtonBack);
            RenderFunc.RenderButton(game, ButtonStart);
        }

        public override void MouseUp(Game game, Vector2f pos, Mouse.Button button)
        {
            if (button == Mouse.Button.Left) {
                if (ButtonBack.IsMouseOver(pos)) {
                    game.Scene = new SceneTitle(game);
                }
            }
        }
    }
}
