using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO;

namespace PWPlanner.TileTypes
{
    public class Special : Tile
    {
        public override int ZIndex
        {
            get { return 10; }
        }

        public Special() { }

        public Special(Image image)
        {
            Image = image;
        }

        public static SpecialName GetSpecialNameByString(string fileName)
        {
            fileName = Path.GetFileNameWithoutExtension(fileName);

            if (Enum.TryParse(fileName, out SpecialName name))
            {
                return name;
            }
            else
            {
                return SpecialName.NONE;
            }

        }

        public override Tile Clone(Image image)
        {
            var fg = new Special();
            fg.Image = image;
            fg.TileName = this.TileName;
            return fg;
        }

        public enum SpecialName
        {
            Acid,
            Acidalt,
            DarkFog,
            DarkFogalt,
            DarkRiverWater,
            DarkRiverWateralt,
            FakeBlood,
            FakeBloodalt,
            Fog,
            Fogalt,
            Quicksand,
            Quicksandalt,
            Water,
            Wateralt,
            Acidfall1,
            Acidfall2,
            Acidfall3,
            Bloodfall,
            Bloodfall1,
            Bloodfall2,
            Bloodfall3,
            DarkRiverWaterfall,
            DarkRiverWaterfall1,
            DarkRiverWaterfall2,
            DarkRiverWaterfall3,
            Waterfall,
            Waterfall1,
            Waterfall2,
            Waterfall3,
            NONE
        }
    }
}
