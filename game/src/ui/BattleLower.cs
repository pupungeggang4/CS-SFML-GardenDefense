using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace GardenDefense
{
    public class BattleLower
    {
        public TextureButton ButtonUpgrade;
        public Text LevelText;
        public Text EnergyText;
        public RectangleShape EnergyBar;

        public BattleLower()
        {
            ButtonUpgrade = new TextureButton(new Vector2f(20, 500), Asset.ButtonUpgrade);
            LevelText = new Text(Asset.Neodgm, "Lv.1", 20);
            LevelText.Position = new Vector2f(UI.Battle["LevelText"].X, UI.Battle["LevelText"].Y);
            LevelText.FillColor = Color.Black;
            EnergyText = new Text(Asset.Neodgm, "6.0/6.0", 20);
            EnergyText.Position = new Vector2f(UI.Battle["EnergyText"].X, UI.Battle["EnergyText"].Y);
            EnergyText.FillColor = Color.Black;
            EnergyBar = new RectangleShape(new Vector2f(UI.Battle["EnergyBarSize"].X, UI.Battle["EnergyBarSize"].Y));
            EnergyBar.Position = new Vector2f(UI.Battle["EnergyBar"].X, UI.Battle["EnergyBar"].Y);
            EnergyBar.FillColor = new Color(255, 127, 0, 255);
        }

        public void Render(Game game)
        {
            ButtonUpgrade.Render(game);
            game.Window.Draw(LevelText);
            game.Window.Draw(EnergyText);
            game.Window.Draw(EnergyBar);
        }
    }
}
