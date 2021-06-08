namespace DISUnity.Enumerations.Apperance
{
    /// <summary>
    /// Camouflage type worn.
    /// </summary>
    public enum Camouflage : byte
    {
        DesertCamouflage,
        WinterCamouflage,
        ForestCamouflage
    }

    /// <summary>
    /// Describes the canopy state of an entity
    /// </summary>
    public enum CanopyState : byte
    {
        NotApplicable,
        PrimaryHatchIsClosed,
        PrimaryHatchIsOpen = 4,
    }

    /// <summary>
    /// Describes compliance of a life form.
    /// </summary>
    public enum Compliance : byte
    {
        Detained = 1,
        Surrender,
        UsingFists,
        VerbalAbuseLevel1,
        VerbalAbuseLevel2,
        VerbalAbuseLevel3,
        PassiveResistanceLevel1,
        PassiveResistanceLevel2,
        PassiveResistanceLevel3,
        UsingNonLethalWeapon1,
        UsingNonLethalWeapon2,
        UsingNonLethalWeapon3,
        UsingNonLethalWeapon4,
        UsingNonLethalWeapon5,
        UsingNonLethalWeapon6
    }

    /// <summary>
    /// Describes the damaged appearance of an entity
    /// </summary>
    public enum Damage : byte
    {
        NoDamage,
        SlightDamage,
        ModerateDamage,
        Destroyed
    }

    /// <summary>
    /// Describes the density of the environmentals
    /// </summary>
    public enum Density : byte
    {
        Clear,
        Hazy,
        Dense,
        VeryDense,
        Opaque
    }

    /// <summary>
    /// Describes the hatch state of an entity
    /// </summary>
    public enum HatchState : byte
    {
        NotApplicable,
        PrimaryHatchIsClosed,
        PrimaryHatchIsPopped,
        PrimaryHatchIsPoppedPersonVisibleUnderHatch,
        PrimaryHatchIsOpen,
        PrimaryHatchIsOpenPersonVisible
    }

    /// <summary>
    /// Describes the state of the life form.
    /// </summary>
    public enum LifeformState : byte
    {
        UprightStandingStill = 1,
        UprightWalking,
        UprightRunning,
        Kneeling,
        Prone,
        Crawling,
        Swimming,
        Parachuting,
        Jumping,
        Sitting,
        Squatting,
        Crouching,
        Wading,
        SurrenderAppearance,
        DetainedAppearance
    }

    /// <summary>
    /// Describes the position of the life forms weapon
    /// </summary>
    public enum LifeformWeapon : byte
    {
        NoWeaponPresent,
        WeaponIsStowed,
        WeaponIsDeployed,
        WeaponIsInTheFiringPosition
    }

    /// <summary>
    /// Describes the paint scheme of an entity
    /// </summary>
    public enum PaintScheme : byte
    {
        UniformColor,
        Camouflage
    }

    /// <summary>
    /// Describes status or location of smoke emanating from an entity
    /// </summary>
    public enum Smoke : byte
    {
        NotSmoking,
        SmokePlume,
        EngineSmoke,
        EngineSmokeAndSmokePlume
    }

    /// <summary>
    /// Describes the size of the dust cloud trailing effect for the entity
    /// </summary>
    public enum TrailingEffect : byte
    {
        NoTrail,
        Small,
        Medium,
        Large
    }
}
