using System;
using System.IO;
using DISUnity.Resources;
using DISUnity.Serializer;
using UnityEngine;

namespace DISUnity.DataType
{
    /// <summary>
    /// A simulation?s designation associated with all object identifiers except those contained in Live Entity PDUs
    /// </summary>
    /// <remarks>
    /// This data type is known as the Simulation Identifier in some of the older DIS standard documents.
    /// </remarks>
    [Serializable]
    public class SimulationAddress : ISerializedData, IEquatable<SimulationAddress>
    {
        [SerializeField]
        [Tooltip(Tooltips.SiteID)]
        ushort m_SiteID;

        [SerializeField]
        [Tooltip(Tooltips.ApplicationID)]
        ushort m_ApplicationID;

        /// <summary>
        /// Size of this data type in bytes
        /// </summary>
        /// <returns></returns>
        public virtual int Length => 4;

        /// <summary>
        /// A site is defined as a facility, installation, organizational unit or a geographic
        /// location that has one or more simulation applications capable of participating in a
        /// distributed event. A facility, installation, organizational unit or geographic location
        /// may have multiple sites associated with it.
        /// Each site participating in an event (e.g., training exercise, experiment, test) shall be
        /// assigned a unique Site Number that is different from any other site that is part of the same event.
        /// A simulation site is a site that generates simulated objects based on simulated data. A live site
        /// is a site that is associated with producing live objects from live sources such as producing
        /// entities representing live aircraft flying in a live training range. A simulation associated
        /// with a live site may issue Live Entity PDUs (e.g., the TSPI PDU) for the live objects or may
        /// issue Entity State PDUs for them.
        /// </summary>
        public ushort Site
        {
            get => m_SiteID;
            set => m_SiteID = value;
        }

        /// <summary>
        /// An application is defined as a software program that is used to generate and process
        /// distributed simulation data including live, virtual and constructive data.
        /// Each application participating in an event (e.g., training exercise) shall be
        /// assigned a unique Application Number for the site with which the application is associated.
        /// </summary>
        public ushort Application
        {
            get => m_ApplicationID;
            set => m_ApplicationID = value;
        }

        public SimulationAddress()
        {
        }

        public SimulationAddress(ushort site, ushort application)
        {
            m_SiteID = site;
            m_ApplicationID = application;
        }

        /// <summary>
        /// Decode network data.
        /// </summary>
        /// <param name="br"></param>
        public virtual void Decode(BinaryReader br)
        {
            m_SiteID = br.ReadUInt16();
            m_ApplicationID = br.ReadUInt16();
        }

        /// <summary>
        /// Encode data for network transmission.
        /// </summary>
        /// <param name="bw"></param>
        public virtual void Encode(BinaryWriter bw)
        {
            bw.Write(m_SiteID);
            bw.Write(m_ApplicationID);
        }

        /// <summary>
        /// Returns a string representation.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"SimulationAddress: {m_SiteID} : {m_ApplicationID}";

        /// <summary>
        /// Compares internal data for equality.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual bool Equals(SimulationAddress b)
        {
            if (m_SiteID != b.m_SiteID) return false;
            if (m_ApplicationID != b.m_ApplicationID) return false;
            return true;
        }

        /// <summary>
        /// Compares internal data for equality.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool Equals(SimulationAddress a, SimulationAddress b) => a.Equals(b);
    }
}