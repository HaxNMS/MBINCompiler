﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAF3FFA464A170D62)]
    public class GcUniverseAddressData : NMSTemplate // 0x18 bytes
    {
        public int RealityIndex;

        public GcGalacticAddressData GalacticAddress;
    }
}
