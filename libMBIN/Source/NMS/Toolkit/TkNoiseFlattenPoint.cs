﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x141A63354CB056EF)]
    public class TkNoiseFlattenPoint : ToolkitData {

        /* 0x00 */ public float Density;
        /* 0x04 */ public float FlattenRadius;
        /* 0x08 */ public float TurbulenceFrequency;
        /* 0x0C */ public float TurbulenceAmplitude;
        /* 0x10 */ public int TurbulenceOctaves;
        /* 0x14 */ public TkNoiseFlattenOptions FlattenType;
        /* 0x1C */ public GcBuildingClassification Classification;     // in code, just an int
        /* 0x20 */ public GcBuildingClusterPlacement Placement;        // in code, just an int
        /* 0x24 */ public bool AddWaypoint;
        /* 0x25 */ public bool AddShelter;
        /* 0x26 */ public bool AddLandingPad;

        [NMS(Size = 1, Ignore = true)]
        public byte[] Padding27;
    }
}
