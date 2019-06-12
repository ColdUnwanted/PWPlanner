﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO;

namespace PWPlanner.TileTypes
{
    public class Foreground : Tile
    {
        public override int ZIndex
        {
            get { return 5; }
        }

        public Foreground() { }

        public Foreground(Image image)
        {
            Image = image;
        }

        public static ForegroundName GetForegroundNameByString(string fileName)
        {
            fileName = Path.GetFileNameWithoutExtension(fileName);

            if (Enum.TryParse(fileName, out ForegroundName name))
            {
                return name;
            }
            else
            {
                return ForegroundName.NONE;
            }

        }

        public override Tile Clone(Image image)
        {
            var fg = new Foreground();
            fg.Image = image;
            fg.TileName = this.TileName;
            return fg;
        }

        public enum ForegroundName
        {
            AlabasterPillar,
            AlienEye,
            AnniversaryCake,
            AnniversaryCake2yo,
            AnniversaryHamRadio,
            AnniversaryPortal,
            AntiqueChair,
            AntiqueTable,
            ArmChair,
            ArrowSign1,
            ArrowSign2,
            ArrowSign3,
            ArrowSign4,
            AshenSoil,
            AshenSoilalt,
            Bamboo,
            BarStool,
            Bathtub,
            BattleGate,
            BattleGatealt,
            BattleLock,
            BattleScoreboard,
            BattleWorldLock,
            BBB,
            BBBGraffiti1,
            BBBGraffiti2,
            Bed,
            Bedrock,
            BedrockFlat,
            BedrockLava,
            BeigeBrick,
            BirthdayCake,
            BlackBlock,
            BlackBrick,
            BlackCandles,
            BlackPennant,
            BloodSplash,
            BloodyChest,
            BloodyClawMarks,
            BlueBlock,
            BlueBrick,
            BlueCandyBlock,
            BlueCanopy,
            BlueEasterBlock,
            BlueEasterEgg,
            BlueGlowBlock,
            BlueJelly,
            BlueMetalChair,
            BluePortal,
            BlueRoyalEgg,
            BlueRunestone,
            BlueSunUmbrella,
            BoneGate,
            BoneGatealt,
            Bonfire,
            BookPodium,
            Bookshelf,
            Boombox,
            BowlofJellyBeans,
            Brazier,
            BrokenRuinTile,
            BronzeBabyCupTrophy,
            BronzeFishermansCupTrophy,
            BronzeGoblet,
            BronzeMedal,
            BronzeProCupTrophy,
            BrownBlock,
            BrownVegetationBlock,
            BubblegumMachine,
            Bumper,
            BunnyLoco,
            Bush,
            Buzzsaw,
            Cabinet,
            Cactus,
            Campfire,
            CandleStand,
            CandyCaneBlock,
            CandyPipe,
            CandySpikes1,
            CandySpikes2,
            CandySpikes3,
            CandySpikes4,
            CandySpiralBlock,
            CandyWatermelonBlock,
            CastleDoor,
            CastleWall,
            CelticColumn1,
            CelticColumn2,
            CelticColumn3,
            CelticCross,
            Chains,
            ChaosBanner,
            ChaosLightCrystal,
            ChaosThrone,
            Checkpoint,
            CheeseBlock,
            ChemistryPoster,
            CherryBonsai,
            ChocoDecoBlock,
            ChurchBell,
            CircuitBoard,
            ClassicPainting,
            ClassicSculpture,
            ClassicSculpturealt,
            ClayPot,
            ClearJelly,
            CloudPlatform,
            CloverleafBlock,
            CoalBlock,
            CoatRack,
            CobraStatue,
            Coffin,
            ConcreteBlock1x1,
            ConcreteBlock2x1,
            ConcreteBlock2x2,
            ConcretePlatform,
            ConstructionBarricade,
            CookieBlock,
            Corn,
            CrackedPottery,
            CubistPainting,
            CupidStatue,
            CyanCandyBlock,
            DaHoodSign,
            DarkBridge1,
            DarkBridge2,
            DarkBridge3,
            DarkChocolateBlock,
            DarkDrainPipe1,
            DarkDrainPipe2,
            DarkDrainPipe3,
            DarkElectricWires1,
            DarkElectricWires2,
            DarkElectricWires3,
            DarkElectricWires4,
            DarkElectricWires5,
            DarkElectricWires6,
            DarkRedBlock,
            DarkRoyalEgg,
            DarkSign1,
            DarkSign2,
            DarkStoneBlock1,
            DarkStoneBlock1alt,
            DarkStoneBlock2,
            DarkStoneBlock2alt,
            DarkStoneBlock3,
            DarkStoneBlock3alt,
            DarkSupportBeam1,
            DarkSupportBeam2,
            DarkWorldLock,
            DeathCounter,
            DecorativeSword,
            Deflector,
            DemonAltar,
            DesktopPC,
            Diploma,
            DiscoBall,
            DiscoBlock,
            DisplayCase,
            Door,
            DottedPinkBlock,
            DragonFossil1,
            DragonFossil2,
            DragonFossil3,
            DragonFossil4,
            DragonFossil5,
            DragonFossil6,
            DragonFossil7,
            DrippingBlood,
            DrippingSlimeCorner,
            DrippingSlimeTop,
            DungeonDoor,
            EasterChicks,
            EasterEggBasket,
            EbenWoodChest,
            ElectricChair,
            ElectricitySign,
            ElectricTrap1,
            ElectricTrap2,
            ElectricTrap3,
            ElectricTrap4,
            ElvenBanner,
            ElvenBlock1,
            ElvenBlock1alt,
            ElvenBlock2,
            ElvenBlock2alt,
            ElvenBlock3,
            ElvenBlock3alt,
            ElvenBlock4,
            ElvenBlock4alt,
            ElvenBridge1,
            ElvenBridge2,
            ElvenBridge3,
            ElvenFence,
            ElvenLightCrystal,
            ElvenSign1,
            ElvenSign2,
            ElvenThrone,
            EntrancePortal,
            EvilSpikeTrap1,
            EvilSpikeTrap2,
            EvilSpikeTrap3,
            EvilSpikeTrap4,
            Evolverator,
            ExclamationSign,
            FallingSign,
            FamiliarFoodMachine,
            FancyTombstone,
            FavouriteHologram,
            FinishLine,
            FINPennant,
            FireballShooterTrap1,
            FireballShooterTrap2,
            FireballShooterTrap3,
            FireballShooterTrap4,
            FireBarrel,
            Firefly,
            FireHydrant,
            Fireplace,
            FireTrap1,
            FireTrap2,
            FireTrap3,
            FireTrap4,
            FishBarrel,
            Fishbowl,
            FishingScoreboard,
            FishTank,
            FlatScreenTV,
            FloorLamp,
            FloorSpotlight,
            FlowerofSummer,
            Fountain,
            FrankensteinBlock,
            Fridge,
            FrostedSoilBlock,
            FrostedSoilBlockalt,
            FruitTray,
            Fungi,
            FuseCabinet,
            GardenGnome,
            Gargoyle,
            GemSoil,
            GemSoilalt,
            GhostTrap,
            GiantClamChest,
            GiantEasterEgg,
            GingerbreadBlock,
            GingerbreadFence,
            GingerbreadSign,
            GlassBlock,
            GlassCabinet,
            GlassDoor,
            GlowingContainer,
            GlueBlock,
            GlueBlockalt,
            GluePlatform,
            GoldenBabyCupTrophy,
            GoldenConeStatue,
            GoldenFishermansCupTrophy,
            GoldenHorseshoe,
            GoldenPopsicleStatue,
            GoldenProCupTrophy,
            GoldenSkullBlock,
            GoldenToilet,
            Gramophone,
            Granite,
            Granitealt,
            Grass,
            GraveSlant,
            Gravestone,
            GravityModifier,
            GreenBlock,
            GreenBrick,
            GreenCandyBlock,
            GreenEasterBlock,
            GreenGlowBlock,
            GreenGummyBear,
            GreenJelly,
            GreenMetalChair,
            GreenMushroom,
            GreenPennant,
            GreenPipeBlock1,
            GreenPipeBlock2,
            GreenPipeBlock3,
            GreenPipeBlock4,
            GreenRunestone,
            GreenStereos,
            GreenXmasRibbon,
            GreyBlock,
            GreyBrick,
            GreyFireStairs1,
            GreyFireStairs2,
            GreyFireStairs3,
            GreyFireStairs4,
            GreyFireStairs5,
            HamRadio,
            HangingBat,
            HangingHearts,
            HangingLeaves,
            HangingSkull,
            HangingWires1,
            HangingWires2,
            HauntedMirror,
            HazardBlock,
            HazardPlatform,
            Headstone,
            HeartBlock,
            HeartDecoration,
            HeartGraffiti1,
            HeartGraffiti2,
            HeartGraffiti3,
            HeartGraffiti4,
            HeartGraffiti5,
            HeartGraffiti6,
            HeartGraffiti7,
            HeartGraffiti8,
            HeartGraffiti9,
            HeartSign,
            HeartTrap1,
            HeartTrap2,
            HeartTrap3,
            HeartTrap4,
            HeavyMetalPoster,
            HelloBot,
            HeroicPinballBumper,
            HeroicSpringBoard1,
            HeroicSpringBoard2,
            HeroicSpringBoard3,
            HeroicSpringBoard4,
            Hokora,
            HollyWreath,
            HotTub,
            HousePlant,
            HugeMetalFan1,
            HugeMetalFan2,
            HugeRedFan1,
            HugeRedFan2,
            Ice,
            IceCreamSign,
            IcePlatform,
            Icicles,
            IndustrialFan,
            IrishBalloons,
            IrishPennantString,
            IronBlock,
            IronChandelier,
            IronFence,
            IronThrone,
            JackoLantern,
            JakeGraffiti1,
            JakeGraffiti2,
            JakeGraffiti3,
            JakeGraffiti4,
            JungleGrass,
            KatanaDecoration,
            KettleGrill,
            KiddieRide,
            KiwiBlock,
            LabControlPanel1,
            LabControlPanel2,
            LabEquipment1,
            LabEquipment2,
            LabEquipment3,
            LabHose1,
            LabHose2,
            LabMeter,
            Lantern,
            LargeBush,
            LargeLock,
            LargeSandCastle,
            LaserBeamTrap1,
            LaserBeamTrap2,
            LaserBeamTrap3,
            LaserBeamTrap4,
            LaserTrap1,
            LaserTrap2,
            LaserTrap3,
            LaserTrap4,
            Lava,
            LavaLamp,
            LeaningPlanks,
            LEDSign,
            LegendarySoilBlock,
            LegendarySoilBlockalt,
            LemonadeKeg,
            LeopardArmchair,
            LeprechaunGnome,
            LevelDoor,
            LevelHatch,
            LevelVIPDoor,
            LevelVIPHatch,
            Lifebuoy,
            LightBlueBlock,
            LightBlueJelly,
            LightDrainPipe1,
            LightDrainPipe2,
            LightDrainPipe3,
            LightPavement,
            LightPavementalt,
            LightSupportBeam1,
            LightSupportBeam2,
            Lily,
            LiquorishBlock,
            LuckyCloverleaf,
            LuckyHorseshoe,
            MagicStuff,
            MagLift,
            MakeupTable,
            ManekiNekoL,
            ManekiNekoR,
            Mannequin,
            Marble,
            MarbleFireplace,
            MayanStatue,
            MediumLock,
            MediumSandCastle,
            MetalBarrel,
            MetalBeamBlock1,
            MetalBeamBlock2,
            MetalBeamPlatform,
            MetalHatch,
            MetalPlate,
            MetalPlatform,
            MetalRailing,
            MetalRingBlock,
            MetalSlant,
            MetalTrapDoor,
            Microwave,
            MilkChocolateBlock,
            Mimic,
            MinatureSpaceship,
            MirrorWardrobe,
            Moai,
            ModernPainting,
            MossyRuinTile,
            Mushroom,
            NeonHeart,
            NetherCrystal,
            NetherGraffiti1,
            NetherGraffiti2,
            NetherGraffiti3,
            NetherGraffiti4,
            NetherGraffiti5,
            NetherGraffiti6,
            NoteBoard,
            Obisidian,
            OldAltar,
            OldBrickPile,
            OldTV,
            OldTyres,
            OldWallLamp,
            OpenSign,
            OrangeBlock,
            OrangeEasterEgg,
            OrangeGlowBlock,
            OrangeGummyBear,
            OrangeJelly,
            OrangeRoyalEgg,
            OrangeRunestone,
            OuijaBoard,
            Oven,
            Palisade,
            ParrotCage,
            PhoneLinePole1,
            PhoneLinePole2,
            PhoneLinePole3,
            PicnicTable,
            PileOfMoney,
            Pinata,
            PineappleBlock,
            PineappleBlockalt,
            PinkBlock,
            PinkBrick,
            PinkCandyBlock,
            PinkJelly,
            PinkMetalChair,
            PinkRose,
            PixieDust,
            PlainPoster,
            PlatinumLock,
            PoisonTrap,
            PoisonTrap1,
            PoisonTrap2,
            PoisonTrap3,
            Poop,
            Portal,
            PotofGold,
            PottedPlant,
            PrizeBox,
            PurpleBlock,
            PurpleEasterBlock,
            PurpleJelly,
            PurpleSunUmbrella,
            PWETerminal,
            PWGraffiti1,
            PWGraffiti2,
            PWGraffiti3,
            PWGraffiti4,
            PWGraffiti5,
            PWGraffiti6,
            QuantumSafe,
            RadiatingNuke,
            RatingBoard,
            RavenTree,
            RecordTrophyButterflyfish,
            RecordTrophyCarp,
            RecordTrophyGoldfish,
            RecordTrophyHalibut,
            RecordTrophyHerring,
            RecordTrophyKingfish,
            RecordTrophySeaAngler,
            RecordTrophyTuna,
            Recycler,
            RedBlock,
            RedBrick,
            RedCandle,
            RedCandyBlock,
            RedCanopy,
            RedEasterBlock,
            RedFireStairs1,
            RedFireStairs2,
            RedFireStairs3,
            RedFireStairs4,
            RedFireStairs5,
            RedGlowBlock,
            RedGummyBear,
            RedJelloPlatform,
            RedJelly,
            RedMetalChair,
            RedPortal,
            RedRoyalEgg,
            RedRunestone,
            RedSunUmbrella,
            RedXmasRibbon,
            RedZombieTrap,
            ReindeerLights,
            ReinforcedPillar1,
            ReinforcedPillar2,
            ReinforcedPillar3,
            ReinforcedPillar4,
            Replicator,
            Rocks,
            RodUpgradeStation,
            Rose,
            RoundMetalTable,
            RubberDuck,
            RuinPatternBlock1,
            RuinPatternBlock2,
            RuinSlant,
            RuinsPillar1,
            RuinsPillar2,
            RuinsPillar3,
            RuinsPillar4,
            RuinTiles,
            RuleBot,
            RustySewerPipe1,
            RustySewerPipe2,
            RustySewerPipe3,
            RustySewerPipe4,
            RustySewerPipe5,
            RustySewerPipe6,
            Safe,
            SamuraiBlock,
            Sand,
            Sandalt,
            SandCastle,
            Sandstone,
            Sarcophagus,
            SarcosuchusFossil1,
            SarcosuchusFossil2,
            SarcosuchusFossil3,
            SarcosuchusFossil4,
            ScifiArrow1,
            ScifiArrow2,
            ScifiArrow3,
            ScifiArrow4,
            ScifiBlock1,
            ScifiBlock2,
            ScifiBlock3,
            ScifiBlock4,
            ScifiBlock5,
            ScifiComputer,
            ScifiCrate,
            ScifiCratePile,
            ScifiDoor,
            ScifiGenerator,
            ScifiInterface1,
            ScifiLights,
            ScifiPanel1,
            ScifiPanel2,
            ScifiPanel3,
            ScifiPillar1,
            ScifiTable,
            Scoreboard,
            Serpentine,
            SerpentineandEggs,
            SewageDrain,
            SheriffCoatRack,
            Shikaka,
            ShovelInSand,
            Shower,
            Shrubbery,
            Sign,
            SilverBabyCupTrophy,
            SilverFishermansCupTrophy,
            SilverProCupTrophy,
            SilverTreeTrunk1,
            SilverTreeTrunk2,
            SilverTreeTrunk3,
            SilverTreeTrunk4,
            SilverVegetationBlock,
            SinisterCalendar,
            SkullBlock,
            SlicedWatermelonBlock,
            SmallBush,
            SmallChest,
            SmallFuseBox,
            SmallLock,
            SmallPWGraffiti,
            SmallRocks,
            SmallSandCastle,
            SnowBlock,
            SnowBlockalt,
            SnowLantern,
            Snowman,
            SnowyFence,
            SoilBlock,
            SoilBlockalt,
            SourGround,
            SourGroundalt,
            Spider,
            SpiderWeb,
            SpikeBall,
            SpikeTrap,
            SpikeTrap2,
            SpikeTrap3,
            SpikeTrap4,
            SpiralPillar,
            Spotlight,
            SpringBoard,
            SpringBoard2,
            SpringBoard3,
            SpringBoard4,
            SpringFlowers,
            StartLine,
            SteelSpikes1,
            SteelSpikes2,
            SteelSpikes3,
            SteelSpikes4,
            Stereos,
            StonePlatform,
            StopSign,
            StrawberryBlock,
            StrawberryBlockalt,
            StreetBench,
            StreetFence,
            StuddedMetal,
            SunChair,
            Sunflower,
            SunUmbrella,
            SurfStand,
            SwingChair,
            SwordInStone,
            TaikoDrum,
            TallGrass,
            Tapestry,
            TeaSet,
            TeslaSphere,
            Throne,
            TikiBar,
            TikiTorch,
            TintedGlassDoor,
            ToiletSeat,
            TombStone,
            Torch,
            Torii,
            ToyBunny,
            ToyChick,
            TrafficCone,
            TrafficLights,
            TrashCan,
            TreeStump,
            TreeTrunk,
            TreeTrunk2,
            TreeTrunk3,
            TreeTrunk4,
            TRexFossil1,
            TRexFossil2,
            TRexFossil3,
            TRexFossil4,
            TRexFossil5,
            TRexFossil6,
            TRexFossil7,
            TRexFossil8,
            TRexFossil9,
            Truss1,
            Truss2,
            Truss3,
            Truss4,
            Truss5,
            Turkey,
            TVAntenna,
            TVChair,
            TwistedTreePillar1,
            TwistedTreePillar2,
            TwistedTreePillar3,
            TwistedTreePillar4,
            TwistedTreePillar5,
            UnholyGround,
            UnholyGroundalt,
            UrbanGraffiti1,
            UrbanGraffiti2,
            UrbanGraffiti3,
            UrbanGraffiti4,
            UrbanGraffiti5,
            UrbanGraffiti6,
            UrbanPoster1,
            UrbanPoster2,
            UrbanSign1,
            UrbanSign2,
            UrbanSign3,
            UrbanSign4,
            UrbanWoodenFence,
            UVSGraffiti1,
            UVSGraffiti2,
            UVSGraffiti3,
            UVSGraffiti4,
            UVSGraffiti5,
            UVSGraffiti6,
            VegetationBlock,
            VikingArmorBlock,
            VikingBlock,
            VikingFigureHead,
            VikingShieldDecoration,
            VikingWall,
            VikingWall2,
            VikingWall3,
            VikingWall4,
            Vine,
            VioletEasterEgg,
            VioletRoyalEgg,
            VortexPortal,
            Wardrobe,
            WaterBed,
            WatercolorBlock,
            WatermelonBlock,
            WeaponRack,
            WeaponRuleBot,
            WhiteBlocks,
            WhiteBrick,
            WhiteDungeonDoor,
            WhiteRoyalEgg,
            WillowCatkin,
            WingedHumanoid1,
            WingedHumanoid2,
            WingedHumanoid3,
            WingedHumanoid4,
            WinterBells,
            WireFence,
            WishingWell,
            WoodBlock,
            WoodenBarrel,
            WoodenChair,
            WoodenCrate,
            WoodenFence,
            WoodenHatch,
            WoodenPlatform,
            WoodenTable,
            WoodPanel,
            WoodWall,
            WorldHologram,
            WorldLock,
            WOTWTrophy,
            XmasLights,
            XmasTree,
            XtremeSpkr,
            YardLamp,
            YellowBlock,
            YellowBrick,
            YellowCandyBlock,
            YellowEasterBlock,
            YellowJelly,
            YellowMetalChair,
            YellowRoyalEgg,
            YinYangBlock,
            ZombieTrap,
            BrownStalactites1,
            BrownStalactites2,
            BrownStalactites3,
            BrownStalagmites1,
            BrownStalagmites2,
            BrownStalagmites3,
            GreyStalactites1,
            GreyStalactites2,
            GreyStalactites3,
            EasterGraffiti1,
            EasterGraffiti2,
            EasterGraffiti3,
            EasterGraffiti4,
            EasterGraffiti5,
            EasterGraffiti6,
            EasterGraffiti7,
            EasterGraffiti8,
            EasterGraffiti9,
            AdTV,
            AlienArrowSign1,
            AlienArrowSign2,
            AlienArrowSign3,
            AlienArrowSign4,
            AlienChest,
            AlienComputer,
            AlienDuct1,
            AlienDuct2,
            AlienFlowers,
            AlienGenerator,
            AlienInfoScreen1,
            AlienInfoScreen2,
            AlienInfoScreen3,
            AlienInfoScreen4,
            AlienInfoScreen5,
            AlienInfoScreen6,
            AlienLift,
            AlienMushroom,
            AlienPillar,
            AlienPillarRuins1,
            AlienPillarRuins2,
            AlienPlatform1,
            AlienPlatform2,
            AlienPlatform3,
            AlienRockBlock,
            AlienSign,
            AlienSoilBlock,
            AlienSoilBlockalt,
            AlienStoneBlock,
            AlienTree1,
            AlienTree2,
            AlienTree3,
            BlueAlienRuins1,
            BlueAlienRuins2,
            BlueAlienRuins3,
            BlueHibernationPod,
            BlueNanotechBlock1,
            BlueNanotechBlock1alt,
            BlueNanotechBlock2,
            BlueNanotechBlock3,
            BlueNanotechBlock4,
            CrackedAlienDirt,
            DarkAlienRuins1,
            DarkAlienRuins2,
            DarkNanotechBlock1,
            DarkNanotechBlock1alt,
            DarkNanotechBlock2,
            DarkNanotechBlock3,
            DarkNanotechBlock4,
            DrippingAlienSlime1,
            DrippingAlienSlime2,
            GlowPlant,
            GreenLightStems,
            GreenWallLight,
            HoveringMine,
            KryptoniteBlock,
            LaserTurretTrap1,
            LaserTurretTrap2,
            LaserTurretTrap3,
            LaserTurretTrap4,
            NewbieLock,
            Pinata19,
            PoisonPlant,
            PurpleHibernationPod,
            PurpleLightStems,
            PurpleWallLight,
            RedCraterBlock,
            SmallLaserBeamTrap1,
            SmallLaserBeamTrap2,
            SmallLaserBeamTrap3,
            SmallLaserBeamTrap4,
            SpaceshipChair,
            SpaceshipTable,
            TentacleTrap,
            NONE
        }
    }
}
