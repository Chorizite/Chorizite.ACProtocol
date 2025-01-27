using System.IO;
using System.Collections.Generic;
using Chorizite.ACProtocol.Enums;
using Chorizite.ACProtocol.Messages;
using Chorizite.ACProtocol.Types;
using Chorizite.ACProtocol.Extensions;
using Chorizite.Common.Enums;
using System.Numerics;

namespace Chorizite.ACProtocol.Messages.S2C {
    /// <summary>
    /// Remove a position property from an object
    /// </summary>
    public class Qualities_RemovePositionEvent : ACS2CMessage {
        /// <inheritdoc />
        public override uint OpCode => 0x01DE;

        /// <inheritdoc />
        public override S2CMessageType MessageType => S2CMessageType.Qualities_RemovePositionEvent;

        public byte Sequence;

        /// <summary>
        /// Id of object being updated
        /// </summary>
        public uint ObjectId;

        public PropertyPosition Type;

        /// <summary>
        /// Reads instance data from a binary reader
        /// </summary>
        public override void Read(BinaryReader reader) {
            base.Read(reader);
            Sequence = reader.ReadByte();
            ObjectId = reader.ReadUInt32();
            Type = (PropertyPosition)reader.ReadUInt32();
        }

        /// <summary>
        /// Writes instance data to a binary writer
        /// </summary>
        public override void Write(BinaryWriter writer) {
            base.Write(writer);
            writer.Write(Sequence);
            writer.Write(ObjectId);
            writer.Write((uint)Type);
        }

    }

}