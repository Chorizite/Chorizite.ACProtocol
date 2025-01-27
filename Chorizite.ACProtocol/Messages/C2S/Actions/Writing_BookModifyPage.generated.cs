using System.IO;
using System.Collections.Generic;
using Chorizite.ACProtocol.Enums;
using Chorizite.ACProtocol.Messages;
using Chorizite.ACProtocol.Types;
using Chorizite.ACProtocol.Extensions;
using Chorizite.Common.Enums;
using System.Numerics;

namespace Chorizite.ACProtocol.Messages.C2S.Actions {
    /// <summary>
    /// Updates a page in a book
    /// </summary>
    public class Writing_BookModifyPage : ACGameAction {
        /// <summary>
        /// Id of book
        /// </summary>
        public uint ObjectId;

        /// <summary>
        /// Number of page being updated
        /// </summary>
        public int PageNum;

        /// <summary>
        /// New text for the page
        /// </summary>
        public string PageText;

        /// <summary>
        /// Reads instance data from a binary reader
        /// </summary>
        public override void Read(BinaryReader reader) {
            base.Read(reader);
            ObjectId = reader.ReadUInt32();
            PageNum = reader.ReadInt32();
            PageText = reader.ReadString16L();
        }

        /// <summary>
        /// Writes instance data to a binary writer
        /// </summary>
        public override void Write(BinaryWriter writer) {
            base.Write(writer);
            writer.Write(ObjectId);
            writer.Write(PageNum);
            writer.Write(PageText);
        }

    }

}
