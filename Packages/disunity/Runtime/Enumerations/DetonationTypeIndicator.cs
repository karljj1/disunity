#if DIS_VERSION_7

namespace DISUnity.Enumerations
{
    /// <summary>
    /// Indicates the type of descriptor used in a Detonation PDU in DIS 7.
    /// </summary>
    public enum DetonationTypeIndicator : byte
    {
        Munition,
        Expendable,
        NonMunitionExplosion
    }
}

#endif