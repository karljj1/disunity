using System.IO;
using DISUnity.DataType;
using DISUnity.Serializer;
using NUnit.Framework;

namespace DISUnity.Tests
{
    [TestFixture(typeof(ClockTime))]
    [TestFixture(typeof(DataQueryDatumSpecification))]
    [TestFixture(typeof(EntityIdentifier))]
    [TestFixture(typeof(EntityType))]
    [TestFixture(typeof(SimulationAddress))]
    [TestFixture(typeof(TimeStamp))]
    [TestFixture(typeof(WorldCoordinates))]
    public class SerializationTests<T> where T : ISerializedData, new()
    {
        [Test]
        public static void EncoeDecodeProducesSameValues()
        {
            var stream = new MemoryStream();
            var writer = new BinaryWriter(stream);

            var instance = new T();
            instance.Encode(writer);

            Assert.AreEqual(writer.BaseStream.Length, instance.Length, "Expected Length of data type to match length of produced stream.");

            stream.Position = 0;
            var reader = new BinaryReader(stream);
            var decodedInstance = new T();
            decodedInstance.Decode(reader);

            Assert.AreEqual(instance, decodedInstance);
        }
    }
}
