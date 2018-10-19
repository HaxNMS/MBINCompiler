﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xAD1718785B26B78F)]
    public class GcRewardSpecificTechFromList : GameComponentType {

        public List<NMSString0x10> TechList;

        public bool FailIfAllKnown;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding11;

		public enum TechListRewardOrderEnum { OneRandom, InOrder, TryAllRandom }
		public TechListRewardOrderEnum TechListRewardOrder;
    }
}
