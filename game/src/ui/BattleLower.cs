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
            LevelText.Position = new Vector2f(UI.Battle["LevelText"][0], UI.Battle["LevelText"][1]);
            LevelText.FillColor = Color.Black;
            EnergyText = new Text(Asset.Neodgm, "6.0/6.0", 20);
            EnergyText.Position = new Vector2f(UI.Battle["EnergyText"][0], UI.Battle["EnergyText"][1]);
            EnergyText.FillColor = Color.Black;
            EnergyBar = new RectangleShape((UI.Battle["EnergyBarSize"][0], UI.Battle["EnergyBarSize"][1]));
            EnergyBar.Position = new Vector2f(UI.Battle["EnergyBar"][0], UI.Battle["EnergyBar"][1]);
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
