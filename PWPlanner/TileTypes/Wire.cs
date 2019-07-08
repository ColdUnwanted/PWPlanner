using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO;

namespace PWPlanner.TileTypes
{
    public class Wire : Tile
    {
        public override int ZIndex
        {
            get { return 20; }
        }

        public Wire() { }

        public Wire(Image image)
        {
            Image = image;
        }

        public static WireName GetSpecialNameByString(string fileName)
        {
            fileName = Path.GetFileNameWithoutExtension(fileName);

            if (Enum.TryParse(fileName, out WireName name))
            {
                return name;
            }
            else
            {
                return WireName.NONE;
            }

        }

        public override Tile Clone(Image image)
        {
            var fg = new Wire();
            fg.Image = image;
            fg.TileName = this.TileName;
            return fg;
        }

        public enum WireName
        {
            ANDGate,
            DELAYTIMERGate,
            NANDGate,
            NORGate,
            NOTGate,
            ORGate,
            RANDOMIZERGate,
            SIGNALDIVIDERGate,
            SIGNALHOLDERGate,
            TIMERGate,
            TOGGLEGate,
            XNORGate,
            XORGate,
            NONE
        }
    }
}
