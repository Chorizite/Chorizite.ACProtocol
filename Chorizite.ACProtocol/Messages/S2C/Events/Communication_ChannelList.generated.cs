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
    /// ChannelList: Provides list of characters listening to a channel, I assume in response to a command
    /// </summary>
    public class Communication_ChannelList : ACGameEvent {
        public List<string> Characters = new();

        /// <summary>
        /// Reads instance data from a binary reader
        /// </summary>
        public override void Read(BinaryReader reader) {
            base.Read(reader);
            Characters = reader.ReadPackableList<string>();
        }

        /// <summary>
        /// Writes instance data to a binary writer
        /// </summary>
        public override void Write(BinaryWriter writer) {
            base.Write(writer);
            writer.WritePackableList(Characters);
        }

    }

}
