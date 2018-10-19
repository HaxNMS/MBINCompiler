﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x108, GUID = 0x61448847C97DFCA1)]
    public class GcMissionSequenceWaitRealTime : GameComponent {

        [NMS(Size = 0x80)]
        public string Message;
        public ulong Time;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
