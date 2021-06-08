namespace DISUnity.Enumerations
{
    /// <summary>
    /// Encoding type when EncodingClass is audio   
    /// </summary>
    public enum SignalEncodingType
    {
        _8_bit_mu_law = 1,
        CVSD_per_MIL_STD_188_113,
        ADPCM_per_CCITT_G_721,
        _16_bit_linear_PCM2sComplementBigEndian,
        _8_bit_linear_PCM,
        VQ_VectorQuantization,
        GSM_FullRate = 8,
        GSM_HalfRate,
        SpeexNarrowBand,
        _16_bit_linear_PCM2sComplementLittleEndian = 100
    }
}
