using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO;
using System.ComponentModel;

namespace PWPlanner.TileTypes
{
    public class Background : Tile
    {
        public override int ZIndex
        {
            get { return 1; }
        }

        public Background() { }

        public Background(Image image)
        {
            Image = image;
        }

        public static BackgroundName GetBackgroundNameByString(string fileName)
        {
            fileName = Path.GetFileNameWithoutExtension(fileName);
            if (Enum.TryParse(fileName, out BackgroundName name))
            {
                return name;
            }
            else
            {
                return BackgroundName.NONE;
            }

        }

        public override Tile Clone(Image image)
        {
            var bg = new Background();
            bg.Image = image;
            bg.TileName = this.TileName;
            return bg;
        }

        public enum BackgroundName
        {
            ArmoredBackground,
            BambooWall,
            BarredWindow1,
            BarredWindow2,
            BarredWindow3,
            BarredWindow4,
            BlackDiagonalChecker,
            BlackIronBackground1,
            BlackIronBackground2,
            BlackMetalSheet,
            BlackTile,
            BlueBigTile,
            BlueDiagonalChecker,
            BlueNeonBackground,
            BlueSpheresBackground,
            BlueTangleWallpaper,
            BlueTile,
            BlueXmasWallpaper,
            BrokenRuinBackground,
            BrownBigTile,
            BrownBrickWallpaper,
            BrownIronBackground1,
            BrownIronBackground2,
            BrownVegetationBackground,
            BurntBackground,
            CandyBackground,
            CandyLaceBackground,
            CastleWallpaper,
            CastleWallTile,
            CastleWindow,
            CaveWall,
            ChocolateBackground,
            CloverleafWindow,
            CloverWallpaper,
            ClownWallpaper,
            DarkUrbanBackground1,
            DarkUrbanBackground2,
            DarkUrbanBackground3,
            DirtyHerringbone,
            DirtyWall1,
            DirtyWall2,
            DollarBackground,
            DungeonBars,
            DungeonWall,
            EctoplasmBackground,
            ElvenBrickBackground,
            ElvenShinglesWallpaper,
            ElvenTileBackground,
            ElvenWindow1,
            ElvenWindow2,
            ElvenWindow3,
            ElvenWindow4,
            ElvenWindow5,
            ElvenWindow6,
            FlowerWallpaper,
            GhostBackground,
            GlassTile,
            GreenBigTile,
            GreenGiftwrap,
            GreenGlowWire,
            GreenNeonBackground,
            GreenScreen,
            GreenSpheresBackground,
            GreenTile,
            GreyBigTile,
            GreyBrickWallpaper,
            GreyDotIllusion,
            GreyHerringbone,
            GreyIronBackground1,
            GreyIronBackground2,
            GreySpheresBackground,
            HeartWallpaper,
            HoneycombBackground,
            IceBackground,
            ImperialWallpaper,
            IndentedElvenBackground1,
            IndentedElvenBackground2,
            IndentedElvenBackground3,
            IndentedPurpleBackground1,
            IndentedPurpleBackground2,
            IndentedPurpleBackground3,
            JailBackground,
            LavaBackground,
            LightBlueWallpaper,
            LightWoodenBackground,
            MeltedChocolate,
            MetalBackground1,
            MetalBackground2,
            MetalBackground3,
            MetalBeamsBackground,
            MoneyBackground,
            NonSlipMetal,
            OrangeGlowWire,
            OrangeNeonBackground,
            OrangeTile,
            PatterbedMetalBackground,
            PinkTile,
            PurpleBrickBackground,
            PurpleTileBackground,
            RainbowWallpaper,
            RedBigTile,
            RedBrickWallpaper,
            RedDiagonalChecker,
            RedDotIllusion,
            RedSpheresBackground,
            RedTile,
            RedVelvetBackground,
            RedWallpaper,
            RedXmasWallpaper,
            RoundMoire,
            RuinBackground,
            RuinTileBackground,
            RuneBackground,
            SamuraiBackground,
            SandyCaveWall,
            ScaffoldBackground1,
            ScaffoldBackground2,
            ScifiBackground1,
            ScifiBackground2,
            ScifiBackground3,
            ScifiBackground4,
            Shoji,
            SilverVegetationBackground,
            SkyscrapperWindow1,
            SkyscrapperWindow2,
            SkyscrapperWindow3,
            SkyscrapperWindow4,
            SlimyBackground,
            SpheresWallpaper,
            SpiralMosaic,
            SquareMoire,
            StarryWallpaper,
            StoneBackground,
            StoreWindow1,
            StoreWindow2,
            StoreWindow3,
            StripesWallpaper,
            TilesWallpaper,
            TintedWindowFrame,
            TornWallpaper,
            UnholyBackground,
            UrbanBackground1,
            UrbanBackground2,
            UrbanBackground3,
            VegetationBackground,
            VikingStoneBackground,
            VioletNeonBackground,
            WhiteStripedWallpaper,
            WhiteTangleWallpaper,
            WhiteTile,
            WindowFrame,
            WirefenceBackground,
            WoodenBackground,
            WoodenBeamBackground,
            WoodenPolesBackground,
            WoodenWindowFrame,
            YellowBrickWallpaper,
            YellowTile,
            AlienCaveWall,
            DarkNanotechWall1,
            DarkNanotechWall2,
            DarkNanotechWall3,
            DarkNanotechWall4,
            DarkNanotechWall5,
            DarkNanotechWall6,
            DarkNanotechWindow,
            PurpleNanotechWall1,
            PurpleNanotechWall2,
            PurpleNanotechWall3,
            PurpleNanotechWall4,
            PurpleNanotechWall5,
            PurpleNanotechWall6,
            BasicButton,
            BasicSwitch,
            BigRedButton,
            CampingTent,
            ColaFridge,
            ConstantFlameTrap1,
            ConstantFlameTrap2,
            ConstantFlameTrap3,
            ConstantFlameTrap4,
            ConstantPoisonTrap1,
            ConstantPoisonTrap2,
            ConstantPoisonTrap3,
            ConstantPoisonTrap4,
            DisappearingBlock,
            FireballTriggerTrap1,
            FireballTriggerTrap2,
            FireballTriggerTrap3,
            FireballTriggerTrap4,
            GreenRedLight,
            GiantPalmTree1,
            GiantPalmTree2,
            GiantPalmTree3,
            GiantPalmTree4,
            OnOffLight,
            OutHouse,
            PressurePad,
            ProximitySensor,
            PowerSwitch,
            RedWarningLight1,
            RedWarningLight2,
            ScifiButton,
            ScifiLever,
            StoneButton,
            SpikeTriggerTrap1,
            SpikeTriggerTrap2,
            SpikeTriggerTrap3,
            SpikeTriggerTrap4,
            SoapBubbleMachine,
            WoodenGroundLever,
            WoodenLever,
            WiredMetalTrapdoor,
            NONE
        }
    }
}
