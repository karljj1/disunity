namespace DISUnity.Enumerations
{
    /// <summary>
    /// Indicates the response to an action request. 
    /// </summary>
    public enum RequestStatus
    {
        Other,
        Pending,
        Executing,
        PartiallyComplete,
        Complete,
        RequestRejected,
        ReTransmitRequestNow,
        ReTransmitRequestLater,
        InvalidTimeParameters,
        SimulationTimeExceeded,
        RequestDone,
        TACCSFLOSReply_Type1 = 100,
        TACCSFLOSReply_Type2 = 101,
        JoinExerciseRequestRejected = 201
    }
}
