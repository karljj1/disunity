namespace DISUnity.Enumerations
{
    /// <summary>
    /// The family of protocols to which the PDU belongs.
    /// </summary>
    public enum ProtocolFamily : byte
    {
        Other,
        EntityInformationInteraction,
        Warfare,
        Logistics,
        RadioCommunications,
        SimulationManagement,
        DistributedEmissionRegeneration,
        EntityManagement,
        Minefield,
        SyntheticEnvironment,
        SimulationManagementwithReliability,
        LiveEntity,
        NonRealTime,
        InformationOperations, //   Taken from 'IEEE 1278.1-200X Draft' SISO-REF-010 PCR Changes
        ExperimentalCGF = 129,
        ExperimentalEntityInfomationFieldInstrumentation = 130,
        ExperimentalWarfareFieldInstrumentation = 131,
        ExperimentalEnviromentObjectInfomationInteraction = 132,
        ExperimentalEntityManagement = 133
    }
}

