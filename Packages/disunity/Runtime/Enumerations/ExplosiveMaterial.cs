#if DIS_VERSION_7

namespace DISUnity.Enumerations
{
    /// <summary>
    /// The material that exploded. This may be a material that may explode under certain 
    /// conditions (e.g., gasoline or grain dust), as well as, a material that is intended 
    /// to cause an explosion (e.g., TNT).
    /// </summary>
    /// <remarks>
    /// These values were taken from CR02668.
    /// </remarks>
    public enum ExplosiveMaterial
    {
        General,
        LiquidAviationMissileFuels,
        LiquidOtherFuels,
        LiquidExplosiveMaterial,
        Solid,
        Gaseous,
        DustMaterial,
        AVGAS_AviationGas = 10,
        JetFuelUnspecified,
        JP4_F40JETB,
        JP5_F44JETA,
        JP7,
        JP8F_34JETA1,
        JP10MissileFuel,
        JPTS,
        JetA,
        JetA1,
        JetB,
        JetBiofuel,
        GasolinePetrol_UnspecifiedOctane = 151,
        Ethanol = 153,
        E85Ethanol,
        FuelOil,
        Kerosene,
        CrudeOil_Unspecified,
        LightCrudeOil,
        LiquidPetroleumGas,
        RP1RocketFuel,
        LH2RocketFuel,
        LOXRocketFuel,
        HydrogenLiquid = 166,
        Alcohol = 164,
        Nitroglycerin = 301,
        ANFO,
        Dynamite = 451,
        TNT,
        RDX,
        PETN,
        HMX,
        C4,
        CompositionC4,
        NaturalGas = 601,
        Butane,
        Propane,
        Helium,
        HydrogenGaseous,
        DustUnspecifiedType = 801,
        GrainDust,
        FlourDust,
        SugarDust
    }
}

#endif
