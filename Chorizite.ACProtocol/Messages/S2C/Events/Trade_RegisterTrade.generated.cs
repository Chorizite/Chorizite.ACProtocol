using System.IO;
using System.Collections.Generic;
using Chorizite.ACProtocol.Enums;
using Chorizite.ACProtocol.Messages;
using Chorizite.ACProtocol.Types;
using Chorizite.ACProtocol.Extensions;
using Chorizite.Common.Enums;
using System.Numerics;

namespace Chorizite.ACProtocol.Messages.S2C.Events {
    /// <summary>
    /// RegisterTrade: Send to begin a trade and display the trade window
    /// </summary>
    public class Trade_RegisterTrade : ACGameEvent {
        /// <summary>
        /// Person initiating the trade
        /// </summary>
        public uint InitiatorId;

        /// <summary>
        /// Person receiving the trade
        /// </summary>
        public uint PartnerId;

        /// <summary>
        /// Some kind of stamp
        /// </summary>
        public long Stamp;

        /// <summary>
        /// Reads instance data from a binary reader
        /// </summary>
        public override void Read(BinaryReader reader) {
            base.Read(reader);
            InitiatorId = reader.ReadUInt32();
            PartnerId = reader.ReadUInt32();
            Stamp = reader.ReadInt64();
        }

        /// <summary>
        /// Writes instance data to a binary writer
        /// </summary>
        public override void Write(BinaryWriter writer) {
            base.Write(writer);
            writer.Write(InitiatorId);
            writer.Write(PartnerId);
            writer.Write(Stamp);
        }

    }

}
