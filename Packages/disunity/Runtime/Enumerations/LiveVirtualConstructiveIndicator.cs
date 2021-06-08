#if DIS_VERSION_7

namespace DISUnity.Enumerations
{
    /// <summary>
    /// Indicates whether the data contained in this PDU is related to a     
    /// live, virtual or constructive entity. If the LVC designation is not 
    /// able to be determined, this field shall be set to No Statement (0).  
    /// This is a new field in the DIS 7 standard.
    /// </summary>
    /// <remarks>
    /// If you are not familiar with the LVC term: http://en.wikipedia.org/wiki/Live,_Virtual,_and_Constructive
    /// </remarks>
    public enum LiveVirtualConstructiveIndicator : byte
    {
        NoStatementLVC,
        LiveLVC,
        VirtualLVC,
        ConstructiveLVC
    }
}

#endif