﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x2BA0, GUID = 0x527B3CA0EBC56594)]
    public class TkVoxelGeneratorSettingsElement : ToolkitDataType {

        public TkVoxelGeneratorData Min;
        public TkVoxelGeneratorData Max;
    }
}
