﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1CDF915FBA8D3FEF)]
    public class GcSpaceStationSpawnData : GameComponentType {

		public enum SpawnModeEnum { None, UseSeed, UseAltID }
		public SpawnModeEnum SpawnMode;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;
        public GcSeed Seed;
        [NMS(Size = 0x100)]
        public string AltId;
        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding118;
        public Vector4f SpawnPosition;
        public Vector4f SpawnFacing;
    }
}
