namespace DISUnity.Enumerations
{
    /// <summary>
    /// Indicates the type of PDU being acknowledged.
    /// </summary>
    public enum AcknowledgeFlag
    {
        Unknown,
        CreateEntityPDU,
        RemoveEntityPDU,
        Start_ResumePDU,
        Stop_FreezePDU,
        TransferControlRequest
    }
}
