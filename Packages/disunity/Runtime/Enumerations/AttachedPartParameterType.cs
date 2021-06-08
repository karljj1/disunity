namespace DISUnity.Enumerations
{
    /// <summary>
    /// The station to which an attached part is attached is identified by the Parameter Type
    /// enumeration of the Attached Part VP record.
    /// Stations shall be numbered sequentially beginning with one and incrementing by one.
    /// The order of numbering shall be from top to bottom, then back to front, and then left
    /// to right. The only exception shall be aircraft wing stations.
    /// The fuselage stations, left wing stations, and right wing stations shall be separated into  
    /// different categories. Wing stations shall be numbered from inboard to outboard.   
    /// </summary>
    public enum AttachedPartParameterType
    {
        Unknown,
        ModelSpecificStations,        //   1 - 511
        FuselageStations       = 512, // 512 - 639
        LeftWingStations       = 640, // 640 - 767
        RightWingStations      = 768, // 768 - 895     
        M16A42Rifle            = 896,
        M249SAW                = 897,
        M60MachineGun          = 898,
        M203GrenadeLauncher    = 899,
        M136AT4                = 900,
        M47Dragon              = 901,
        AAWSMJavelin           = 902,
        M18A1ClaymoreMine      = 903,
        MK19GrenadeLauncher    = 904,
        M2MachineGun           = 905
    }
}
