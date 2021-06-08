namespace DISUnity.Enumerations
{
    /// <summary>
    /// Dead Reckoning Parameters                                            
    /// Dead Reckoning Algorithms consist of 3 elements.
    /// XYZ                                                           
    /// X - Specifies rotation as either fixed(F) or rotating(R).           
    /// Y - Specifies dead reckoning rates to be held constant as either rate of position (P) or rate of velocity (V).                   
    /// Z - Specifies the coordinate system as either world coordinates (W) or body axis coordinates(B).  
    /// </summary>
    public enum DeadReckoningAlgorithm : byte
    {
        Other,

        /// <summary>
        /// No movement, the object is static
        /// </summary>
        Static,

        /// <summary>
        /// Constant velocity (or low acceleration)linear motion    
        /// </summary>
        FPW,

        /// <summary>
        /// Similar to <see cref="FPW"/> but where orientation is required (e.g. visual simulation).
        /// </summary>
        RPW,

        /// <summary>
        /// Similar to <see cref="FVW"/> but where orientation is required (e.g. visual simulation).                               
        /// </summary>
        RVW,

        /// <summary>
        /// High speed or manoeuvring at any speed (e.g. TBM, ICBM, SAM, SSM, and ASM weapons) 
        /// </summary>
        FVW,

        /// <summary>
        /// Similar to <see cref="RPW"/> but when body-centred calculation is preferred.
        /// </summary>
        FPB,

        /// <summary>
        /// Similar to <see cref="RVW"/> but when body-centred calculation is preferred.
        /// </summary>
        RPB,

        /// <summary>
        /// Similar to <see cref="FVW"/> but when body-centred calculation is preferred.
        /// </summary>
        RVB,

        /// <summary>
        /// Similar to <see cref="FPB"/> but when body-centred calculation is preferred.   
        /// </summary>
        FVB
    }
}

