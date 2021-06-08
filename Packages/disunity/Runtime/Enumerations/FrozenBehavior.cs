namespace DISUnity.Enumerations
{
    /// <summary>
    /// Describes frozen behavior in StopFreeze PDU.
    /// </summary>
    public enum FrozenBehavior : byte
    {
        SimClock,
        TransmitPDU,
        ReceivePDU
    }
}