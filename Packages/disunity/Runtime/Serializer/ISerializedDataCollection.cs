using System.IO;

namespace DISUnity.Serializer
{
    public interface ISerializedDataCollection
    {
        int Length { get; }

        int NumberOfRecords { get; }

        /// <summary>
        /// Decode network data.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="numberOfRecords">Number of records to decode.</param>
        void Decode(BinaryReader reader, uint numberOfRecords);

        /// <summary>
        /// Encode data for network transmission.
        /// </summary>
        /// <param name="writer"></param>
        void Encode(BinaryWriter writer);
    }
}