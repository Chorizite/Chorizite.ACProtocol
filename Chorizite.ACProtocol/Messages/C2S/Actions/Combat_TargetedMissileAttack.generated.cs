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
    /// Starts a missle attack against a target
    /// </summary>
    public class Combat_TargetedMissileAttack : ACGameAction {
        /// <summary>
        /// Id of creature being attacked
        /// </summary>
        public uint ObjectId;

        /// <summary>
        /// Height of the attack
        /// </summary>
        public AttackHeight Height;

        /// <summary>
        /// Accuracy level
        /// </summary>
        public float Accuracy;

        /// <summary>
        /// Reads instance data from a binary reader
        /// </summary>
        public override void Read(BinaryReader reader) {
            base.Read(reader);
            ObjectId = reader.ReadUInt32();
            Height = (AttackHeight)reader.ReadUInt32();
            Accuracy = reader.ReadSingle();
        }

        /// <summary>
        /// Writes instance data to a binary writer
        /// </summary>
        public override void Write(BinaryWriter writer) {
            base.Write(writer);
            writer.Write(ObjectId);
            writer.Write((uint)Height);
            writer.Write(Accuracy);
        }

    }

}
