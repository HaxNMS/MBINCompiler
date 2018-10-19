﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x65B3EC85D2F35211)]
    public class TkSceneNodeAttributeData : ToolkitDataType {

        [NMS(Size = 0x10)]
        public string Name;
        [NMS(Size = 0x20)]
        public string AltID;
        [NMS(Size = 0x100)]
        public string Value;
    }
}
