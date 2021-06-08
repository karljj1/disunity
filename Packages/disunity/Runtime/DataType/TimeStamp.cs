using System;
using System.IO;
using DISUnity.Enumerations;
using DISUnity.Serializer;
using UnityEngine;

namespace DISUnity.DataType
{
    /// <summary>
    /// Stores absolute/ relative timestamps.
    /// Timestamps are used to reduce the error in a simulation.
    ///
    /// A lot of DIS simulators simply ignore timestamps however if error(I.E inaccuracy
    /// between a entities position and its actual position) is an issue then the timestamp
    /// can be used to reduce this error.
    ///
    /// Absolute timestamps tend to require the use of very accurate and expesnive clocks which are synchronized.
    /// Relative timestamps are less accurate and tend to use the computers internal clock.
    ///
    /// The following is taken straight from the DIS standard:
    /// "To make sure that relative timestamps are synchronized, you need to compare information about a received
    /// PDU that contains a relative timestamp with the time you are maintaining in your simulation application.
    /// This is done using software and without any special hardware. It does require that a few packets be observed
    /// before time is well synchronized. As packets are received, the difference between their relative timestamps
    /// and the receiver's clock is averaged. This average will correspond to the average latency, and the difference
    /// represents clock skew. After a few dozen packets, the difference between the observed average and the real
    /// average latency is around 5ms. After several hundred, the difference is in the 1ms neighborhood. This is not
    /// as long a time to wait as might be imagined. A dozen ES PDU's per minute are emitted by simulators for
    /// entities which are stopped. Thus, a few minutes of idle time before the exercise starts provides data for 5ms
    /// accuracy, and at 1-2 PDU's per second while moving, 1ms accuracy can be had in a matter of minutes.
    /// Exercises with stricter needs really should use absolute based time."
    /// </summary>
    [Serializable]
    public class TimeStamp : ISerializedData, IEquatable<TimeStamp>
    {
        [SerializeField]
        uint m_AllFields;

        /// <summary>
        /// Size of this data type in bytes
        /// </summary>
        /// <returns></returns>
        public int Length => 4;

        /// <summary>
        /// The type of time stamp.
        /// </summary>
        public TimeStampType Type
        {
            get => (TimeStampType)(m_AllFields & 1);
            set => m_AllFields = (uint)((uint)value | (m_AllFields & -2));
        }

        /// <summary>
        /// Time value. Scale of the time is determined by setting one hour equal to (2^31 - 1), 
        /// thereby resulting in each time unit representing 3600 s/( 2^31 - 1 ) = 1.676 micro secs
        /// or 0.000001676 seconds. This is the time for the current hour.
        /// </summary>
        public uint Time
        {
            get => m_AllFields >> 1;

            // Bit 0 is used by the Type field so dont change it.
            // Shift value left by one bit and set bit 0 if it was set before.
            set => m_AllFields = (value << 1) | (m_AllFields & 1);
        }

        /// <summary>
        /// Type and Time in a single int.
        /// </summary>
        public uint AllFields
        {
            get => m_AllFields;
            set => m_AllFields = value;
        }

        public TimeStamp()
        {
        }

        public TimeStamp(TimeStampType type, uint time)
        {
            Type = type;
            Time = time;
        }

        public TimeStamp(uint typeAndTime)
        {
            m_AllFields = typeAndTime;
        }

        public void Decode(BinaryReader br)
        {
            m_AllFields = br.ReadUInt32();
        }

        public void Encode(BinaryWriter bw)
        {
            bw.Write((uint)m_AllFields);
        }

        public override string ToString() => $"{nameof(TimeStamp)}({Type}): {Time}";

        public bool Equals(TimeStamp b)
        {
            if (m_AllFields != b.m_AllFields) return false;
            return true;
        }

        public static bool Equals(TimeStamp a, TimeStamp b)
        {
            return a.Equals(b);
        }
    }
}