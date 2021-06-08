namespace DISUnity.Enumerations
{
    /// <summary>
    /// Describes the reason for StopFreeze PDU.   
    /// </summary>
    public enum StopFreezeReason : byte
    {
        Other,
        Recess,
        Termination,
        SystemFailure,
        SecurityViolation,
        EntityReconstitution,
        StopForReset,
        StopForRestart,
        AbortTrainingReturnToTacticalOperations
    }
}