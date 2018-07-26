﻿namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x4C0)]
    public class GcBaseBuildingMaterial : NMSTemplate
    {
        /* 0x00 */ public int MaterialIndex;

        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;

        [NMS(Size = 0x10)]
        /* 0x08 */ public string Name;
        /* 0x18 */ public TkTextureResource Icon;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x9C */ public byte[] Padding9C;

        [NMS(Size = 0x20)]
        /* 0xA0 */ public string LocName;

        [NMS(Size = 0x10)]
        /* 0xC0 */ public GcBaseBuildingPalette[] Palettes;
    }
}
