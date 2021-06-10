//using System;
//using System.Linq;
//using System.IO;
//using UnityEngine;
//using System.Collections.Generic;
//using DISUnity.DataType;
//using System.Text;
//using System.Collections.ObjectModel;
//using DISUnity.Serializer;

//namespace DISUnity.DataType
//{
//	/// <summary>
//    /// Datum specification record as defined in document 1278.1-2012 point 6.2.18.
//	/// </summary>
//	[Serializable]
//	public class DatumSpecification : ISerializedData
//	{
//		#region Properties
		
//		#region Private
		
//		[SerializeField]
//		FixedDatumCollection fixedDatums = new FixedDatumCollection();

//		[SerializeField]
//		VariableDatumCollection variableDatums = new VariableDatumCollection();
		
//		#endregion Private

//		/// <summary>
//		/// Fixed datum collection. 
//		/// </summary>
//		public FixedDatumCollection FixedDatums
//		{
//			get
//			{
//				return fixedDatums;
//			}
//			set
//			{
//				isDirty = true;
//				fixedDatums = value;
//			}
//		}
		
//		/// <summary>
//		/// Fixed datum collection. 
//		/// </summary>
//		public VariableDatumCollection VariableDatums
//		{
//			get
//			{
//				return variableDatums;
//			}
//			set
//			{
//				isDirty = true;
//				variableDatums = value;
//			}
//		}
		
//		/// <summary>
//		/// Total size of the collection in bytes.
//		/// </summary>
//		public override int Length
//		{
//			get
//			{
//				return 8 + fixedDatums.Length + variableDatums.Length;
//			}
//		}

//		#endregion Properties
		
//		public DatumSpecification()
//		{
//		}
		
//		/// <summary>
//		/// Create a new instance from binary data.
//		/// </summary>
//		/// <param name="br"></param>
//		public DatumSpecification( BinaryReader br )
//		{
//			Decode( br );
//		}
		    
//		#region DataTypeBase

//		/// <summary>
//		/// Decode network data.
//		/// </summary>
//		/// <param name="br"></param>
//		/// <param name="numberOfRecords">Number of records to decode from the stream.</param>
//		public override void Decode( BinaryReader br )
//		{
//			uint numFixed = br.ReadUInt32();
//			uint numVar = br.ReadUInt32();
			
//			fixedDatums.Decode( br, numFixed );
//			variableDatums.Decode( br, numVar );
			
//			isDirty = true;                       
//		}
		
//		/// <summary>
//		/// Encode data for network transmission.
//		/// </summary>
//		/// <param name="bw"></param>
//		public override void Encode( BinaryWriter bw )
//		{
//			bw.Write( fixedDatums.NumberOfRecords );
//			bw.Write( variableDatums.NumberOfRecords );
			
//			fixedDatums.Encode( bw );
//			variableDatums.Encode( bw );			
//		}
		
//		/// <summary>
//		/// Returns a string representation.
//		/// </summary>
//		/// <returns></returns>
//		public override string ToString()
//		{
//			StringBuilder sb = new StringBuilder();			
//			sb.Append( fixedDatums.ToString() );
//			sb.Append( variableDatums.ToString() );			
//			return sb.ToString();			
//		}
		
//		#endregion DataTypeBase
		
//		#region Operators
		
//		/// <summary>
//		/// Compares internal data for equality.
//		/// </summary>
//		/// <param name="b"></param>        
//		/// <returns></returns>
//		public bool Equals( DatumSpecification b )
//		{
//			if( fixedDatums != b.fixedDatums       ) return false;
//			if( variableDatums != b.variableDatums ) return false;
//			return true;			
//		}
		
//		/// <summary>
//		/// Compares internal data for equality.
//		/// </summary>
//		/// <param name="a"></param>
//		/// <param name="b"></param>
//		/// <returns></returns>
//		public static bool Equals( DatumSpecification a, DatumSpecification b )
//		{
//			return a.Equals( b );
//		}
		
//		#endregion Operators
//	}
//}