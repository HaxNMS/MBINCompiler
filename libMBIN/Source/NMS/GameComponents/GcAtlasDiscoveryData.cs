﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3041C51DBAC8620E)]
    public class GcAtlasDiscoveryData : GameComponent {

        /* 0x00 */ public GcUniverseAddressData UniverseAddress;
        /* 0x18 */ public GcDiscoveryTypes Type;
        /* 0x1C */ public int PayloadElements;
        [NMS(Size = 0x5)]
        /* 0x20 */ public ulong[] Payload;        // each struct is 0x8 bytes sub_140471C90
    }
}
