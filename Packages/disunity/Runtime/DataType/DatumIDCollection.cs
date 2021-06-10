using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DISUnity.Enumerations;
using DISUnity.Serializer;
using UnityEngine;

namespace DISUnity.DataType
{
    /// <summary>
    /// Holds a collection of <see cref="DatumID"/>.    
    /// </summary>
    [Serializable]
    public class DatumIDCollection : ISerializedDataCollection, IEquatable<DatumIDCollection>
    {
        [SerializeField]
        List<DatumID> m_Items = new List<DatumID>();

        /// <summary>
        /// Total size of the collection in bytes.
        /// </summary>
        public int Length => NumberOfRecords * 4;// 4 bytes is fixed length of a encoded DatumID data type.

        public List<DatumID> DatumIDs => m_Items;

        /// <summary>
        /// Total number of fixed datum records.
        /// </summary>
        public int NumberOfRecords => m_Items.Count;

        public void Decode(BinaryReader br, uint numberOfRecords)
        {
            m_Items.Clear();
            for (uint i = 0; i < numberOfRecords; ++i)
            {
                var di = (DatumID)br.ReadUInt32();
                m_Items.Add(di);
            }
        }

        public void Encode(BinaryWriter bw)
        {
            foreach (var o in m_Items)
            {
                bw.Write((uint)o);
            }
        }

        /// <summary>
        /// Returns a string representation.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datum IDs:");
            foreach(var d in m_Items)
            {
                sb.Append(d + ", ");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Compares internal data for equality.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Equals(DatumIDCollection b) => Enumerable.SequenceEqual(m_Items, b.m_Items);

        /// <summary>
        /// Compares internal data for equality.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool Equals(DatumIDCollection a, DatumIDCollection b) => a.Equals(b);
    }
}