﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x75324406CCCAAABD)]
    public class TkLSystemLocatorEntry : ToolkitDataType {

        [NMS(Size = 0x80)]
        public string Model;

        public float Probability;
        public List<TkLSystemRestrictionData> Restrictions;
    }
}
