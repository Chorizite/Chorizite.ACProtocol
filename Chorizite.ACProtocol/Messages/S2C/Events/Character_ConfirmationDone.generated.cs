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
    /// Confirmation done
    /// </summary>
    public class Character_ConfirmationDone : ACGameEvent {
        /// <summary>
        /// the type of confirmation panel being closed
        /// </summary>
        public ConfirmationType ConfirmationType;

        /// <summary>
        /// sequence number
        /// </summary>
        public uint ContextId;

        /// <summary>
        /// Reads instance data from a binary reader
        /// </summary>
        public override void Read(BinaryReader reader) {
            base.Read(reader);
            ConfirmationType = (ConfirmationType)reader.ReadUInt32();
            ContextId = reader.ReadUInt32();
        }

        /// <summary>
        /// Writes instance data to a binary writer
        /// </summary>
        public override void Write(BinaryWriter writer) {
            base.Write(writer);
            writer.Write((uint)ConfirmationType);
            writer.Write(ContextId);
        }

    }

}
