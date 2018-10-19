﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xE12FCC23D50B7756)]
    public class GcBuildingOverrideData : GameComponentType {

        public GcSeed Seed;
        public Vector4f Position;
        public int Index;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] EndPadding;
    }
}
