﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x88175D4FD88CF82D)]
    public class GcExpeditionCategory : GameComponentType {

		public enum ExpeditionCategoryEnum { Combat, Exploration, Mining, Diplomacy, Balanced }
		public ExpeditionCategoryEnum ExpeditionCategory;
    }
}
