

using ProtoBuf;
using System;
using System.Text.Json.Serialization;

namespace WarcraftRumbleLoadoutTools
{
    //All mini deck code values in hex
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WRMini
    {
        AngryChickens = 0x01,
        ArcaneBlast = 0x02,
        Blizzard = 0x03,
        ChainLightning = 0x04,
        CheatDeath = 0x05,
        DeepBreath = 0x06,
        EarthAndMoon = 0x07,
        Eclipse = 0x08,
        Execute = 0x09,
        HolyNova = 0x0a,
        LivingBomb = 0x0b,
        Polymorph = 0x0c,
        SmokeBomb = 0x0d,
        Abomination = 0x0e,
        AncientOfWar = 0x0f,
        AnubArak = 0x10,
        Banshee = 0x11,
        BaronRivendare = 0x12,
        BatRider = 0x13,
        BloodmageThalnos = 0x14,
        BogBeast = 0x15,
        CairneBloodhoof = 0x16,
        Cenarius = 0x17,
        Charlga = 0x18,
        Chimaera = 0x19,
        CoreHounds = 0x1a,
        DarkIronMiner = 0x1b,
        DarkspearTroll = 0x1c,
        DefiasBandits = 0x1d,
        DireBatlings = 0x1e,
        OrgrimDoomhammer = 0x1f,
        Drake = 0x20,
        GeneralDrakkisath = 0x21,
        DruidOfTheClaw = 0x22,
        Dryad = 0x23,
        EarthElemental = 0x24,
        EmperorThaurissan = 0x25,
        FaerieDragon = 0x26,
        FireElemental = 0x27,
        Firehammer = 0x28,
        Flamewaker = 0x29,
        GnollBrute = 0x2d,
        Grommash = 0x30,
        Harpies = 0x32,
        Footmen = 0x2a,
        Gargoyle = 0x2b,
        Ghoul = 0x2c,
        SAFEPilot = 0x2e,
        GoblinSappers = 0x2f,
        GryphonRider = 0x31,
        //MountaineerDwarf = 0x32 // Invalid mini
        HarvestGolem = 0x33,
        HeadlessHorseman = 0x34,
        Hogger = 0x35,
        Huntress = 0x36,
        Jaina = 0x37,
        Maiev = 0x38,
        Malfurion = 0x39,
        Meatwagon = 0x3a,
        MoltenGiant = 0x3b,
        Moonkin = 0x3c,
        Mountaineer = 0x3d,
        MurlocTidehunters = 0x3f,
        Necromancer = 0x40,
        OgreMage = 0x41,
        OldMurkeye = 0x42,
        Onu = 0x43,
        PlagueFarmer = 0x44,
        Prowler = 0x45,
        Pyromancer = 0x46,
        Quillboar = 0x47,
        Ragnaros = 0x48,
        Raptors = 0x49,
        RendBlackhand = 0x4a,
        Shaman = 0x4b,
        SkeletonParty = 0x4c,
        Skeletons = 0x4d,
        Sneed = 0x4e,
        Spiderlings = 0x4f,
        StonehoofTauren = 0x50,
        SwoleTroll = 0x51,
        Sylvanas = 0x52,
        Tirion = 0x53,
        Treants = 0x54,
        Vultures = 0x55,
        WarsongGrunts = 0x56,
        WarsongRaider = 0x57,
        Whelps = 0x58,
        WitchDoctor = 0x59,
        Worgen = 0x5a,
        Ysera = 0x5b,
        // MountaineerBear = 0x5c //Invalid Mini
        Priestess = 0x5d
    }

    //idk of a better way to do this ¯\_(ツ)_/¯
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WRMiniTalent
    {
        //Angry Chickens
        Snackrifice = WRMini.AngryChickens << 2,
        WalkingCrate = (WRMini.AngryChickens << 2) + 1,
        FuriousFowl = (WRMini.AngryChickens << 2) + 2,

        //Arcane Blast
        Amplification = WRMini.ArcaneBlast << 2,
        ArcanePower = (WRMini.ArcaneBlast << 2) + 1,
        Torrent = (WRMini.ArcaneBlast << 2) + 2,

        //Blizzard
        Coldsnap = WRMini.Blizzard << 2,
        Icecrown = (WRMini.Blizzard << 2) + 1,
        BrittleIce = (WRMini.Blizzard << 2) + 2,

        //Chain Lightning
        BrilliantFlash = WRMini.ChainLightning << 2,
        StormsReach = (WRMini.ChainLightning << 2) + 1,
        Reverberation = (WRMini.ChainLightning << 2) + 2,

        //Cheat Death
        SealFate = WRMini.CheatDeath << 2,
        Vampirism = (WRMini.CheatDeath << 2) + 1,
        Apocalypse = (WRMini.CheatDeath << 2) + 2,

        //Deep Breath
        Attunement = WRMini.DeepBreath << 2,
        MeltingPoint = (WRMini.DeepBreath << 2) + 1,
        DoubleDragon = (WRMini.DeepBreath << 2) + 2,

        //Earth And Moon
        Moonfury = WRMini.EarthAndMoon << 2,
        NaturesGrace = (WRMini.EarthAndMoon << 2) + 1,
        Balance = (WRMini.EarthAndMoon << 2) + 2,

        //Eclipse
        SolarFlare = WRMini.Eclipse << 2,
        UmbralForce = (WRMini.Eclipse << 2) + 1,
        CelestialFocus = (WRMini.Eclipse << 2) + 2,

        //Execute
        Bloodthirsty = WRMini.Execute << 2,
        KillingSpree = (WRMini.Execute << 2) + 1,
        Overpower = (WRMini.Execute << 2) + 2,

        //Holy Nova
        InnerFire = WRMini.HolyNova << 2,
        Renew = (WRMini.HolyNova << 2) + 1,
        AmplifyMagic = (WRMini.HolyNova << 2) + 2,

        //Living Bomb
        BurdenOfFate = (WRMini.LivingBomb << 2),
        ChainReaction = (WRMini.LivingBomb << 2) + 1,
        BlastRadius = (WRMini.LivingBomb << 2) + 2,

        //Polymorph
        GoldenFleece = (WRMini.Polymorph << 2),
        ExplodingSheep = (WRMini.Polymorph << 2) + 1,
        StableTransfiguration = (WRMini.Polymorph << 2) + 2,

        //Smoke Bomb
        StrangersInTheNight = (WRMini.SmokeBomb << 2),
        BandOfThieves = (WRMini.SmokeBomb << 2) + 1,
        ThroughTheShadows = (WRMini.SmokeBomb << 2) + 2,

        //Abomination
        NoxiousPresence = (WRMini.Abomination << 2),
        Cannonball = (WRMini.Abomination << 2) + 1,
        MeatHook = (WRMini.Abomination << 2) + 2,

        //Ancient of War
        Sapling = (WRMini.AncientOfWar << 2),
        Behemoth = (WRMini.AncientOfWar << 2) + 1,
        LightningRod = (WRMini.AncientOfWar << 2) + 2,

        //Anub'arak
        Regenerate = (WRMini.AnubArak << 2),
        ExplosiveShells = (WRMini.AnubArak << 2) + 1,
        TrapDoor = (WRMini.AnubArak << 2) + 2,

        //Banshee
        SoulEruption = (WRMini.Banshee << 2),
        UnholyFrenzy = (WRMini.Banshee << 2) + 1,
        WillOfTheNecropolis = (WRMini.Banshee << 2) + 2,

        //Baron Rivendare
        DeathPact = (WRMini.BaronRivendare << 2),
        SkeletalFrenzy = (WRMini.BaronRivendare << 2) + 1,
        ChillofTheGrave = (WRMini.BaronRivendare << 2) + 2,

        //Bat Rider
        FlamingPitch = (WRMini.BatRider << 2),
        EnchantedVials = (WRMini.BatRider << 2) + 1,
        FierySurplus = (WRMini.BatRider << 2) + 2,

        //Bloodmage Thalnos
        Bane = (WRMini.BloodmageThalnos << 2),
        DrainLife = (WRMini.BloodmageThalnos << 2) + 1,
        Dominance = (WRMini.BloodmageThalnos << 2) + 2,

        //Bog Beast
        Flourish = (WRMini.BogBeast << 2),
        RampantGrowth = (WRMini.BogBeast << 2) + 1,
        LivingWood = (WRMini.BogBeast << 2) + 2,

        //Cairne Bloodhoof
        Reincarnation = (WRMini.CairneBloodhoof << 2),
        Plainsrunning = (WRMini.CairneBloodhoof << 2) + 1,
        Aftershock = (WRMini.CairneBloodhoof << 2) + 2,

        //Cenarius
        Revitalize = (WRMini.Cenarius << 2),
        ForceOfNature = (WRMini.Cenarius << 2) + 1,
        WildGrowth = (WRMini.Cenarius << 2) + 2,

        //Charlga
        NaturesGrasp = (WRMini.Charlga << 2),
        CavernousMists = (WRMini.Charlga << 2) + 1,
        SpiritPassage = (WRMini.Charlga << 2) + 2,

        //Chimaera
        CorrosiveBreath = (WRMini.Chimaera << 2),
        FrostShock = (WRMini.Chimaera << 2) + 1,
        Leviathan = (WRMini.Chimaera << 2) + 2,

        //Core Hounds
        FieryRebirth = (WRMini.CoreHounds << 2),
        GuardDog = (WRMini.CoreHounds << 2) + 1,
        EternalBond = (WRMini.CoreHounds << 2) + 2,

        //Dark Iron Miner
        DarkIronArmaments = (WRMini.DarkIronMiner << 2),
        GoldMine = (WRMini.DarkIronMiner << 2) + 1,
        DwarvenAmbition = (WRMini.DarkIronMiner << 2) + 2,

        //Darkspear Troll
        BigBadVoodoo = (WRMini.DarkspearTroll << 2),
        Headhunting = (WRMini.DarkspearTroll << 2) + 1,
        SerpentSting = (WRMini.DarkspearTroll << 2) + 2,

        //Defias Bandits
        DeadlyPoison = (WRMini.DefiasBandits << 2),
        Lockpick = (WRMini.DefiasBandits << 2) + 1,
        LastResort = (WRMini.DefiasBandits << 2) + 2,

        //Dire Batlings
        MidnightsCall = (WRMini.DireBatlings << 2),
        Soundbite = (WRMini.DireBatlings << 2) + 1,
        GuanoHappens = (WRMini.DireBatlings << 2) + 2,

        //Doomhammer
        DeathlessRage = (WRMini.OrgrimDoomhammer << 2),
        RallyTheClan = (WRMini.OrgrimDoomhammer << 2) + 1,
        ConquerorsDiplomacy = (WRMini.OrgrimDoomhammer << 2) + 2,

        //Drake
        MotherDrake = (WRMini.Drake << 2),
        Roost = (WRMini.Drake << 2) + 1,
        EngulfingFlames = (WRMini.Drake << 2) + 2,

        //Drakkisath
        ChromaticScales = (WRMini.GeneralDrakkisath << 2),
        PiercingBlows = (WRMini.GeneralDrakkisath << 2) + 1,
        LastingLegacy = (WRMini.GeneralDrakkisath << 2) + 2,

        //Druid of the Claw
        Regrowth = (WRMini.DruidOfTheClaw << 2),
        Rejuvination = (WRMini.DruidOfTheClaw << 2) + 1,
        LeaderOfThePack = (WRMini.DruidOfTheClaw << 2) + 2,

        //Dryad
        Barrage = (WRMini.Dryad << 2),
        NaturesSwiftness = (WRMini.Dryad << 2) + 1,
        Thorns = (WRMini.Dryad << 2) + 2,

        //Earth Elemental
        ReadyToRumble = (WRMini.EarthElemental << 2),
        ShrapnelBlast = (WRMini.EarthElemental << 2) + 1,
        ObsidianShard = (WRMini.EarthElemental << 2) + 2,

        //Emperor Thaurissan
        MoirasWit = (WRMini.EmperorThaurissan << 2),
        Hubris = (WRMini.EmperorThaurissan << 2) + 1,
        Incinerate = (WRMini.EmperorThaurissan << 2) + 2,

        //Faerie Dragon
        PhaseShift = (WRMini.FaerieDragon << 2),
        Invisibility = (WRMini.FaerieDragon << 2) + 1,
        FaeBlessing = (WRMini.FaerieDragon << 2) + 2,

        //Fire Elemental
        ImmolationAura = (WRMini.FireElemental << 2),
        MoltenCore = (WRMini.FireElemental << 2) + 1,
        FanTheFlames = (WRMini.FireElemental << 2) + 2,

        //Firehammer
        MoultinMetal = (WRMini.Firehammer << 2),
        BlazingSpeed = (WRMini.Firehammer << 2) + 1,
        HeightenedRage = (WRMini.Firehammer << 2) + 2,

        //Flamewaker
        HeatStroke = (WRMini.Flamewaker << 2),
        Engulf = (WRMini.Flamewaker << 2) + 1,
        Backdraft = (WRMini.Flamewaker << 2) + 2,

        //Gnoll Brute
        Rabid = (WRMini.GnollBrute << 2),
        Pillage = (WRMini.GnollBrute << 2) + 1,
        ThickHide = (WRMini.GnollBrute << 2) + 2,

        //Grommash
        Bladestorm = (WRMini.Grommash << 2),
        MirrorImage = (WRMini.Grommash << 2) + 1,
        SavageStrikes = (WRMini.Grommash << 2) + 2,

        //Harpies
        InfectiousSwipes = (WRMini.Harpies << 2),
        TrinketCollectors = (WRMini.Harpies << 2) + 1,
        TalonDive = (WRMini.Harpies << 2) + 2,

        //Footmen
        ShieldBash = (WRMini.Footmen << 2),
        Fortification = (WRMini.Footmen << 2) + 1,
        LastStand = (WRMini.Footmen << 2) + 2,

        //Gargoyle
        WingBuffet = (WRMini.Gargoyle << 2),
        ObsidianStatue = (WRMini.Gargoyle << 2) + 1,
        AerialSuperiority = (WRMini.Gargoyle << 2) + 2,

        //Ghoul
        BoneShield = (WRMini.Ghoul << 2),
        Ravenous = (WRMini.Ghoul << 2) + 1,
        TasteForBlood = (WRMini.Ghoul << 2) + 2,

        //Safe Pilot
        GnomishCloakingDevice = (WRMini.SAFEPilot << 2),
        ComingInHot = (WRMini.SAFEPilot << 2) + 1,
        GnomishMuttonizer = (WRMini.SAFEPilot << 2) + 2,

        //Goblin Sappers
        ExtraBoom = (WRMini.GoblinSappers << 2),
        RocketPoweredTurboBoots = (WRMini.GoblinSappers << 2) + 1,
        CrudeGunpowder = (WRMini.GoblinSappers << 2) + 2,

        //Gryphon Rider
        AirDrop = (WRMini.GryphonRider << 2),
        OdynsFury = (WRMini.GryphonRider << 2) + 1,
        MightyThrow = (WRMini.GryphonRider << 2) + 2,

        //Harvest Golem
        TrojanChickens = (WRMini.HarvestGolem << 2),
        UnstableCore = (WRMini.HarvestGolem << 2) + 1,
        BountifulHarvest = (WRMini.HarvestGolem << 2) + 2,

        //Headless Horseman
        NightWatch = (WRMini.HeadlessHorseman << 2),
        Decapitate = (WRMini.HeadlessHorseman << 2) + 1,
        NeighDeathExperience = (WRMini.HeadlessHorseman << 2) + 2,

        //Hogger
        HamHock = (WRMini.Hogger << 2),
        SpoiledMeat = (WRMini.Hogger << 2) + 1,
        FatalFrenzy = (WRMini.Hogger << 2) + 2,

        //Huntress
        DarnassianSteel = (WRMini.Huntress << 2),
        ElvenMight = (WRMini.Huntress << 2) + 1,
        Shadowmeld = (WRMini.Huntress << 2) + 2,

        //Jaina
        Blink = (WRMini.Jaina << 2),
        Clearcasting = (WRMini.Jaina << 2) + 1,
        Flurry = (WRMini.Jaina << 2) + 2,

        //Maiev
        EvelopingShadows = (WRMini.Maiev << 2),
        Shadowstep = (WRMini.Maiev << 2) + 1,
        Remorseless = (WRMini.Maiev << 2) + 2,

        //Malfurion
        NaturalSalve = (WRMini.Malfurion << 2),
        DeepSlumber = (WRMini.Malfurion << 2) + 1,
        Germinate = (WRMini.Malfurion << 2) + 2,

        //Meatwagon
        MeatAndBones = (WRMini.Meatwagon << 2),
        FiletTrebuchet = (WRMini.Meatwagon << 2) + 1,
        GreasedGears = (WRMini.Meatwagon << 2) + 2,

        //Molten Giant
        ThreateningPresence = (WRMini.MoltenGiant << 2),
        BloodOfTheMountain = (WRMini.MoltenGiant << 2) + 1,
        Bolster = (WRMini.MoltenGiant << 2) + 2,

        //Moonkin
        Vengeance = (WRMini.Moonkin << 2),
        Moonglow = (WRMini.Moonkin << 2) + 1,
        Typhoon = (WRMini.Moonkin << 2) + 2,

        //Mountaineer
        FrenziedSpirit = (WRMini.Mountaineer << 2),
        MendPets = (WRMini.Mountaineer << 2) + 1,
        Intimidation = (WRMini.Mountaineer << 2) + 2,

        //Murloc Tidehunters
        SafetyBubble = (WRMini.MurlocTidehunters << 2),
        CarefulAim = (WRMini.MurlocTidehunters << 2) + 1,
        Morelocs = (WRMini.MurlocTidehunters << 2) + 2,

        //Necromancer
        CultOfTheDamned = WRMini.Necromancer << 2,
        JeweledSkulls = (WRMini.Necromancer << 2) + 1,
        BreathOfTheDying = (WRMini.Necromancer << 2) + 2,

        //Ogre Mage
        FrostfireBolt = (WRMini.OgreMage << 2),
        Ignite = (WRMini.OgreMage << 2) + 1,
        Avarice = (WRMini.OgreMage << 2) + 2,

        //Old Murkeye
        TipOfTheSpear = (WRMini.OldMurkeye << 2),
        Marathon = (WRMini.OldMurkeye << 2) + 1,
        ElectricEels = (WRMini.OldMurkeye << 2) + 2,

        //Onu
        Barkskin = (WRMini.Onu << 2),
        Petrify = (WRMini.Onu << 2) + 1,
        FromTheTrees = (WRMini.Onu << 2) + 2,

        //Plague Farmer
        PartingGift = (WRMini.PlagueFarmer << 2),
        Virulence = (WRMini.PlagueFarmer << 2) + 1,
        SplashingPumpkins = (WRMini.PlagueFarmer << 2) + 2,

        //Prowler
        OnTheProwl = (WRMini.Prowler << 2),
        PackLeader = (WRMini.Prowler << 2) + 1,
        PredatoryInstincts = (WRMini.Prowler << 2) + 2,

        //Pyromancer
        Pyroblast = (WRMini.Pyromancer << 2),
        Conflagrate = (WRMini.Pyromancer << 2) + 1,
        BlazeOfGlory = (WRMini.Pyromancer << 2) + 2,

        //Quillboar
        Bristleback = (WRMini.Quillboar << 2),
        TunnelVision = (WRMini.Quillboar << 2) + 1,
        BrambleBurst = (WRMini.Quillboar << 2) + 2,

        //Ragnaros
        ConcussiveBlast = (WRMini.Ragnaros << 2),
        RadiantFlames = (WRMini.Ragnaros << 2) + 1,
        SonsOfFlame = (WRMini.Ragnaros << 2) + 2,

        //Raptors
        StrengthInNumbers = (WRMini.Raptors << 2),
        FastFood = (WRMini.Raptors << 2) + 1,
        Motivation = (WRMini.Raptors << 2) + 2,

        //Rend Blackhand
        FlamingSoul = (WRMini.RendBlackhand << 2),
        ScaleAndSteel = (WRMini.RendBlackhand << 2) + 1,
        Legionnaire = (WRMini.RendBlackhand << 2) + 2,

        //Shaman
        EarthwallTotem = (WRMini.Shaman << 2),
        LightningMastery = (WRMini.Shaman << 2) + 1,
        EarthShield = (WRMini.Shaman << 2) + 2,

        //Skeleton Party
        FiveMan = (WRMini.SkeletonParty << 2),
        CorpseRun = (WRMini.SkeletonParty << 2) + 1,
        RitualOfRime = (WRMini.SkeletonParty << 2) + 2,

        //Skeletons
        QuestingBuddies = (WRMini.Skeletons << 2),
        Cackle = (WRMini.Skeletons << 2) + 1,
        Exhume = (WRMini.Skeletons << 2) + 2,

        //Sneed
        MineIsMoneyFriend = (WRMini.Sneed << 2),
        LeadWithGreed = (WRMini.Sneed << 2) + 1,
        LandGrab = (WRMini.Sneed << 2) + 2,

        //Spiderlings
        BloatedCarapace = (WRMini.Spiderlings << 2),
        CaveDwellers = (WRMini.Spiderlings << 2) + 1,
        Envenom = (WRMini.Spiderlings << 2) + 2,

        //Stonehoof Tauren
        Pummel = (WRMini.StonehoofTauren << 2),
        Momentum = (WRMini.StonehoofTauren << 2) + 1,
        Provoke = (WRMini.StonehoofTauren << 2) + 2,

        //Swole Troll
        Trollnado = (WRMini.SwoleTroll << 2),
        TrollTrain = (WRMini.SwoleTroll << 2) + 1,
        MeatierElbow = (WRMini.SwoleTroll << 2) + 2,

        //Sylvanas
        QueensReach = (WRMini.Sylvanas << 2),
        BansheesWail = (WRMini.Sylvanas << 2) + 1,
        ForsakenFury = (WRMini.Sylvanas << 2) + 2,

        //Tirion
        DivineShield = (WRMini.Tirion << 2),
        Consecrate = (WRMini.Tirion << 2) + 1,
        ByTheLight = (WRMini.Tirion << 2) + 2,

        //Treants
        Composting = (WRMini.Treants << 2),
        Uproot = (WRMini.Treants << 2) + 1,
        Propagation = (WRMini.Treants << 2) + 2,

        //Vultures
        TendonRip = (WRMini.Vultures << 2),
        FeedingFrenzy = (WRMini.Vultures << 2) + 1,
        Migration = (WRMini.Vultures << 2) + 2,

        //Warsong Grunts
        BloodPact = (WRMini.WarsongGrunts << 2),
        GuardDuty = (WRMini.WarsongGrunts << 2) + 1,
        Command = (WRMini.WarsongGrunts << 2) + 2,

        //Warsong Raider
        Saboteur = (WRMini.WarsongRaider << 2),
        RazingFocus = (WRMini.WarsongRaider << 2) + 1,
        SunderArmor = (WRMini.WarsongRaider << 2) + 2,

        //Whelps
        Rookery = (WRMini.Whelps << 2),
        FlameBurst = (WRMini.Whelps << 2) + 1,
        ChromaticPlating = (WRMini.Whelps << 2) + 2,

        //Witch Doctor
        Alchemist = (WRMini.WitchDoctor << 2),
        AmplifyCurse = (WRMini.WitchDoctor << 2) + 1,
        SpiritWard = (WRMini.WitchDoctor << 2) + 2,

        //Worgen
        LoneWolf = (WRMini.Worgen << 2),
        Premeditation = (WRMini.Worgen << 2) + 1,
        Frenzy = (WRMini.Worgen << 2) + 2,

        //Ysera
        RecurringDream = (WRMini.Ysera << 2),
        CorruptedDream = (WRMini.Ysera << 2) + 1,
        SharedDream = (WRMini.Ysera << 2) + 2,

        //Priestess
        PowerWordShield = (WRMini.Priestess << 2),
        EmpoweredRenew = (WRMini.Priestess << 2) + 1,
        SpiritOfRedemption = (WRMini.Priestess << 2) + 2

        //Arthas

    }
    [ProtoContract]
    public abstract class MiniBase
    {
        [ProtoMember(2)]
        public abstract int? TalentID { get; set; }
        [ProtoMember(1)]
        public abstract WRMini Mini { get; set; }

        public WRMiniTalent? Talent
        {
            get => TalentID != null ? (WRMiniTalent?)(((byte)Mini << 2) + TalentID) : null;
            set => TalentID = (byte?)(value != null ? (int?)value - ((byte)Mini << 2) : null);
        }
    }
}
