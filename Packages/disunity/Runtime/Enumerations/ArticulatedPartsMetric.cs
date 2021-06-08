namespace DISUnity.Enumerations
{
    /// <summary>
    /// Identifies the transformation to be applied to the articulated part.
 	/// Recommended type of metric:
	///	    Horizontal control surfaces  -  Elevation
    ///     Vertical control surfaces    -  Azimuth
    ///     Extendible items             -  Extension
    ///     Fixed path items             -  Position
    ///     Turrets                      -  Azimuth
    ///     Guns                         -  Elevation
    ///     Movable missile launcher     -  Azimuth and elevation
    /// </summary>
    /// <remarks>
    /// If more than one of azimuth, elevation, or rotation exists for the same articulated part, the order of the
    /// transformation shall be azimuth, then elevation, and then rotation.
    /// </remarks>
    public enum ArticulatedPartsMetric
    {
        /// <summary>
        /// Position shall specify the location of an articulated part along a particular path to which its movement is
        /// constrained. The path may be any three-space curve. 
        /// The value zero shall represent fully retracted, and one shall represent fully extended. Intermediate
        /// positions are represented as a fraction of the path traveled. One path may be associated with each articulated
        /// part on each entity type.
        /// </summary>
        Position = 1,

        /// <summary>
        /// Position rate shall specify the rate of change of position in units of fraction of entire path per second. For
        /// example, a position rate of one indicates that the articulated part has traversed the entire path in 1 s.
        /// </summary>
        PositionRate,

        /// <summary>
        /// Extension shall specify the linear extension of the part in one direction in meters. The value zero shall
        /// represent fully retracted. 
        /// </summary>
        Extension,

        /// <summary>
        /// Extension rate shall specify the rate of change of extension in units of meters per second.
        /// </summary>
        ExtensionRate,

        /// <summary>
        /// The  x,  y, and  z shall specify the translation from the articulated parts reference coordinate system to the
        /// current location of the articulated parts coordinate system. 
        /// </summary>
        XValue,
        XRate,
        YValue,

        /// <summary>
        /// The  x, y, and  z rates shall specify the rate of change of the position of the articulated coordinate system
        /// expressed in meters per second.
        /// </summary>
        YRate,
        ZValue,
        ZRate,

        /// <summary>
        /// Azimuth shall specify the rotation of an articulated part with respect to its reference z-axis. Measured in radians.
        /// </summary>
        Azimuth,
        AzimuthRate,

        /// <summary>
        /// Elevation shall specify the rotation of an articulated part with respect to its reference y-axis. Measured in radians.
        /// </summary>
        Elevation,
        ElevationRate,

        /// <summary>
        /// Rotation shall specify the rotation of an articulated part with respect to its reference x-axis. Measured in radians.
        /// </summary>
        Rotation,
        RotationRate
    }
}