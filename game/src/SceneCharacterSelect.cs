using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class SceneCharacterSelect : Scene
    {

        public Text TextTitle = new Text(Asset.Neodgm, "Select character", 32);
        public RectangleShape ButtonBack = new RectangleShape(UI.ButtonLargeSize);

        public SceneCharacterSelect(Game game)
        {
            TextTitle.Position = UI.CharacterSelect["TextTitle"];
            TextTitle.FillColor = Color.Black;
            ButtonBack.Position = UI.CharacterSelect["ButtonBack"];
            ButtonBack.FillColor = Color.Yellow;
        }

        public override void Update(Game game)
        {
            
        }

        public override void Render(Game game)
        {
            game.Window.Draw(TextTitle);
            game.Window.Draw(ButtonBack); 
        }

        public override void MouseUp(Game game, Vector2f pos, Mouse.Button button)
        {
            if (button == Mouse.Button.Left) {
                if (ButtonBack.GetGlobalBounds().Contains(pos)) {
                    game.Scene = new SceneTitle(game);
                }
            }
        }
    }
}
