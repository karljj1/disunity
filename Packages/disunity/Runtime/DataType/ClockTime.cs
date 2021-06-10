using System;
using System.IO;
using DISUnity.Serializer;
using UnityEngine;

namespace DISUnity.DataType
{
    [Serializable]
    public class ClockTime : ISerializedData, IEquatable<ClockTime>
    {
        [SerializeField]
        int m_Hours;

        [SerializeField]
        TimeStamp m_TimePastHour = new TimeStamp();

        /// <summary>
        /// Size of this data type in bytes
        /// </summary>
        public int Length => 8;

        /// <summary>
        /// Specifies the hours since 0000 hours January 1, 1970 UTC.
        /// </summary>
        public int Hours
        {
            get => m_Hours;
            set => m_Hours = value;
        }

        /// <summary>
        /// This field shall specify the time past the hour indicated in the Hour field.
        /// See TimeStamp class.
        /// </summary>
        public TimeStamp TimePastHour
        {
            get => m_TimePastHour;
            set => m_TimePastHour = value;
        }

        /// <summary>
        /// Decode network data.
        /// </summary>
        /// <param name="br"></param>
        public void Decode(BinaryReader br)
        {
            m_Hours = br.ReadInt32();
            m_TimePastHour.Decode(br);
        }

        /// <summary>
        /// Encode data for network transmission.
        /// </summary>
        /// <param name="bw"></param>
        public void Encode(BinaryWriter bw)
        {
            bw.Write(m_Hours);
            m_TimePastHour.Encode(bw);
        }

        /// <summary>
        /// Returns a string representation
        /// </summary>
        public override string ToString() => $"Hours={m_Hours}, TimePastHour={m_TimePastHour}";

        /// <summary>
        /// Compares internal data for equality.
        /// </summary>
        public bool Equals(ClockTime b)
        {
            if (m_Hours != b.m_Hours) return false;
            if (!m_TimePastHour.Equals(b.m_TimePastHour)) return false;
            return true;
        }

        /// <summary>
        /// Compares internal data for equality.
        /// </summary>
        public static bool Equals(ClockTime a, ClockTime b) => a.Equals(b);
    }
}