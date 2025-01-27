﻿using System.IO;

namespace Chorizite.ACProtocol.Packets {
	public class CICMDCommandHeader {
		public uint Command;
		public uint Param;

		public CICMDCommandHeader() {

		}

		public CICMDCommandHeader(BinaryReader reader) {
			Command = reader.ReadUInt32();
			Param = reader.ReadUInt32();
		}
	}
}