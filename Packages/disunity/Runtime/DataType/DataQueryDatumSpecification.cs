using System;
using System.IO;
using System.Text;
using DISUnity.Serializer;
using UnityEngine;

namespace DISUnity.DataType
{
    /// <summary>
    /// Data query datum specification record as defined in document 1278.1-1995 point 5.2.9.
    /// </summary>
    [Serializable]
    public class DataQueryDatumSpecification : ISerializedData, IEquatable<DataQueryDatumSpecification>
    {
        [SerializeField]
        DatumIDCollection m_FixedDatumIDs = new DatumIDCollection();

        [SerializeField]
        DatumIDCollection m_VariableDatumIDs = new DatumIDCollection();

        /// <summary>
        /// Fixed datum collection. 
        /// </summary>
        public DatumIDCollection FixedDatumIDs
        {
            get => m_FixedDatumIDs;
            set => m_FixedDatumIDs = value;
        }

        /// <summary>
        /// Fixed datum collection. 
        /// </summary>
        public DatumIDCollection VariableDatumIDs
        {
            get => m_VariableDatumIDs;
            set => m_VariableDatumIDs = value;
        }

        /// <summary>
        /// Total size of the collection in bytes.
        /// </summary>
        public int Length => 8 + m_FixedDatumIDs.Length + m_VariableDatumIDs.Length;

        /// <summary>
        /// Decode network data.
        /// </summary>
        /// <param name="br"></param>
        /// <param name="numberOfRecords">Number of records to decode from the stream.</param>
        public void Decode(BinaryReader br)
        {
            uint numFixed = br.ReadUInt32();
            uint numVar = br.ReadUInt32();

            m_FixedDatumIDs.Decode(br, numFixed);
            m_VariableDatumIDs.Decode(br, numVar);
        }

        /// <summary>
        /// Encode data for network transmission.
        /// </summary>
        /// <param name="bw"></param>
        public void Encode(BinaryWriter bw)
        {
            bw.Write(m_FixedDatumIDs.NumberOfRecords);
            bw.Write(m_VariableDatumIDs.NumberOfRecords);

            m_FixedDatumIDs.Encode(bw);
            m_VariableDatumIDs.Encode(bw);
        }

        /// <summary>
        /// Returns a string representation.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Fixed ");
            sb.Append(m_FixedDatumIDs.ToString());
            sb.Append("Variable ");
            sb.Append(m_VariableDatumIDs.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Compares internal data for equality.
        /// </summary>
        /// <param name="b"></param>        
        /// <returns></returns>
        public bool Equals(DataQueryDatumSpecification b)
        {
            if (!m_FixedDatumIDs.Equals(b.m_FixedDatumIDs)) return false;
            if (!m_VariableDatumIDs.Equals(b.m_VariableDatumIDs)) return false;
            return true;
        }

        /// <summary>
        /// Compares internal data for equality.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool Equals(DataQueryDatumSpecification a, DataQueryDatumSpecification b) => a.Equals(b);
    }
}