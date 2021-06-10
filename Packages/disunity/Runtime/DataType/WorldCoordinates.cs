using System;
using System.IO;
using DISUnity.Serializer;
using UnityEngine;

namespace DISUnity.DataType
{
    /// <summary>
    /// World coordinate system.     
    /// Using a right-handed, geocentric Cartesian coordinate system.
    /// The origin of the coordinate system is the centroid of the World Geodetic System 1984 (WGS 84) reference frame.
    /// Scale is 1 unit equals 1m.
    /// </summary>
    [Serializable]
    public class WorldCoordinates : ISerializedData, IEquatable<WorldCoordinates>
    {
        [SerializeField]
        double m_X;

        [SerializeField]
        double m_Y;

        [SerializeField]
        double m_Z;

        /// <summary>
        /// Size of this data type in bytes
        /// </summary>
        /// <returns></returns>
        public int Length => 24;

        /// <summary>
        /// X
        /// </summary>
        public double X
        {
            get => m_X;
            set => m_X = value;
        }

        /// <summary>
        /// Y
        /// </summary>
        public double Y
        {
            get => m_Y;
            set => m_Y = value;
        }

        /// <summary>
        /// Z
        /// </summary>
        public double Z
        {
            get => m_Z;
            set => m_Z = value;
        }

        public WorldCoordinates()
        {
        }

        public WorldCoordinates(double x, double y, double z)
        {
            m_X = x;
            m_Y = y;
            m_Z = z;
        }

        /// <summary>
        /// Set x,y and z.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public void Set(double x, double y, double z)
        {
            m_X = x;
            m_Y = y;
            m_Z = z;
        }

        /// <summary>
        /// Decode network data.
        /// </summary>
        /// <param name="br"></param>
        public void Decode(BinaryReader br)
        {
            m_X = br.ReadDouble();
            m_Y = br.ReadDouble();
            m_Z = br.ReadDouble();
        }

        /// <summary>
        /// Encode data for network transmission.
        /// </summary>
        /// <param name="bw"></param>
        public void Encode(BinaryWriter bw)
        {
            bw.Write(m_X);
            bw.Write(m_Y);
            bw.Write(m_Z);
        }

        /// <summary>
        /// Returns a string representation.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"({m_X}, {m_Y}, {m_Z})";

        /// <summary>
        /// Compares internal data for equality.
        /// </summary>
        /// <param name="b"></param>        
        /// <returns></returns>
        public bool Equals(WorldCoordinates b)
        {
            const double d = 0.000001;

            if (Math.Abs(m_X - b.m_X) > d) return false;
            if (Math.Abs(m_Y - b.m_Y) > d) return false;
            if (Math.Abs(m_Z - b.m_Z) > d) return false;
            return true;
        }

        /// <summary>
        /// Compares internal data for equality.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool Equals(WorldCoordinates a, WorldCoordinates b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// Get/Set using index, if an invalid index is used then it will be ignored.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return m_X;
                    case 1: return m_Y;
                    case 2: return m_Z;
                    default:
                        throw new IndexOutOfRangeException($"Should be between 0-2, not {index}.");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: m_X = value; break;
                    case 1: m_Y = value; break;
                    case 2: m_Z = value; break;
                    default:
                        throw new IndexOutOfRangeException($"Should be between 0-2, not {index}.");
                }
            }
        }
    }
}

