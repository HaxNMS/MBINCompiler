﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0xF5BC05B6F8B8A74B)]
    public class GcStatsBonus : NMSTemplate
    {
        public GcStatsTypes StatsTypes;
        public float Bonus;
        public int Level;
    }
}
