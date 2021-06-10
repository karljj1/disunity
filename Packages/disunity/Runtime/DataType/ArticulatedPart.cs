//using System;
//using System.IO;
//using DISUnity.Enumerations;
//using DISUnity.Utils;
//using UnityEngine;

//namespace DISUnity.DataType
//{
//    /// <summary>
//    /// The Articulated Part VP record is used to represent the state of the movable parts of an entity. 
//    /// Examples of movable parts include the turret on a tank and the periscope on a submarine.
//    /// An Articulated Part VP record shall represent the value of only one parameter of a movable, 
//    /// or articulated, part. Thus, it may require multiple Articulated Part VP records to describe  
//    /// the state of a single articulated part. 
//    /// </summary>
//    [Serializable]
//    public class ArticulatedPart : VariableParameter
//    {
//        [SerializeField]
//        byte m_ChangeIndicator;

//        [SerializeField]
//        ushort m_PartID;

//        [Tooltip(Tooltips.ArticulatedPartsMetric)]
//        [SerializeField]
//        ArticulatedPartsMetric m_ParamMetric = ArticulatedPartsMetric.Position; // Default

//        [Tooltip(Tooltips.ArticulatedPartsClass)]
//        [SerializeField]
//        ArticulatedPartsClass m_ParamClass = ArticulatedPartsClass.Rudder; // Default

//        [SerializeField]
//        float m_ParamValue;

//        /// <summary>
//        /// Stores change to any articulated part. Set to 0 at sim start and incremented
//        /// each time a change occurs, if value is greater than 255 it should be set back to 0.
//        /// </summary>
//        public byte ChangeIndicator
//        {
//            get => m_ChangeIndicator;
//            set => m_ChangeIndicator = value;
//        }

//        /// <summary>
//        /// The identification of the articulated part to which this articulation parameter is attached. 
//        /// </summary>
//        public ushort PartID
//        {
//            get => m_PartID;
//            set => m_PartID = value;
//        }

//        /// <summary>
//        /// Identifies a particular articulated part on a given entity type.
//        /// </summary>
//        public ArticulatedPartsClass Class
//        {
//            get => m_ParamClass;
//            set => m_ParamClass = value;
//        }

//        /// <summary>
//        /// Identifies the transformation to be applied to the articulated part.
//        /// </summary>
//        public ArticulatedPartsMetric Metric
//        {
//            get => m_ParamMetric;
//            set => m_ParamMetric = value;
//        }

//        /// <summary>
//        /// The value for the articulated part.
//        /// </summary>
//        public float Value 
//        {
//            get => m_ParamValue;
//            set => m_ParamValue = value;
//        }

//        public ArticulatedPart()
//        {
//        }
//        /*
//        /// <summary>
//        /// Create a new instance from binary data.
//        /// </summary>
//        /// <param name="br"></param>
//        public ArticulatedPart(BinaryReader br)
//        {
//            Decode(br);
//        }

//        /// <summary>
//        /// Decode network data.
//        /// </summary>
//        /// <param name="br"></param>
//        public override void Decode(BinaryReader br)
//        {
//            isDirty = true;
//            variableParameterType = (VariableParameterType)br.ReadByte();
//            m_ChangeIndicator = br.ReadByte();
//            m_PartID = br.ReadUInt16();

//            int typeVariant = br.ReadInt32();
//            m_ParamMetric = (ArticulatedPartsMetric)(typeVariant % 32);
//            m_ParamClass = (ArticulatedPartsClass)(typeVariant - (int)m_ParamMetric);

//            m_ParamValue = br.ReadSingle();
//            br.BaseStream.Seek(1, SeekOrigin.Current); // Skip padding
//        }

//        /// <summary>
//        /// Encode data for network transmission.
//        /// </summary>
//        /// <param name="bw"></param>
//        public override void Encode(BinaryWriter bw)
//        {
//            bw.Write((byte)variableParameterType);
//            bw.Write(m_ChangeIndicator);
//            bw.Write((ushort)m_PartID);
//            bw.Write((int)m_ParamClass + (int)m_ParamMetric);
//            bw.Write(m_ParamValue);
//            bw.Write((byte)0); // Padding
//            isDirty = false;
//        }

//        /// <summary>
//        /// Decoder used for VariableParameters with the type field of ArticulatedPart(0).
//        /// </summary>
//        /// <param name="type"></param>
//        /// <param name="br"></param>
//        public new static VariableParameter FactoryDecode(int type, BinaryReader br)
//        {
//            return new ArticulatedPart(br);
//        }

//        /// <summary>
//        /// Returns a string representation.
//        /// </summary>
//        /// <returns></returns>
//        public override string ToString()
//        {
//            return string.Format("Articulated Part({0}: Change {1}: {2}({3} = {4}", m_PartID, m_ChangeIndicator, Class, Metric, m_ParamValue);
//        }

//        #endregion DataTypeBase

//        #region Operators

//        /// <summary>
//        /// Compares internal data for equality.
//        /// </summary>
//        /// <param name="b"></param>
//        /// <returns></returns>
//        public bool Equals(ArticulatedPart b)
//        {
//            if (variableParameterType != b.variableParameterType) return false;
//            if (m_ChangeIndicator != b.m_ChangeIndicator) return false;
//            if (m_PartID != b.m_PartID) return false;
//            if (m_ParamMetric != b.m_ParamMetric) return false;
//            if (m_ParamClass != b.m_ParamClass) return false;
//            if (m_ParamValue != b.m_ParamValue) return false;
//            return true;
//        }

//        /// <summary>
//        /// Compares internal data for equality.
//        /// </summary>
//        /// <param name="a"></param>
//        /// <param name="b"></param>
//        /// <returns></returns>
//        public static bool Equals(ArticulatedPart a, ArticulatedPart b)
//        {
//            return a.Equals(b);
//        }
//        /*
//    }
//}