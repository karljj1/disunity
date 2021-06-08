namespace DISUnity.Enumerations
{
    /// <summary>
    /// Represents the result of a detonation.
    /// </summary>
    public enum DetonationResult : byte
    {
        Other,
        EntityImpact,
        EntityProximateDetonation,
        GroundImpact,
        GroundProximateDetonation,
        Detonation,
        NoneOrNoDetonationDud,
        HE_HitSmall,
        HE_HitMedium,
        HE_HitLarge,
        ArmorPiercingHit,
        DirtblastSmall,
        DirtblastMedium,
        DirtblastLarge,
        WaterblastSmall,
        WaterblastMedium,
        WaterblastLarge,
        AirHit,
        BuildingHitSmall,
        BuildingHitMedium,
        BuildingHitLarge,
        MineClearingLineCharge,
        EnvironmentObjectImpact,
        EnvironmentObjectProximateDetonation,
        WaterImpact,
        AirBurst,
        KillWithFragmentType1,
        KillWithFragmentType2,
        KillWithFragmentType3,
        KillWithFragmentType1AfterflyOutFailure,
        KillWithFragmentType2AfterflyOutFailure,
        MissDueToflyOutFailure,
        MissDueToEndGameFailure,
        MissDueToflyOutAndEndGameFailure
    }
}
