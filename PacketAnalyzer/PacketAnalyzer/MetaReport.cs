using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace PacketAnalyzer
{
    /// <summary>
    /// Instantiated once for every distinct packet. Contains human interpretable meta information of the packet's payload.
    /// This class is XML serializable.
    /// </summary>
    class MetaReport
    {
        #region Meta information about this object
        /// <summary>
        /// Opcode Id 
        /// </summary>
        public uint Opcode;
        /// <summary>
        /// Client version for this packet
        /// </summary>
        public uint ClientVersion;
        /// <summary>
        /// Version of this application that was used to analyze the packet
        /// </summary>
        public uint PackAnVersion;
        #endregion

        #region Observed Statistics
        /// <summary>
        /// Amount of times this packet type was observed
        /// </summary>
        public uint ObservedOccurances;
        /// <summary>
        /// Amount of times the packet was analyzed. Always smaller or equal to ObservedOccurances
        /// </summary>
        public uint AnalyzedCount;
        /// <summary>
        /// Largest observed size in bytes for this type of packet
        /// </summary>
        public uint ObservedLargestSize;
        /// <summary>
        /// Smallest observed size in bytes for this type of packet
        /// </summary>
        public uint ObservedSmallestSize;


        #endregion
    }
}
