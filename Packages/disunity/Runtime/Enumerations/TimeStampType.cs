namespace DISUnity.Enumerations
{
    /// <summary>
    /// Indicates if the Time stamp is absolute or relative.
    /// </summary>
    /// <remarks>
    /// Absolute - Used when all simulation clocks are synchronized to UTC 
    /// 
    /// Relative - Used when clocks are not synchronized, Each sim shall keep time begging with an
    /// arbitrary starting point. The timestamp represents units of time passed since the beginning 
    /// of the current hour.      
    /// </remarks>
    public enum TimeStampType : byte
    {
        Relative,
        Absolute
    }
}

