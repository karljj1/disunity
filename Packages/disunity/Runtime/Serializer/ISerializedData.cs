using System.IO;

namespace DISUnity.Serializer
{
    public interface ISerializedData
    {
        int Length { get; }

        /// <summary>
        /// Decode network data.
        /// </summary>
        /// <param name="reader"></param>
        void Decode(BinaryReader reader);

        /// <summary>
        /// Encode data for network transmission.
        /// </summary>
        /// <param name="writer"></param>
        void Encode(BinaryWriter writer);
    }
}