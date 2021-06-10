using System;
using System.IO;
using DISUnity.Enumerations;
using DISUnity.Serializer;
using UnityEngine;

namespace DISUnity.DataType
{
    /// <summary>
    /// The type of entity 
    /// </summary>
    [Serializable]
    public class EntityType : ISerializedData, IEquatable<EntityType>
    {
        [SerializeField]
        byte m_Kind;

        [SerializeField]
        byte m_Domain;

        [SerializeField]
        int m_Country;

        [SerializeField]
        byte m_Category;

        [SerializeField]
        byte m_SubCategory;

        [SerializeField]
        byte m_Specific;

        [SerializeField]
        byte m_Extra;

        /// <summary>
        /// Size of this data type in bytes
        /// </summary>
        public int Length => 8;

        /// <summary>
        /// The kind of entity.
        /// </summary>
        public EntityKind Kind
        {
            get => (EntityKind)m_Kind;
            set => m_Kind = (byte)value;
        }

        /// <summary>
        /// The domain in which the entity operates (e.g., subsurface, surface, and land) except for
        /// munition entities. For munition entities this field shall specify the domain of the
        /// target (for example, the munition might be a surface-to-air, so the domain would be anti-air).        
        /// </summary>
        public EntityDomain Domain
        {
            get => (EntityDomain)m_Domain;
            set => m_Domain = (byte)value;
        }

        /// <summary>
        /// Country to which the design of the entity or its design specification is attributed.
        /// </summary>
        public Country Country
        {
            get => (Country)m_Country;
            set => m_Country = (ushort)value;
        }

        /// <summary>
        /// Main category that describes the entity.
        /// </summary>
        public byte Category
        {
            get => m_Category;
            set => m_Category = value;
        }

        /// <summary>
        /// A particular subcategory to which an entity belongs based on the Category field.
        /// </summary>
        public byte SubCategory
        {
            get => m_SubCategory;
            set => m_SubCategory = value;
        }

        /// <summary>
        /// Specific information about an entity based on the Subcategory field.
        /// </summary>
        public byte Specific
        {
            get => m_Specific;
            set => m_Specific = value;
        }

        /// <summary>
        /// Extra information required to describe a particular entity. 
        /// The contents of this field depend on the type of entity represented.
        /// </summary>
        public byte Extra
        {
            get => m_Extra;
            set => m_Extra = value;
        }

        /// <summary>
        /// Generated by bit shifting all fields into a single unsigned long value.
        /// </summary>
        public ulong HashCode
        {
            get
            {
                return (ulong)Kind << 56 | (ulong)Domain << 48 | (ulong)Country << 32 | (ulong)Category << 24 | (ulong)SubCategory << 16 | (ulong)Specific << 8 | (ulong)Extra;
            }
        }

        public EntityType()
        {
        }

        /// <summary>
        /// Create a new entity type.
        /// </summary>
        /// <param name="kin">Kind</param>
        /// <param name="dom">Domain</param>
        /// <param name="coun">Country</param>
        /// <param name="cat">Main category that describes the entity.</param>
        /// <param name="subCat">Sub category to which an entity belongs based on the Category field.</param>
        /// <param name="spec">Specific information about an entity based on the Subcategory field.</param>
        /// <param name="ext">Extra information required to describe a particular entity</param>
        public EntityType(EntityKind kin, EntityDomain dom, Country coun, byte cat, byte subCat, byte spec, byte ext)
        {
            m_Kind = (byte)kin;
            m_Domain = (byte)dom;
            m_Country = (ushort)coun;
            m_Category = cat;
            m_SubCategory = subCat;
            m_Specific = spec;
            m_Extra = ext;
        }

        /// <summary>
        /// CCreate a new entity type.
        /// </summary>
        /// <param name="kin">Kind</param>
        /// <param name="dom">Domain</param>
        /// <param name="coun">Country</param>
        /// <param name="cat">Main category that describes the entity.</param>
        /// <param name="subCat">Sub category to which an entity belongs based on the Category field.</param>
        /// <param name="spec">Specific information about an entity based on the Subcategory field.</param>
        /// <param name="ext">Extra information required to describe a particular entity</param>
        public EntityType(byte kin, byte dom, ushort coun, byte cat, byte subCat, byte spec, byte ext)
        {
            m_Kind = kin;
            m_Domain = dom;
            m_Country = coun;
            m_Category = cat;
            m_SubCategory = subCat;
            m_Specific = spec;
            m_Extra = ext;
        }

        /// <summary>
        /// Decode network data.
        /// </summary>
        /// <param name="br"></param>
        public void Decode(BinaryReader br)
        {
            m_Kind = br.ReadByte();
            m_Domain = br.ReadByte();
            m_Country = br.ReadUInt16();
            m_Category = br.ReadByte();
            m_SubCategory = br.ReadByte();
            m_Specific = br.ReadByte();
            m_Extra = br.ReadByte();
        }

        /// <summary>
        /// Encode data for network transmission.
        /// </summary>
        /// <param name="bw"></param>
        public void Encode(BinaryWriter bw)
        {
            bw.Write(m_Kind);
            bw.Write(m_Domain);
            bw.Write((ushort)m_Country);
            bw.Write(m_Category);
            bw.Write(m_SubCategory);
            bw.Write(m_Specific);
            bw.Write(m_Extra);
        }

        /// <summary>
        /// Returns a string representation.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Entity Type: {m_Kind}-{m_Domain}-{m_Country}-{m_Category}-{m_SubCategory}-{m_Specific}-{m_Extra}";

        /// <summary>
        /// Compares internal data for equality.
        /// </summary>        
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Equals(EntityType b)
        {
            if (m_Kind != b.m_Kind) return false;
            if (m_Domain != b.m_Domain) return false;
            if (m_Country != b.m_Country) return false;
            if (m_Category != b.m_Category) return false;
            if (m_SubCategory != b.m_SubCategory) return false;
            if (m_Specific != b.m_Specific) return false;
            if (m_Extra != b.m_Extra) return false;
            return true;
        }

        /// <summary>
        /// Compares internal data for equality.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool Equals(EntityType a, EntityType b) => a.Equals(b);
    }
}