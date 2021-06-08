namespace DISUnity.Enumerations
{
    /// <summary>
    /// The type of PDU.
    /// </summary>
    public enum PDUType : byte
    {
        Other,
        EntityState,
        Fire,
        Detonation,
        Collision,
        ServiceRequest,
        ResupplyOffer,
        ResupplyReceived,
        ResupplyCancel,
        RepairComplete,
        RepairResponse,
        CreateEntity,
        RemoveEntity,
        StartResume,
        StopFreeze,
        Acknowledge,
        ActionRequest,
        ActionResponse,
        DataQuery,
        SetData,
        Data,
        EventReport,
        Comment, // AKA Message PDU
        ElectromagneticEmission,
        Designator,
        Transmitter,
        Signal,
        Receiver,
        IFF_ATC_NAVAIDS,
        UnderwaterAcoustic,
        SupplementalEmissionEntityState,
        IntercomSignal,
        IntercomControl,
        AggregateState,
        IsGroupOf,
        TransferControl, // AKA Transfer Ownership PDU
        IsPartOf,
        MinefieldState,
        MinefieldQuery,
        MinefieldData,
        MinefieldResponseNAK,
        EnvironmentalProcess,
        GriddedData,
        PointObjectState,
        LinearObjectState,
        ArealObjectState,
        TSPI,
        Appearance,
        ArticulatedParts,
        LEFire,
        LEDetonation,
        CreateEntityR,
        RemoveEntityR,
        StartResumeR,
        StopFreezeR,
        AcknowledgeR,
        ActionRequestR,
        ActionResponseR,
        DataQueryR,
        SetDataR,
        DataR,
        EventReportR,
        CommentR,
        RecordR,
        SetRecordR,
        RecordQueryR,
        CollisionElastic,
        EntityStateUpdate,
        DirectedEnergyFire, // Taken from 'IEEE 1278.1-200X Draft' SISO-REF-010 PCR Changes
        EntityDamageStatus, // Taken from 'IEEE 1278.1-200X Draft' SISO-REF-010 PCR Changes
        IOAction, // Taken from 'IEEE 1278.1-200X Draft' SISO-REF-010 PCR Changes
        IOReport, // Taken from 'IEEE 1278.1-200X Draft' SISO-REF-010 PCR Changes
        Attribute, // Taken from 'IEEE 1278.1-200X Draft' SISO-REF-010 PCR Changes
        AnnounceObject = 129,
        DeleteObject = 130,
        DescribeEvent = 132,
        DescribeObject = 133,
        RequestEvent = 134,
        RequestObject = 135
    }
}

